using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InputForm.Models
{
    public class PersSavingDB
    {
        public int ID { get; set;}
        public string SNILS { get; set; }
        public DateTime PBegin { get; set; }
        public DateTime PEnd { get; set; }
        public double Sum { get; set; }
        public int PersonId { get; set; }
        public PersonDB Person { get; set; }
    }
}
