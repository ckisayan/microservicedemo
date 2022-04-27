namespace Ordering.Application.Models
{
    //Basic email DTO object
    public class Email
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}