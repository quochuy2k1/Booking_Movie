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
using Booking_Movie.ViewModel.Catalog.TicketVM;

namespace Booking_Movie.BackendApi.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Actor, ActorViewModel>();
            CreateMap<Director, DirectorViewModel>();
            CreateMap<Producer, ProducerViewModel>();
            //CreateMap<Movie, MovieViewModel>();
            CreateMap<Nationality, NationalityViewModel>();
            CreateMap<Ticket, TicketViewModel>();
            CreateMap<Combo, ComboViewModel>();
            CreateMap<PaymentMethod, PaymentMethodViewModel>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Cinema, CinemaViewModel>();
            CreateMap<Auditorium, AuditoriumViewModel>();
            CreateMap<ScreeningType, ScreeningTypeViewModel>();
            //CreateMap<Screening, ScreeningViewModel>();
        }
    }
}
