namespace Mini_Projects.Exercises.Part1;

public class Person
{
        private string name;
        private string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string Show()
        {
            return name + "\n " + address;
        }
    
}