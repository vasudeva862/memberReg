using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class AddClaimResponse
    {
        public bool IsSuccess { get; set; } = true;
        public string? Message { get; set; } = "Add Claim Successfully";
    }
}
