using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class UpdateClaimRequest
    {
        [Required]
        public string? Id { get; set; }
        [Required]
        public string? UserID { get; set; }
        [Required]
        public int? ClaimID { get; set; } = 0;
        [Required]
        public string? DependentName1 { get; set; }
        [Required]
        public string? Dependent1Claim { get; set; }
        [Required]
        public string? DateOfBirth1 { get; set; }
        [Required]
        public string? DependentName2 { get; set; }
        [Required]
        public string? Dependent2Claim { get; set; }
        [Required]
        public string? DateOfBirth2 { get; set; }
        [Required]
        public string? DateOfAdmission { get; set; }
        [Required]
        public string? DateOfDischarge { get; set; }
        [Required]
        public string? ProviderName { get; set; }
        [Required]
        public double TotalBillAmount { get; set; }
    }
}
