using System;
using System.Collections.Generic;
using Programming_School.Enums;
using Programming_School.School;

namespace Programming_School.Persons
{
    public class Mentor : Person, ISalary
    {
        private int _salary;

        int ISalary.Salary
        {
            get => _salary;
            set => _salary = value;
        }

        private List<Languages> LanguagesList { get; set; }
        private List<Modules>ModulesList { get; set; }
        private Modules module { get; set; }

        public Mentor(string name, int phoneNumber, int birthDate, List<Languages> languagesList, int salary)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.BirthDate = birthDate;
            LanguagesList = languagesList;
            _salary = salary;
        }

        public void MentorModule()
        {
            foreach (var language in LanguagesList)
            {
                switch (language)
                {
                    case Languages.JavaEE:
                        ModulesList.Add(Modules.AdvancedModule);
                        break;
                    case Languages.PythonLanguage:
                        ModulesList.Add(Modules.ProgrammingBasics);
                        break;
                    case Languages.WebLanguagesKnowledge:
                        ModulesList.Add(Modules.WebModule);
                        break;
                    case Languages.JavaSE:
                        ModulesList.Add(Modules.OOPModule);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException($"Mentor dosent know langueage{language}");
                }
            }
        }
    }
}