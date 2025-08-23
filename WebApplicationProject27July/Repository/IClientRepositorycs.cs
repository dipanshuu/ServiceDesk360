using WebApplicationProject27July.Models;

namespace WebApplicationProject27July.Repository
{
    public interface IClientRepositorycs
    {
        List<Client> GetClients();
        Client GetClientById(int id);
        void AddClientDetails(Client clnt);
        void UpdateClient(Client clnt);
        void DeleteClientDetails(int id);
    }
}
