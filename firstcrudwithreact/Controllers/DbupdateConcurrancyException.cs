
namespace firstcrudwithreact.Controllers
{
    [Serializable]
    internal class DbupdateConcurrancyException : Exception
    {
        public DbupdateConcurrancyException()
        {
        }

        public DbupdateConcurrancyException(string? message) : base(message)
        {
        }

        public DbupdateConcurrancyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}