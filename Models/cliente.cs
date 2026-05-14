namespace veterinaria.Models
{
    public class Cliente
    {
        public int id {  get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime Fechanac {  get; set; }

        public int Telefono { get; set; }

        public string Masco { get; set; }

        public List<Mascota> Mascotas { get; set; } = new List<Mascota>();

    }
    }
