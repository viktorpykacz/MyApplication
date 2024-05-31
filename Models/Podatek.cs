namespace MyApplication.Models
{
    public class Podatek
    {
        public int Id { get; set; }
        public string? Dodal { get; set; } = "api";
        public string? DataWpisu { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public decimal? VatDoOdliczenia { get; set; }
        public decimal? PitDoZaplaty { get; set; }
        public decimal? VatDoZaplaty { get; set; }
        public decimal? ZusDoZaplaty { get; set; }
    }
}
