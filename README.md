# 🎵 Playlist de Músicas - ASP.NET MVC

Projeto desenvolvido para fins didáticos com o objetivo de ensinar o padrão MVC (Model-View-Controller) utilizando ASP.NET Core.

## 📚 Sobre o projeto

Este sistema permite gerenciar uma playlist de músicas com operações básicas de CRUD: criar música, listar músicas, editar música e excluir música. Os dados são armazenados em memória utilizando uma lista, ou seja, não há banco de dados. Ao reiniciar o sistema, os dados são perdidos.

## 🧠 O que é MVC

MVC é um padrão de arquitetura que separa a aplicação em três partes principais.

O Model (Modelo) é responsável pelos dados e regras de negócio.  
A View (Visão) é responsável pela interface com o usuário.  
O Controller (Controlador) controla o fluxo da aplicação.

## 🧱 Estrutura do projeto

```
Controllers/
   MusicaController.cs

Models/
   Musica.cs

Dados/
   BancoFake.cs

Views/
   Musica/
      Index.cshtml
      Create.cshtml
      Edit.cshtml
      Delete.cshtml
```

## 🎵 Model: Musica

```csharp
public class Musica
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public string Genero { get; set; }
    public int DuracaoMinutos { get; set; }
    public bool Favorita { get; set; }
}
```

## 🗃️ BancoFake

```csharp
public static class BancoFake
{
    public static List<Musica> Musicas = new List<Musica>();
    public static int ProximoId = 1;
}
```

## 🎮 Controller

Ações principais:

- Index → lista músicas  
- Create → cria música  
- Edit → edita música  
- Delete → exclui música  

## ▶️ Como executar

Clone o repositório:

```
git clone https://github.com/profalexresende/csharp_mvc_2026.git
```

Execute o projeto no Visual Studio (F5)

Acesse:

```
/Musica
```

## 🚀 Tecnologias

- ASP.NET Core MVC  
- C#  
- Razor  

## ⚠️ Observações

Dados em memória (não persistem).

## ⭐ Projeto educacional
