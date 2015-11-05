using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.DBHandler;
using HealthCareModel.Object_Models;

namespace HealthCareModel.ControlHandler
{
    //static - no need to create objects from this class
    //methods will have to be static as well
    public static class UserControl
    {
        private static IUserHandler userHandler = new UserHandler();

        public static void createUser(string firstName, string lastName, string username, string password, string role)
        {
            userHandler.createUser(firstName, lastName, username, password, role);
        }

        public static void updateUser(string firstName, string lastName, string username, string password, string role)
        {
            userHandler.updateUser(firstName, lastName, username, password, role);
        }

        public static User getUser(string username)
        {
            return userHandler.getUser(username);
        }

        public static List<User> getUsers()
        {
            return userHandler.getUsers();
        }
    }
}
