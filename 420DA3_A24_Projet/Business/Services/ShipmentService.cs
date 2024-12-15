using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class ShipmentService {

    private readonly ShipmentDAO dao;
    private readonly ShipmentView view;

    public ShipmentService(WsysApplication application, WsysDbContext context) {
        this.dao = new ShipmentDAO(context);
        this.view = new ShipmentView(application);
    }



    public Shipment? OpenViewForCreation(ShippingOrder order) {
        Shipment shipment = (Shipment) FormatterServices.GetUninitializedObject(typeof(Shipment));
        shipment.ShippingOrder = order;
        DialogResult result = this.view.OpenForCreation(shipment);
        return result == DialogResult.OK ? shipment : null;
    }

    public Shipment OpenViewForDetailsView(Shipment shipment) {
        throw new NotImplementedException("Shipment view not implemented.");
    }

    public Shipment OpenViewForModification(Shipment shipment) {
        throw new NotImplementedException("Shipment view not implemented.");
    }

    public Shipment OpenViewForDeletion(Shipment shipment) {
        throw new NotImplementedException("Shipment view not implemented.");
    }

    public List<Shipment> GetAll(bool includeDeleted = false) {
        return this.dao.GetAll(includeDeleted);
    }

    public Shipment? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    public List<Shipment> Search(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    public Shipment? Create(Shipment shipment) {
        return this.dao.Create(shipment);
    }

    public Shipment Update(Shipment shipment) {
        return this.dao.Update(shipment);
    }

    public Shipment Delete(Shipment shipment, bool softDeletes = true) {
        return this.dao.Delete(shipment, softDeletes);
    }
}
