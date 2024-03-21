using Microsoft.AspNetCore.Components;
using RenoSystemDB.BLL;
using RenoSystemDB.Entities;

namespace RenoWebApp.Components.Pages
{
    public partial class Query
    {
        [Inject]
        JobServices JobServices { get; set; }

        [Inject]
        SupplyServices SupplyServices { get; set; }

        [Inject]
        NavigationManager NavigationManager { get; set; }

        //Required Properties
        public List<Job> Jobs { get; set; }
        public List<Supply> Supplies { get; set; }

        public string jobType {get; set; }

        [Parameter]
        public int JobId { get; set; }
        protected override Task OnInitializedAsync()
        {
            return Task.Run(() =>
            {
                Jobs = JobServices.GetAllJobs();

                if (JobId != 0)
                {
                    Supplies = SupplyServices.GetSuppliesByJobId(JobId);
                }
            });          
        }

        private void HandleSelectedJob()
        {
            if (JobId !=0)
            {
                Supplies = SupplyServices.GetSuppliesByJobId(JobId);
                NavigationManager.NavigateTo($"/query/{JobId}");
            }
        }  
        
        private void ClearFields()
        {
            JobId = 0;  
        }
    }
}
