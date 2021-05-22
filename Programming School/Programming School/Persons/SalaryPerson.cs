namespace Programming_School.Persons
{
    public class SalaryPerson: Person, ISalary
    {
        private int _salary;

        public SalaryPerson(string name, int phoneNumber, int birthDate, int salary)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.BirthDate = birthDate;
            _salary = salary;
        }

        int ISalary.Salary
        {
            get => _salary;
            set => _salary = value;
        }
    }