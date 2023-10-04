using System.ComponentModel.DataAnnotations;

namespace ShoppingListProject.Entitylayer
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }
        public string? NotificationType { get; set; }
        public string? NotificationTypeSymbol { get; set; }
        public string? NotificationDetails { get; set; }
        public DateTime CreateDate { get; set; }
        public bool NotificationStatus { get; set; }
        public string? NotificationColor { get; set; }
    }
}
