using Microsoft.AspNetCore.Mvc;
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
    public async Task<ActionResult<ServiceResponse<List<CategoryHoursModel>>>> GetCategoryHours()
    {
        var result = await _hoursService.GetCategoryHours();
        return Ok(result);
    }
}