using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        #region fields
        const string monkeyImage = "   /~\\\n  C oo\n  _( ^)\n /   ~\\";
        const string dogImage = " ,-.___,-.\n \\_/_ _\\_/\n  ) O_O(\n  { (_) }\n   `-^-'";
        const string penguinImage = "   .~.\n   /V\\\n  // \\\\\n /(   )\\\n  ^`~'^";
        const string fishImage = "}}=^=0>";

        string ownersName;
        string petsName;
        string petType;
        int hunger;
        int thirst;
        int bathroomUrge;
        int energy;
        int neediness;
        string image;
        #endregion

        #region Constructors
        public VirtualPet()
        {
        }
        public VirtualPet(string ownersName, string petType, string petsName)
        {
            this.ownersName = ownersName;
            this.petType = petType;
            this.petsName = petsName;
        }
        public VirtualPet(int hunger, int thirst, int bathroom, int energy, int neediness)
        {
            this.hunger = hunger;
            this.thirst = thirst;
            this.bathroomUrge = bathroom;
            this.energy = energy;
            this.neediness = neediness;
        }
        #endregion

        #region properties
        public string OwnersName
        {
            get { return this.ownersName; }
            set { this.ownersName = value; }
        }

        public string PetType
        {
            get { return this.petType; }
            set { this.petType = value; }
        }

        public string Image
        {
            get { return this.image; }
            set { this.image = value; }
        }

        public string MonkeyImage
        {
            get { return monkeyImage; }
        }

        public string DogImage
        {
            get { return dogImage; }
        }

        public string PenguinImage
        {
            get { return penguinImage; }
        }

        public string FishImage
        {
            get { return fishImage; }
        }

        public string PetsName
        {
            get { return this.petsName; }
            set { this.petsName = value; }
        }

        public int Hunger
        {
            get
            {
                return this.hunger;

            }
            set
            {
                this.hunger = value;
                if (this.hunger < 0)
                {
                    this.hunger = 0;
                }
                if (this.hunger > 100)
                {
                    this.hunger = 100;
                }
            }

        }
        public int Thirst
        {
            get { return this.thirst; }

            set
            {
                this.thirst = value;
                if (this.thirst < 0)
                {
                    this.thirst = 0;
                }
                if (this.thirst > 100)
                {
                    this.thirst = 100;
                }
            }
        }

        public int BathroomUrge
        {
            get { return this.bathroomUrge; }

            set
            {
                this.bathroomUrge = value;
                if (this.bathroomUrge < 0)
                {
                    this.bathroomUrge = 0;
                }
                if (this.bathroomUrge > 100)
                {
                    this.bathroomUrge = 100;
                }
            }
        }

        public int Energy
        {
            get { return this.energy; }

            set
            {
                this.energy = value;
                if (this.energy < 0)
                {
                    this.energy = 0;
                }
                if (this.energy > 100)
                {
                    this.energy = 100;
                }
            }
        }
        public int Neediness
        {
            get { return this.neediness; }

            set
            {
                this.neediness = value;
                if (this.neediness < 0)
                {
                    this.neediness = 0;
                }
                if (this.neediness > 100)
                {
                    this.neediness = 100;
                }
            }
        }

        public double PetSatisfaction //this property takes the average of the virtual pet's needs and subtracts it from 100 to get a sense of the pet's level of satisfaction. It will be used in main to determine the end of the game. 
        {
            get { return 100 - ((this.Hunger + this.Thirst + this.BathroomUrge + this.Neediness + this.Energy) / 5); }

        }

        #endregion

        #region methods
        public void ShowPetStatus()
        {
            Console.WriteLine("{0} the {1} :", this.PetsName, this.PetType);
            Console.WriteLine("\tis {0}% hungry.", this.Hunger);
            Console.WriteLine("\tis {0}% thirsty.", this.Thirst);
            Console.WriteLine("\thas a {0}% need to go to the bathroom.", this.BathroomUrge);
            Console.WriteLine("\tis {0}% energetic.", this.Energy);
            Console.WriteLine("\tis {0}% needy.", this.Neediness);
            Console.WriteLine();
        }

        public void FeedPet()
        {
            this.Hunger -= 50;
            this.BathroomUrge += 20;
            this.Energy += 10;
            this.Thirst += 30;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Yum!\"", this.PetsName);
        }

        public void WaterPet()
        {
            this.Thirst -= 80;
            this.BathroomUrge += 20;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Refreshing!\"", this.PetsName);
        }

        public void Bathroom()
        {
            this.BathroomUrge -= 90;
            this.Energy -= 10;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"Aaaaah!\"", this.PetsName);
        }

        public void CuddleWithPet()
        {
            this.Energy -= 30;
            this.Neediness -= 40;
            this.BathroomUrge += 10;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"I Love you!!\"", this.PetsName);
        }

        public void PlayWithPet()
        {
            this.Energy -= 60;
            this.Neediness -= 60;
            Console.WriteLine(this.Image);
            Console.WriteLine("{0} says, \"This is so much fun!\"", this.PetsName);
        }
        #endregion
    }
}
