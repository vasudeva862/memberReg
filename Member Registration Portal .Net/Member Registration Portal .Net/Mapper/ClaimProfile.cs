using AutoMapper;
using CommonLayer;
using CommonLayer.Model;

namespace Member_Registration_Portal_.Net.Mapper
{
    public class ClaimProfile : Profile
    {
        public ClaimProfile()
        {
            CreateMap<AddClaimRequest, ClaimDetails>();
            CreateMap<UpdateClaimRequest, ClaimDetails>();
        }
    }
}
