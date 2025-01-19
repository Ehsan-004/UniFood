namespace UniFood.Models;

public class StudentReserve
{
    public int Id { get; set; }
    
    public string StudentId { get; set; }
    public Student Student { get; set; }
    
    public int ReserveId { get; set; }
    public Reserve Reserve { get; set; }
}