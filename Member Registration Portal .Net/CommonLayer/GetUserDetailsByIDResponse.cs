using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class GetUserDetailsByIDResponse
    {
        public bool IsSuccess { get; set; } = true;
        public string? Message { get; set; } = "Fetch User Details Successfully";
        public UserDetails? data { get; set; } = new UserDetails();
    }
}
