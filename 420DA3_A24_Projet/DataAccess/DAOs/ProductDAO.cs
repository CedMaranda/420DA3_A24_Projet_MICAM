using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

internal class ProductDAO {

    private readonly WsysDbContext context;

    public ProductDAO(WsysDbContext context) {
        this.context = context;
    }

    public Product? GetById(int id, bool includeDeleted = false) {
        try {
            return this.context.Products
                .Where(product => product.Id == id && (includeDeleted || product.DateDeleted == null))
                .Include(product => product.OwnerClient)
                .Include(product => product.Supplier)
                .SingleOrDefault();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve product Id #{id}.", ex);
        }
    }

    public Product? GetByProductName(string productName, bool includeDeleted = false) {
        try {
            return this.context.Products
                .Where(product => product.ProductName == productName && (includeDeleted || product.DateDeleted == null))
                .Include(product => product.OwnerClient)
                .Include(product => product.Supplier)
                .SingleOrDefault();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve product with productName [{productName}].", ex);
        }
    }


    public List<Product> Search(string criterion, bool includeDeleted = false) {
        try {
            return this.context.Products
                .Where(product => (
                    product.Id.ToString().Contains(criterion)
                    || product.ProductName.ToLower().Contains(criterion.ToLower())
                ) && (includeDeleted || product.DateDeleted == null))
                .Include(product => product.OwnerClient)
                .Include(product => product.Supplier)
                .ToList();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search product with criterion [{criterion}].", ex);
        }
    }

    public Product Create(Product product) {
        try {
            _ = this.context.Products.Add(product);
            _ = this.context.SaveChanges();
            return product;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert product in database.", ex);
        }
    }

    public Product Update(Product product) {
        DateTime? originalDateModified = product.DateModified;
        try {
            product.DateModified = DateTime.Now;
            _ = this.context.Products.Update(product);
            _ = this.context.SaveChanges();
            return product;

        } catch (Exception ex) {
            product.DateModified = originalDateModified;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update product in database.", ex);
        }
    }

    public Product Delete(Product product, bool softDeletes = true) {
        DateTime? originalDateDelated = product.DateDeleted;
        try {
            if (softDeletes) {
                product.DateDeleted = DateTime.Now;
                _ = this.context.Products.Update(product);

            } else {
                _ = this.context.Products.Remove(product);
            }
            _ = this.context.SaveChanges();
            return product;

        } catch (Exception ex) {
            product.DateModified = originalDateDelated;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete product from database.", ex);
        }
    }


}
