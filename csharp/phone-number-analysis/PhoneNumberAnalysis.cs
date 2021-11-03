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

        if (areaCode == newYorkCity)
        {
            if (secondDigits == fakeNumber)
            {
                return (true, true, lastFour);
            }
            return (true, false, lastFour);
        }
        if (secondDigits == fakeNumber)
        {
            return (false, true, lastFour);
        }
        return (false, false, lastFour);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        if (phoneNumberInfo.IsFake)
        {
            return true;
        }
        else return false;
    }



}



