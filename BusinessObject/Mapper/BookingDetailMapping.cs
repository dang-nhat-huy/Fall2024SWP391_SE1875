﻿using AutoMapper;
using BusinessObject.Model;
using BusinessObject.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Mapper
{
    public class BookingDetailMapping : Profile
    {
        public BookingDetailMapping()
        {
            CreateMap<BookingDetail, BookingDetailResponseDTO>()
                .ForMember(dest => dest.BookingDetailID, opt => opt.MapFrom(src => src.BookingDetailId))
                 .ForMember(dest => dest.BookingID, opt => opt.MapFrom(src => src.BookingId))
        .ForMember(dest => dest.ServiceId, opt => opt.MapFrom(src => src.ServiceId)) // Map trực tiếp từ ServiceId
        .ForMember(dest => dest.StylistId, opt => opt.MapFrom(src => src.StylistId)) // Map trực tiếp từ StylistId
                   .ForMember(dest => dest.CreateDate, opt => opt.MapFrom(src => src.CreateDate))
                    .ForMember(dest => dest.CreateBy, opt => opt.MapFrom(src => src.CreateBy))
                     .ForMember(dest => dest.UpdateDate, opt => opt.MapFrom(src => src.UpdateDate))
                      .ForMember(dest => dest.UpdateBy, opt => opt.MapFrom(src => src.UpdateBy));

            CreateMap<BookingDetail, BookingOfStylistDTO>()
                .ForMember(dest => dest.BookingDetailId, opt => opt.MapFrom(src => src.BookingDetailId))
                .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => src.Booking.TotalPrice))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Booking.Status))
                .ForMember(dest => dest.CreateBy, opt => opt.MapFrom(src => src.Booking.CreateBy))
                .ReverseMap();

            CreateMap<HairService, ServiceDetailDTO>()
                .ForMember(dest => dest.ServiceId, opt => opt.MapFrom(src => src.ServiceId))
                .ForMember(dest => dest.ServiceName, opt => opt.MapFrom(src => src.ServiceName))
                .ForMember(dest => dest.StylistName, opt => opt.NullSubstitute(null))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.EstimateTime, opt => opt.MapFrom(src => src.EstimateTime))
                .ReverseMap();

            CreateMap<Schedule, ScheduledDetailDTO>()
                .ForMember(dest => dest.ScheduleId, opt => opt.MapFrom(src => src.ScheduleId))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                .ReverseMap();
        }
    }
}
