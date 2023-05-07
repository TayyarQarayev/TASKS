
Hotel reservation = new(4, "Viles Hotel", "Masalli Rayonu", 80);
Console.WriteLine($"Hotel - {reservation.HotelName} Adress - {reservation.Address}");
double totalPrice = reservation.GetPriceRoom();
Console.WriteLine($"Resrevasiya qiymeti - {totalPrice}"); 
public class Hotel
{
    public Guid Id { get; private set; }
    public int _RoomCount;
    public int RoomCount 
    {
        get 
        {
            return _RoomCount;
        } 
        set
        {
            if (RoomCount < 0 || RoomCount > 200)
            {
                Console.WriteLine("Room count is 0 and 200.");
            }
            else
            {
                RoomCount = _RoomCount;
            }
        }
    }
    public string HotelName { get; set; }
    public string Address { get; set; }
    public double RoomPrice { get; set; }

    public Hotel(int roomCount, string hotelName, string address, double roomPrice)
    {
        Id = Guid.NewGuid();
        _RoomCount = roomCount;
        HotelName = hotelName;
        Address = address;
        RoomPrice = roomPrice;
    }

    public double GetPriceRoom()
    {
        return _RoomCount * RoomPrice;
    }
}