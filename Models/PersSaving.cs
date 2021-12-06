using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputForm.Models
{
    public class PersSaving
    {
        public int ID { get; set;}
        public string SNILS { get; set; }
        public DateTime PBegin { get; set; }
        public DateTime PEnd { get; set; }
        public double Sum { get; set; }
        public int PersID { get; set; }
        public Person Person { get; set; }
        public PersSaving(PersSavingDB dbModel)
        {
            ID = dbModel.ID;
            SNILS = dbModel.SNILS;
            PBegin = dbModel.PBegin;
            PEnd = dbModel.PEnd;
            Sum = dbModel.Sum;
            PersID = dbModel.PersonId;
            Person = new Person(dbModel.Person);
        }
    }
}
