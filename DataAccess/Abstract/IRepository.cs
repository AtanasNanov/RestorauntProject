using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository : IDisposable
    {
        //Lipsva class Employee taka che metodite ne rabotqt za sega
        IEnumerable<Employee> GetEmployees(); 
        Employee GetEmployeeByID(int employeeId);
        void InsertEmplyee(Employee employee);
        void DeleteEmployee(int employeeId);
        void UpdateEmployee(Employee employee);
        void Save();

    }
}
