namespace Inlämning
{
    public class Person
    {
        //Här är privata attributerna
        private string name;
        private int age;

        //Offentliga metoder för att initiera objekt med rätt attribut
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name 
        {  
            get { return name; } 
            set { name = value; }
        }

        public int Age 
        { 
            get { return age; } 
            set { age = value; } 
        }

        //Metoden för att visa personens information
        public void ShowInfo()
        {
            Console.WriteLine($"Namn: {name} Ålder: {age} år");
        }
      
    }



}

