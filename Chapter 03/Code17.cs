using Microsoft.Data.SqlClient;

var myCondition = true;
var conn = new SqlConnection("Data Source=.;Initial Catalog=MyDatabase;Integrated Security=True");
var cmd = new SqlCommand("SELECT * FROM MyTable", conn);
while (myCondition)
{
// Do something while
// myCondition is true
}

var reader = cmd.ExecuteReader();
while (reader.Read())
{
    // Process each record while
    // reader.Read() has records
    // to read from DataSource
    ProcessRecord(reader);
}

void ProcessRecord(SqlDataReader reader)
{
    // Process the record
    // from the reader
    // object
}