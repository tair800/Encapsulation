namespace Encapsluation.Models
{
    internal class Company : Job
    {
        public void FullInfo()
        {
            Console.WriteLine($"{Name}{Description}{WorkingHours}");
        }

    }
}
