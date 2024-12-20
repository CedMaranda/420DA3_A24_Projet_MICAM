﻿using Project_Utilities.Enums;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Projet.Business.Domain;


/// <summary>
/// Classe représentant un ordre de restockage.
/// </summary>
public class PurchaseOrder {

    private int quantity;

    public int Id { get; set; }
    public PurchaseOrderStatusEnum Status { get; set; }
    public int Quantity {
        get { return this.quantity; }
        set {
            if (!this.ValidateQuantity(value)) {
                throw new ArgumentOutOfRangeException("Quantity", "Quantity must be greater than or equal to 1.");
            }
            this.quantity = value;
        }
    }
    public int OrderedProductId { get; set; }
    public int DestinationWarehouseId { get; set; }
    public DateTime? CompletionDate { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    public byte[] RowVersion { get; set; } = null!;


    public virtual Product OrderedProduct { get; set; } = null!;
    public virtual Warehouse DestinationWarehouse { get; set; } = null!;


    /// <summary>
    /// Constructeur orienté création manuelle.
    /// NOTE: Statut par défaut: "New".
    /// </summary>
    /// <param name="orderedProductId">L'identifiant du produit de l'ordre de restockage.</param>
    /// <param name="destinationWarehouseId">L'identifiant de l'entrepôt de destination de l'ordre de restockage.</param>
    /// <param name="quantity">La quantité du produit de l'ordre de restockage.</param>
    public PurchaseOrder(int orderedProductId, int destinationWarehouseId, int quantity) {
        this.OrderedProductId = orderedProductId;
        this.DestinationWarehouseId = destinationWarehouseId;
        this.Quantity = quantity;
        this.Status = PurchaseOrderStatusEnum.New;
    }


    /// <summary>
    /// Constructeur orienté entity framework.
    /// </summary>
    /// <param name="id">L'identifiant de l'ordre de restockage.</param>
    /// <param name="status">Le statut de l'ordre de restockage.</param>
    /// <param name="orderedProductId">L'identifiant du produit de l'ordre de restockage.</param>
    /// <param name="destinationWarehouseId">L'identifiant de l'entrepôt de destination de l'ordre de restockage.</param>
    /// <param name="quantity">La quantité du produit de l'ordre de restockage.</param>
    /// <param name="completionDate">La date de complétion (réception par l'entrepôt) de l'ordre de restockage.</param>
    /// <param name="dateCreated">La date de création de l'ordre de restockage.</param>
    /// <param name="dateModified">La date de dernière modification de l'ordre de restockage.</param>
    /// <param name="dateDeleted">La date de suppression de l'ordre de restockage.</param>
    /// <param name="rowVersion">Le numéro de version anti-concurrence de l'entrée dans la base de donnée.</param>
    protected PurchaseOrder(int id,
        PurchaseOrderStatusEnum status,
        int orderedProductId,
        int destinationWarehouseId,
        int quantity,
        DateTime? completionDate,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted,
        byte[] rowVersion)
        : this(orderedProductId, destinationWarehouseId, quantity) {

        this.Id = id;
        this.Status = status;
        this.CompletionDate = completionDate;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
        this.RowVersion = rowVersion;
    }

    /// <summary>
    /// Marks the <see cref="PurchaseOrder"/> as completed.
    /// </summary>
    /// <remarks>
    /// Its <see cref="Status">status</see> will be set to <see cref="PurchaseOrderStatusEnum.Completed"/>,
    /// its <see cref="CompletionDate">completion date</see> will be set to <see cref="DateTime.Now"/> and
    /// the <see cref="Produit.qteStock">quantity in stock</see> of its 
    /// <see cref="OrderedProduct">ordered product</see> will be incremented by the order's
    /// <see cref="Quantity">quantity</see>.
    /// </remarks>
    public void MarkCompleted() {
        if (this.Status == PurchaseOrderStatusEnum.Completed) {
            throw new ValidationException("Purchase order is already completed.");
        }
        this.OrderedProduct.ProductQuantity += this.Quantity;
        this.CompletionDate = DateTime.Now;
        this.Status = PurchaseOrderStatusEnum.Completed;
    }

    /// <summary>
    /// Validates that the <see cref="PurchaseOrder"/>'s <see cref="Quantity"/> is greater or equals to 1.
    /// </summary>
    /// <param name="quantity"></param>
    /// <returns></returns>
    public bool ValidateQuantity(int quantity) {
        return quantity >= 1;
    }

    public override string ToString() {
        return $"#{this.Id} ({this.Status}) - {this.Quantity} x {this.OrderedProduct.ProductName} - Destination: {this.DestinationWarehouse.Name}";
    }
}
