using WebApplicationProject27July.Context;
using WebApplicationProject27July.Models;

namespace WebApplicationProject27July.Repository
{
    public class SqlClientRepository : IClientRepositorycs
    {
        private readonly ClientDbContext _clientDbContext;

        public SqlClientRepository(ClientDbContext clientDbContext) {
        _clientDbContext=clientDbContext;
        }
        void IClientRepositorycs.AddClientDetails(Client clnt)
        {
            _clientDbContext.Client.Add(clnt);
            _clientDbContext.SaveChanges();
        }

        void IClientRepositorycs.DeleteClientDetails(int id)
        {
            var clnt = _clientDbContext.Client.First(x => x.ClientId == id);
            _clientDbContext.Client.Remove(clnt);
            _clientDbContext.SaveChanges();
        }

        Client IClientRepositorycs.GetClientById(int id)
        {
            var clnt = _clientDbContext.Client.First(x => x.ClientId == id);
            return clnt;
        }

        List<Client> IClientRepositorycs.GetClients()
        {
            return _clientDbContext.Client.ToList();
        }

        void IClientRepositorycs.UpdateClient(Client clnt)
        {
            var clnts = _clientDbContext.Client.First(x => x.ClientId == clnt.ClientId);
            clnts.CName = clnt.CName;
            clnts.ContractAmt = clnt.ContractAmt;
            clnts.ContractDurationYrs = clnt.ContractDurationYrs;
            clnts.Country = clnt.Country;
            _clientDbContext.Client.Update(clnt);
            _clientDbContext.SaveChanges();
        }
    }
}
