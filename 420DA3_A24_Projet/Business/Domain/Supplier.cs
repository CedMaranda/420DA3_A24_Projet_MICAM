using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class Supplier {
    public const int SUPPLIER_NAME_MAX_LENGTH = 64;
    public const int SUPPLIER_CONTACT_FIRSTNAME_MAX_LENGTH = 64;
    public const int SUPPLIER_CONTACT_LASTNAME_MAX_LENGTH = 64;
    public const int SUPPLIER_CONTACT_EMAIL_MAX_LENGTH = 64;
    public const int SUPPLIER_CONTACT_PHONE_MAX_LENGTH = 10;
    public const int SUPPLIER_PRODUCT_CODE_MAX_LENGTH = 64;

    private int id;
    private string supplierName = null!;
    //private string description = null!;

    public int Id {
        get { return this.id; }
        set {
            if (!ValidateId(value)) {
                throw new ArgumentOutOfRangeException("Id", "Id must be greater than or equal to 0.");
            }
            this.id = value;
        }
    }
    public string SupplierName {
        get { return this.supplierName; }
        set {
            if (!ValidateSupplierName(value)) {
                throw new ArgumentOutOfRangeException("Name", $"Name length must be lower than or equal to {SUPPLIER_NAME_MAX_LENGTH} characters.");
            }
            this.supplierName = value;
        }
    }

    //public int Id { get; set; }
    //public string SupplierName { get; set; }ê
    public string SupplierContactLastName {
        get { return this.SupplierContactLastName; }
        set {
            if (!ValidateContactLastName(value)) {
                throw new ArgumentOutOfRangeException("Name", $"Name length must be lower than or equal to {SUPPLIER_CONTACT_LASTNAME_MAX_LENGTH} characters.");
            }
            this.SupplierContactLastName = value;
        }
    }
    public string SupplierContactFirstname {
        get { return this.SupplierContactFirstName; }
        set {
            if (!ValidateContactFirstName(value)) {
                throw new ArgumentOutOfRangeException("Name", $"Name length must be lower than or equal to {SUPPLIER_CONTACT_LASTNAME_MAX_LENGTH} characters.");
            }
            this.SupplierContactLastName = value;
        }
    }
    public string SupplierContactEmail { get; set; }
    public string SupplierContactPhone { get; set; }
    public string ProductCodeSupplier { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateDeleted { get; set; }
    public DateTime? DateModified { get; set; }

    public virtual List<Product> Products { get; set; } = new List<Product>();

    public static bool ValidateId(int id) {
        return id >= 0;
    }

    public static bool ValidateSupplierName(string name) {
        return name.Length <= SUPPLIER_NAME_MAX_LENGTH;
    }

    public static bool ValidateContactLastName(string lastName) {
        return lastName.Length <= SUPPLIER_CONTACT_LASTNAME_MAX_LENGTH;
    }

    public static bool ValidateContactFirstName(string firstName) {
        return firstName.Length <= SUPPLIER_CONTACT_FIRSTNAME_MAX_LENGTH;
    }

    public static bool ValidateContactEmail(string email) {
        return email.Length <= SUPPLIER_CONTACT_EMAIL_MAX_LENGTH;
    }

    public static bool ValidateContactPhone(string phone) {
        return phone.Length <= SUPPLIER_CONTACT_PHONE_MAX_LENGTH;
    }


}
