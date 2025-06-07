public class Car
{
    // private data members
    private string model;
    private int year;
    // public method to access and modify private data members
    public void SetModel(string model)
    {
        this.model = model;
    }

    public string GetModel()
    {
        return this.model;
    }

    public void SetYear(int year)
    {
        this.year = year;
    }

    public int GetYear()
    {
        return this.year;
    }
}