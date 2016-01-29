namespace Exemple.Model
{
    class Employee
    {
        public static Employee CreatEpmloyee(string firstname,string lastname)
        {
            return new Employee { FirstName=firstname,LastName=lastname};
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
