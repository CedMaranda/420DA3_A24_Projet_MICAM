using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Domain;
public class PurchaseOrder {

    public int Id { get; set; }
    public int OrderedProductId { get; set; }
    public int DestinationWarehouseId { get; set; }
    public Product OrderedProduct { get; set; } = null!;
    public Warehouse DestinationWarehouse { get; set; } = null!;
}
