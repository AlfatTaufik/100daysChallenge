static void OperatingProcedure1()
{
string[]
[] userEnteredValue = new string[]
{
    new string[] {"1", "two", "3"},
    new string[] {"0", "1", "2"}
};

foreach (string[] userEntries in userEnteredValue)
{
    try
    {
        BussinessProcess1(userEntries);
    }
    catch (Exception ex)
    {
        if (ex.StackTrace.Contains("BussinessProcess1") && (ex is FormatException))
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Corrective action taken in OperatingProcedure1");
        }
        else if (ex is DivideByZeroException)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");
            // re-throw the original exception
            throw;
        }
        else
        {
            throw new AplicationException("ApplicationException: User input values in 'OperatingProcedure1' must be valid integers", ex);
        }
    }
}
}


static void BussinessProcess1(String[] userEntries)
{
    int valueEntered;

    foreach (var userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (FormatException)
        {
            FormatException InvalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw InvalidFormatException;
        }
        catch (DivideByZeroException)
        {
            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
            throw unexpectedDivideByZeroException;
        }
    }
}