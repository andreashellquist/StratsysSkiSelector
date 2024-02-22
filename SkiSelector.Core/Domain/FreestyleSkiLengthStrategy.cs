using SkiSelector.Core.Interfaces;

namespace SkiSelector.Core.Domain;

public class FreestyleSkiLengthStrategy:ISkiLengthStrategy
{
    private const int AdditionToUnder5 = 0;
    private const int AdditionFor5To8YearOlds = 10;
    private const int AdditionToOver8YearOlds = 15;
    private const int MaxLength = 192;

    public int? GetSuitableLength(int age, int length)
    {
        if (length > MaxLength)
            return MaxLength;
        
        var addition = GetLengthAdditionByAge(age);
        for (var i = MaxLength; i > 100; i -= 5)
        {
            if (i <= length + addition)
                return i;
        }

        return null;
    }

    private int GetLengthAdditionByAge(int age)
    {
        return age switch
        {
            < 5 => AdditionToUnder5,
            < 8 => AdditionFor5To8YearOlds,
            _ => AdditionToOver8YearOlds
        };
    }
}