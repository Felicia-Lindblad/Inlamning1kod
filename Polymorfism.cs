namespace Inlämning
{
    //Här börjar orginal klassen
    public class Food
    {
        public virtual void EatFood()
        {
            Console.WriteLine("Jag äter mat");
        }
    } //Här slutar orginal klassen

    //Här börjar första sub-klassen
    public class IceCream : Food
    {
        public override void EatFood()
        {
            Console.WriteLine("Jag äter glass");
        }
    } //Här slutar första sub-klassen

    //Här börjar andra sub-klassen
    public class Fruit : Food
    {
        public override void EatFood()
        {
            Console.WriteLine("Jag äter frukt");
        }
    } //Här slutar andra sub-klassen
}
