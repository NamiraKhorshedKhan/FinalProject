using DAL.EFs.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Admin, string, Admin> AdminDataAccess()
        {
            return new AdminRepo();
        }
        public static IRepo<Booking, string, Booking> BookingDataAccess()
        {
            return new BookingRepo();
        }
        public static IRepo<Customer, string, Customer> CustomerDataAccess()
        {
            return new CustomerRepo();
        }
        public static IRepo<Feedback, string, Feedback> FeedbackDataAccess()
        {
            return new FeedbackRepo();
        }
        public static IRepo<Login, string, Login> LoginDataAccess()
        {
            return new LoginRepo();
        }
        public static IRepo<Menu, string, Menu> MenuDataAccess()
        {
            return new MenuRepo();
        }
        public static IRepo<Payment, string, Payment> PaymentDataAccess()
        {
            return new PaymentRepo();
        }
        public static IRepo<Rating, string, Rating> RatingDataAccess()
        {
            return new RatingRepo();
        }
        public static IRepo<Restaurant, string, Restaurant> RestaurantDataAccess()
        {
            return new RestaurantRepo();
        }
        public static IRepo<Review, string, Review> ReviewDataAccess()
        {
            return new ReviewRepo();
        }
        public static IRepo<Token, string, Token> TokenDataAccess()
        {
            return new TokenRepo();
        }
        public static IAuth AuthDataAccess()
        {
            return new LoginRepo();
        }
    }
}
