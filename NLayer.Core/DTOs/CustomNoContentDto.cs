using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomNoContentDto
    {
        [JsonIgnore]
        public int StatusCode { get; set; }
        public List<String> Errors { get; set; }

        public static CustomNoContentDto Success(int statusCode)
        {
            return new CustomNoContentDto {StatusCode = statusCode };
        }

        public static CustomNoContentDto Fail(int statusCode, List<string> errors)
        {
            return new CustomNoContentDto { StatusCode = statusCode, Errors = errors };
        }

        public static CustomNoContentDto Fail(int statusCode, string error)
        {
            return new CustomNoContentDto { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
