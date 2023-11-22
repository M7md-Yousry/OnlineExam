using System.ComponentModel.DataAnnotations;

namespace OnlineExam.Models;

public class Exams
{
    public int Id { get; set; }
    [Required,StringLength(80 ,MinimumLength = 10), RegularExpression(@"[^.!?]+\?")]
    public string? Question { get; set; }
    [Required]
    public string? Answer1 { get; set; }
    [Required]
    public string? Answer2 { get; set; }
    [Required]
    public string? Answer3 { get; set; }
    [Required]
    public string? Answer4 { get; set; }
    [Required]
    public string? Answer5 { get; set; }
    [Required, RegularExpression(@"[^0]+")]
    public double? Score { get; set; }
    
}