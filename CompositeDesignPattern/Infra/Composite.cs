using CompositeDesignPattern.Interface;

namespace CompositeDesignPattern.Infra;

public class Composite:ICustomComponent
{
    public string Name { get; set; }
    List<ICustomComponent> Components { get; set; }
    public Composite(string name)
    {
        Name = name;
    }

    public void AddComponent(ICustomComponent component)
    {
        Components.Add(component);
    }

    public decimal CalculatePrice()
    {
        decimal totalPrice = 0;
        foreach (var item in Components)
        {
            totalPrice += item.CalculatePrice();
        }

        return totalPrice;
    }
}