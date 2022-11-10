using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        //Lipsva class Employee taka che metodite ne rabotqt za sega
        T GetById(int id);
        IEnumerable<T> List();
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);

    }
    
}
