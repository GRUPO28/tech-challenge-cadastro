using MongoDB.Bson.Serialization.Conventions;

namespace Cadastro.Infrastructure.Repositories.Persistence;

public class MongoDBRegistror
{
    public static void RegisterDocumentResolver()
    {
        var pack = new ConventionPack
        {
            new CamelCaseElementNameConvention(),
        };

        ConventionRegistry.Register("Camel Case", pack, t => t.FullName.Contains(".MongoDB.Models"));
    }
}
