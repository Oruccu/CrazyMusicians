namespace CrazyMusicians.Data
{
    public class CrazyMusician
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Profession { get; set; } = "";
        public string Property { get; set; } = "";
    }

    public static class DataList
    {
        public static List<CrazyMusician> GetCrazyMusicians()
        {
            return new List<CrazyMusician>
            {
                new CrazyMusician { Id = 1, Name = "Ahmet Çalgı", Profession = "Ünlü Çalgı Çalar", Property = "Her zaman yanlış nota çalar, ama çok eğlenceli" },
                new CrazyMusician { Id = 2, Name = "Zeynep Melodi", Profession = "Popüler Melodi Yazarı", Property = "Şarkıları yanlış anlaşılır ama çok popüler" },
                new CrazyMusician { Id = 3, Name = "Cemil Akor", Profession = "Çılgın Akorist", Property = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
                new CrazyMusician { Id = 4, Name = "Fatma Nota", Profession = "Sürpriz Nota Üreticisi", Property = "Nota üretirken sürekli sürprizler hazırlar" },
                new CrazyMusician { Id = 5, Name = "Hasan Ritim", Profession = "Ritim Canavarı", Property = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
                new CrazyMusician { Id = 6, Name = "Elif Armoni", Profession = "Armoni Ustası", Property = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır" },
                new CrazyMusician { Id = 7, Name = "Ali Perde", Profession = "Perde Uygulayıcı", Property = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir" },
                new CrazyMusician { Id = 8, Name = "Ayşe Rezonans", Profession = "Rezonans Uzmanı", Property = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
                new CrazyMusician { Id = 9, Name = "Murat Ton", Profession = "Tonlama Meraklısı", Property = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç" },
                new CrazyMusician { Id = 10, Name = "Selin Akor", Profession = "Akor Sihirbazı", Property = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır" }
            };
        }
    }
}
