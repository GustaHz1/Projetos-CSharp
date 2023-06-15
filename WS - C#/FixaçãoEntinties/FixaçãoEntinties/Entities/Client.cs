using System;

namespace FixaçãoEntinties.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() {

        }
        public Client(String name, String email, DateTime birthdate) {
            Name = name;
            Email = email;
            BirthDate = birthdate;
        }
        public override string ToString() {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}