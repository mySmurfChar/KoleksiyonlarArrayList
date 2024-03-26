using System.Collections;
using System.IO;

namespace StringMethods
{
    internal class Program
    {


static void Main(string[] args)
 {
  program.ArrayListMetodu();
 }
private void ArrayListMetodu()
{

    //System.Collections namespace

    
    ArrayList liste = new ArrayList();
    //eleman ekleme
    liste.Add("Ayşe");
    liste.Add(2);
    liste.Add(true);
    liste.Add('A');

    //içerisindeki verilere erişim
    Console.WriteLine(liste[1]);

    //foreach ile hepsini yazdırma
    foreach(var item in liste)
    {
        Console.WriteLine(item);
    }

    //AddRange
    Console.WriteLine("******AddRange******");
    string[] renkler = { "kırmızı", "sarı", "yesil" };
    List<int> sayılar = new List<int> { 92, 76, 1, 2, 3, };

    liste.AddRange(renkler);
    liste.AddRange(sayılar);

    foreach (var item in liste)
    {
        Console.WriteLine(item);
    }

    //Sıralama -Sort-
    //Diziyi olduğu gibi sıralamaya kalktığımızda hata verecektir
    //bütün elemanların aynı veri tipinde olması gerekir sıralamak için
    //Yoksa derlemede hata olmaz çalışma zamanında hata olur

    Console.WriteLine("******* Sort *******");
    //liste.Sort();

    //YUKARIDAKİ KODU ÇALIŞTIRMAK İÇİN LİSTENİN BÜTÜN ELEMANLARI AYNI VERİTİPİNDE OLMALI




}
    }
}
