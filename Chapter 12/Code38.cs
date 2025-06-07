using Microsoft.AspNetCore.Mvc.RazorPages;

public class RecentPurchasesModel : PageModel
{
    public List<Purchase> Purchases { get; set; }

    public void OnGet()
    {
        // Load recent purchases
        Purchases = /* Fetch from database or service */ ;
    }

    public bool UserIsFinancialOperator()
    {
    // Implement our logic to determine if the current user is a financial operator
    }

    public bool UserIsCustomerSuccessOperator()
    {
    // Implement our logic to determine if the current user is a customer success operator
    }
}