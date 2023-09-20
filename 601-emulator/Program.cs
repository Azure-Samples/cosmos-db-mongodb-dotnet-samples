// <imports>
using System.Runtime.CompilerServices;
using MongoDB.Driver;
// </imports>

// <client>
var client = new MongoClient(
    "mongodb://localhost:C2y6yDjf5%2FR%2Bob0N8A7Cgv30VRDJIWEHLM%2B4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw%2FJw%3D%3D@localhost:10255/admin?ssl=true&retrywrites=false"
);
// </client>

// <resources>
var database = client.GetDatabase("cosmicworks");

var collection = database.GetCollection<dynamic>("products");
// </resources>

// <upsert>
var item = new
{
    name = "Kiama classic surfboard"
};

await collection.InsertOneAsync(item);
// </upsert>
