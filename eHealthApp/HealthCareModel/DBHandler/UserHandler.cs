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
        //create USER
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

        //get User
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
        //Get Users
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
        //Update User
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

        //delete User??

    }
}
