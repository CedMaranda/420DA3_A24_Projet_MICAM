using System;

public class AdresseDAO
{
    private readonly ExempleDbContext context;

    public AdressDAO(ExempleDbContext context) {
        this.context = context;
    }

    public List<Adress> GetAll(bool includeDeleted = false) {
        return includeDeleted
            ? this.context.Adresses.ToList()
            : this.context.Adresses.Where(adress => adress.DateDeleted == null).ToList();
    }

    
    public Adress? GetById(int id, bool includeDeleted = false) {
        return includeDeleted
            ? this.context.Adresses.FirstOrDefault(adress => adress.Id == id)
            : this.context.Adresses.FirstOrDefault(adress => adress.Id == id && adress.DateDeleted == null);
    }

    
    public List<Adress> Search(string filter) {
        return this.context.Adresses.Where(ad =>
            (ad.Adressee.Contains(filter) || ad.City.Contains(filter) || ad.Country.Contains(filter))
            && ad.DateDeleted == null
        ).ToList();
    }

    
    public Adress Create(Adress adress) {
        adress.DateCreated = DateTime.Now;
        _ = this.context.Adresses.Add(adress);
        _ = this.context.SaveChanges();
        return adress;
    }

    
    public Adress Update(Adress adress) {
        adress.DateModified = DateTime.Now;
        _ = this.context.Adresses.Update(adress);
        _ = this.context.SaveChanges();
        return adress;
    }

    
    public void Delete(Adress adress, bool softDeletes = true) {
        if (softDeletes) {
            adress.DateDeleted = DateTime.Now;
            _ = this.context.Adresses.Update(adress);
        } else {
            _ = this.context.Adresses.Remove(adress);
        }
        _ = this.context.SaveChanges();
    }

}
