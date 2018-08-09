using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public interface IRepository<T>
    {
        IEnumerable<T> Items { get; }
        T getById(int id);
        void insert(T element);
        void update(T element);
        void delete(int id);
        Boolean ContainsId(int id);
    }
}
