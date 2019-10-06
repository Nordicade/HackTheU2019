using System;
using MongoDB.Driver;
using System.Threading.Tasks;

public class MongoDB
{
    //This is the default constructor
	public MongoDB()
	{
        var connectionString = "mongodb + srv://Test_Admin:<drowssap>@hacktheu-htus5.gcp.mongodb.net/admin?retryWrites=true&w=majority";
        var client = new MongoClient(connectionString);
    }
}
