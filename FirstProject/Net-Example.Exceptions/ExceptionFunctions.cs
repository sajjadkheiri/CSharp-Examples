namespace Net_Example.Exceptions;

public class ExceptionFunctions
{
    /// <summary>
    /// when : when is a condition and you can use 2 or more similar catch with different conditions
    /// </summary>
    public void Sum(int a, int b)
    {
        try
        {
            if (a < default(int))
            {
                throw new Exception("");
            }

            if (b < default(int))
            {
                throw new FormatException("");
            }
        }
        catch (FormatException fe) when (!string.IsNullOrEmpty(fe.Source))
        {
            Console.WriteLine($"Format Exception : {fe.Message}");
            Console.WriteLine($"Format Exception Source : {fe.Source}");
        }
        catch (FormatException fe) when (string.IsNullOrEmpty(fe.Source))
        {
            Console.WriteLine($"Format Exception : {fe.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception : {e.Message}");
        }
        finally
        {
            Console.WriteLine("End");
        }
    }
}
