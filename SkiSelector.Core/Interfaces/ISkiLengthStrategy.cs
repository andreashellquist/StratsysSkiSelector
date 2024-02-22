namespace SkiSelector.Core.Interfaces;

public interface ISkiLengthStrategy
{
    public int? GetSuitableLength(int age, int length);
}