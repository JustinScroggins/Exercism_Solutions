using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string formattedNumber = phoneNumber.Trim('-');
        if (formattedNumber.Contains("555"))
        {
            return (false, true, "1234");
        }
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
