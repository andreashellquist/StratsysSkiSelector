using Microsoft.AspNetCore.Mvc;
using SkiSelector.Core;
using SkiSelector.Core.Dtos;
using SkiSelector.Core.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class SkiSelectorController : ControllerBase
{
    private readonly ILogger<SkiSelectorController> _logger;
    private readonly ISkiSelectorService _skiSelectorService;

    public SkiSelectorController(ILogger<SkiSelectorController> logger, ISkiSelectorService skiSelectorService)
    {
        _logger = logger;
        _skiSelectorService = skiSelectorService;
    }

    [HttpPost(Name = "GetSkiLength")]
    public int? GetSkiLength(SkiProfileRequest skiProfileRequest)
    {
        var skiProfileDto = new SkiProfileDto(skiProfileRequest.Age, skiProfileRequest.Length, skiProfileRequest.SkiType);
        var skiLenght = _skiSelectorService.GetLengthOfSkis(skiProfileDto);
        if (skiLenght == null)
            _logger.LogWarning(
                "Provided SkiProfileRequest resulted in that no ski length selected. Input was Age: {age}, Length: {length}, SkiType: {skiType}",
                skiProfileRequest.Age, skiProfileRequest.Length, skiProfileRequest.SkiType);
        else
            _logger.LogInformation(
                "Provided SkiProfileRequest resulted in that ski length:{skilength} was  selected. Input was Age: {age}, Length: {length}, SkiType: {skiType}",
                skiLenght, skiProfileRequest.Age, skiProfileRequest.Length, skiProfileRequest.SkiType);

        return skiLenght;
    }
}