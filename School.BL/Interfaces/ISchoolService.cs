using Inside.Common;
using Microsoft.AspNetCore.Http;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.BL.Interfaces
{
    public interface ISchoolService
    {
        public Response<NoValue> Create(StudentDto studentDto);
        public Response<NoValue> SCV(IFormFile file);
        public Response<NoValue> SCVPrivate(IFormFile file);
    }
}
