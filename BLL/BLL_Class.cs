using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class BLL_Class
    {
        public List<User> GetUser_BLL()
        {
            return new DAL_Class().GetUser();
        }

        public void AddUser_BLL(User user)
        {
            new DAL_Class().AddUser(user);
        }
    }
    
}
