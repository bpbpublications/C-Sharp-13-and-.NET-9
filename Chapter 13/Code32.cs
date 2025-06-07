public class Patient
{
    public int ID { get; set; }
    public string LastName { get; set; }
    public string FirstMidName { get; set; }
    public List<Doctor> Doctor { get; set; }
}