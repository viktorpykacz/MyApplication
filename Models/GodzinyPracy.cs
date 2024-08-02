namespace MyApplication.Models
{
    public class GodzinyPracy
    {
        public int Id { get; set; }
        public string? Dodal { get; set; }
        public DateTime DataWpisu { get; set; }
        public DateTime DataAktywnosci { get; set; }
        public Boolean? CzyPraca { get; set; }
        public string? NazwaProjektu { get; set; }
        public int? IleGodzin { get; set; }

    }
}
