// Permite usar listas (List)
using System.Collections.Generic;

// Permite usar a classe Musica
using PlaylistMusicasMVC.Models;

// Namespace da pasta Dados
namespace PlaylistMusicasMVC.Dados
{
    // Classe estática (não precisa criar objeto com "new")
    public static class BancoFake
    {
        // Lista que armazena todas as músicas em memória
        public static List<Musica> Musicas = new List<Musica>();

        // Controla o próximo ID automaticamente
        public static int ProximoId = 1;
    }
}