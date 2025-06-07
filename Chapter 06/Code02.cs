// Rentable interface represents products that can be rented
public interface IRentable
{
    int RentalPeriodInDays { get; set; }

    void Rent();
}