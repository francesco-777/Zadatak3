using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadatak3.Models
{
    public class Racun
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Datum računa je obavezan podatak!")]
        [StringLength(50, ErrorMessage = "Maksimalno 50 znakova!")]
        public string DatumRacuna { get; set; }
        [Required(ErrorMessage = "Ime je obavezan podatak!")]
        [StringLength(50, ErrorMessage = "Maksimalno 50 znakova!")]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Prezime je obavezan podatak!")]
        [StringLength(50, ErrorMessage = "Maksimalno 50 znakova!")]
        public string Prezime { get; set; }
        [Required(ErrorMessage = "Email je obavezan podatak!")]
        [StringLength(50, ErrorMessage = "Maksimalno 50 znakova!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Adresa je obavezan podatak!")]
        [StringLength(50, ErrorMessage = "Maksimalno 50 znakova!")]
        public string Adresa { get; set; }
    }
}