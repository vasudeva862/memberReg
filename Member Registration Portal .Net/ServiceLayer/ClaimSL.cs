using CommonLayer;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ClaimSL : IClaimSL
    {
        private readonly IClaimRL _claimRL;
        public ClaimSL(IClaimRL claimRL)
        {
            _claimRL = claimRL;
        }

        public async Task<AddClaimResponse> AddClaim(AddClaimRequest request)
        {
            return await _claimRL.AddClaim(request);
        }

        public async Task<DeleteClaimResponse> DeleteClaim(DeleteClaimRequest request)
        {
            return await _claimRL.DeleteClaim(request);
        }

        public async Task<GetClaimResponse> GetClaim(string? UserID)
        {
            return await _claimRL.GetClaim(UserID);
        }

        public async Task<UpdateClaimResponse> UpdateClaim(UpdateClaimRequest request)
        {
            return await (_claimRL.UpdateClaim(request));
        }
    }
}
