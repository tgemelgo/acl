using ACT.Services;
using ACT.Services.Interfaces;
using ACT.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ACT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaunchController : ControllerBase
    {
        private readonly ILaunchService _launchService;

        public LaunchController(ILaunchService launchService) 
        {
            _launchService = launchService;
        }

        [HttpPost]
        public ActionResult Post(VM_Launch launch)
        {
            try
            {
                _launchService.Add(launch);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public ActionResult Put(VM_Launch launch)
        {
            try
            {
                _launchService.Update(launch);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("id:guid")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                _launchService.Remove(id);
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("id:guid")]
        public ActionResult GetById(Guid id)
        {
            try
            {
                var item = _launchService.Get(id);
                if (item == null)
                    return NotFound();

                return Ok(item);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet()]
        public ActionResult GetAll()
        {
            try
            {
                var item = _launchService.GetAll();
                if (!item.Any())
                    return NotFound();

                return Ok(item);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
