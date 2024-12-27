using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesExample.Models;
using RazorPagesExample.Repository;
using System.Reflection.Metadata.Ecma335;

namespace RazorPagesExample.Pages.Employees
{
    public class DetailsModel:PageModel
    {
        private readonly IEmpoloyeeRepository repository;

        public DetailsModel(IEmpoloyeeRepository _repository)
        {
            repository = _repository;

        }



        public Employee employee { get; set; } = default!;
        public IActionResult OnGet(int id)
        {
            employee = repository.GetById(id);


            if(employee == null)
            {
                return RedirectToPage("/NotFound");
            }

           return Page();
        }
       
       

    }
}
