using ACT.Services.Interfaces;
using ACT.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ACT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsolidatedDayController : ControllerBase
    {
        private readonly IConsolidatedDayService _consolidatedDay;

        public ConsolidatedDayController(IConsolidatedDayService consolidatedDay ) 
        {
            _consolidatedDay = consolidatedDay;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VM_ConsolidatedDay>> Get([FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate)
        {
            try
            {
                var _dataReport = _consolidatedDay.GetReport(startDate, endDate);
                if (_dataReport.Any())
                    return Ok(_dataReport);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
