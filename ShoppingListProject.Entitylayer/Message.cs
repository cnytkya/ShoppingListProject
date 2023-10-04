using System.ComponentModel.DataAnnotations;

namespace ShoppingListProject.Entitylayer
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string? Sender { get; set; }
        public string? Receiver { get; set; }
        public string? Subject { get; set; }
        public string? MessageDetails { get; set; }
        public DateTime CreatedDate { get; set; }
        //public string MessageImage { get; set; }
        public bool MessageStatus { get; set; }
    }
}
