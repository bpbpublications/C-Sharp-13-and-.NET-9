MyContext>AddDbContext(options = >
options . UseNpgsql ( Configuration . MySQL  GetConnectionString ( "DefaultConnection" ) ) ;
{
    "ConnectionStrings" : 
    {
        "DefaultConnection" : 
        "Server=my_server;Database=my_db;User=my_user;Password=my_pw;"
    }
}