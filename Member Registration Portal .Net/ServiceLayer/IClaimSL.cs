﻿using CommonLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IClaimSL
    {
        Task<AddClaimResponse> AddClaim(AddClaimRequest request);
        Task<UpdateClaimResponse> UpdateClaim(UpdateClaimRequest request);
        Task<DeleteClaimResponse> DeleteClaim(DeleteClaimRequest request);
        Task<GetClaimResponse> GetClaim(string? UserID);
    }
}
