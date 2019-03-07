using System;

namespace Pets
{
    public class Dog : Pet
    {

        public Dog(string name, string owner, double weight) : base (string.Empty, name, owner, weight)
        {
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public string bark(int count)
        {
            string bark = "";
            for (int i = 0; i < count; i++)
            {
                bark = "bark!" + bark;
            }

            return bark;
        }
    }
}
