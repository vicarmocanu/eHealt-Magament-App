using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HealthCareModel.ControlHandler;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in both code and config file together.
    public class UserService : IUserService
    {

        private static readonly System.Object obj1 = new System.Object();
        private static readonly System.Object obj2 = new System.Object();
        private static readonly System.Object obj3 = new System.Object();
        private static readonly System.Object obj4 = new System.Object();
        private static readonly System.Object obj5 = new System.Object();

        public void createUser(string firstName, string lastName, string username, string password, string role)
        {
            if (System.Threading.Monitor.TryEnter(obj1, 45000))
            {
                try
                {
                    UserControl.createUser(firstName, lastName, username, password, role);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj1);
                }
            }
        }

        public void updateUser(string firstName, string lastName, string username, string password, string role)
        {
            if (System.Threading.Monitor.TryEnter(obj2, 45000))
            {
                try
                {
                    UserControl.updateUser(firstName, lastName, username, password, role);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj2);
                }
            }
        }

        public User getUser(string userName)
        {
            User serviceUser = new User();
            if (System.Threading.Monitor.TryEnter(obj3, 45000))
            {
                try
                {
                    serviceUser.FirstName = UserControl.getUser(userName).firstName;
                    serviceUser.LastName = UserControl.getUser(userName).lastName;
                    serviceUser.UserName = UserControl.getUser(userName).userName;
                    serviceUser.Password = UserControl.getUser(userName).password;
                    serviceUser.Role = UserControl.getUser(userName).role;

                }
                catch (NullReferenceException)
                {

                }
                finally
                {
                    System.Threading.Monitor.Exit(obj3);
                }
            }
            return serviceUser;
        }

        public List<User> getUsers()
        {
            List<User> users = new List<User>();

            if (System.Threading.Monitor.TryEnter(obj4, 45000))
            {
                try
                {

                    List<HealthCareModel.Object_Models.User> returnList = UserControl.getUsers();

                    if (returnList.Count != 0)
                    {
                        foreach (HealthCareModel.Object_Models.User userHost in returnList)
                        {
                            User serviceUser = new User();

                            serviceUser.FirstName = userHost.firstName;
                            serviceUser.LastName = userHost.lastName;
                            serviceUser.UserName = userHost.userName;
                            serviceUser.Password = userHost.password;
                            serviceUser.Role = userHost.role;

                            users.Add(serviceUser);
                        }
                    }
                }
                catch (NullReferenceException)
                {
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj4);
                }
            }

            return users;
        }

        public void deleteUser(string userName)
        {
            User serviceUser = new User();

            if (System.Threading.Monitor.TryEnter(obj5, 45000))
            {
                try
                {
                    UserControl.deleteUser(userName);
                }
                finally
                {
                    System.Threading.Monitor.Exit(obj5);
                }
            }
        }
    }
}
