using Inside.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using School.BL.Interfaces;
using School.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CsvHelper;

namespace School.BL.Services
{
    public class SchoolService : ISchoolService
    {
        private  IHostingEnvironment _hosting { get; set; }

        public Response<NoValue> Create(StudentDto studentDto)
        {
            Response<NoValue> response = new Response<NoValue>();

            string JsonString = JsonSerializer.Serialize(studentDto);

            try
            {
                WriteFile(JsonString);
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            catch (Exception ex)
            {

                response.StatusCode = System.Net.HttpStatusCode.BadRequest;
            }

            return response;
        }

        public Response<NoValue> SCV(IFormFile file)
        {
            Response<NoValue> response = new Response<NoValue>();
            try
            {
                
                using (var csvReader = new CsvReader((IParser)file.OpenReadStream()))
                {
                    var records = csvReader.GetRecords<StudentDto>().ToList();
                    string JsonString = JsonSerializer.Serialize(records);
                    WriteFile(JsonString);
                }
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            catch (Exception)
            {

                response.StatusCode = System.Net.HttpStatusCode.BadRequest;
            }   
            
          
            return response;
        }

        public Response<NoValue> SCVPrivate(IFormFile file)
        {
             Response<NoValue> response = new Response<NoValue>();
            try
            {
                
                using (var csvReader = new CsvReader((IParser)file.OpenReadStream()))
                {
                    var records = csvReader.GetRecords<StudentPrivateDto>().ToList();
                    string JsonString = JsonSerializer.Serialize(records);
                    WriteFile(JsonString);
                }
                response.StatusCode = System.Net.HttpStatusCode.OK;
            }
            catch (Exception)
            {

                response.StatusCode = System.Net.HttpStatusCode.BadRequest;
            }   
            
          
            return response;
        
        }

        internal bool WriteFile(string stream)
        {
            try
            {
                DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;  // using System;

                string fileNeme = now.ToUnixTimeSeconds().ToString();
                string filePath = $"_hosting//output//fileName";
               
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write(stream);
                sw.Close();
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
