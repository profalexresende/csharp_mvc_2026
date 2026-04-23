// Importa recursos de validação (Required, Range, etc.)
using System.ComponentModel.DataAnnotations;

// Define o "pacote" onde essa classe está localizada
namespace PlaylistMusicasMVC.Models
{
    // Classe que representa uma música no sistema
    public class Musica
    {
        // ID único da música (identificador)
        public int Id { get; set; }

        // Campo obrigatório (não pode ser vazio)
        [Required]
        public string Titulo { get; set; }

        // Campo obrigatório
        [Required]
        public string Artista { get; set; }

        // Campo opcional (pode ficar vazio)
        public string Genero { get; set; }

        // Duração em minutos (mais simples que segundos)
        // Range define valores mínimos e máximos permitidos
        [Range(1, 60)]
        public int DuracaoMinutos { get; set; }

        // Indica se a música é favorita (true ou false)
        public bool Favorita { get; set; }
    }
}