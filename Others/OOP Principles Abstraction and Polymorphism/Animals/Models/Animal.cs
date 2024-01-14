namespace Animals.Models;

public abstract class Animal
{
    private string Name;
    private string favouriteFood;

    public Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.favouriteFood = favouriteFood;
    }

    public virtual string ExplainSelf()
    {
        return $"I am {this.Name} and my favourite food is {this.favouriteFood}";
    }
}
