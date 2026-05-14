namespace veterinaria.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public string Duenio { get; set; }

        public string Vete { get; set; }

        public int ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        public int VeterinarioId { get; set; }

        public Veterinario? Veterinario { get; set; }
        
    }
}
