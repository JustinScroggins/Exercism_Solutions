using System;


public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string newYorkCity = "212";
        string fakeNumber = "555";
        string areaCode = phoneNumber.Substring(0, 3);
        string secondDigits = phoneNumber.Substring(4, 3);
        string lastFour = phoneNumber.Substring(8, 4);
        bool IsNewYork;
        bool IsFake;
        if (areaCode == newYorkCity)
        {
            IsNewYork = true;
        }
        if (secondDigits == fakeNumber)
        {
            IsFake = true;
        }
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
