using System;

public class Product
{
    public string name;
    public string type;
    public double price;
    public int quantity;

    public Product (string name, string type, double price, int quantity)
    {
        this.name = name;
        this.type = type;
        this.price = price;
        this.quantity = quantity;
    }

    public override string ToString()
    {
        return $"{this.name} {this.type} {this.price} {this.quantity}";
    }
}

