using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_A24_Projet.DataAccess.DAOs;
internal class SupplierDAO {
    private WsysDbContext context;

    public SupplierDAO(WsysDbContext context) {
        this.context = context;
    }
    public List<Supplier> GetAll(bool includeDeleted = false) {
        return includeDeleted
            ? this.context.Suppliers.ToList()
            : this.context.Suppliers.Where(supplier => supplier.DateDeleted == null).ToList();
    }
    public Supplier? GetById(int id, bool includeDeleted = false) {
        return includeDeleted
            ? this.context.Suppliers.FirstOrDefault(supplier => supplier.Id == id)
            : this.context.Suppliers.FirstOrDefault(supplier => supplier.Id == id && supplier.DateDeleted == null);
    }

    public List<Supplier> Search(string filter) {
        return this.context.Suppliers.Where(supplier =>
            (supplier.SupplierName.Contains(filter) || supplier.SupplierContactFirstname.Contains(filter) || supplier.SupplierContactLastName.Contains(filter))
            && supplier.DateDeleted == null
        ).ToList();
    }
    public Supplier Create(Supplier supplier) {
        supplier.DateCreated = DateTime.Now;
        _ = this.context.Suppliers.Add(supplier);
        _ = this.context.SaveChanges();
        return supplier;
    }
    public Supplier Update(Supplier supplier) {
        supplier.DateModified = DateTime.Now;
        _ = this.context.Suppliers.Update(supplier);
        _ = this.context.SaveChanges();
        return supplier;
    }
    public void Delete(Supplier supplier, bool softDeletes = true) {
        if (softDeletes) {
            supplier.DateDeleted = DateTime.Now;
            _ = this.context.Suppliers.Update(supplier);
        } else {
            _ = this.context.Suppliers.Remove(supplier);
        }
        _ = this.context.SaveChanges();
    }
}
