using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class ShipmentDAO {
    private WsysDbContext context;

    public ShipmentDAO(WsysDbContext context) {
        this.context = context;
    }

    public List<Shipment> GetAll(bool includeDeleted = false) {
        return this.context.Shipments
            .Include(shipment => shipment.ShippingOrder)
            .Where(shipment => includeDeleted || shipment.DateDeleted == null)
            .ToList();
    }

    public Shipment? GetById(int id, bool includeDeleted = false) {
        return this.context.Shipments
            .Include(shipment => shipment.ShippingOrder)
            .Where(shipment => shipment.Id == id && (includeDeleted || shipment.DateDeleted == null))
            .SingleOrDefault();
    }

    public Shipment? GetByShippingOrderId(int shippingOrderId, bool includeDeleted = false) {
        return this.context.Shipments
            .Include(shipment => shipment.ShippingOrder)
            .Where(shipment => shipment.ShippingOrderId == shippingOrderId && (includeDeleted || shipment.DateDeleted == null))
            .SingleOrDefault();
    }

    public List<Shipment> Search(string criterion, bool includeDeleted = false) {
        return this.context.Shipments
            .Include(shipment => shipment.ShippingOrder)
            .Where(shipment => (
                shipment.Id.ToString().Contains(criterion)
                || shipment.TrackingNumber.Contains(criterion)
                || shipment.ShippingOrder.Id.ToString().Contains(criterion)
                || shipment.ShippingOrder.SourceClient.ClientName.Contains(criterion)
                && (includeDeleted || shipment.DateDeleted == null))
            )
            .ToList();
    }

    public Shipment? Create(Shipment shipment) {
        _ = this.context.Shipments.Add(shipment);
        _ = this.context.SaveChanges();
        return shipment;
    }

    public Shipment Update(Shipment shipment) {
        shipment.DateModified = DateTime.Now;
        _ = this.context.Shipments.Update(shipment);
        _ = this.context.SaveChanges();
        return shipment;
    }

    public Shipment Delete(Shipment shipment, bool softDeletes = true) {
        if (softDeletes) {
            shipment.DateDeleted = DateTime.Now;
            _ = this.context.Shipments.Update(shipment);
        } else {
            _ = this.context.Shipments.Remove(shipment);
        }
        _ = this.context.SaveChanges();
        return shipment;
    }
}
