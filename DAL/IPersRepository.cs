using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InputForm.Models;

namespace InputForm.DAL
{
    interface IPersRepository:IDisposable
    {
        IEnumerable<PersSaving> GetSavings();
        IEnumerable<Person> GetPeople();
        PersSaving GetSavingbySnils(string snils);
    }
}
