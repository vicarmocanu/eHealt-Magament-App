using HealthCareModel.Object_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareModel.DBHandler
{
    interface IUserHandler
    {
        //create user
        void createUser(string firstName, string lastName, string username, string password, string role);

        //update user
        void updateUser(string firstName, string lastName, string username, string password, string role);

        //get user
        User getUser(string username);

        //get all users
        List<User> getUsers();

        //delete user
        void deleteUser(string username);

        //login
        string userLogIn(string username, string password);
    }
}
