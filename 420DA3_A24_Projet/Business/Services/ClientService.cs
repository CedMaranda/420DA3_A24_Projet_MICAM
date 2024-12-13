using System;


public class ClientService
{
    private readonly ClientDAO clientDAO;

    public ClientService(ClientDAO clientDAO) {
        this.clientDAO = clientDAO;
    }

    // Récupérer tous les clients
    public List<Client> GetAllClients(bool includeDeleted = false) {
        return clientDAO.GetAll(includeDeleted);
    }

    // Récupérer un client par ID
    public Client? GetClientById(int id, bool includeDeleted = false) {
        return clientDAO.GetById(id, includeDeleted);
    }

    // Rechercher des clients
    public List<Client> SearchClients(string filter) {
        return clientDAO.Search(filter);
    }

    // Créer un nouveau client
    public Client CreateClient(Client client) {
        ValidateClient(client);
        return clientDAO.Create(client);
    }

    // Mettre à jour un client existant
    public Client UpdateClient(Client client) {
        ValidateClient(client);

        var existingClient = clientDAO.GetById(client.Id);
        if (existingClient == null) {
            throw new KeyNotFoundException("Client not found.");
        }

        return clientDAO.Update(client);
    }

    // Supprimer un client
    public void DeleteClient(int id, bool softDelete = true) {
        var client = clientDAO.GetById(id);
        if (client == null) {
            throw new KeyNotFoundException("Client not found.");
        }

        clientDAO.Delete(client, softDelete);
    }

    // Valider un client
    private void ValidateClient(Client client) {
        if (!client.ValidateClientName(client.ClientName)) {
            throw new ArgumentException("Invalid Client Name.");
        }
        if (!client.ValidateContactFirstName(client.ContactFirstName)) {
            throw new ArgumentException("Invalid Contact First Name.");
        }
        if (!client.ValidateContactLastName(client.ContactLastName)) {
            throw new ArgumentException("Invalid Contact Last Name.");
        }
        if (!client.ValidateContactEmail(client.ContactEmail)) {
            throw new ArgumentException("Invalid Contact Email.");
        }
        if (!client.ValidateContactTelephone(client.ContactTelephone)) {
            throw new ArgumentException("Invalid Contact Telephone.");
        }
    }
}


