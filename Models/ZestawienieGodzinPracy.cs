namespace MyApplication.Models
{
    public class ZestawienieGodzinPracy
    {
        public int Id { get; set; }
        public DateOnly? DataWpisu { get; set; }
        public int? Rok { get; set; }
        public int? Miesiac { get; set; }
        public string? NazwaProjektu { get; set; }
        public int? IleGodzin { get; set; }
    }
}
