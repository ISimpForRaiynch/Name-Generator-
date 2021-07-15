using System;
using System.Reflection;

namespace Name_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To ISFR (ISimpForRainych) Name Generator:");
            Console.WriteLine("Specification Time!");
            Console.WriteLine("Would You Like A Male Or Female Name? (Type 'F' for Female or 'M' for Male)");
            string myGender = Console.ReadLine();
            string[] mNames = new[] { "Liam", "Noah", "Oliver", "William", "James", "Lucas", "Mason", "Ehtan", "Henry", "Jacob", "Alexander", "Daniel", "Sebastian", "Jack", "Aiden", "Owen", "David", "John", "Julian", "Carter", "Grayson", "Jayden", "Theodore", "Gabriel", "Leo", "Jaxon", "Asher", "Christopher", "Thomas", "Caleb" };
            string[] fNames = new[]
            {
                "Olivia", "Ava", "Himari", "Hina", "Yua", "Sakura", "Ichika", "Yui", "Sophia", "Angelica", "Giannie", "Jade", "Maria", "Sarah", "Evelyn", "Summer",
                "Luna", "Mila", "Scarlett", "Tiffany", "Emily", "Alexandra", "Andrea", "Nora", "Chloe", "Hannah", "Ivy","Adriana"
            };
            string[] lNames = new[] {"Smith", "Brown", "Garcia", "Miller", "Alvarado", "Morales", "Coronel", "Carpio", "Gaona", "Colon", "Flores", "Yung", "Wang", "Li", "Aoki", "Chiba", "Fuji", "Perez", "Gonzalez", "Walker", "Hill", "Green", "Carter", "Rivera", "Solace", "Hernandez", "Jimnez", "Bustos"};
            Random R = new Random();
            var randomIndex = R.Next(0, 28);
            if (myGender.Contains("M"))
            {
                Console.WriteLine("Your Name Is:" + mNames[randomIndex] + " " + lNames[randomIndex]);
            }
            else if (myGender.Contains("F"))
            {
                Console.WriteLine("Your Name Is: " + fNames[randomIndex] + " " +  lNames[randomIndex]);
            }

        }
    }
}
