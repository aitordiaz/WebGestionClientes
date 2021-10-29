using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebGestionClientes.Models
{
    /// <summary>Clase <c>Cliente</c> usada como Modelo en la aplicación MVC de Gestión, define
    /// las propiedades de los datos que se almacenan en la base de datos.
    /// </summary>
    public class Cliente
    {
        
        public int Id { get; set; }

        // Cálculo letra DNI http://www.interior.gob.es/web/servicios-al-ciudadano/dni/calculo-del-digito-de-control-del-nif-nie
        [Required, RegularExpression(@"^[0-9]{8}[TRWAGMYFPDXBNJZSQVHLCKE]$"), StringLength(9)]
        public string Dni { get; set; }

        [Required, StringLength(40)]
        
        public string Nombre { get; set; }

        [Required, StringLength(100)]
        public string Apellidos { get; set; }

        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; }

        [Required, RegularExpression(@"^(6|7)[0-9]{8}$",
            ErrorMessage = "El número de teléfono debe empezar por 6 o 7 y tener 9 cifras")]
        public int Telefono { get; set; }

        [Required, StringLength(100)]
        public string PaisRes { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Required, DataType(DataType.Date)]
        public DateTime FehcaNac { get; set; }

        [StringLength(200)]
        public string NombreEmpresa { get; set; }

        [StringLength(50)]
        public string CuentaTwitter { get; set; }
        // public list<string> intereses { get; set; }
        [StringLength(50)]
        public string Genero { get; set; }
    }
}
