// Decouple an abstraction from its implementation so that the two can vary independently

/// <summary>
/// Refined abstraction method is a bridge between the abstraction and implementation by changing it's behaviour 
/// </summary>


RecipeBase recipe = new RefinedRecipe();

//set cook as John and cook 
recipe.Cook = new JohnCook();
recipe.Boil();
recipe.Fry();

//change cook to Branden and cook
//now you can assign a new cook to the cook independently
recipe.Cook = new BrandenCook();
recipe.Boil();
recipe.Fry();

/// <summary>
/// Abstract Class
/// </summary>
public class RecipeBase
{

    private Cook cook;

    public Cook Cook
    {
        set { cook = value; }
    }

    public virtual void Boil()
    {
        cook.Boil();
    }

    public virtual void Fry()
    {
        cook.Fry();
    }
}

/// <summary>
/// Refined Abstract class with which you can redefine the abstract methods (this is working as a bridge between an abstraction and implementation)
/// </summary>
public class RefinedRecipe : RecipeBase
{
    public override void Boil()
    {
        Console.WriteLine();
        Console.WriteLine("===================Boil Start===============");
        base.Boil();
        Console.WriteLine("===================Boil End=================");
        Console.WriteLine();
    }

    public override void Fry()
    {
        Console.WriteLine();
        Console.WriteLine("===================Fry Start=================");
        base.Fry();
        Console.WriteLine("===================Fry End===================");
        Console.WriteLine();
    }
}
public abstract class Cook
{
    public abstract void Boil();
    public abstract void Fry();
}

public class JohnCook : Cook
{
    public override void Boil()
    {
        Console.WriteLine("John is Boiling");
    }

    public override void Fry()
    {
        Console.WriteLine("John is Frying");
    }
}

public class BrandenCook : Cook
{
    public override void Boil()
    {
        Console.WriteLine("Branden is Boiling");
    }

    public override void Fry()
    {
        Console.WriteLine("Branden is Frying");
    }
}