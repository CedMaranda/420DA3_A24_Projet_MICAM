using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class WarehouseDAO {
    private WsysDbContext context;

    public WarehouseDAO(WsysDbContext context) {
        this.context = context;
    }

    public List<Warehouse> GetAll(bool includeDeleted = false) {
        return this.context.Warehouses
            .Include(warehouse => warehouse.Address)
            .Where(warehouse => includeDeleted || warehouse.DateDeleted == null)
            .ToList();
    }

    public Warehouse? GetById(int id, bool includeDeleted = false) {
        return this.context.Warehouses
            .Include(warehouse => warehouse.Address)
            .Where(warehouse => warehouse.Id == id && (includeDeleted || warehouse.DateDeleted == null))
            .SingleOrDefault();
    }

    public List<Warehouse> Search(string criterion, bool includeDeleted = false) {
        return this.context.Warehouses
            .Include(warehouse => warehouse.Address)
            .Where(warehouse => (
                warehouse.Id.ToString().Contains(criterion)
                || warehouse.Name.Contains(criterion)
                || warehouse.Address.Addressee.Contains(criterion)
                || warehouse.Address.Street.Contains(criterion) 
                || warehouse.Address.City.Contains(criterion)) 
                && (includeDeleted || warehouse.DateDeleted == null))
            .ToList();
    }

    public Warehouse Create(Warehouse warehouse) {
        _ = this.context.Warehouses.Add(warehouse);
        _ = this.context.SaveChanges();
        return warehouse;
    }

    public Warehouse Update(Warehouse warehouse) {
        warehouse.DateModified = DateTime.Now;
        _ = this.context.Warehouses.Update(warehouse);
        _ = this.context.SaveChanges();
        return warehouse;
    }

    public Warehouse Delete(Warehouse warehouse, bool softDeletes = true) {
        if (softDeletes) {
            warehouse.DateDeleted = DateTime.Now;
            _ = this.context.Warehouses.Update(warehouse);
        } else {
            _ = this.context.Warehouses.Remove(warehouse);
        }
        _ = this.context.SaveChanges();
        return warehouse;
    }
}
