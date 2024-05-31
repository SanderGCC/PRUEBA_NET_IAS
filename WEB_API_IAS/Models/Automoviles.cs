
namespace WEB_API_IAS.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Automoviles
    {

        [Key]
        /// <summary>
        /// Define la llave primaria de la entidad Automovil.
        /// </summary>
        public int Id { get; set; }

        [Required]
        /// <summary>
        /// Atributo Modelo.
        /// </summary>
        public string Modelo { get; set; }

        /// <summary>
        /// Atributo Descripción.
        /// </summary>
        public string? Descripcion { get; set; }

        [Required]
        /// <summary>
        /// Atributo Precio.
        /// </summary>
        public int Precio { get; set; }

        [Required]
        /// <summary>
        /// Atributo Kilometraje.
        /// </summary>
        public int Kilometraje { get; set; }

        [Required]
        /// <summary>
        /// Atributo que define la relación con la tabla "Marca".
        /// </summary>
        public int IdMarca { get; set; }
    }

}
