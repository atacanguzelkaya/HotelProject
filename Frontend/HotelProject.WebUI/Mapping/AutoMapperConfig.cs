﻿using AutoMapper;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.About;
using HotelProject.WebUI.Dtos.Login;
using HotelProject.WebUI.Dtos.Register;
using HotelProject.WebUI.Dtos.Service;
using HotelProject.WebUI.Dtos.Staff;
using HotelProject.WebUI.Dtos.Subscribe;
using HotelProject.WebUI.Dtos.Testimonial;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

			CreateMap<ResultAboutDto, About>().ReverseMap();
			CreateMap<UpdateAboutDto, About>().ReverseMap();

			CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

			CreateMap<ResultStaffDto, Staff>().ReverseMap();

			CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();
		}
	}
}