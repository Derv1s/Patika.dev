using System;

namespace Degiskenler;
class Program
{
    static void Main(string[] args)
    {
        int deger = 2;
        string name = null;
        string Name = "berkay";

        Console.WriteLine(deger);
        Console.WriteLine(name);
        Console.WriteLine(Name);

        System.Console.WriteLine("------------");

        byte b = 5;             // 1 byte
        sbyte sb = 6;           // 1 byte

        short s = 7;            // 2 byte
        ushort us = 8;          // 2 byte

        Int16 i16 = 12;         // 2 byte
        int i = 13;             // 4 byte
        Int32 i32 = 23;         // 4 byte
        Int64 i64 = 24;         // 8 byte

        uint ui = 234;          // 4 byte
        long l = 232;           // 8 byte
        ulong ul = 342;         // 8 byte

        float f = 5;            // 4 byte -> reel sayılar
        double d = 4.56;        // 8 byte
        decimal de = 234;       // 16 byte

        char ch = '2';          // byte
        string str = "yazı";    // sınırsıza yakın

        bool b1 = true;
        bool b2 = false;

        DateTime dt = DateTime.Now;

        System.Console.WriteLine("Şu anda zaman: " + dt);

        // tüm değişken türleri temelde object olduğu için "object" değişken türü her türlü veriyi saklar
        object o1 = "x";
        object o2 = '2';
        object o3 = 3;
        object o4 = 4.5;

        // string ile işlemler
        string str1 = string.Empty;
        str1 = "Berkay Özgün";
        string ad = "Berkay";
        string soyad = "Özgün";
        string tamisim = ad + " " + soyad;

        // int ile işlemler
        int integer1 = 5;
        int integer2 = 3;
        int integer3 = integer1 * integer2;

        // bool ile işlemler
        bool bool1 = 10>2;

        // değişken dönüşümleri
        string str20 = "20";
        int int20 = 20;

        string yenideger = str20 + int20.ToString();
        System.Console.WriteLine("String dönüşümü = " + yenideger);     // çıktı = 2020

        int int21 = int20 + Convert.ToInt32(str20);
        System.Console.WriteLine("Integer dönüşümü = " + int21);        // çıktı = 40

        int int22 = int20 + int.Parse(str20);

        // datetime ile işlemler
        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        System.Console.WriteLine(datetime);

        string datetimeHour = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
        System.Console.WriteLine(datetimeHour);
    }
}
