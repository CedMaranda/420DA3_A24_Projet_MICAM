using _420DA3_A24_Projet.DataAccess.Contexts;
/// <summary>
/// Classe d'accès aux données pour les clients. Fournit des méthodes pour récupérer, 
/// rechercher, créer, mettre à jour et supprimer des enregistrements de clients 
/// dans la base de données. Prend en charge les suppressions logiques et physiques.
/// </summary>

internal class ClientDAO {
    private WsysDbContext context;

    public ClientDAO(WsysDbContext context) {
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
