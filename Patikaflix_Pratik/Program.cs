using Patikaflix_Pratik;


var tvSeriesList = new List<TvSeries>();

while (true)
{
    Console.WriteLine("Patikaflix'e hoş geldiniz! Dizilerinizi kaydetmek ister misiniz? Evet için e, hayır için h tuşuna basınız.");
    string yanit = Console.ReadLine().ToLower();

    if (yanit == "h")
    {
        Console.WriteLine("Program sonlandırıldı.");
        break;
    }

    if (yanit != "e")
        Console.WriteLine("Geçersiz bir değer girdiniz.");

    soru1:
    if (yanit == "e")
    {
        TvSeries serie1 = new TvSeries();

        Console.Write("Dizinin adını giriniz: ");
        serie1.Name = Console.ReadLine();

        Console.Write("Dizinin yapım yılını giriniz: ");
        serie1.ProductionYear = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dizinin türünü giriniz: ");
        serie1.Genre = Console.ReadLine();

        Console.Write("Dizinin yayınlanma yılını giriniz: ");
        serie1.AirYear = Convert.ToInt32(Console.ReadLine());

        Console.Write("Dizinin yönetmenini giriniz: ");
        serie1.Director = Console.ReadLine();

        Console.Write("Dizinin yayınlandığı ilk platformu giriniz: ");
        serie1.Platform = Console.ReadLine();


        tvSeriesList.Add(serie1);

    }

    Console.WriteLine("Başka bir dizi eklemek istiyor musunuz? Yanıtınız evet ise e, hayır ise h tuşuna basınız.");
    string cevap = Console.ReadLine().ToLower();
    if (cevap == "h") 
        break;
    if (cevap == "e")
        goto soru1;
}

List<ComedySeries> comedySeriesList = tvSeriesList.Where(x => x.Genre.ToLower() == "komedi").Select(x => new ComedySeries
{
    Name = x.Name,
    Genre = x.Genre,
    Director = x.Director,

})
 .OrderBy(x => x.Name)
 .ThenBy(x => x.Director)
 .ToList();

Console.WriteLine("Komedi Dizileri ve Yönetmenleri: ");

foreach (var series in comedySeriesList)
{
    Console.WriteLine(series.Name);
    Console.WriteLine(series.Director);
    
}
