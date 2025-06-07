public class CustomerService
{
    private readonly ICustomerRepository _customerRepository;
    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public void SaveCustomer(Customer customer)
    {
        _customerRepository.Save(customer);
    }
}