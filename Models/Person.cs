using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputForm.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string SNILS { get; set; }
        public Person(PersonDB dbModel)
        {
            ID = dbModel.ID;
            Surname = dbModel.Surname;
            Name = dbModel.Name;
            Patronymic = dbModel.Patronymic;
            BirthDate = dbModel.BirthDate;
            SNILS = dbModel.SNILS;
        }
    }
}
