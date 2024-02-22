using System.ComponentModel.DataAnnotations;
using SkiSelector.Core.Enums;

namespace WebApplication1.Models;

public class SkiProfileRequest
{
    [Required]
    public int Age { get; set; }
    [Required]
    public int Length { get; set; }
    [Required]
    public SkiType SkiType { get; set; }
}