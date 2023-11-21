using System.ComponentModel.DataAnnotations;

namespace OnlineExam.Models;

public class Exams
{
    public int Id { get; set; }
    public string? Question { get; set; }
    public string? Answer1 { get; set; }
    public string? Answer2 { get; set; }
    public string? Answer3 { get; set; }
    public string? Answer4 { get; set; }
    public string? Answer5 { get; set; }
    
}