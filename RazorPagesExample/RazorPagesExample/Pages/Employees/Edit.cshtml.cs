using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesExample.Models;
using RazorPagesExample.Repository;

namespace RazorPagesExample.Pages.Employees
{
    public class EditModel: PageModel
    {

        private readonly IEmpoloyeeRepository empoloyeeRepository;

        public EditModel(IEmpoloyeeRepository _empoloyeeRepository)
        {
            empoloyeeRepository = _empoloyeeRepository;
        }

        [BindProperty]
        public Employee Employee { get; set; } = null!;

        public void OnGet(int id)
        {
            Employee = empoloyeeRepository.GetById(id);
        }


       /* public IActionResult OnPost(Employee employee)
        {
            Employee = empoloyeeRepository.Update(employee);
            return RedirectToPage("/employees/Index");
        }
       */
        public IActionResult OnPost()
        {
            Employee = empoloyeeRepository.Update(Employee);
            return RedirectToPage("/employees/Index");
        }

    }
}
