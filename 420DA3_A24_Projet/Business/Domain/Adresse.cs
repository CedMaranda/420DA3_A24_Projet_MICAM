using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using System;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Classe représentant une adresse avec des informations détaillées telles que le destinataire,
/// le numéro civique, la rue, la ville, l'état, le pays et le code postal. 
/// Fournit des propriétés pour valider les données et des constructeurs pour initialiser l'objet.
/// Inclut également des métadonnées telles que les dates de création, de modification et de suppression.
/// </summary>

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

    private string _addressee;
    private string _civicNumber;
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _postalCode;

    public string Addressee {
        get => _addressee;
        set {
            if (string.IsNullOrEmpty(value) || value.Length > AdresseeMaxLength)
                throw new ArgumentException($"Invalid Addressee. Maximum length is {AdresseeMaxLength}.");
            _addressee = value;
        }
    }

    public string CivicNumber {
        get => _civicNumber;
        set {
            if (!ValidateCivicNumber(value))
                throw new ArgumentException($"Invalid Civic Number. Maximum length is {CivicNumberMaxLength}.");
            _civicNumber = value;
        }
    }

    public string Street {
        get => _street;
        set {
            if (!ValidateStreet(value))
                throw new ArgumentException($"Invalid Street. Maximum length is {StreetMaxLength}.");
            _street = value;
        }
    }

    public string City {
        get => _city;
        set {
            if (!ValidateCity(value))
                throw new ArgumentException($"Invalid City. Maximum length is {CityMaxLength}.");
            _city = value;
        }
    }

    public string State {
        get => _state;
        set {
            if (!ValidateState(value))
                throw new ArgumentException($"Invalid State. Maximum length is {StateMaxLength}.");
            _state = value;
        }
    }

    public string Country {
        get => _country;
        set {
            if (!ValidateCountry(value))
                throw new ArgumentException($"Invalid Country. Maximum length is {CountryMaxLength}.");
            _country = value;
        }
    }

    public string PostalCode {
        get => _postalCode;
        set {
            if (!ValidatePostalCode(value))
                throw new ArgumentException($"Invalid Postal Code. Maximum length is {PostalCodeMaxLength}.");
            _postalCode = value;
        }
    }

    public DateTime DateCreated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public DateTime? DateModified { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; }

    public virtual Warehouse? OwnerWarehouse { get; set; }
    public virtual ShippingOrder? OwnerShipOrder { get; set; }

    public Adresse(string addressee, string civicNumber, string street, string city, string state, string country, string postalCode, AddressTypesEnum addressType) {
        Addressee = addressee;
        CivicNumber = civicNumber;
        Street = street;
        City = city;
        State = state;
        Country = country;
        PostalCode = postalCode;
        AddressType = addressType;
        DateCreated = DateTime.Now;
    }

    public Adresse(int id, string addressee, string civicNumber, string street, string city, string state, string country, string postalCode,
                   AddressTypesEnum addressType, DateTime dateCreated, DateTime? dateDeleted, DateTime? dateModified, byte[] rowVersion) {
        Id = id;
        Addressee = addressee;
        CivicNumber = civicNumber;
        Street = street;
        City = city;
        State = state;
        Country = country;
        PostalCode = postalCode;
        AddressType = addressType;
        DateCreated = dateCreated;
        DateDeleted = dateDeleted;
        DateModified = dateModified;
        RowVersion = rowVersion;
    }

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

        return $"#{Id} [{Enum.GetName<AddressTypesEnum>(AddressType)}] {Addressee}, {CivicNumber} {Street}, {City}, {State}, {Country}, {PostalCode}";
    }
}

