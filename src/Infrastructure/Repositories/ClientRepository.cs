using Domain;
using Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository, IRepository<Client>
    {
        private readonly ApplicationContext _context;
        public ClientRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients;
        }
        public Client Get(int clientId)
        {
            return _context.Clients.SingleOrDefault(c => c.Id == clientId);
        }

        public void Add(Client client)
        {
            _context.Clients.Add(client);
        }

        public void Delete(int clientId)
        {
            _context.Clients.Remove(Get(clientId));
        }

        public void Update(Client client)
        {
            _context.Clients.Update(client);
        }
    }
}
