using DIO.ConsoleApp.NET.Model.Enum;
using System.Text;

namespace DIO.ConsoleApp.NET.Model
{
    public class Serie: EntidadeBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public int Ano { get; set; }
        public bool Excluido { get; private set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        public override string ToString()
        {
            var textoString = new StringBuilder();
            textoString.AppendLine($"Gênero: {Genero}");
            textoString.AppendLine($"Titulo: {Titulo}");
            textoString.AppendLine($"Descrição: {Descricao}");
            textoString.AppendLine($"Ano de Início: {Ano}");
            return textoString.ToString();
        }

        public string AdicionarTitulo(string titulo) => Titulo = titulo;
        public int AdicionarId(int id) => Id = id;
        public bool Excluir() => Excluido = true;
    }
}
