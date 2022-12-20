using WebApplication1.Models;

namespace Notifications.Data
{
    public interface IDatabase
    {
        void InsertBuyer(Buyer buyer);
        void UpdatetBuyer(Buyer buyer);
        void InsertProperty(Property property);
        void UpdatetProperty(Property property);
    }
}
