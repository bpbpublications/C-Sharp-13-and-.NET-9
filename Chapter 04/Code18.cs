using Microsoft.Data.SqlClient;

namespace Book;
public class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }

    public static Person GetPersonFromSqlDataReader(SqlDataReader reader)
    {
        // Define a local lambda function for the age calculation
        Func<DateTime, int> calculateAge = birthDate =>
        {
            return birthDate.Date > DateTime.Today.AddYears((DateTime.Today.Year - birthDate.Year) - 1) ? (DateTime.Today.Year - birthDate.Year) - 1 : DateTime.Today.Year - birthDate.Year;
        };
        return new Person
        {
            Name = Convert.ToString(reader["Name"]),
            LastName = Convert.ToString(reader["LastName"]),
            Address = Convert.ToString(reader["Address"]),
            Age = calculateAge(Convert.ToDateTime(reader["BirthDate"])),
            Occupation = Convert.ToString(reader["Occupation"])
        };
    }
}