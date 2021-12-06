using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputForm.Models
{
    public class PersonDB
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string SNILS { get; set; }

    }
}
