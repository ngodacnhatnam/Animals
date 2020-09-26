using System;
namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; private set; }
        public string FavsFood { get;  private set; }
        protected Animal(string name, string favsfood) {
            Name = name;
            FavsFood = favsfood;

        }

        public virtual string ExplainSelf()
        {
            return string.Format("I am {0} and my favorite food is {1}", this.Name, this.FavsFood);
        }
    }
}
