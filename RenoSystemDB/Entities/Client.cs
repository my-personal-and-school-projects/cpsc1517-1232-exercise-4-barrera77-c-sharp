﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RenoSystemDB.Entities;

public partial class Client
{
    public int ClientId { get; set; }

    public string Contact { get; set; }

    public string Phone { get; set; }

    public string Number { get; set; }

    public string Unit { get; set; }

    public string Street { get; set; }

    public string City { get; set; }

    public string Province { get; set; }

    public string PostalCode { get; set; }

    public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
}