using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalThreeLayer;
namespace CalThreeLayer.DAL_DataAL
{
    public class Person
    {
        private string email;
        private string password;

        public Person(string email, string password)
        {
            this.email = email;
            this.password = password;
        }
        public Person() { }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
