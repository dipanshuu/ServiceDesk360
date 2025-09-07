using WebApplicationProject27July.Models;

namespace WebApplicationProject27July.Repository
{
    public class ClientRepository : IClientRepositorycs
    {
        static List<Client> clients = new List<Client>();
        static ClientRepository()
        {
            clients.Add(new Client() { ClientId = 101, CName = "Dabur", ContractAmt = 125, ContractDurationYrs = 8, Country = "India" });
            clients.Add(new Client() { ClientId = 102, CName = "VAA", ContractAmt = 80, ContractDurationYrs = 10, Country = "United Kingdom" });
            clients.Add(new Client() { ClientId = 103, CName = "Etihad Airways", ContractAmt = 500, ContractDurationYrs = 2, Country = "UAE" });
            clients.Add(new Client() { ClientId = 104, CName = "Delta Airlines", ContractAmt = 300, ContractDurationYrs = 2, Country = "United States" });
        }
        public void AddClientDetails(Client clnt)
        {
            clients.Add(clnt);
        }

        public void DeleteClientDetails(int id)
        {
            var clnt = clients.First(x => x.ClientId == id);
            clients.Remove(clnt);
        }

        public Client GetClientById(int id)
        {
            var clnt = clients.First(x => x.ClientId == id);
            return clnt;
        }

        public List<Client> GetClients()
        {
            return clients;
        }

        public void UpdateClient(Client clnt)
        {
  
        }
    }
}
