using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorPagesApp.Pages
{
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime AppointmentDate { get; set; }
    }

    public class CustomerModel : PageModel
    {
        [BindProperty]
        public Customer Customer { get; set; }

        public void OnPost()
        {
        // Handle form submission, such as registering the customer
        // and scheduling the appointment
        }
    }