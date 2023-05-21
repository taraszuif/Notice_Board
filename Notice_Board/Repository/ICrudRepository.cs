using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notice_Board.Repository
{
    public interface ICrudRepository<T>
    {
        void Create(T item);
        T Read(string id);
        void Update(T item);
        void Delete(string id);
        void Save();
        void Load();
    }
}
