using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using BookingManagementDAL;

namespace BookingManagementBLL
{
    public class BookingBLL
    {
        private readonly string connectionstr;
        public BookingBLL()
        {
            connectionstr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        }
        public IEnumerable<Booking> GetAllReservation()
        {
            
            using (var connection = new SqlConnection(connectionstr))
            {
                //Set up DynamicParameters object to pass parameters  
                DynamicParameters parameters = new DynamicParameters();


                //Execute stored procedure and map the returned result to a Customer object  
                var customer = connection.Query<Booking>("GetReservationList", commandType: CommandType.StoredProcedure);
                return customer.ToList();
            }
            
        }
    }
}
