namespace ReservationWebClub.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
