using System.Collections;
/*
Şu ana dek gördüğümüz ilkel dizilerin (veriTipi[]) olarak tanımlanan iki büyük özelliği vardı TIP BAĞIMLILIĞI ve ELEMAN SAYISI ZORUNLULUĞU

Artık ArrayList ile birlikte bu bağımlılıklar ortadan kalktı.

Dezavantağı
ArrayList içerisindeki elemanları otomatik olarak object veri tipine döndürme özelliğine sahiptir. Dolayısıyla verileri geri almak istediğinizde mecburen convert işlemi gerek duymaktasınız.
--Boxing : Unboxing
*/

ArrayList yeniDizi = new ArrayList() { "İstanbul", 34, true };
yeniDizi.Add("Ankara");
yeniDizi.Add(06);
yeniDizi.Add(10.5);
yeniDizi.Add(false);

foreach (var items in yeniDizi)
{
    Console.WriteLine(items);
}

ArrayList sehirler = new ArrayList() { "İstanbul", "Ankara" };
sehirler.Add("İzmir");
sehirler.Add("Bursa");
sehirler.Add("Eskişehir");
sehirler.Add("Edirne");
sehirler.Add("Rize");
sehirler.Add("Antalya");

Console.WriteLine((string)sehirler[0]);

Console.WriteLine(sehirler.Count.ToString());

Console.WriteLine(sehirler.Contains("İstanbul"));

Console.WriteLine(sehirler.IndexOf("Izmir").ToString());
Console.WriteLine(sehirler.LastIndexOf("İzmir").ToString());

sehirler.Insert(3, "Sakarya");
sehirler.Remove("İzmir");
sehirler.RemoveAt(4);

sehirler.Sort();
sehirler.Reverse();

sehirler.Clear();

// O anki kapasiteyi o anki eleman sayısına eşitler.
sehirler.TrimToSize();
