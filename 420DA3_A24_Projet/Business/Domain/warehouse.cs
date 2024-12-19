using System;
using System.Collections.Generic;

namespace _420DA3_A24_Projet.Business.Domain;

/// <summary>
/// Classe représentant un entrepôt dans l'application.
/// </summary>
public class Warehouse {
    /// <summary>
    /// Longueur maximale du nom de l'entrepôt.
    /// </summary>
    public const int NameMaxLength = 128;

    private string name = null!;

    /// <summary>
    /// Identifiant unique de l'entrepôt.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nom de l'entrepôt.
    /// </summary>
    public string Name { 
        get { return this.name; } 
        set {
            if (!ValidateName(value)) {
                throw new ArgumentOutOfRangeException(nameof(this.Name), $"Name length must not exceed {NameMaxLength} characters.");
            }
            this.name = value;
        }
    }

    /// <summary>
    /// Identifiant de l'adresse associée à l'entrepôt.
    /// </summary>
    public int AddressId { get; set; }

    /// <summary>
    /// Date de création de l'entrepôt.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Date de dernière modification.
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Date de suppression de l'entrepôt.
    /// </summary>
    public DateTime? DateDeleted { get; set; }

    /// <summary>
    /// Numéro de version pour la gestion de la concurrence.
    /// </summary>
    public byte[] RowVersion { get; set; } = null!;

    /// <summary>
    /// Adresse associée à l'entrepôt.
    /// </summary>
    public virtual Adresse Address { get; set; } = null!;

    /// <summary>
    /// Liste des employés assignés à cet entrepôt.
    /// </summary>
    public virtual List<User> WarehouseEmployees { get; set; } = new List<User>();

    /// <summary>
    /// Liste des ordres de restockage de cet entrepôt.
    /// </summary>
    public virtual List<PurchaseOrder> RestockOrders { get; set; } = new List<PurchaseOrder>();

    /// <summary>
    /// Liste des clients attitrés à cet entrepôt.
    /// </summary>
    public virtual List<Client> WarehouseClients { get; set; } = new List<Client>();





    /// <summary>
    /// Constructeur pour créer un entrepôt.
    /// </summary>
    /// <param name="name">Le nom de l'entrepôt.</param>
    /// <param name="addressId">L'identifiant de l'adresse associée.</param>
    public Warehouse(string name, int addressId) {
        this.Name = name;
        this.AddressId = addressId;
    }


    /// <summary>
    /// Constructeur orienté EF Core.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="addressId"></param>
    /// <param name="dateCreated"></param>
    /// <param name="dateModified"></param>
    /// <param name="dateDeleted"></param>
    /// <param name="rowVersion"></param>
    public Warehouse(
        int id, 
        string name, 
        int addressId, 
        DateTime dateCreated, 
        DateTime? dateModified, 
        DateTime? dateDeleted, 
        byte[] rowVersion) : this(name, addressId) {

        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }



    /// <summary>
    /// Méthode de validation du nom de l'entrepôt.
    /// </summary>
    /// <param name="name">Nom à valider.</param>
    /// <returns>Vrai si le nom est valide, sinon faux.</returns>
    public static bool ValidateName(string name) {
        return !string.IsNullOrEmpty(name) && name.Length <= NameMaxLength;
    }

    /// <summary>
    /// Surcharge de la méthode ToString().
    /// </summary>
    /// <returns>Une chaîne de caractères décrivant l'entrepôt.</returns>
    public override string ToString() {
        return $"#{this.Id} - {this.Name}";
    }
}