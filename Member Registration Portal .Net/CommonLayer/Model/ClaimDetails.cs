using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Model
{
    public class ClaimDetails
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? CreatedDate { get; set; } = DateTime.Now.ToString("dd-MM-yyyy");
        public string? UserID { get; set; }
        public int? ClaimID { get; set; } = 0;
        public string? DependentName1 { get; set; }
        
        public string? Dependent1Claim { get; set; }
        
        public string? DateOfBirth1 { get; set; }
        
        public string? DependentName2 { get; set; }
        
        public string? Dependent2Claim { get; set; }
        
        public string? DateOfBirth2 { get; set; }
        
        public string? DateOfAdmission { get; set; }
        
        public string? DateOfDischarge { get; set; }
        
        public string? ProviderName { get; set; }
        
        public double TotalBillAmount { get; set; }
    }
}
