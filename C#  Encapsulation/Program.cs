
Hotel reservation = new(4, "Viles Hotel", "Masalli Rayonu", 80);
Console.WriteLine(reservation);
double totalPrice = reservation.GetPriceRoom(2);
Console.WriteLine(totalPrice); 
public class Hotel
{
    public Guid Id { get; }
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

        if (roomPrice < 60 || roomPrice > 150)
        {
            throw new ArgumentOutOfRangeException(nameof(roomPrice), "Room price is 60 and 150.");
        }

        Id = Guid.NewGuid();
        _RoomCount = roomCount;
        HotelName = hotelName;
        Address = address;
        RoomPrice = roomPrice;
    }

    public double GetPriceRoom(int countOfRoom)
    {
        return countOfRoom * RoomPrice;
    }
}