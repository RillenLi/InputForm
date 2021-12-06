using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InputForm.Models;
using Microsoft.EntityFrameworkCore;

namespace InputForm.DAL
{
    class SQLPersRepository : IPersRepository
    {
        private PensionContext db;
        public SQLPersRepository(PensionContext context)
        {
            this.db = context;
        }
        public IEnumerable<PersSaving> GetSavings()
        {
            return db.PersSavings.Select(ps => new PersSaving(ps));
        }
        public IEnumerable<Person> GetPeople()
        {
            return db.Persons.Select(p => new Person(p));
        }
        public PersSaving GetSavingbySnils(string snils)
        {
            var gsbs = from s in db.PersSavings
                       where s.SNILS == snils
                       select s;
            PersSavingDB res = gsbs
                .Include(ps => ps.Person)
                .FirstOrDefault();
            return res == null ? null : new PersSaving(res);
        }
        private bool disposed = false;
        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
