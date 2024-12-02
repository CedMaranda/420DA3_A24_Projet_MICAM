using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;

public class Adresse {

    public const int AdresseeMaxLength = 64;
    public const int CivicNumberMaxLength = 6;
    public const int StreetMaxLength = 128;
    public const int CityMaxLength = 64;
    public const int StateMaxLength = 64;
    public const int CountryMaxLength = 64;
    public const int PostalCodeMaxLength = 12;

    public int Id { get; set; }
    public AddressTypesEnum AddressType { get; set; }

    // TODO @CÉDRICK: Utiliser vos méthodes de validation
    // pour valider les valeurs lors du 'set' des propriétés textuelles
    public string Adressee { get; set; }
    public string CivicNumber { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public DateTime? DateModified { get; set; }
    // TODO @CÉDRICK: Ajouter une propriété anti-concurrence 'RowVersion' de type byte[]

    public virtual Warehouse? OwnerWarehouse { get; set; }
    public virtual ShippingOrder? OwnerShipOrder { get; set; }

    public Adresse(string adressee, string civicNumber, string street, string city, string state, string country, string postalCode, AddressTypesEnum addressType) {
        Adressee = adressee;
        CivicNumber = civicNumber;
        Street = street;
        City = city;
        State = state;
        Country = country;
        PostalCode = postalCode;
        AddressType = addressType;
    }

    // TODO @CÉDRICK: Ajouter un autre constructeur
    // pour EF Core (avec des paramètres pour TOUTES les propriétés de données

    public bool ValidateCivicNumber(string civicNumber) =>
        !string.IsNullOrEmpty(civicNumber) && civicNumber.Length <= CivicNumberMaxLength;

    public bool ValidateStreet(string street) =>
        !string.IsNullOrEmpty(street) && street.Length <= StreetMaxLength;

    public bool ValidateCity(string city) =>
        !string.IsNullOrEmpty(city) && city.Length <= CityMaxLength;

    public bool ValidateState(string state) =>
        !string.IsNullOrEmpty(state) && state.Length <= StateMaxLength;

    public bool ValidateCountry(string country) =>
        !string.IsNullOrEmpty(country) && country.Length <= CountryMaxLength;

    public bool ValidatePostalCode(string postalCode) =>
        !string.IsNullOrEmpty(postalCode) && postalCode.Length <= PostalCodeMaxLength;


    public override string ToString() {
        return $"#{Id} [{Enum.GetName<AddressTypesEnum>(AddressType)}] {Adressee}, {CivicNumber} {Street}, {City}, {State}, {Country}, {PostalCode}";
    }
}
