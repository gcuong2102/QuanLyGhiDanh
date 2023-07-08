using AutoMapper;
using QuanLyGhiDanh.Data;
using QuanLyGhiDanh.Models;

namespace QuanLyGhiDanh.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() 
        {
            CreateMap<Users, UserModel>().ReverseMap();
        }
    }
}
