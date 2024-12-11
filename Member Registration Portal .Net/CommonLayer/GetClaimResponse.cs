using CommonLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class GetClaimResponse
    {
        public bool IsSuccess { get; set; } = true;
        public string? Message { get; set; } = "Fetch Record Successfully";
        public List<ClaimDetails>? data { get; set; } = new List<ClaimDetails>();
    }
}
