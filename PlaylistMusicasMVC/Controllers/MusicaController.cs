// Importa funcionalidades do ASP.NET MVC
using Microsoft.AspNetCore.Mvc;

// Importa o Model Musica
using PlaylistMusicasMVC.Models;

// Importa o "banco fake"
using PlaylistMusicasMVC.Dados;

// Permite usar métodos como FirstOrDefault
using System.Linq;

// Namespace do controller
namespace PlaylistMusicasMVC.Controllers
{
    // Controller responsável pelas ações de música
    public class MusicaController : Controller
    {
        // ============================
        // LISTAR MÚSICAS (READ)
        // ============================
        public IActionResult Index()
        {
            // Envia a lista de músicas para a View
            return View(BancoFake.Musicas);
        }

        // ============================
        // BRIR FORMULÁRIO (CREATE - GET)
        // ============================
        public IActionResult Create()
        {
            // Apenas abre o formulário vazio
            return View();
        }

        // ============================
        // SALVAR NOVA MÚSICA (CREATE - POST)
        // ============================
        [HttpPost]
        public IActionResult Create(Musica musica)
        {
            // Verifica se os dados passaram nas validações
            if (ModelState.IsValid)
            {
                // Define o ID automaticamente
                musica.Id = BancoFake.ProximoId++;

                // Adiciona a música na lista
                BancoFake.Musicas.Add(musica);

                // Redireciona para a listagem
                return RedirectToAction("Index");
            }

            // Se houver erro, retorna para o formulário com os dados preenchidos
            return View(musica);
        }

        // ============================
        // ABRIR EDIÇÃO (GET)
        // ============================
        public IActionResult Edit(int id)
        {
            // Procura a música pelo ID
            var musica = BancoFake.Musicas
                .FirstOrDefault(m => m.Id == id);

            // Se não encontrar, retorna erro 404
            if (musica == null) return NotFound();

            // Envia a música para a View
            return View(musica);
        }

        // ============================
        // SALVAR EDIÇÃO (POST)
        // ============================
        [HttpPost]
        public IActionResult Edit(Musica musica)
        {
            // Busca a música existente na lista
            var existente = BancoFake.Musicas
                .FirstOrDefault(m => m.Id == musica.Id);

            // Se não encontrar, retorna erro
            if (existente == null) return NotFound();

            // Verifica validação
            if (ModelState.IsValid)
            {
                // Atualiza os dados da música
                existente.Titulo = musica.Titulo;
                existente.Artista = musica.Artista;
                existente.Genero = musica.Genero;
                existente.DuracaoMinutos = musica.DuracaoMinutos;
                existente.Favorita = musica.Favorita;

                // Volta para a listagem
                return RedirectToAction("Index");
            }

            // Se houver erro, volta para edição
            return View(musica);
        }

        // ============================
        // CONFIRMAR EXCLUSÃO (GET)
        // ============================
        public IActionResult Delete(int id)
        {
            // Busca a música pelo ID
            var musica = BancoFake.Musicas
                .FirstOrDefault(m => m.Id == id);

            // Se não encontrar
            if (musica == null) return NotFound();

            // Envia para a tela de confirmação
            return View(musica);
        }

        // ============================
        // EXCLUIR (POST)
        // ============================
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmado(int id)
        {
            // Procura a música na lista
            var musica = BancoFake.Musicas
                .FirstOrDefault(m => m.Id == id);

            // Se existir
            if (musica != null)
            {
                // Remove da lista
                BancoFake.Musicas.Remove(musica);
            }

            // Volta para a listagem
            return RedirectToAction("Index");
        }
    }
}