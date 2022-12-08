using AutoMapper;
using Booking_Movie.Data.Entities;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Catalog.CategoryVM;
using Booking_Movie.ViewModel.Catalog.ComboVM;
using Booking_Movie.ViewModel.Catalog.DirectorVM;
using Booking_Movie.ViewModel.Catalog.MovieVM;
using Booking_Movie.ViewModel.Catalog.PaymentMethodVM;
using Booking_Movie.ViewModel.Catalog.ProducerVM;
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
            CreateMap<Ticket, TicketViewModel>();
            CreateMap<Combo, ComboViewModel>();
            CreateMap<PaymentMethod, PaymentMethodViewModel>();
            CreateMap<Category, CategoryViewModel>();
        }
    }
}
