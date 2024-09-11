namespace Inlämning
{
    //Här börjar den abstrakta klassen
   public abstract class Car
    {
        public abstract void Drive();
    } //Här slutar den abstrakta klassen
   
    //Här börjar Sub-klassen Bus
    public class Bus : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Bussen kör långsamt");
        }
    } //Här slutar sub-klassen Bus

    //Här börjar sub-klassen Tractor
    public class Tractor : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Traktorn kör långsammare");
        }
    } //Här slutar sub-klassen tractor
}
