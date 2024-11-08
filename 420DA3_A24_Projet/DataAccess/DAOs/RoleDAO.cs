using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// TODO @PROF: Documenter
/// </summary>
internal class RoleDAO {

    private WsysDbContext context;

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="context"></param>
    public RoleDAO(WsysDbContext context) {
        this.context = context;
    }


    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetById(int id, bool includeDeleted = false) {
        return context.Roles
            .Where(role => role.Id == id && (includeDeleted || role.DateDeleted == null))
            .SingleOrDefault();
    }

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> Search(string criterion, bool includeDeleted = false) {
        return context.Roles
            .Where(role => (
                role.Id.ToString().Contains(criterion)
                || role.Name.Contains(criterion)
                || role.Description.Contains(criterion)
            ) && (includeDeleted || role.DateDeleted == null))
            .ToList();
    }

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public Role Create(Role entity) {
        _ = context.Roles.Add(entity);
        _ = context.SaveChanges();
        return entity;
    }

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public Role Update(Role entity) {
        entity.DateModified = DateTime.Now;
        _ = context.Roles.Update(entity);
        _ = context.SaveChanges();
        return entity;
    }

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="doSoftDelete"></param>
    /// <returns></returns>
    public Role Delete(Role entity, bool doSoftDelete = true) {
        if (doSoftDelete) {
            entity.DateDeleted = DateTime.Now;
            _ = context.Roles.Update(entity);
        } else {
            _ = context.Roles.Remove(entity);
        }
        _ = context.SaveChanges();
        return entity;
    }


}
