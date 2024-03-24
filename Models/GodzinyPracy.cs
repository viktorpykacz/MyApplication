namespace MyApplication.Models
{
    public class GodzinyPracy
    {
        public int Id { get; set; } 
        public DateOnly? DataWpisu { get; set; }
        public DateOnly? DataAktywnosci { get; set; }
        public Boolean? CzyPraca { get; set; }
        public string? NazwaProjektu { get; set; }
        public int? IleGodzin { get; set; }

    }
}
