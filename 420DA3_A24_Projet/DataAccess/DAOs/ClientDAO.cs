using System;


public class ClientDAO
{

        public ClientDAO(ExempleDbContext context) {
            this.context = context;
        }
        public List<Client> GetAll(bool includeDeleted = false) {
            return includeDeleted
                ? this.context.Clients.ToList()
                : this.context.Clients.Where(client => client.DateDeleted == null).ToList();
        }
        public Client? GetById(int id, bool includeDeleted = false) {
            return includeDeleted
                ? this.context.Clients.FirstOrDefault(client => client.Id == id)
                : this.context.Clients.FirstOrDefault(client => client.Id == id && client.DateDeleted == null);
        }

        public List<Client> Search(string filter) {
            return this.context.Clients.Where(client =>
                (client.ClientName.Contains(filter) || client.ContactFirstName.Contains(filter) || client.ContactLastName.Contains(filter))
                && client.DateDeleted == null
            ).ToList();
        }
        public Client Create(Client client) {
            client.DateCreated = DateTime.Now;
            _ = this.context.Clients.Add(client);
            _ = this.context.SaveChanges();
            return client;
        }
        public Client Update(Client client) {
            client.DateModified = DateTime.Now;
            _ = this.context.Clients.Update(client);
            _ = this.context.SaveChanges();
            return client;
        }
        public void Delete(Client client, bool softDeletes = true) {
            if (softDeletes) {
                client.DateDeleted = DateTime.Now;
                _ = this.context.Clients.Update(client);
            } else {
                _ = this.context.Clients.Remove(client);
            }
            _ = this.context.SaveChanges();
        }
    
}
