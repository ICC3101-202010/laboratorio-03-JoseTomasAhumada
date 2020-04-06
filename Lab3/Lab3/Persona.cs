using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Persona
    {
        protected string rut;
        protected string firstName;
        protected string lastName;
        protected string birth;
        protected string nacionality;
        public Persona(string rut, string firstName, string lastName, string birth, string nacionality)
        {
            this.rut = rut;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birth = birth;
            this.nacionality = nacionality;
        }
        public string Rut()
        {
            return rut;
        }
        public string FirstName()
        {
            return firstName;
        }
        public string LastName()
        {
            return lastName;
        }
        public string Birth()
        {
            return birth;
        }
        public string Nacionality()
        {
            return nacionality;
        }
    }
}
