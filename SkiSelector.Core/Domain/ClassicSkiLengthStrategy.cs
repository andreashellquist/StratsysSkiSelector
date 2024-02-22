using SkiSelector.Core.Interfaces;

namespace SkiSelector.Core.Domain;

public class ClassicSkiLengthStrategy:ISkiLengthStrategy
{
    private const int AdditionToUnder5YearOlds = 0;
    private const int AdditionTo5And6YearOlds = 10;
    private const int AdditionToOver7YearOlds = 20;
    private const int MaxLength = 207;

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
            < 5 => AdditionToUnder5YearOlds,
            < 7 => AdditionTo5And6YearOlds,
            _ => AdditionToOver7YearOlds
        };
    }
}