using CarManagementAPI.Models;
using CarManagementAPI.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

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

        [HttpGet("GetCommissionReport")]
        [Authorize(Roles = "Admin")]
        [Description("API to get comission report for salesman")]
        public async Task<ActionResult<IEnumerable<CommissionReport>>> GetCommissionReport()
        {
            var reports = _commissionService.CalculateCommission();
            return Ok(reports);
        }
    }
}
