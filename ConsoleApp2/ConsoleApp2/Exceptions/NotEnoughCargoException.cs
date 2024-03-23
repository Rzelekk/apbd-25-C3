using System.Runtime.Serialization;

namespace ConsoleApp2.Exceptions;

public class NotEnoughCargoException : Exception
{
    public NotEnoughCargoException()
    {
    }

    protected NotEnoughCargoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public NotEnoughCargoException(string? message) : base(message)
    {
    }

    public NotEnoughCargoException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}