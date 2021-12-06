using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InputForm.Models;

namespace InputForm
{
    public static class FirstData
    {
        public static void Init(PensionContext context)
        {
            if (!context.Persons.Any())
            {
                context.Persons.AddRange
                    (
                    new PersonDB 
                        {
                            BirthDate=new DateTime(1980,11,15),
                            Name = "Иван",
                            Surname= "Иванов",
                            Patronymic= "Иванович",
                            SNILS="123-456-789 12"
                        },
                        new PersonDB
                        {
                            BirthDate=new DateTime(1990,12,10),
                            Name="Петр",
                            Patronymic= "Петрович",
                            Surname= "Петров",
                            SNILS="111-222-333 44"
                        },
                        new PersonDB
                        {
                            BirthDate=new DateTime(1975,06,15),
                            Name="Василий",
                            Patronymic= "Васильевич",
                            Surname= "Васильев",
                            SNILS="555-666-777 88"
                        }
                    );
                context.SaveChanges();
            }
            if (!context.PersSavings.Any())
            {
                context.PersSavings.AddRange
                    (
                    new PersSavingDB
                    {
                        SNILS="123-456-789 12",
                        PBegin=new DateTime(2005,10,4),
                        PEnd=new DateTime(2020,12,30),
                        Sum=40000,
                        PersonId=1
                    },
                    new PersSavingDB
                    {
                        SNILS="111-222-333 44",
                        PBegin=new DateTime(2015,5,15),
                        PEnd=new DateTime(2020,12,30),
                        Sum=20000,
                        PersonId = 2
                    },
                    new PersSavingDB
                    {
                        SNILS="555-666-777 88",
                        PBegin=new DateTime(1995,6,8),
                        PEnd=new DateTime(2020,12,30),
                        Sum=150000,
                        PersonId = 3
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
