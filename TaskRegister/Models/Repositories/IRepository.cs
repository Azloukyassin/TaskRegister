using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskRegister.Models.Repositories
{
    public interface IRepository<TEntity>

    {
        IList<TEntity> List();
        TEntity Find(int id);
        void Add(TEntity entity , int id );
        //void Update(int id, TEntity entity);
        // void Delete(int id);
        // List<TEntity> Search(string term);
    }
    
    
}
