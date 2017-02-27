using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //this first section of code and allows the user to choose an animal type from a list and name it while assigning random numbers to the other fields at instantiation
            Random random = new Random();
            int startHunger = random.Next(90, 100);
            int startThirst = random.Next(60, 70);
            int startBathroom = random.Next(50, 60);
            int startEnergy = random.Next(60, 70);
            int startNeediness = random.Next(75, 100);

            VirtualPet userPet = new VirtualPet();//I used properties instead of constructors because the properties I created account for values less than zero and greater than 100, so everything will be handled through properties instead of constructors
            userPet.Hunger = startHunger;
            userPet.Thirst = startThirst;
            userPet.BathroomUrge = startBathroom;
            userPet.Energy = startEnergy;
            userPet.Neediness = startNeediness;


            Console.WriteLine("Welcome to the VirtualPet application!\nBefore we get started, please tell me your name.");
            string ownersName = Console.ReadLine();
            userPet.OwnersName = ownersName;
            Console.Clear();

            Console.WriteLine("Hello, {0}!\nLet's start by choosing an animal you'd like to have as a VirtualPet.\nPlease enter the number 1,2,3 that corresponds to your animal choice.", ownersName);

            List<string> animalTypes = new List<string>();//using a list here instead of an array so that the choices can be easily expanded in the future
            animalTypes.Add("penguin");
            animalTypes.Add("monkey");
            animalTypes.Add("dog");
           
            for (int i = 0; i < animalTypes.Count; i++)
            {
                int menuNumber = i + 1;
                Console.WriteLine("\tPress {0} for {1}.", menuNumber, animalTypes[i]);
            }

            int animalChoice = int.Parse(Console.ReadLine());

            while (animalChoice < 1 || animalChoice > animalTypes.Count)
            {
                Console.WriteLine("You must choose a number from the options!");
                animalChoice = int.Parse(Console.ReadLine());
            }


            if (animalChoice == 1)
            {
                userPet.PetType = animalTypes[animalChoice - 1]; //setting the index this way will allow for expansion of the list without having to rewrite this code and accounts for the fact that the menu choice started at 1 and not 0
                userPet.Image = userPet.PenguinImage;
            }
            else if (animalChoice == 2)
            {
                userPet.PetType = animalTypes[animalChoice - 1];
                userPet.Image = userPet.MonkeyImage;
            }
            else if (animalChoice == 3)
            {
                userPet.PetType = animalTypes[animalChoice - 1];
                userPet.Image = userPet.DogImage;
            }
            else
            {
                userPet.PetType = "fish";
                Console.WriteLine("Hmm... Something must have gone wrong. It's okay, your pet will be a gerbil.");
                userPet.Image = userPet.FishImage;
            }

            Console.Clear();
            Console.WriteLine("Okay, one last -- but very imporant-- question before we begin.\nWhat would you like to name your pet?");
            userPet.PetsName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Congratulations {0}!\nYou are the proud new owner of {1} the virtual {2}!", userPet.OwnersName, userPet.PetsName, userPet.PetType);
            Console.WriteLine(userPet.Image);
            Console.WriteLine("Isn't {0} adorable!", userPet.PetsName);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();


            //This next section of code "plays the game" until the pet's overall satisfaction reaches a certain point (here, 90). Then the game ends. The user can quit at anytime.
            do
            {

                userPet.ShowPetStatus();

                //user menu
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("\tPress 1 to feed {0}.", userPet.PetsName);
                Console.WriteLine("\tPress 2 to give {0} water.", userPet.PetsName);
                Console.WriteLine("\tPress 3 to take {0} outside to go potty.", userPet.PetsName);
                Console.WriteLine("\tPress 4 to cuddle with {0}.", userPet.PetsName);
                Console.WriteLine("\tPress 5 to play with {0}.", userPet.PetsName);
                Console.WriteLine("\tPress 6 to quit the game.");
                int userMethodChoice = int.Parse(Console.ReadLine());

                while (userMethodChoice < 1 || userMethodChoice > 6)
                {
                    Console.WriteLine("You must choose an option from the menu!\nWhat would you like to do?");
                    userMethodChoice = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                switch (userMethodChoice)
                {

                    case 1:
                        {
                            userPet.FeedPet();
                        }
                        break;

                    case 2:
                        {
                            userPet.WaterPet();
                        }
                        break;

                    case 3:
                        {
                            userPet.Bathroom();
                        }
                        break;

                    case 4:
                        {
                            userPet.CuddleWithPet();
                        }
                        break;

                    case 5:
                        {
                            userPet.PlayWithPet();
                        }
                        break;

                    case 6:
                        {
                            Console.WriteLine("{0} says, \"You're leaving me?\"", userPet.PetsName);
                            Console.WriteLine("You're guilty of animal neglect...");
                            Environment.Exit(0);
                        }
                        break;

                    default: //the while loop above controls for this, but this default is an extra safe guard that will simply feed the pet. 
                        {
                            Console.WriteLine("{0)} says, \"Thanks for the extra food!\"", userPet.PetsName);
                            userPet.FeedPet();
                            break;
                        }


                }


                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();

            } while (userPet.PetSatisfaction <= 90);

            //this section of code is what appears when the user has won the game (when satisfaction is greater than  or equal to 90).
            Console.WriteLine(userPet.Image);
            Console.WriteLine("\nCongratulations {0}!\nYou have successfully provided for {1} the {2} today!\nThe game will now close!", userPet.OwnersName, userPet.PetsName, userPet.PetType);
            Environment.Exit(0);
        }

    }





}
