using System.Data.SqlTypes;

try
{
// Do something
}
catch (ApplicationException ec)
{
// Handle Application exception
}
catch (SqlNullValueException se)
{
// Handle SqlNullValue exception
}
catch (Exception ex)
{
// Handle the default exception
}
finally
{
// Complete the task if it fails or not
}