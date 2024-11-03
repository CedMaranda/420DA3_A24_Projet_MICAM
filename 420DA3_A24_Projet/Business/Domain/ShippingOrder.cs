using _420DA3_A24_Projet.Business.Domain.Pivots;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class ShippingOrder {

    public int Id { get; set; }
    public int SourceClientId { get; set; }
    public int CreatorEmployeeId { get; set; }
    public int DestinationAddressId { get; set; }
    public int? FulfillerEmployeeId { get; set; }
    public virtual Client SourceClient { get; set; } = null!;
    public virtual User CreatorEmployee { get; set; } = null!;
    public virtual Address DestinationAddress { get; set; } = null!;
    public virtual User? FulfillerEmployee { get; set; }
    public virtual Shipment? Shipment { get; set; }
    public virtual List<ShippingOrderProduct> Products { get; set; } = new List<ShippingOrderProduct>();
}
