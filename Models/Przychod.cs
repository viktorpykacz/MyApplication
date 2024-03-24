namespace MyApplication.Models
{
    public class Przychod
    {
        public int Id { get; set; }
        public DateOnly? DataWystawieniaFaktury { get; set; }
        public DateOnly? TerminPlatnosci { get; set; }
        public string? NumerFaktury { get; set; }
        public string? NipKlienta { get; set; }
        public string? OpisFaktury { get; set; }
        public decimal? WartoscNetto { get; set; }
        public decimal? WartoscVat { get; set; }
        public decimal? WartoscBrutto { get; set; }
    }
}
