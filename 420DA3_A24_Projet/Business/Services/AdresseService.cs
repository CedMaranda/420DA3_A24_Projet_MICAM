using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class AdresseService {

    private readonly AdresseDAO adresseDAO;

    public AdresseService(AdresseDAO adresseDAO) {
        this.adresseDAO = adresseDAO;
    }

    // Récupérer toutes les adresses
    public List<Adresse> GetAllAdresses(bool includeDeleted = false) {
        return adresseDAO.GetAll(includeDeleted);
    }

    // Récupérer une adresse par ID
    public Adresse? GetAdresseById(int id, bool includeDeleted = false) {
        return adresseDAO.GetById(id, includeDeleted);
    }

    // Rechercher des adresses
    public List<Adresse> SearchAdresses(string filter) {
        return adresseDAO.Search(filter);
    }

    // Créer une nouvelle adresse
    public Adresse CreateAdresse(Adresse adresse) {
        ValidateAdresse(adresse);

        return adresseDAO.Create(adresse);
    }

    // Mettre à jour une adresse existante
    public Adresse UpdateAdresse(Adresse adresse) {
        ValidateAdresse(adresse);

        var existingAdresse = adresseDAO.GetById(adresse.Id);
        if (existingAdresse == null) {
            throw new KeyNotFoundException("Adresse not found.");
        }

        return adresseDAO.Update(adresse);
    }

    // Supprimer une adresse
    public void DeleteAdresse(int id, bool softDelete = true) {
        var adresse = adresseDAO.GetById(id);
        if (adresse == null) {
            throw new KeyNotFoundException("Adresse not found.");
        }

        adresseDAO.Delete(adresse, softDelete);
    }

    // Valider une adresse
    private void ValidateAdresse(Adresse adresse) {
        if (!adresse.ValidateCivicNumber(adresse.CivicNumber)) {
            throw new ArgumentException("Invalid Civic Number.");
        }
        if (!adresse.ValidateStreet(adresse.Street)) {
            throw new ArgumentException("Invalid Street.");
        }
        if (!adresse.ValidateCity(adresse.City)) {
            throw new ArgumentException("Invalid City.");
        }
        if (!adresse.ValidateState(adresse.State)) {
            throw new ArgumentException("Invalid State.");
        }
        if (!adresse.ValidateCountry(adresse.Country)) {
            throw new ArgumentException("Invalid Country.");
        }
        if (!adresse.ValidatePostalCode(adresse.PostalCode)) {
            throw new ArgumentException("Invalid Postal Code.");
        }
    }
}