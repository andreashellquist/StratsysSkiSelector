using SkiSelector.Core.Interfaces;

namespace SkiSelector.Core.Domain;

public class ClassicSkiLengthStrategy:ISkiLengthStrategy
{
    public int AdditionToUnder5YearOlds = 0;
    public int AdditionTo5And6YearOlds = 10;
    public int AdditionToOver7earOlds = 20;
    public int MaxLength = 207;
    
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
            return AdditionToUnder5YearOlds;
        if (age < 7)
            return AdditionTo5And6YearOlds;
        return AdditionToOver7earOlds;
    }
}