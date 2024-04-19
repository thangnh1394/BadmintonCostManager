namespace CostManager.Pwa.Models;

public class Field
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public decimal CostPerHour { get; set; }
    public bool IsAvailable { get; set; }
    public List<string> Days { get; set; } = new List<string>();
    public int TimePerDay { get; set; }
}