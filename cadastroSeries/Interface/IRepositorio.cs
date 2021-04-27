using System.Collections.Generic;

namespace cadastroSeries.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T seriado);  // série/seriado
         void Exclui(int id);
         void Atualiza(int id, T seriado);
         int ProximoId();
    }
}