using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Interfaces
{
    public interface IAspiranteoRepository
    {
        Task<IEnumerable<Aspirante>> GetAspirantes();
        Task<int> Insert(Aspirante aspirante);
        Task<int> DeleteById(int Id);
        Task<Aspirante> Update(Aspirante aspirante);
    }
}
