using AutoMapper;
using Booking_Movie.Data.Entities;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Catalog.AuditoriumVM;
using Booking_Movie.ViewModel.Catalog.CategoryVM;
using Booking_Movie.ViewModel.Catalog.CinemaVM;
using Booking_Movie.ViewModel.Catalog.ComboVM;
using Booking_Movie.ViewModel.Catalog.DirectorVM;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.NationalityVM;
using Booking_Movie.ViewModel.Catalog.PaymentMethodVM;
using Booking_Movie.ViewModel.Catalog.ProducerVM;
using Booking_Movie.ViewModel.Catalog.ScreeningTypeVM;
using Booking_Movie.ViewModel.Catalog.ScreeningVM;
using Booking_Movie.ViewModel.Catalog.ShowTimeVM;
using Booking_Movie.ViewModel.Catalog.TicketTypeVM;
using Booking_Movie.ViewModel.Catalog.TicketVM;

namespace Booking_Movie.BackendApi.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Actor, ActorViewModel>();
            CreateMap<Auditorium, AuditoriumViewModel>()
                .ForMember(dest => dest.CinemaName, opt => opt.MapFrom(src => src.Cinema.Name));

            CreateMap<Cinema, CinemaViewModel>()
                .ForMember(dest => dest.LocationName, opt => opt.MapFrom(src => src.Location.Name));
            CreateMap<Director, DirectorViewModel>();
            CreateMap<Producer, ProducerViewModel>();
            //CreateMap<Movie, MovieViewModel>();
            CreateMap<Nationality, NationalityViewModel>();
            CreateMap<Ticket, TicketViewModel>()
                .ForMember(dest => dest.ValidityDateFrom, opt => opt.MapFrom(src => src.ValidityDateFrom.Time))
                .ForMember(dest => dest.ValidityDateTo, opt => opt.MapFrom(src => src.ValidityDateTo.Time))
                .ForMember(dest => dest.MovieName, opt => opt.MapFrom(src => src.Movie.Name));
            CreateMap<Combo, ComboViewModel>();
            CreateMap<PaymentMethod, PaymentMethodViewModel>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<ScreeningType, ScreeningTypeViewModel>();
            CreateMap<TicketType, TicketTypeViewModel>();
            CreateMap<ShowTime, ShowTimeViewModel>();
            //CreateMap<Screening, ScreeningViewModel>();
        }
    }
}
