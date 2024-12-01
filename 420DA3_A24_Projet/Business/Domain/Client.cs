using _420DA3_A24_Projet.Business.Domain;
using System;


public class Client
{
   
   public const int ClientNameMaxLength = 128;
   public const int ContactFirstNameMaxLength = 32;
   public const int ContactLastNameMaxLength = 32;
   public const int ContactEmailMaxLength = 128;
   public const int ContactTelephoneMaxLength = 15;

        
   public int Id { get; set; }
   public string ClientName { get; set; }
   public int WarehouseId { get; set; }
   public string ContactFirstName { get; set; }
   public string ContactLastName { get; set; }
   public string ContactEmail { get; set; }
   public string ContactTelephone { get; set; }
   public DateTime DateCreated { get; set; }
   public DateTime? DateModified { get; set; }
   public DateTime? DateDeleted { get; set; }

        
   public virtual Warehouse AssignedWarehouse { get; set; }
   public virtual List<Product> Products { get; set; } = new List<Product>();
   public virtual List<ShippingOrder> ShippingOrders { get; set; } = new List<ShippingOrder>();

        
   public Client(string clientName, string contactFirstName, string contactLastName, string contactEmail, string contactTelephone, int warehouseId)
   {
      ClientName = clientName;
      ContactFirstName = contactFirstName;
      ContactLastName = contactLastName;
      ContactEmail = contactEmail;
      ContactTelephone = contactTelephone;
      WarehouseId = warehouseId;
      DateCreated = DateTime.Now;
   }

        
    public bool ValidateClientName(string clientName) =>
     !string.IsNullOrEmpty(clientName) && clientName.Length <= ClientNameMaxLength;

    public bool ValidateContactFirstName(string firstName) =>
     !string.IsNullOrEmpty(firstName) && firstName.Length <= ContactFirstNameMaxLength;

    public bool ValidateContactLastName(string lastName) =>
     !string.IsNullOrEmpty(lastName) && lastName.Length <= ContactLastNameMaxLength;

    public bool ValidateContactEmail(string email) =>
     !string.IsNullOrEmpty(email) && email.Length <= ContactEmailMaxLength;

    public bool ValidateContactTelephone(string telephone) =>
     !string.IsNullOrEmpty(telephone) && telephone.Length <= ContactTelephoneMaxLength;

    public override string ToString()
    {
      return $"#{Id} - {ClientName}, Contact: {ContactFirstName} {ContactLastName}";
    }
    
}
