namespace Programming_School.Persons
{
    public abstract class Person
    {
        public string Name { get; protected set; }
        protected int PhoneNumber { get; set; }
        protected int BirthDate { get; set; }

        public string GetName()
        {
            return this.Name;
        }
        public int GetPhone()
        {
            return this.PhoneNumber;
        }
        public int GetBirthDate()
        {
            return this.BirthDate;
        }
    }
}