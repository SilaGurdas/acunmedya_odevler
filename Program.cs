using Odev;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Console.WriteLine(YasKategori.Hesapla(22));
        Console.WriteLine(Araba.ArabaDurumu(17));

        Dongu.WhileOrnek();
        Dongu.DoWhileOrnek();

        
        List<Calisan> calisanListesi = new List<Calisan>
        {
            new Calisan { Ad = "Duygu", Soyad = "Murt", Meslek = "Genel Müdür", Maas = 50000, Departman = "Yönetim" },
            new Calisan { Ad = "Gözde", Soyad = "Altunyurt", Meslek = "Müdür", Maas = 30000, Departman = "Satış" },
            new Calisan { Ad = "Enis", Soyad = "Gürer", Meslek = "Programcı", Maas = 20000, Departman = "IT" },
            new Calisan { Ad = "Sıla", Soyad = "Gürdaş", Meslek = "Stajyer", Maas = 5000, Departman = "Pazarlama" }
        };

        double toplamMaas = 0;
        foreach (var calisan in calisanListesi)
        {
            Console.WriteLine($"{calisan.Ad} {calisan.Soyad} - {calisan.Meslek} - {calisan.Maas} TL - {calisan.Departman}");
            toplamMaas += calisan.Maas;
        }

        
        List<Araba> arabaListesi = new List<Araba>
        {
            new Araba { Marka = "BMW", Model = "320i", Tuketim = 7.5 },
            new Araba { Marka = "Mercedes", Model = "C200", Tuketim = 8.0 },
            new Araba { Marka = "Toyota", Model = "Corolla", Tuketim = 6.5 },
            new Araba { Marka = "Honda", Model = "Civic", Tuketim = 6.8 }
        };

       
        foreach (var araba in arabaListesi)
        {
            Console.WriteLine($"{araba.Marka} {araba.Model} - {araba.Tuketim} L/100km");
        }
    }
}
