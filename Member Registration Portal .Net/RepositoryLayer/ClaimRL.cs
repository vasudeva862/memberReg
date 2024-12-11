using AutoMapper;
using CommonLayer;
using CommonLayer.Model;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class ClaimRL : IClaimRL
    {
        private readonly IConfiguration _configuration;
        private readonly MongoClient _mongoConnection;
        private readonly IMongoCollection<ClaimDetails> _claimDetails;
        private readonly IMapper _mapper;
        public ClaimRL(IConfiguration configuration, IMapper mapper)
        {
            _configuration = configuration;
            _mapper = mapper;
            _mongoConnection = new MongoClient(_configuration["MemberRegistrationPortalDatabase:ConnectionString"]);
            var MongoDataBase = _mongoConnection.GetDatabase(_configuration["MemberRegistrationPortalDatabase:DatabaseName"]);
            _claimDetails = MongoDataBase.GetCollection<ClaimDetails>(_configuration["MemberRegistrationPortalDatabase:ClaimCollectionName"]);

        }
        public async Task<AddClaimResponse> AddClaim(AddClaimRequest request)
        {
            AddClaimResponse response = new AddClaimResponse();
            try
            {
                ClaimDetails _claimDetail = new ClaimDetails();
                _claimDetail = _mapper.Map<ClaimDetails>(request);
                _claimDetail.ClaimID = getClaimIDNumber();
                await _claimDetails.InsertOneAsync(_claimDetail);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<DeleteClaimResponse> DeleteClaim(DeleteClaimRequest request)
        {
            DeleteClaimResponse response = new DeleteClaimResponse();
            try
            {
                var IsDelete = _claimDetails.DeleteOneAsync(x => x.Id == request.Id).Result;
                if (!IsDelete.IsAcknowledged)
                {
                    response.IsSuccess = false;
                    response.Message = "Something went wrong";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<GetClaimResponse> GetClaim(string? UserID)
        {
            GetClaimResponse response = new GetClaimResponse();
            try
            {
                response.data = _claimDetails.Find(x => x.UserID == UserID).ToList();
                if (response.data.Count == 0)
                {
                    response.IsSuccess = false;
                    response.Message = "Record Not Found";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public async Task<UpdateClaimResponse> UpdateClaim(UpdateClaimRequest request)
        {
            UpdateClaimResponse response = new UpdateClaimResponse();
            try
            {
                var _claimExist = _claimDetails
                   .Find(x => x.Id == request.Id).FirstOrDefaultAsync().Result;
                if (_claimExist == null)
                {
                    response.IsSuccess = false;
                    response.Message = "Claim Record Not Present";
                    return response;
                }

                _claimExist = _mapper.Map<ClaimDetails>(request);
                var IsUpdate = _claimDetails.ReplaceOneAsync(x => x.Id == request.Id, _claimExist).Result;
                if (!IsUpdate.IsAcknowledged)
                {
                    response.IsSuccess = false;
                    response.Message = "Something went wrong";
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public int getClaimIDNumber()
        {
            var _claimDetail = _claimDetails
                .Find(x => true)
                .SortByDescending(x => x.Id)
                .FirstOrDefaultAsync()
                .Result;

            if (_claimDetail == null)
            {
                return 1000000000;
            }

            return (((Int32)_claimDetail.ClaimID) + 1);

        }


    }
}
