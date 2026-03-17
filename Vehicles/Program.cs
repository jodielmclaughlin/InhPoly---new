namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car nissan = new Car("Nissan", "Juke");
            Motorcycle harley = new Motorcycle("Harley", "Sportster", false);

            nissan.StartEngine();
            nissan.Drive();

            harley.StartEngine();
            harley.Drive();
            
            
                        
            
        }
    }
}
