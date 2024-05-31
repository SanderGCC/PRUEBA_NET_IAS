
namespace V2.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Marcas
    {
        [Key]
        /// <summary>
        /// Define la llave primaria de la entidad Marca.
        /// </summary>
        public int IdMarca { get; set; }

        [Required]
        /// <summary>
        /// Atributo Nombre.
        /// </summary>
        public string Nombre { get; set; }  
    }
}
