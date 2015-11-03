using HealthCareModel.Object_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareModel.Controller
{
    public interface IUserControl
    {
        //create user
        public static void createUser(string firstName, string lastName, string username, string password, string role)
        {
            using (var db = new HealthModelsDataContext())
            {
                var user = new User();
                user.firstName = firstName;
                user.lastname = lastName;
                user.username = username;
                user.password = password;
                user.role = role;
                db.User.InsertOnSubmit(user);

                db.SubmitChanges();
            }
        }

        //update user

        public static void updateUser(string firstName, string lastName, string username, string password, string role)
        {
            var user = new User();
            using (var db = new HealthModelsDataContext())
            {
                user = db.Users.SingleOrDefault(user => user.username == username);

                if (user != null)
                {
                    user.firstName = firstName;
                    user.lastName = lastName;
                    user.username = username;
                    user.password = password;
                    user.role = role;

                    db.SubmitChanges();
                }
            }
        }

        //delete user

        public static void deleteUser(string firstName, string lastName, string username, string password, string role)
        {
            using (var db = new HealthModelsDataContext())
            {
                var deleteUserDetails =
                    from details in db.OrderDetails
                    where details.UserID == 11000
                    select details;

                foreach (var detail in deleteUserDetails)
                {
                    db.UserDetails.DeleteOnSubmit(detail);
                }

                try
                {
                    db.SubmitChanges();
                }

                catch (Exception e)
                {
                    Console.WriteLine(e);
                    //pune exceptii ''for''
                }
            }
        }

        //get an user
        public static User getUser(string username)
        {
            var user = new User();
            using (var db = new HealthModelsDataContext())
            {
                var query = db.Users.SingleOrDefault(user => user.username == username);
                user = query;
            }
            return user;
        }

        //get all user
        public static List<User> getUsers()
        {
            List<User> users = new List<User>();

            using (var db = new HealthModelsDataContext())
            {
                var query = db.Users.ToList();
                users = query;
            }
            return users

        }

        //login ?????????

    }
}
