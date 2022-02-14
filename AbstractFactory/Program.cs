
class Program
{
    static void Main(string[] args)
    {
        //we are creating a sumsung products in Samsung Factory
        AbstractFactory samsungFactory = new SamsungConcreteFactory();
        Client client1 = new Client(samsungFactory);
        client1.Produce();

        Console.WriteLine("=========================");

        AbstractFactory appleFactory = new AppleConcreteFactory();
        Client client2 = new Client(appleFactory);
        client2.Produce();

        Console.ReadLine();
    }
}

abstract class AbstractFactory
{
    public abstract AbstractProductCellphone CreateProductsCellphone();
    public abstract AbstractProductTV CreateProductTV();
}

class SamsungConcreteFactory : AbstractFactory
{
    public override AbstractProductCellphone CreateProductsCellphone()
    {
        return new ZFlip();
    }

    public override AbstractProductTV CreateProductTV()
    {
        return new SlimTV();
    }
}


class AppleConcreteFactory : AbstractFactory
{
    public override AbstractProductTV CreateProductTV()
    {
        return new AppleDisplayTV();
    }

    public override AbstractProductCellphone CreateProductsCellphone()
    {
        return new Iphone();
    }
}

abstract class AbstractProductTV
{
    public abstract void Produce();

}
abstract class AbstractProductCellphone
{
    public abstract void Produce();
}

class AppleDisplayTV : AbstractProductTV
{
    public override void Produce()
    {
        Console.WriteLine(typeof(AppleDisplayTV).Name + " Produced");
    }
}
class SlimTV : AbstractProductTV
{
    public override void Produce()
    {
        Console.WriteLine(typeof(SlimTV).Name + " Produced");
    }
}

class Iphone : AbstractProductCellphone
{
    public override void Produce()
    {
        Console.WriteLine(typeof(Iphone).Name + " produced");
    }
}
class ZFlip : AbstractProductCellphone
{
    public override void Produce()
    {
        Console.WriteLine(typeof(ZFlip).Name + " produced");
    }
}

class Client
{

    private AbstractProductTV _abstractProductTV;
    private AbstractProductCellphone _abstractProductCellphone;

    public Client(AbstractFactory abstractFactory)
    {
        _abstractProductTV = abstractFactory.CreateProductTV();
        _abstractProductCellphone = abstractFactory.CreateProductsCellphone();
    }

    public void Produce()
    {
        _abstractProductTV.Produce();
        _abstractProductCellphone.Produce();
    }
}