using System;
using System.Globalization;
/// <summary>
///InvariantCulture
/// </summary>
public class CultureInfoInvariantCulture
{
    public static int Main()
    {
        CultureInfoInvariantCulture CultureInfoInvariantCulture = new CultureInfoInvariantCulture();

        TestLibrary.TestFramework.BeginTestCase("CultureInfoInvariantCulture");
        if (CultureInfoInvariantCulture.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }

    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: Gets the CultureInfo that is culture-independent (invariant).");
        try
        {
            CultureInfo myCultureInfo = CultureInfo.InvariantCulture;
            CultureInfo myExceptedCultureInfo = new CultureInfo("");
            if (!myCultureInfo.Equals( myExceptedCultureInfo))
             {
                 TestLibrary.TestFramework.LogError("001", "The CultureInfo that is not culture-independent (invariant).");
                 retVal = false;
                
             }
         

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpected exception: " + e);
            retVal = false;
        }
        return retVal;
    }
 

}

