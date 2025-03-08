
using Odev0308;

GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programci pr = new Programci();
Stajyer s = new Stajyer();

double toplamMaas = 0.0;

toplamMaas += gm.MaasinizNedir();
toplamMaas += mu.MaasinizNedir();
toplamMaas += pr.MaasinizNedir();
toplamMaas += s.MaasinizNedir();

Console.WriteLine("Toplam maaş: " + toplamMaas + " TL");

BMW bmw = new BMW();
bmw.marka = "bmw";
bmw.HizliGit(bmw.marka);
bmw.Uc(bmw.marka);
bmw.Yuz(bmw.marka);

Porsche prs = new Porsche();
prs.marka = "Porsche";
prs.Uc(prs.marka);

Mercedes mc = new Mercedes();
mc.marka = "Mercedes";
mc.Uc(mc.marka);
mc.Yuz(mc.marka);

double toplamYakıt = 0.0;
toplamYakıt += bmw.YakitTüketimi();
toplamYakıt += mc.YakitTüketimi();
toplamYakıt += prs.YakitTüketimi();

Console.WriteLine("Harcanan toplam yakıt:" + toplamYakıt);

//ARRAY(DİZİ) NEDİR?
//Array, aynı türdeki birden fazla veriyi tek bir yapıda saklamak için kullanılan bir veri yapısıdır.
//Yani, diziler birden fazla değeri bir arada tutmaMıza imkan verir. Her bir değere eleman denir ve bu elemanlar bir indeks kullanılarak erişilebilir.
