// See https://aka.ms/new-console-template for more information
// Atama ve İşlemli Atama
System.Console.WriteLine("Atama ve İşlemli Atama");

int x = 3;
int y = 3;

System.Console.WriteLine("y = " + y);

y = y + 2;
System.Console.WriteLine("y = " + y);

y += 3;
System.Console.WriteLine("y = " + y);

y /= 2;
System.Console.WriteLine("y = " + y);

x *= 2;
System.Console.WriteLine("x = " + x);

// Mantıksal operatörler
// || && !
System.Console.WriteLine("Mantıksal operatörler");

bool isSucces = true;
bool isComplated = false;

if (isSucces && isComplated)
{
    System.Console.WriteLine("Perfect! -> && kulandık");
}

if (isSucces || isComplated)
{
    System.Console.WriteLine("Perfect! -> || kulandık");
}

if (isSucces && !isComplated)
{
    System.Console.WriteLine("Perfect! -> && ve !isComplated kulandık");
}

// İlişkisel Operatorler
// <, >, <=, >=, ==, !=
System.Console.WriteLine("İlişkisel Operatorler");

int a = 3;
int b = 4;
bool sonuc = a < b;

System.Console.WriteLine("Sonuç = " + sonuc);

sonuc = a > b;
System.Console.WriteLine("Sonuç = " + sonuc);

sonuc = a >= b;
System.Console.WriteLine("Sonuç = " + sonuc);

sonuc = a <= b;
System.Console.WriteLine("Sonuç = " + sonuc);

sonuc = a == b;
System.Console.WriteLine("Sonuç = " + sonuc);

sonuc = a != b;
System.Console.WriteLine("Sonuç = " + sonuc);

// Aritmetiksel Operatörler
System.Console.WriteLine("Aritmetiksel Operatörler");

int sayi = 10;
int sayi2 = 5;

int sonuc1 = sayi+sayi2;
System.Console.WriteLine(sayi + " + " + sayi2 + " = " + sonuc1);

sonuc1 = sayi-sayi2;
System.Console.WriteLine(sayi + " - " + sayi2 + " = " + sonuc1);

sonuc1 = sayi*sayi2;
System.Console.WriteLine(sayi + " * " + sayi2 + " = " + sonuc1);

sonuc1 = sayi/sayi2;
System.Console.WriteLine(sayi + " / " + sayi2 + " = " + sonuc1);

System.Console.WriteLine("sayi = " + sayi);

sayi++;
System.Console.WriteLine("sayi++ = " + sayi);

++sayi;
System.Console.WriteLine("++sayi = " + sayi);

// mod alma
int sonuc2 = 20%3;
System.Console.WriteLine("20 % 3 = " + sonuc2);