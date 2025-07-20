using System.Text;

namespace Shop;

public partial class Product
{
    private int id;
    private string name = String.Empty;
    private string? description;
    private int maxItemsInStock = 0 ;
    private bool isBelowStock = false;
    private int amountInStock = 0;
    private UnitType unitType;
    private bool isBelowStockThreshold = false;
    
    public int Id { get => id; set => id = value; }
    public string Name
    {
        get { return name; }
        set
        {
            name = value.Length > 50 ? value[..50] : value;
        }
    }
    public string? Description
    {
        get { return description; }
        set
        {
            if (value == null)
            {
                description = string.Empty;
            }
            else
            {
                description = value.Length > 250 ? value[..250] : value;

            }
        }
    }
    public UnitType UnitType { get => unitType; set => unitType = value; }
    public int AmountInStock { get => amountInStock; set => amountInStock = value; }
    public bool IsBelowStock { get => isBelowStock; set => isBelowStock = value; }

    public Product(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    public void UseProduct(int items)
    {
        if (items <= amountInStock)
        {
            //use the items
            amountInStock -= items;

            UpdateLowStock();

            Log($"Amount in stock updated. Now {amountInStock} items in stock.");
        }
        else
        {
            Log($"Not enough items on stock for {CreateSimpleProductRepresentation()}. {amountInStock} available but {items} requested.");
        }
    }

    public Product(int id, string name, string? description, Price price, UnitType unitType, int maxAmountInStock)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        Price = price;
        UnitType = unitType;
        maxItemsInStock = maxAmountInStock;
        UpdateLowStock();

    }

    public Price Price { get; set; }

    public void IncreaseStock()
    {
        amountInStock++;
    }

    private void DecreaseStock(int items, string reason)
    {
        if (items <= amountInStock)
        {
            //decrease the stock with the specified number items
            amountInStock -= items;
        }
        else
        {
            amountInStock = 0;
        }

        UpdateLowStock();

        Log(reason);
    }
    public void IncreaseStock(int amount)
    {
        int newStock = AmountInStock + amount;

        if (newStock <= maxItemsInStock)
        {
            AmountInStock += amount;
        }
        else
        {
            AmountInStock = maxItemsInStock;//we only store the possible items, overstock isn't stored
            Log($"{CreateSimpleProductRepresentation} stock overflow. {newStock - AmountInStock} item(s) ordered that couldn't be stored.");
        }

        if (AmountInStock > 10)
        {
            IsBelowStockThreshold = false;
        }
    }

    public bool IsBelowStockThreshold { get; set; }

    public string DisplayDetailsShort()
    {
        return $"{id}. {name} \n{amountInStock} items in stock";
    }

    public string DisplayDetailsFull()
    {
        StringBuilder sb = new();
        //ToDo: add price here too
        sb.Append($"{id} {name} \n{description}\n{amountInStock} item(s) in stock");

        if (isBelowStockThreshold)
        {
            sb.Append("\n!!STOCK LOW!!");
        }

        return sb.ToString();

    }

    internal void UpdateLowStock()
    {
        if (amountInStock < 10)//for now a fixed value
        {
            isBelowStockThreshold = true;
        }
    }

    private void Log(string message)
    {
        //this could be written to a file
        Console.WriteLine(message);
    }

    private string CreateSimpleProductRepresentation()
    {
        return $"Product {id} ({name})";
    }


}