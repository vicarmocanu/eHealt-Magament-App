using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.Object_Models;

namespace HealthCareModel.DBHandler
{
    class UserHandler : IUserHandler
    {
        //create user
        public void createUser(string firstName, string lastName, string username, string password, string role)
        {
            using (var db = new HealthModelsDataContext())
            {
                var user = new User();

                user.firstName = firstName;
                user.lastName = lastName;
                user.userName = username;
                user.password = password;
                user.role = role;

                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
            }
        }

        //get user
        public User getUser(string username)
        {
            var user = new User();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.Users.SingleOrDefault(targetUser => targetUser.userName.Equals(username));
                user = query;
            }

            return user;
        }

        //get users
        public List<User> getUsers()
        {
            List<User> users = new List<User>();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.Users.ToList();
                users = query;
            }

            return users;
        }

        //update user
        public void updateUser(string firstName, string lastName, string username, string password, string role)
        {
            var user = new User();

            using (var db = new HealthModelsDataContext())
            {
                user = db.Users.SingleOrDefault(targetUser => targetUser.userName.Equals(username));

                if(user!=null)
                {
                    user.firstName = firstName;
                    user.lastName = lastName;
                    user.password = password;
                    user.role = role;

                    db.SubmitChanges();
                }
            }
        }

        //delete user
        public void deleteUser(string username)
        {
            using (var db = new HealthModelsDataContext())
            {
                User user = db.Users.SingleOrDefault(targetUser => targetUser.userName.Equals(username));

                if(user!=null)
                {
                    db.Users.DeleteOnSubmit(user);
                    db.SubmitChanges();
                }
            }
        }

        public string userLogIn(string username, string password)
        {
            string result = "Fail";

            using (var db = new HealthModelsDataContext())
            {
                User user = db.Users.SingleOrDefault(targetUser => targetUser.userName.Equals(username) && targetUser.password.Equals(password));

                if(user!=null)
                {
                    result = user.role;
                }
            }

            return result;
        }
    }
}
