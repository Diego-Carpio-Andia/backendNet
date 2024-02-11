namespace APIDiligenciaProveedores.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public required string RazonSocial { get; set; }
        public required string NombreComercial { get; set; }
        public long IdentificacionTributaria { get; set; }
        public required string NumeroTelefonico { get; set; }
        public required string CorreoElectronico { get; set; }
        public required string SitioWeb { get; set; }
        public required string DireccionFisica { get; set; }
        public required string Pais { get; set; }
        public decimal FacturacionAnual { get; set; }
        public DateTime FechaUltimaEdicion { get; set; }

    }
}
