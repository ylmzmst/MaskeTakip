//https://youtu.be/2EkMrrX9sYY?list=PLqG356ExoxZWfcrBP53Njxir4a-OgqRki&t=16488

using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    public static void Main(string[] args)
    {
        SelamVer();
        SelamVer("mesut");
        Topla(10,20);
        Topla();

        Console.WriteLine(string.Empty);

        //arrays
        string ogrenci1 = "mesut";
        string ogrenci2 = "refik";
        string ogrenci3 = "halit";
        string ogrenci4 = "karay";

        Console.WriteLine(ogrenci1);
        Console.WriteLine(ogrenci2);
        Console.WriteLine(ogrenci3);
        Console.WriteLine(ogrenci4);

        Console.WriteLine(string.Empty);

        string[] ogrenciler = new string[]
        {
            "mesut","refik","halit","karay"
        };
        ogrenciler = new string[5];
        ogrenciler[4] = "ilker";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }
        Console.WriteLine(string.Empty);

        string[] sehir1 = new string[] { "ankara", "istanbul", "izmir" };
        string[] sehir2 = new string[] { "bursa", "antalya", "diyarbakır" };

        sehir2 = sehir1;
        sehir1[0] = "adana";
        Console.WriteLine(sehir2[0]);
        Console.WriteLine(string.Empty);
        for (int i = 0; i < sehir1.Length; i++)
        {
            Console.WriteLine(sehir1[i]);
        }
        for (int i = 0; i < sehir2.Length; i++)
        {
            Console.WriteLine(sehir2[i]);
        }

        foreach (var item in sehir2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(string.Empty);

        List<string> yenisehirler = new List<string>
        {
            "çorum","samsun","kastamonu"
        };
        yenisehirler.Add("bayburt");
        foreach (var item in yenisehirler)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(string.Empty);

        Person person1=new Person();
        person1.FirstName = "Engin";
        person1.LastName = "Demiroğ";
        person1.BirthYear = 1985;
        person1.NatId = 123;

        Person person2=new Person();
        person2.FirstName = "Mesut";
        person2.LastName = "Yılmaz";
        person2.BirthYear = 1991;
        person2.NatId = 456;

        Person person3 = new Person();

        PttManager pttManager = new PttManager(new PersonManager());

        pttManager.GiveMask(person1);

        pttManager.GiveMask(person2);

        Console.WriteLine("İsim :");
        person3.FirstName = Console.ReadLine();
        Console.WriteLine("Soyisim :");
        person3.LastName = Console.ReadLine();
        Console.WriteLine("Doğum Yılı :");
        person3.BirthYear=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("TC No :");
        person3.NatId =Convert.ToInt64(Console.ReadLine());

        pttManager.GiveMask(person3);

        Console.ReadLine();
    }


    static void SelamVer(string isim="noname")
    {
        Console.WriteLine("Merhaba "+isim);
    }

    static int Topla(int sayi1=0, int sayi2 = 0)
    {
        int sonuc=sayi1 + sayi2;
        Console.WriteLine("Toplam :" + sonuc);
        return sonuc;
    }

}

//Vatandas1 vatadas = new Vatandas1();

//Console.ReadLine();

//static void Degisken()
//{
//    string mesaj = "Hello, World!";
//    double tutar = 100000.5;
//    int sayi = 100;
//    bool logstate = false;

//    string ad = "mesut";
//    string soyad = "yılmaz";
//    int birthyear = 1991;
//    long tcNo = 12345678910;



//    Console.WriteLine(mesaj);
//    Console.WriteLine(mesaj);
//    Console.WriteLine(tutar * 0.18);

//}

public class Vatandas1
{
    public string Name = "mesut";
    public string Surname = "yılmaz";
    public int Birthyear = 1991;
    public long TcNo = 12345678910;

}
public class Vatandas2
{
    public string Name { get; set; }
    public string Surname { get; set;}
    public int Birthyear { get; set;}
    public long TcNo { get; set;}
}