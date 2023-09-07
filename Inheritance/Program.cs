using System;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in commo
            

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird1 = new Bird();

            bird1.BeakShape = "sharp";
            bird1.CanFly = true;
            bird1.FeatherColor = "brown and white";
            bird1.Diet = "fish";
            bird1.Legs = 2;
            bird1.Size = "28 to 40"; 
            bird1.Species = "American Bald Eagle"; 
            bird1.BirthType = "laying eggs";

            Console.WriteLine($"The {bird1.Species} is a bird that typically grows a wingspan of {bird1.Size} inches. It is a bird with {bird1.FeatherColor} feathers." +
                $" {bird1.Species}s have {bird1.Legs} legs and a {bird1.BeakShape} beak. They live off of a diet consisting of mostly {bird1.Diet}." +
                $"\nIt is {bird1.CanFly} that {bird1.Species}s can fly and they also reproduce by {bird1.BirthType}\n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile reptile1 = new Reptile();

            reptile1.Habitat = "brackish wetlands and rivers"; 
            reptile1.IsVenomous = false;
            reptile1.Diet = "birds, fish and mammals";
            reptile1.AverageWeight = 1000; 
            reptile1.Legs = 4;
            reptile1.Size = "17 feet"; 
            reptile1.Species = "Saltwater Crocodile"; 
            reptile1.BirthType = "laying eggs";

            Console.WriteLine($"\nThe {reptile1.Species} resides typically in {reptile1.Habitat} near Indian, Asian and Australian coastlines. \n" +
                $"{reptile1.Species}s on average get up to about {reptile1.Size} in length and weigh over {reptile1.AverageWeight} pounds. \n" +
                $"They have {reptile1.Legs} legs and give birth by {reptile1.BirthType}. {reptile1.Species}s feed on a diet primarily containing \n{reptile1.Diet}," +
                $" but they are considered to have the broadest range of prey species of any crocodile. \nWhile it is {reptile1.IsVenomous} that crocodiles are " +
                $"venomous, they are still an extremely dangerous predator.");
        }
    }
}
