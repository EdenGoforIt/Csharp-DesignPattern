

class Program
{
    static void Main(string[] args)
    {
        var test = new CloneObject(1);
        var clonedOne = test.Clone();
        Console.WriteLine(clonedOne.Id);

        var test2 = new CloneObjectTwo(2);
        var clonedTwo = test2.Clone();
        Console.WriteLine(clonedTwo.Id);

        Console.ReadLine();
    }
}



public abstract class ProtoType
{
    private int _id;

    public ProtoType(int id)
    {
        _id = id;
    }
    public int Id
    {
        get { return _id; }
    }

    public abstract ProtoType Clone();
}

public class CloneObject : ProtoType
{
    public CloneObject(int id) : base(id)
    {
    }

    public override ProtoType Clone()
    {
        return (ProtoType)this.MemberwiseClone();
    }
}

public class CloneObjectTwo : ProtoType
{
    public CloneObjectTwo(int id) : base(id)
    {
    }

    public override ProtoType Clone()
    {
        return (ProtoType)this.MemberwiseClone();
    }
}