using System.ComponentModel.DataAnnotations;

namespace restaurante.Models
{
    public class Bodega
    {
        public Bodega(int id_producto, string nombre_producto, DateTime fecha_ingreso, int cantidad, string tipo)
        {
            Id_producto = id_producto;
            Nombre = nombre_producto;
            Ingreso = fecha_ingreso;
            Cantidad = cantidad;
            Tipo = tipo;
        }

        public int Id_producto { get; set; }

        [Display(Name="Nombre Producto")]
        [Required(ErrorMessage ="El Nombre del producto es requerido")]
        public string Nombre { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        [Required(ErrorMessage = "La Fecha de ingreso es requerida")]
        //[DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime Ingreso { get; set; }

        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "La Cantidad es requerida")]
        public int Cantidad { get; set; }

        [Display(Name = "Tipo Producto")]
        [Required(ErrorMessage = "El Tipo del Producto es requerido")]
        public string Tipo { get; set; }    
    }
}
