﻿namespace MyApplication.Models
{
    public class Kontrakt
    {
        public int Id { get; set; }
        public DateTime DataWpisu { get; set; }
        public string? Dodal { get; set; }
        public DateTime StartKontraktu { get; set; }
        public bool? CzyTerminowy { get; set; }
        public DateTime KoniecKontraktu { get; set; }
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
