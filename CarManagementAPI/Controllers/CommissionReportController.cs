using CarManagementAPI.Models;
using CarManagementAPI.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommissionReportController : ControllerBase
    {
        private readonly ICommissionService _commissionService;

        public CommissionReportController(ICommissionService commissionService)
        {
            _commissionService = commissionService;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CalculateCommission([FromBody] Salesman salesman, [FromBody] List<Sale> sales)
        {
            var commission = _commissionService.CalculateCommission(salesman, sales);
            return Ok(commission);
        }
    }
}
