namespace MyApplication.Models
{
    public class ZestawienieMiesieczneFirmy
    {
        public int Id { get; set; }
        public string? DataWpisu { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public decimal? KosztyBiuro { get; set; }
        public decimal? KosztyAuto { get; set; }
        public decimal? KosztyLacznie { get; set; }
        public decimal? PrzychodyLacznie { get; set; }
        public decimal? VatLacznie { get; set; }
    }
}
