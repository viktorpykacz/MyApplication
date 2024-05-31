namespace MyApplication.Models
{
    public class Koszt
    {
        public int Id { get; set; }
        public string? Dodal { get; set; } = "api";
        public string? DataWystawieniaFaktury { get; set; }
        public string? NumerFaktury { get; set; }
        public string? NipFirmy { get; set; }
        public string? OpisKosztu { get; set; }
        public string? RodzajKosztu { get; set; }
        public decimal? WartoscNetto { get; set; }
        public decimal? WartoscVat { get; set; }
        public decimal? WartoscBrutto { get; set; }
    }
}
