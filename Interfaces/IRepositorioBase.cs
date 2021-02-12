using System.Collections.Generic;

namespace DIO.ConsoleApp.NET.Interfaces
{
    public interface IRepositorioBase<T>
    {
        IList<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Excluir(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}
