using RazorPagesExample.Models;
using RazorPagesExample.Pages.Employees;

namespace RazorPagesExample.Repository
{
    public interface IEmpoloyeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        Employee Update(Employee entity);
    }
}
