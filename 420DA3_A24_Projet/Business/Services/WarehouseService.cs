using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.Business.Services;
internal class WarehouseService {

    private WsysApplication parentApp;
    private WarehouseDAO dao;
    private WarehouseView view;

    public WarehouseService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.dao = new WarehouseDAO(context);
        this.view = new WarehouseView(this.parentApp);
    }

    public Warehouse? OpenViewForCreation() {
        throw new NotImplementedException("Warehouse view not implemented.");
    }

    public Warehouse OpenViewForDetailsView(Warehouse warehouse) {
        throw new NotImplementedException("Warehouse view not implemented.");
    }

    public Warehouse OpenViewForModification(Warehouse warehouse) {
        throw new NotImplementedException("Warehouse view not implemented.");
    }

    public Warehouse OpenViewForDeletion(Warehouse warehouse) {
        throw new NotImplementedException("Warehouse view not implemented.");
    }



    public List<Warehouse> GetAll(bool includeDeleted = false) {
        return this.dao.GetAll(includeDeleted);
    }

    public Warehouse? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    public List<Warehouse> Search(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    public Warehouse? Create(Warehouse warehouse) {
        return this.dao.Create(warehouse);
    }

    public Warehouse Update(Warehouse warehouse) {
        return this.dao.Update(warehouse);
    }

    public Warehouse Delete(Warehouse warehouse, bool softDeletes = true) {
        return this.dao.Delete(warehouse, softDeletes);
    }
}
