
using Business.Concrete;
using Entities.Concrete;

//int sonuc=Toplama(3,5);
//static int Topla()
//{
//    return 5;
//}
//#region degiskenler
//// static void Degiskenler()
////{
////    string Mesaj = "Merhaba";
////    double tutar = 100000;
////    int sayi = 100;
////    bool girisYapmisMi = false;

////    string ad = "Engin";
////    string Soyad = "Demiroğ";
////    int dogumYili = 1985;
////    long tcNo = 12345678910;
////}
//#endregion
//static void selamVer(string isim="İsimsiz")
//{
//    Console.WriteLine("Merhaba "+isim);
//}
//static int Toplama(int n1,int n2)
//{
//    int sonuc=n1 + n2;
//    Console.WriteLine("Toplam: "+sonuc);
//    return sonuc;
//}

//Diziler /Arrays
string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";
ogrenciler=new string[4];
ogrenciler[3] = "İlker";
Person person1 = new Person();
person1.NationalIdentity = 12345678910;
person1.FirstName = "Eyüp";
person1.LastName = "Pervanlar";
person1.DateOfBirthYear=2002;
for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}
string[] sehirler1 = new[] { "Ankara", "İstanbul","izmir" };
string[] sehirler2 = new[] { "Bursa", "antalya", "Diyarlarbakır" };
foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}
List<String> yenisehirler1 = new List<string>{"ankara","istanbul","İzmir"};
yenisehirler1.Add("Trabzon");
foreach (var sehir in yenisehirler1)
{
    Console.WriteLine(sehir);
}
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
Console.ReadLine();