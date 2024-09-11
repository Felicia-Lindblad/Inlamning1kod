namespace Inlämning
{

    //Här skapar man original klassen
    public class Animal
    {
        //Attributer
        public string Name;

        public string Type;

        //Metod
        public void Sound()
        {
            Console.WriteLine("Detta djruret gör ett ljud");
        }
    } //Här slutar orginal klassen

    //Här skapar man en sub-klass
    public class Cat : Animal
    {
        //Nytt attribut
        public string Color;

        //Ny metod
        public new void Sound()
        {
            Console.WriteLine("Katten jamar");
        }
    } //Här slutar sub-klassen
}
