using Microsoft.AspNetCore.Mvc;
using MudBlazor;
using zenTime.Server.Services;
using zenTime.Shared;

namespace zenTime.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HoursController : ControllerBase
{
    private readonly IHoursService _hoursService;

    public HoursController(IHoursService hoursService)
    {
        _hoursService = hoursService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<TimeTrackingModel>>>> GetHours()
    {
        var result = await _hoursService.GetHours();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<TimeTrackingModel>>>> SetHours()
    {
        var result = await _hoursService.SetHours();
        return Ok(result);
    }
}