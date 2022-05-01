using SkiSelector.Core.Domain;
using SkiSelector.Core.Dtos;
using SkiSelector.Core.Enums;
using SkiSelector.Core.Interfaces;

namespace SkiSelector.Core.Services;

public class SkiSelectorService:ISkiSelectorService
{
    public int? GetLengthOfSkis(SkiProfileDto skiProfileDto)
    {
        ISkiLengthStrategy skiLengthStrategy = null;
        if (skiProfileDto.SkiType == SkiType.Classic)
            skiLengthStrategy = new ClassicSkiLengthStrategy();
        else if (skiProfileDto.SkiType == SkiType.Freestyle)
            skiLengthStrategy = new FreestyleSkiLengthStrategy();
        else
        {
            
            return null;
        }
        return skiLengthStrategy.GetSuitableLenght(skiProfileDto.Age, skiProfileDto.Lenght);
    }
}