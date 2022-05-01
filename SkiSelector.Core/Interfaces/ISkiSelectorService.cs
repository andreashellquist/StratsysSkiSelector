using SkiSelector.Core.Dtos;

namespace SkiSelector.Core.Interfaces;

public interface ISkiSelectorService
{
    public int? GetLengthOfSkis(SkiProfileDto skiProfileDto);
}