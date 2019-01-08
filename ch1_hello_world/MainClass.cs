using System;

namespace ConsoleApplication
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            FireFighter fireFighter = new FireFighter("Joe Carrington", 35);
            fireFighter.PensionAmount = 5000;
            
            PrintNameAndAge(fireFighter);
            PrintPensionAmount(fireFighter);
            
            fireFighter.DriveToPlaceOfInterest();
            
            PoliceOfficer officer = new PoliceOfficer("Jane Hope", 32);
            officer.PensionAmount = 5500;
            officer.HasEmergency = true;
            
            PrintNameAndAge(officer);
            PrintPensionAmount(officer);
            
            officer.DriveToPlaceOfInterest();
        }

        static void PrintNameAndAge(IPerson person)
        {
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);
        }

        static void PrintPensionAmount(PublicServant servant)
        {
            if(servant is FireFighter)
                Console.WriteLine("Pension of firefighter: " + servant.PensionAmount + "\n");
            else if (servant is PoliceOfficer)
                Console.WriteLine("Pension of officer: " + servant.PensionAmount + "\n");
        }
    }
}