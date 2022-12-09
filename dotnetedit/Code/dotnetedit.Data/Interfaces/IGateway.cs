using MongoDB.Driver;

namespace dotnetedit.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
