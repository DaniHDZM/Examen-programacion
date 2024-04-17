using System.ComponentModel.DataAnnotations;

public class Producto
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [MaxLength(200, ErrorMessage = "El nombre no debe exceder 200 caracteres.")]
    public string Nombre { get; set; } = "";

    [Required(ErrorMessage = "El inventario es obligatorio.")]
    [Range(1, double.MaxValue, ErrorMessage = "El inventario debe ser positivo o mayor a 0")]
    public int Inventario { get; set; } = 0;

    [Required(ErrorMessage = "El departamento es obligatorio.")]
    public string Departamento { get; set; } = "";

    public Producto(string? nombre, int inventario, string? departamento)
    {
        Nombre = nombre;
        Inventario = inventario;
        Departamento = departamento;
    }
}