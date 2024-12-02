using _420DA3_A24_Projet.Business.Services;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Business.Domain {
    /// <summary>
    /// Classe représentant une expédition dans l'application.
    /// </summary>
    public class Shipment {
        /// <summary>
        /// Longueur maximale du numéro de suivi.
        /// </summary>
        public const int TrackingNumberMaxLength = 64;

        /// <summary>
        /// Identifiant unique de l'expédition.
        /// </summary>
        public int Id { get; set; }

        public ShipmentStatusEnum Status { get; set; }
        public ShippingProvidersEnum ShippingProvider { get; set; }

        /// <summary>
        /// Numéro de suivi de l'expédition.
        /// </summary>
        public string TrackingNumber { get; set; } = null!;

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
        /// <param name="shippingProvider">Le service de livraison utilisé.</param>
        /// <param name="shippingOrderId">L'identifiant de l'ordre d'expédition associé.</param>
        public Shipment(ShippingProvidersEnum shippingProvider, int shippingOrderId) {
            ShippingProvider = shippingProvider;
            ShippingOrderId = shippingOrderId;
            TrackingNumber = TrackingNumberFactory.GetInstance().GetNewTrackingNumber(shippingProvider);
            Status = ShipmentStatusEnum.New;
        }

        // TODO @AYMAN: constructeur pour EF Core avec des paramètres pour toutes les propriétés de données



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
            return $"#{Id} ({Enum.GetName(Status)}) - Shipping Order ID: {ShippingOrder.Id}; Tracking Number: {TrackingNumber} ({Enum.GetName(ShippingProvider)})";
        }
    }
}
