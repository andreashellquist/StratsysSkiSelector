using Microsoft.Extensions.Logging;
using Moq;
using SkiSelector.Core.Dtos;
using SkiSelector.Core.Enums;
using SkiSelector.Core.Interfaces;
using WebApplication1.Controllers;
using WebApplication1.Models;
using Xunit;

namespace SkiSelector.Api.Test;

public class SkiSelectorControllerTest
{
    [Fact]
    public void SkiSelectorController_GetSkiLength_ReturnsCorrectLength()
    {
        //arrange
        var loggerMock = new Mock<ILogger<SkiSelectorController>>();
        var skiSelectorMock = new Mock<ISkiSelectorService>();
        var lengthResult = 203;
        var request = new SkiProfileRequest
        {
            Age = 38, Lenght = 185, SkiType = SkiType.Classic
        };
        skiSelectorMock.Setup(x => x.GetLengthOfSkis(It.Is<SkiProfileDto>(s =>
            s.Age == request.Age && s.Lenght == request.Lenght && s.SkiType == request.SkiType))).Returns(202);
        
        var controller = new SkiSelectorController(loggerMock.Object, skiSelectorMock.Object);
        
        //act
        var result = controller.GetSkiLength(request);
        
        //assert
        Assert.Equal(lengthResult, result);
    }
}