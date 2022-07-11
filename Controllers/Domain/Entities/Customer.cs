using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; private set; }

        public string fullName { get; private set; }

        public string email { get; private set; }

        public string emailConfirmation { get; private set; }

        public string CPF { get; private set; }

        public DateTime DayOfBirth { get; private set; }

        public bool EmailSms { get; private set; }

        public bool country { get; private set; }

        public string city { get; private set; }

        public string postalCode { get; private set; }

        public string address { get; private set; }

        public int number { get; private set; }

        public DateTime Created { get; private set; }

        public Customer(string name, string email, string emailConfirmation, string cpf,
        string city, string postalCode, string address)
        {
            this.fullName = name;
            this.email = email;
            this.emailConfirmation = emailConfirmation;
            this.CPF = cpf;
            this.city = city;
            this.postalCode = postalCode;
            this.address = address;
            Id = Guid.NewGuid();
            Created = DateTime.Now;
        }

        public bool IsSpecial() {
            return DateTime.Now.Year - Created.Year >= 5;
        }
    }
}