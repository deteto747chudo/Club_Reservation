namespace ReservationWebClub.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int SeatCount { get; set; }
        public bool IsSmokingAllowed { get; set; }
    }

}
