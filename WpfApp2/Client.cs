using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Client
    {
        [Key]
        public int idClient { get; set; }
        private string firstName, secondName, lastName, loginUserClient;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string LoginUserClient
        {
            get { return loginUserClient; }
            set { loginUserClient = value; }
        }

        public Client() { }

        public Client(string firstName, string secondName, string lastName, string loginUserClient)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.loginUserClient = loginUserClient;
        }
    }
}
