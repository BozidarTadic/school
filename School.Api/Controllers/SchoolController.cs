using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.BL.Interfaces;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _schoolService;

        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Create([FromBody] StudentDto studentDto)
        {
            var result = _schoolService.Create(studentDto);

            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return Ok(result.Content);
                case System.Net.HttpStatusCode.InternalServerError:
                    return StatusCode(500, "Internal server error");
              
                default:
                    return BadRequest();
            }


        }
        [HttpPost]
        [Route("SVCFile")]
        public IActionResult SVVFile( IFormFile file)
        {
            var result = _schoolService.SCV(file);

            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return Ok(result.Content);
                case System.Net.HttpStatusCode.InternalServerError:
                    return StatusCode(500, "Internal server error");

                default:
                    return BadRequest();
            }


        }
        [HttpPost]
        [Route("SVCPrivateFile")]
        public IActionResult SVVprivateFile(IFormFile file)
        {
            var result = _schoolService.SCVPrivate(file);

            switch (result.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    return Ok(result.Content);
                case System.Net.HttpStatusCode.InternalServerError:
                    return StatusCode(500, "Internal server error");

                default:
                    return BadRequest();
            }


        }


    }
}
