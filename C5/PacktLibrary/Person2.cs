using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.CS7
{
    public partial class Person : IComparable<Person>
    {
        // property defined using C# 1 - 5 syntax 
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }

        // two properties defined using C# 6+ lambda expression syntax 
        public string Greeting => $"{Name} says 'Hello!'";

        public short Age => (short)(System.DateTime.Today
          .Subtract(DateOfBirth).TotalDays / 365.25);

        public string FavoriteIceCream { get; set; } // auto-syntax 

        private string favoritePrimaryColor;
        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                    case "yellow":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException($"{value} is not a primary color.Choose from: red, green, blue or yellow."); 
                }
            }

        }

        // indexers 
        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }

        // methods to "multiply" 
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        // operator to "multiply" 
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        // method with a local function 
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException(
                  $"{nameof(number)} cannot be less than zero.");
            }
            return localFactorial(number);

            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        // event 
        public event EventHandler Shout;

        // field 
        public int AngerLevel;

        // method 
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // if something is listening... 
                if (Shout != null)
                {
                    // ...then raise the event 
                    Shout(this, EventArgs.Empty);
                }

                //Shout?.Invoke(this, EventArgs.Empty);
            }
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }


        public override string ToString()
        {
            return $"{Name} is a {base.ToString()}";
        }

        public void TimeTravel(DateTime when)
        {
            if (when <= DateOfBirth)
            {
                throw new PersonException("If you travel back in time to a date earlier than your own birth then the universe will explode!"); 
            }
            else
            {
                Console.WriteLine($"Welcome to {when:yyyy}!");
            }
        }




    }
}