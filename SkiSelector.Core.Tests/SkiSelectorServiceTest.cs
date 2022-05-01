using SkiSelector.Core.Dtos;
using SkiSelector.Core.Enums;
using SkiSelector.Core.Services;
using Xunit;

namespace SkiSelector.Core.Tests;

public class SkiSelectorServiceTest
{
    [Theory]
    [InlineData(4, 110, SkiType.Classic, 107)]
    [InlineData(4, 110, SkiType.Freestyle, 107)]
    [InlineData(8, 145, SkiType.Classic, 162)]
    [InlineData(8, 145, SkiType.Freestyle, 157)]
    [InlineData(38, 185, SkiType.Classic, 202)]
    [InlineData(38, 185, SkiType.Freestyle, 192)]
    public void SkiSelectorService_GetLengthOfSkis_ReturnsCorrectLength(int age, int length, SkiType skiType, int expectedResult)
    {
        //arrange
        var service = new SkiSelectorService();
        var profile = new SkiProfileDto(age, length, skiType);
        //act
        var result = service.GetLengthOfSkis(profile);
        
        Assert.Equal(expectedResult, result);
    }
}