using _420DA3_A24_Projet.DataAccess.Contexts;

internal class AdresseDAO {
    private readonly WsysDbContext context;

    public AdresseDAO(WsysDbContext context) {
        this.context = context;
    }

    public List<Adresse> GetAll(bool includeDeleted = false) {
        return includeDeleted
            ? this.context.Adresses.ToList()
            : this.context.Adresses.Where(adress => adress.DateDeleted == null).ToList();
    }


    public Adresse? GetById(int id, bool includeDeleted = false) {
        return includeDeleted
            ? this.context.Adresses.FirstOrDefault(adress => adress.Id == id)
            : this.context.Adresses.FirstOrDefault(adress => adress.Id == id && adress.DateDeleted == null);
    }


    public List<Adresse> Search(string filter) {
        return this.context.Adresses.Where(ad =>
            (ad.Addressee.Contains(filter) || ad.City.Contains(filter) || ad.Country.Contains(filter))
            && ad.DateDeleted == null
        ).ToList();
    }


    public Adresse Create(Adresse adress) {
        adress.DateCreated = DateTime.Now;
        _ = this.context.Adresses.Add(adress);
        _ = this.context.SaveChanges();
        return adress;
    }


    public Adresse Update(Adresse adress) {
        adress.DateModified = DateTime.Now;
        _ = this.context.Adresses.Update(adress);
        _ = this.context.SaveChanges();
        return adress;
    }


    public void Delete(Adresse adress, bool softDeletes = true) {
        if (softDeletes) {
            adress.DateDeleted = DateTime.Now;
            _ = this.context.Adresses.Update(adress);
        } else {
            _ = this.context.Adresses.Remove(adress);
        }
        _ = this.context.SaveChanges();
    }

}
