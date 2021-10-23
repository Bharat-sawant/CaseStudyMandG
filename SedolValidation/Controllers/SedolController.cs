using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SedolValidation.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SedolValidation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SedolController : ControllerBase
    {
        

        private readonly ILogger<SedolController> _logger;
        private readonly ISedolValidator _SedolValidatorService;

        public SedolController(ILogger<SedolController> logger, ISedolValidator SedolValidator)
        {
            _logger = logger;
            _SedolValidatorService = SedolValidator;
        }
        //// input test https://localhost:44388/Sedol/ValidateSedol/Null
        //// input test https://localhost:44388/Sedol/ValidateSedol/%22%2
        //// input test https://localhost:44388/Sedol/ValidateSedol/12
        //// input test https://localhost:44388/Sedol/ValidateSedol/123456789
        //// input test https://localhost:44388/Sedol/ValidateSedol/1234567
        //// input test https://localhost:44388/Sedol/ValidateSedol/0709954
        //// input test https://localhost:44388/Sedol/ValidateSedol/B0YBKJ7
        //// input test https://localhost:44388/Sedol/ValidateSedol/9123451
        //// input test https://localhost:44388/Sedol/ValidateSedol/9ABCDE8
        //// input test https://localhost:44388/Sedol/ValidateSedol/9123_51
        //// input test https://localhost:44388/Sedol/ValidateSedol/VA.CDE8
        //// input test https://localhost:44388/Sedol/ValidateSedol/9123458
        //// input test https://localhost:44388/Sedol/ValidateSedol/9ABCDE1  
        [HttpGet]
        [Route("ValidateSedol/{input}")]
        public IActionResult ValidateSedol(string input)
        {
            return Ok( _SedolValidatorService.ValidateSedol(input));
        }
    }
}
