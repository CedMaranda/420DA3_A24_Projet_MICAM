using _420DA3_A24_Projet.Business.Domain.Pivots;

namespace _420DA3_A24_Projet.Business.Domain;
public class Product {
    public const int PRODUCT_NAME_MAX_LENGTH = 64;
    public const int PRODUCT_DESCRIPTION_MAX_LENGTH = 255;
    public const int PRODUCT_UPC_CODE_MAX_LENGTH = 50;
    public const int PRODUCT_SUPPLIER_CODE_MAX_LENGTH = 25;
    public const int PRODUCT_IMAGE_FILE_NAME_MAX_LENGTH = 50;

    private int id;
    private string productName = null!;



    public int Id {
        get { return this.id; }
        set {
            if (!ValidateId(value)) {
                throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
            }
            this.id = value;
        }
    }
    public int OwnerClientId { get; set; }
    public int SupplierId { get; set; }
    public string ProductName {
        get { return this.productName; }
        set {
            if (!ValidateProductName(value)) {
                throw new ArgumentOutOfRangeException("ProductName", $"ProductName length must be lower than or equal to {PRODUCT_NAME_MAX_LENGTH} characters.");
            }
            this.productName = value;
        }
    }
    public string ProductDescription {
        // TODO @PAULIN : Ici, il y a une erreur: il faut utiliser un backing field
        // au lieu de la propriété dans le get et set comme vous avez fait pour ProductName / productName
        get { return this.ProductDescription; }
        set {
            if (!ValidateProductDescription(value)) {
                throw new ArgumentOutOfRangeException("ProductDescription", $"ProductDescription length must be lower than or equal to {PRODUCT_DESCRIPTION_MAX_LENGTH} characters.");
            }
            this.ProductDescription = value;
        }
    }
    public string UPCCode {
        get { return this.UPCCode; }
        set {
            if (!ValidateUPCCode(value)) {
                throw new ArgumentOutOfRangeException("UPCCode", $"UPCCode length must be lower than or equal to {PRODUCT_UPC_CODE_MAX_LENGTH} characters.");
            }
            this.UPCCode = value;
        }
    }
    public string ProductSupplierCode {
        get { return this.ProductSupplierCode; }
        set {
            if (!ValidateProductSupplierCode(value)) {
                throw new ArgumentOutOfRangeException("ProductSupplierCode", $"ProductSupplierCode length must be lower than or equal to {PRODUCT_SUPPLIER_CODE_MAX_LENGTH} characters.");
            }
            this.ProductSupplierCode = value;
        }
    }
    public string ProductImageFileName {
        get { return this.ProductImageFileName; }
        set {
            if (!ValidateProductImageFileName(value)) {
                throw new ArgumentOutOfRangeException("ProductImageFileName", $"ProductImageFileName length must be lower than or equal to {PRODUCT_IMAGE_FILE_NAME_MAX_LENGTH} characters.");
            }
            this.ProductImageFileName = value;
        }
    }
    public int ProductQuantity { get; set; }
    public int ProductQuantityTargeted { get; set; }
    public float ProductWeight { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public DateTime? DateModified { get; set; }
    public byte[] RowVersion { get; set; } = null!;


    public virtual Client OwnerClient { get; set; }
    public virtual Supplier Supplier { get; set; }
    public virtual List<ShippingOrderProduct> ShippingOrderProducts { get; set; } = new List<ShippingOrderProduct>();
    public virtual List<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public Product(string productName, string productDescription) {
        this.productName = productName;
        this.ProductDescription = productDescription;
    }

    protected Product(int id,
        string productName,
        string productDescription,
        string UPCCode,
        string procutSupplierCode,
        string productImageFileName,
        int productQuantity,
        int productQuantityTargeted,
        int clientId,
        int supplierId,
        DateTime dateCreated,
        DateTime? dateModified,
        DateTime? dateDeleted)
        : this(productName, productDescription) {
        this.Id = id;
        this.DateCreated = dateCreated;
        this.DateModified = dateModified;
        this.DateDeleted = dateDeleted;
    }

    public static bool ValidateId(int id) {
        return id >= 0;
    }

    public static bool ValidateProductName(string name) {
        return name.Length <= PRODUCT_NAME_MAX_LENGTH;
    }

    public static bool ValidateProductDescription(string lastName) {
        return lastName.Length <= PRODUCT_DESCRIPTION_MAX_LENGTH;
    }

    public static bool ValidateUPCCode(string firstName) {
        return firstName.Length <= PRODUCT_UPC_CODE_MAX_LENGTH;
    }

    public static bool ValidateProductSupplierCode(string email) {
        return email.Length <= PRODUCT_SUPPLIER_CODE_MAX_LENGTH;
    }

    public static bool ValidateProductImageFileName(string phone) {
        return phone.Length <= PRODUCT_IMAGE_FILE_NAME_MAX_LENGTH;
    }
}
