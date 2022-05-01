using SkiSelector.Core.Enums;
using SkiSelector.Core.Interfaces;

namespace SkiSelector.Core.Domain;

public class FreestyleSkiLengthStrategy:ISkiLengthStrategy
{
    public int AdditionToUnder5 = 0;
    public int AdditionFor5To8YearOlds = 10;
    public int AdditionToOver8YearOlds = 15;
    public int MaxLength = 192;
    public int? GetSuitableLenght(int age, int length)
    {
        if (length > MaxLength)
            return MaxLength;
        
        var addition = GetLengthAdditionByAge(age);
        for (int i = MaxLength; i > 100; i -= 5)
        {
            if (i <= length + addition)
                return i;
        }

        return (int?)null;
    }

    private int GetLengthAdditionByAge(int age)
    {
        if (age < 5)
            return AdditionToUnder5;
        if (age < 8)
            return AdditionFor5To8YearOlds;
        return AdditionToOver8YearOlds;
    }
}