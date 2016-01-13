using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HealthCareModel.DBHandler;
using HealthCareModel.Object_Models;

namespace HealthCareModel.ControlHandler
{
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

        public static void deleteUser(string username)
        {
            userHandler.deleteUser(username);
        }

        public static string userLogIn(string username, string password)
        {
            return userHandler.userLogIn(username, password);
        }
    }
}
