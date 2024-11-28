namespace ReservationWebClub.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Notes { get; set; }
    }
}
