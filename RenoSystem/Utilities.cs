namespace Utils
{
    public static class Utilities
    {
        public static bool IsNonZeroPositive(int value) => value > 0;

        public static bool IsValidMinimum(int value1, int value2) => value1 >= value2;

        public static bool IsZeroPositive(int value) => value >= 0;
        public static bool IsNullEmptyOrWhiteSpace(string value) => string.IsNullOrWhiteSpace(value);
    }
}
