namespace Net_Example.Exceptions;

/// <summary>
/// You can create your personal exception handling class
/// </summary>
public class PersonalException : Exception
{
    public PersonalException(string? message) : base(message)
    {
        
    }
}
