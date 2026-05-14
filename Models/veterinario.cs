namespace veterinaria.Models
{
    public class Veterinario
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido  { get; set; }

        public int Telefono { get; set; }

        public string Mascoa { get; set; }

        public List<Mascota> Mascotas { get; set; } = new List<Mascota>();
    }
}
