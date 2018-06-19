using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MulhouseHabitat.Models
{
    public class MHLogements
    {
        public int Id { get; set; }

        [Display(Name = "Type de logement")]
        public string Type { get; set; }

        [Display(Name = "Numéro de rue")]
        public string StreetNumber { get; set; }

        [Display(Name = "Rue")]
        public string StreetName { get; set; }

        [Display(Name = "Code Postal")]
        public string PostalCode { get; set; }

        [Display(Name = "Ville")]
        public string City { get; set; }

        [Display(Name = "Nombres de pièces")]
        public int NumberOfPieces { get; set; }

        [Display(Name = "Taille en M²")]
        public int Size { get; set; }

        [Required(ErrorMessage ="le statut de location est nécéssaire")]
        [Display(Name = "Disponible")]
        public bool Rented { get; set; }


        public MHLogements()
        {

        }

        public MHLogements (int _id,string _type, string _streetNumber,string _streetName, string _postalCode,string _city,int _numberOfPieces,int _size,bool _rented)
        {
            this.Id = _id;
            this.Type = _type;
            this.StreetNumber = _streetNumber;
            this.StreetName = _streetName;
            this.PostalCode = _postalCode;
            this.City = _city;
            this.NumberOfPieces = _numberOfPieces;
            this.Size = _size;
            this.Rented = _rented;
        }


    }
}