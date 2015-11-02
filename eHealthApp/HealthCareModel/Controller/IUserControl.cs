using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareModel.Controller
{
    public interface IUserControl
    {
        void createUser(string firstName, string lastName, string username, string password, string role);

       
    }
}
 