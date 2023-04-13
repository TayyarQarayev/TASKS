
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

Phone phone = new Phone();
phone.Name = "Xiaomi";
phone.Model = "Note 10 pro";
phone.Price = 1000;

phone.ShowNameAndModel();
decimal mounthlyprice = phone.CalcCredit(6, 5);
Console.WriteLine($"Mounthly price : {mounthlyprice} AZN");

public class Phone
{
    public string Name;
    public string Model;
    public int Price;

    public void ShowNameAndModel() 
    {
        Console.WriteLine($"Phone name - {Name} and model - {Model}");
    }

    public decimal CalcCredit(int mounth, decimal percent)
    {
        decimal mounthlyprice = (Price * (1 + percent / 100)) / mounth;
        return mounthlyprice;
    }
}