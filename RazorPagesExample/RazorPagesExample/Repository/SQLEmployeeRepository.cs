using RazorPagesExample.Models;

namespace RazorPagesExample.Repository
{
    public class SQLEmployeeRepository : IEmpoloyeeRepository
    {
        private readonly DataContext dataContext;

        public SQLEmployeeRepository(DataContext _dataContext)
        {
            dataContext = _dataContext;

        }

        public IEnumerable<Employee> GetAll()
        {
            return dataContext.Employees.ToList();
        }

        public Employee GetById(int id)
        { 
            return dataContext.Employees.FirstOrDefault(i=> i.Id== id);
        }

        public Employee Update(Employee entity)
        {
           var entity1 = dataContext.Employees.FirstOrDefault(i => i.Id == entity.Id);

            if(entity1 != null)
            {
                entity1.Name = entity.Name;
                entity1.Email = entity.Email;
                entity1.Department = entity.Department;
                entity1.Photo = entity.Photo;
                dataContext.SaveChanges();
            }
            return entity1;
        }
    }
}
