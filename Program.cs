namespace Target_Heart_Rate_Calculator
{
   internal class Program
   {
      static void Main(string[] args)
      {
         string firstName;
         string lastName;
         int birthYear;
         int currentYear;

         Console.Write("Enter your First Name: ");
         firstName = Console.ReadLine();

         Console.Write("Enter your Last Name: ");
         lastName = Console.ReadLine();

         Console.Write("Enter your birth year: ");
         birthYear = int.Parse(Console.ReadLine());

         Console.Write("Enter the current year: ");
         currentYear = int.Parse(Console.ReadLine());

         HeartRates Person1 = new HeartRates(firstName, lastName, birthYear, currentYear);

         Console.WriteLine($"\nName: {Person1._FirstName} {Person1._LastName}\n" +
            $"Birth Year: {Person1._BirthYear}\n" +
            $"Age: {Person1.Age} years old.\n\n" +
            $"Heart Rates\n\n" +
            $"Maximum Heart Rate: {Person1.MaxHeartRate}\n" +
            $"Target Heart Rate is between {Person1.MinTargetHeartRate} and {Person1.MaxTargetHeartRate}.");
      }
   }
}