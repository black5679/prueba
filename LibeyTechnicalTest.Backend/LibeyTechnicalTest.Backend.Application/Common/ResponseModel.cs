using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Application.Common
{
    public class ResponseModel
    {
        public string? Message { get; set; }
        public dynamic? Data { get; set; }
        public ResponseModel(string message) 
        {
            Message = message;
        }
        public ResponseModel(string message, dynamic? data)
        {
            Message = message;
            Data = data;
        }
    }
}
