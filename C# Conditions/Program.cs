using System.Linq.Expressions;
using System.Text;
using static System.Console;
using static System.Convert;
OutputEncoding = Encoding.UTF8;


// Menyu Sistemi

WriteLine(" -Menyu- ");
WriteLine(" 1-İsti yeməklər.");
WriteLine(" 2-Qazan yeməkləri.");
WriteLine(" 3-İçkilər.");
WriteLine(" 4-Desertlər.");
Write(" Menyu seçin : ");
int MenyuNumber = ToInt32(ReadLine());

switch (MenyuNumber)
{
	case 1:
        WriteLine(" - İsti yeməklər - ");
        WriteLine("1-Toyuq Kababı");
		WriteLine("2-Qovurma");
		WriteLine("3-Səbzəli Plov");
		WriteLine("4-Cız - Bız Köftə");
		Write(" Bir yemək seçin : ");
        int istiYemekNumber = ToInt32(ReadLine());
        switch (istiYemekNumber)
        {
            case 1:
                WriteLine("Toyuq kababı sifariş edildi.");
                break;
            case 2:
                WriteLine("Qovurma sifariş edildi.");
                break;
            case 3:
                WriteLine("Səbzəli Plov sifariş edildi.");
                break;
            case 4:
                WriteLine("Cız - Bız Köftə sifariş edildi.");
                break;
            default:
                Write(" Belə bir yemək yoxdur ");
                break;
        }

        break;
	case 2:
        WriteLine(" - Qazan yeməkləri - ");
        WriteLine("1-Toyuq Soyutma");
        WriteLine("2-Toyuq Ləvəngisi");
        WriteLine("3-Qazan Kababı");
        WriteLine("4-Yarpaq Dolması");
        Write(" Bir yemək seçin : ");
        int qazanYemekNumber = ToInt32(ReadLine());
        switch (qazanYemekNumber)
        {
            case 1:
                WriteLine("Toyuq Soyutma sifariş edildi.");
                break;
            case 2:
                WriteLine("Toyuq Ləvəngisi sifariş edildi.");
                break;
            case 3:
                WriteLine("Qazan Kababı sifariş edildi.");
                break;
            case 4:
                WriteLine("Yarpaq Dolması sifariş edildi.");
                break;
            default:
                Write(" Belə bir yemək yoxdur ");
                break;
        }
        break;
	case 3:
        WriteLine(" - İçkilər - ");
        WriteLine("1-Qazsız su");
        WriteLine("2-Cocacola");
        WriteLine("3-Fanta");
        WriteLine("4-Kampot");
        WriteLine("5-Çay");
        Write(" Bir içki seçin : ");
        int ickiNumber = ToInt32(ReadLine());
        switch (ickiNumber)
        {
            case 1:
                WriteLine("Qazsız su sifariş edildi.");
                break;
            case 2:
                WriteLine("Coscacola sifariş edildi.");
                break;
            case 3:
                WriteLine("Fanta sifariş edildi.");
                break;
            case 4:
                WriteLine("Kampot sifariş edildi.");
                break;
            case 5:
                WriteLine("Çay sifariş edildi.");
                break;
            default:
                Write(" Belə bir içki yoxdur ");
                break;
        }
        break;
    case 4:
        WriteLine(" - Desertlər - ");
        WriteLine("1-Mürəbbə");
        WriteLine("2-Snickers");
        WriteLine("3-Rulet");
        WriteLine("4-Meyvə(Assorti)");
        Write(" Bir Desert seçin : ");
        int desertNumber = ToInt32(ReadLine());
        switch (desertNumber)
        {
            case 1:
                WriteLine("Mürəbbə sifariş edildi.");
                break;
            case 2:
                WriteLine("Snickers sifariş edildi.");
                break;
            case 3:
                WriteLine("Rulet sifariş edildi.");
                break;
            case 4:
                WriteLine("Meyvə(Assorti) sifariş edildi.");
                break;
            default:
                Write(" Belə bir içki yoxdur ");
                break;
        }
        break;
    default:
		Write(" Belə bir menyu yoxdur ");
		break;
}