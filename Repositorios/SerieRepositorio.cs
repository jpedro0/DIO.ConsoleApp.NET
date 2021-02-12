using DIO.ConsoleApp.NET.Interfaces;
using DIO.ConsoleApp.NET.Model;
using System.Collections.Generic;

namespace DIO.ConsoleApp.NET.Repositorios
{
    public class SerieRepositorio : IRepositorioBase<Serie>
    {
        private IList<Serie> listaSeries = new List<Serie>();
        public void Atualizar(int id, Serie entidade) => listaSeries[id] = entidade;
        public void Excluir(int id) => listaSeries[id].Excluir();
        public void Insere(Serie entidade) => listaSeries.Add(entidade);
        public IList<Serie> Lista() => listaSeries;
        public int ProximoId() => listaSeries.Count;
        public Serie RetornaPorId(int id) => listaSeries[id];
    }
}
