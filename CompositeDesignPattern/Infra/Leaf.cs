using CompositeDesignPattern.Interface;

namespace CompositeDesignPattern.Infra;

public class Leaf:ICustomComponent
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Leaf(string name,decimal price)
    {
        Name = name;
        Price = price;
    }

    public void AddComponent(ICustomComponent component)
    {
        throw new NotImplementedException();
    }

    public decimal CalculatePrice()
    {
        return Price;
    }
}