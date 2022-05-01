namespace SkiSelector.Core.Interfaces;

public interface ISkiLengthStrategy
{
    public int? GetSuitableLenght(int age, int length);
}