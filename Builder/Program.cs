
class Program
{
    static void Main(string[] args)
    {
        //Builder design pattern separates the concern of creating or building a complex object from its representation 
        //so that the same construction process can create different representations

        Director director = new Director();

        Builder iphoneBuilder = new IphoneBuilder();
        Builder samsungBuilder = new SamsungBuilder();

        director.Construct(iphoneBuilder);
        CellPhone iphoneProduct = iphoneBuilder.GetResult();
        iphoneProduct.Show();

        director.Construct(samsungBuilder);
        CellPhone samsungProduct = samsungBuilder.GetResult();
        samsungProduct.Show();
    }
}


class Director
{
    public void Construct(Builder builder)
    {
        builder.BuildBattery();
        builder.BuildScreen();
    }
}

abstract class Builder
{
    public abstract void BuildScreen();
    public abstract void BuildBattery();
    public abstract CellPhone GetResult();
}

class IphoneBuilder : Builder
{
    private CellPhone cellPhone = new CellPhone();

    public override void BuildScreen()
    {
        cellPhone.Add("Iphone Screen");
    }
    public override void BuildBattery()
    {
        cellPhone.Add("Iphone Battery");
    }
    public override CellPhone GetResult()
    {
        return cellPhone;
    }

}

class SamsungBuilder : Builder
{
    private CellPhone cellPhone = new CellPhone();

    public override void BuildBattery()
    {
        cellPhone.Add("Samsung Battery");
    }
    public override void BuildScreen()
    {
        cellPhone.Add("Samsung Screen");
    }
    public override CellPhone GetResult()
    {
        return cellPhone;
    }


}

class CellPhone
{
    private List<string> parts = new List<string>();

    public void Add(string part)
    {
        parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("\n==============================");
        Console.WriteLine("         CellPhone Parts        \n");
        foreach (string part in parts)
        {
            Console.WriteLine(part);
        }
        Console.WriteLine("==============================");
    }

}
