using System;
using System.Collections.Generic;
using System.Reflection;
using Programming_School.Enums;
using Programming_School.Util;

namespace Programming_School.Persons
{
    public class Student : Person
    {
        public Modules CurrentModule { get; set; }
        public int Progress { get; set; }
        public bool Graduated { get; set; }

        public Student(string name, int phoneNumber, int birthDate)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.BirthDate = birthDate;
            CurrentModule = Modules.ProgrammingBasics;
            Progress = Constants.StartProgress;
            Graduated = false;
        }

        public void AdvanceToNextModule()
        {
            if (Progress == 100)
            {
                switch (CurrentModule)
                {
                    case Modules.ProgrammingBasics:
                        CurrentModule = Modules.WebModule;
                        break;
                    case Modules.WebModule:
                        CurrentModule = Modules.OOPModule;
                        break;
                    case Modules.OOPModule:
                        CurrentModule = Modules.AdvancedModule;
                        break;
                    case Modules.AdvancedModule:
                        Graduated = true;
                        break;
                }
            }
        }
    }
}
    