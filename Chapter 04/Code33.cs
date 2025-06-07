using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

[TestMethod]
public void TestCustomerServiceSave()
{
    // Arrange
    var mockRepo = new Mock<ICustomerRepository>();
    var service = new CustomerService(mockRepo.Object);
    var customer = new Customer
    {
        Name = "Alice"
    };
    // Act
    service.SaveCustomer(customer);
    // Assert
    mockRepo.Verify(r => r.Save(customer), Times.Once());
}