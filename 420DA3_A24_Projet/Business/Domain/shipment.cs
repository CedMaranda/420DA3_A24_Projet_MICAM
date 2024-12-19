using _420DA3_A24_Projet.Business.Services;
using Project_Utilities.Enums;
using System;

namespace _420DA3_A24_Projet.Business.Domain; 

/// <summary>
/// Classe représentant une expédition dans l'application.
/// </summary>
public class Shipment {
    /// <summary>
    /// Longueur maximale du numéro de suivi.
    /// </summary>
    public const int TrackingNumberMaxLength = 64;

    private string trackingNumber = null!;

    /// <summary>
    /// Identifiant unique de l'expédition.
    /// </summary>
    public int Id { get; set; }

    public ShipmentStatusEnum Status { get; set; }

    public ShippingProvidersEnum ShippingProvider { get; set; }

    /// <summary>
    /// Numéro de suivi de l'expédition.
    /// </summary>
    public string TrackingNumber { 
        get { return this.trackingNumber; }
        set {
            if (!ValidateTrackingNumber(value)) {
                throw new ArgumentOutOfRangeException(nameof(this.TrackingNumber), $"Tracking number must not exceed {TrackingNumberMaxLength} characters.");
            }
            this.trackingNumber = value;
        }
    }

    /// <summary>
    /// Identifiant de l'ordre d'expédition associé.
    /// </summary>
    public int ShippingOrderId { get; set; }

    /// <summary>
    /// Date de création de l'expédition.
    /// </summary>
    public DateTime DateCreated { get; set; }

    /// <summary>
    /// Date de dernière modification.
    /// </summary>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Date de suppression de l'expédition.
    /// </summary>
    public DateTime? DateDeleted { get; set; }

    /// <summary>
    /// Numéro de version pour la gestion de la concurrence.
    /// </summary>
    public byte[] RowVersion { get; set; } = null!;

    /// <summary>
    /// L'ordre d'expédition associé.
    /// </summary>
    public virtual ShippingOrder ShippingOrder { get; set; } = null!;

    /// <summary>
    /// Constructeur pour créer une expédition.
    /// </summary>
    /// <param name="trackingNumber">Le numéro de suivi.</param>
    /// <param name="shippingOrderId">L'identifiant de l'ordre d'expédition associé.</param>
    public Shipment(ShippingProvidersEnum shippingProvider, int shippingOrderId) {
        this.ShippingProvider = shippingProvider;
        this.ShippingOrderId = shippingOrderId;
        this.TrackingNumber = TrackingNumberFactory.GetInstance().GetNewTrackingNumber(shippingProvider);
    }

    /// <summary>
    /// Constructeur orienté EF Core.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="shippingProvider"></param>
    /// <param name="trackingNumber"></param>
    /// <param name="shippingOrderId"></param>
    /// <param name="dateCreated"></param>
    /// <param name="dateModified"></param>
    /// <param name="dateDeleted"></param>
    /// <param name="rowVersion"></param>
    public Shipment(
        int id,
        ShipmentStatusEnum status,
        ShippingProvidersEnum shippingProvider,
        string trackingNumber,
        int shippingOrderId, 
        DateTime dateCreated, 
        DateTime? dateModified, 
        DateTime? dateDeleted, 
        byte[] rowVersion) {

        this.Id = id;
        this.Status = status;
        this.ShippingProvider = shippingProvider;
        this.TrackingNumber = trackingNumber;
        this.ShippingOrderId = shippingOrderId;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    /// <summary>
    /// Méthode de validation du numéro de suivi.
    /// </summary>
    /// <param name="trackingNumber">Numéro de suivi à valider.</param>
    /// <returns>Vrai si le numéro est valide, sinon faux.</returns>
    public static bool ValidateTrackingNumber(string trackingNumber) {
        return !string.IsNullOrEmpty(trackingNumber) && trackingNumber.Length <= TrackingNumberMaxLength;
    }

    /// <summary>
    /// Surcharge de la méthode ToString().
    /// </summary>
    /// <returns>Une chaîne de caractères décrivant l'expédition.</returns>
    public override string ToString() {
        return $"#{this.Id} - Order ID: {this.ShippingOrderId} Tracking Number: {this.TrackingNumber}";
    }
}
