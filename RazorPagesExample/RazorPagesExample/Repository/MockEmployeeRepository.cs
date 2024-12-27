using RazorPagesExample.Models;

namespace RazorPagesExample.Repository
{
    public class MockEmployeeRepository : IEmpoloyeeRepository
    {


        private List<Employee> employe;
        public MockEmployeeRepository()
        {
            employe = new List<Employee>()
            {
                new Employee{Id=1,Name ="Yaşar Apaydın",Email="apaydinyasar0@gmail.com",Photo="1.jpg",Department="Muhasebe"},
   new Employee{Id=2,Name ="Kağan Ağman",Email="kaganAgman@gmail.com",Photo="2.jpg",Department="Yazılım"},
     new Employee{Id=3,Name ="Emirhan Topçu",Email="emirhan@gmail.com",Photo="3.jpg",Department="Yıldız"},
       new Employee{Id=4,Name ="Cemil Yıldırım",Email="Cemil@gmail.com",Photo="4.jpg",Department="IK"},
       new Employee{Id=5,Name ="Ali Altunar",Email="alialtunar@mail.com",Photo="5.jpg",Department="Yazılım"}

            };
        }

        public IEnumerable<Employee> GetAll()
        {
            return employe;
        }

        public Employee GetById(int id)
        {
            return employe.FirstOrDefault(x=> x.Id == id);
        }

        public Employee Update(Employee entity)
        {
            Employee employee = employe.FirstOrDefault(i=> i.Id == entity.Id);

            if(employee != null)
            {
             employee.Name = entity.Name;
            employee.Email = entity.Email;
            employee.Photo = entity.Photo;
            employee.Email = entity.Email;
            }
            return employee;
        }
    }
}
