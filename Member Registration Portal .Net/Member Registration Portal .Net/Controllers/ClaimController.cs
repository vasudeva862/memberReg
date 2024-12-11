using CommonLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using System.ComponentModel.DataAnnotations;

namespace Member_Registration_Portal_.Net.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimSL _claimSL;
        public ClaimController(IClaimSL claimSL) 
        {
            _claimSL = claimSL;
        }

        [HttpPost]
        public async Task<IActionResult> AddClaim(AddClaimRequest request)
        {
            AddClaimResponse response = new AddClaimResponse();
            try 
            {
                response = await _claimSL.AddClaim(request);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateClaim(UpdateClaimRequest request)
        {
            UpdateClaimResponse response = new UpdateClaimResponse();
            try 
            {
                response = await _claimSL.UpdateClaim(request);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetClaim([FromQuery, Required]string? UserID)
        {
            GetClaimResponse response = new GetClaimResponse();
            try 
            {
                response = await _claimSL.GetClaim(UserID);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClaim([FromQuery]DeleteClaimRequest request)
        {
            DeleteClaimResponse response = new DeleteClaimResponse();
            try 
            {
                response = await _claimSL.DeleteClaim(request);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return Ok(response);
        }
    }
}
