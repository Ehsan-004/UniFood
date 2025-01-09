using UniFood.Data.Enum;

namespace UniFood.Models;

public class Reserve
{
    public int Id { get; set; }
    public ReserveType Type { get; set; }
    public DateTime Date { get; set; }
    
    public ICollection<StudentReserve> ReservingStudents { get; set; }
}