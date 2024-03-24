namespace MyApplication.Models
{
    public class Kontrakt
    {
        public int Id { get; set; }
        public DateOnly? DataWpisu { get; set; }
        public DateOnly? StartKontraktu { get; set; }
        public bool? CzyTerminowy { get; set; }
        public DateOnly? KoniecKontraktu { get; set; }
        public string? NazwaProjektu { get; set; }
        public decimal? StawkaGodzinowa { get; set; }
        public decimal? StawkaMiesieczna { get; set; }
        public string? Stanowisko { get; set; }
        public string? OpisStanowiska { get; set; }
        public bool? CzyOutsourcing { get; set; }
        public string? NazwaZleceniodawcy { get; set; }
        public string? NipZleceniodawcy { get; set; }
        public string? AdresZleceniodawcy { get; set; }
        public string? KodPocztowyZleceniodawcy { get; set; }
        public string? MiastoZleceniodawcy { get; set; }
        public string? KrajZleceniodawcy { get; set; }
        public string? EmailZleceniodawcy { get; set ; }
    }
}
