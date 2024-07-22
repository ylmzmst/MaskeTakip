using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISuppierService
    {
        private IApplicantService _applicantservice;

        public PttManager(IApplicantService applicantService) //constructor new de çalışır
        {
            _applicantservice = applicantService;
        }
        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager(); bağımlılık yapıyo
            if (_applicantservice.CheckPerson(person)) 
            { 
                Console.WriteLine(person.FirstName + " " + person.LastName+" için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " için maske verilemedi");
            }
        }
    }
}
