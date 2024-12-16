using System;

/// <summary>
/// Service de gestion des clients. Permet de récupérer, rechercher, 
/// créer, mettre à jour et supprimer des clients tout en validant 
/// les informations fournies.
/// </summary>
public class ClientService {
    private readonly ClientDAO clientDAO;

    public ClientService(ClientDAO clientDAO) {
        this.clientDAO = clientDAO;
    }

    public List<Client> GetAllClients(bool includeDeleted = false) {
        return clientDAO.GetAll(includeDeleted);
    }

   
    public Client? GetClientById(int id, bool includeDeleted = false) {
        return clientDAO.GetById(id, includeDeleted);
    }

   
    public List<Client> SearchClients(string filter) {
        return clientDAO.Search(filter);
    }

    
    public Client CreateClient(Client client) {
        ValidateClient(client);
        return clientDAO.Create(client);
    }

    public Client UpdateClient(Client client) {
        ValidateClient(client);

        Client? existingClient = clientDAO.GetById(client.Id);
        if (existingClient == null) {
            throw new KeyNotFoundException("Client not found.");
        }

        return clientDAO.Update(client);
    }

    
    public void DeleteClient(int id, bool softDelete = true) {
        Client? client = clientDAO.GetById(id);
        if (client == null) {
            throw new KeyNotFoundException("Client not found.");
        }

        clientDAO.Delete(client, softDelete);
    }

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

