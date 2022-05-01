using SkiSelector.Core.Enums;

namespace SkiSelector.Core.Dtos;

public class SkiProfileDto
{
    public int Age { get; set; }
    public int Lenght { get; set; }
    public SkiType SkiType { get; set; }
    
    public SkiProfileDto(int age, int lenght, SkiType skiType)
    {
        Age = age;
        Lenght = lenght;
        SkiType = skiType;
    }
}