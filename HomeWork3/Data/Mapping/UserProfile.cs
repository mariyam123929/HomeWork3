﻿using AutoMapper;
using ControllerFirst.DTO.Requests;
using ControllerFirst.Data.Models;
using HomeWork3.Data.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ControllerFirst.Data.Mapping;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterRequest, User>()
            .ForMember(dest => dest.UserName, opt =>
                opt.MapFrom(src => src.Username))
            .ForMember(dest => dest.Email,
                opt =>
                    opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Password,
                opt =>
                    opt.MapFrom(src => src.Password));
    }
}
