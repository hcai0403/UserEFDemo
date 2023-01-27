using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class DAL_Class
    {
        UserDBEntities1 udb = new UserDBEntities1();
        public List<User> GetUser()
        {
            List<User> users = new List<User>();
            try
            {
                
                users = udb.Users.ToList();

                return users;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured while retrieving Users - " + ex.Message.ToString());
            }
        }

        public void AddUser(User user){

            try
            {
                
                udb.Users.Add(user);
                udb.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured while Adding User - " + ex.Message.ToString());
            }

        }

    }
}
