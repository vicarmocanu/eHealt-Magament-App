using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HealthCareWCFServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        void createUser(string firstName, string lastName, string username, string password, string role);

        [OperationContract]
        void updateUser(string firstName, string lastName, string username, string password, string role);

        [OperationContract]
        User getUser(string userName);

        [OperationContract]
        List<User> getUsers();

        [OperationContract]
        void deleteUser(string userName);
    }

    [DataContract]
    public class User
    {
        private string firstName;
        private string lastName;
        private string userName;
        private string password;
        private string role;

        [DataMemberAttribute]
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        [DataMemberAttribute]
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        [DataMemberAttribute]
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        [DataMemberAttribute]
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        [DataMemberAttribute]
        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }
    }
}
