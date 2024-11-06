using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// Classe de DAO pour les entités <see cref="User"/>.
/// </summary>
class UserDAO {

    private WsysDbContext context;

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="context"></param>
    public UserDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public User? GetById(int id, bool includeDeleted = false) {
        return context.Users
            .Where(user => user.Id == id && (includeDeleted || user.DateDeleted == null))
            .Include(user => user.Roles)
            .Include(User => User.EmployeeWarehouse)
                .ThenInclude(warehouse => warehouse.Address)
            .SingleOrDefault();
    }

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="username"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public User? GetByUsername(string username, bool includeDeleted = false) {
        return context.Users
            .Where(user => user.Username == username && (includeDeleted || user.DateDeleted == null))
            .Include(user => user.Roles)
            .Include(User => User.EmployeeWarehouse)
                .ThenInclude(warehouse => warehouse.Address)
            .SingleOrDefault();
    }

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<User> Search(string criterion, bool includeDeleted = false) {
        return context.Users
            .Where(user => (
                user.Username.Contains(criterion)
                || user.Id.ToString().Contains(criterion)
            ) && (includeDeleted || user.DateDeleted == null))
            .Include(user => user.Roles)
            .Include(User => User.EmployeeWarehouse)
                .ThenInclude(warehouse => warehouse.Address)
            .ToList();
    }

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public User Create(User entity) {
        _ = context.Users.Add(entity);
        _ = context.SaveChanges();
        return entity;
    }

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public User Update(User entity) {
        entity.DateModified = DateTime.Now;
        _ = context.Users.Update(entity);
        _ = context.SaveChanges();
        return entity;
    }

    /// <summary>
    /// TODO @PROF: Documenter
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="doSoftDelete"></param>
    /// <returns></returns>
    public User Delete(User entity, bool doSoftDelete = true) {
        if (doSoftDelete) {
            entity.DateDeleted = DateTime.Now;
            _ = context.Users.Update(entity);
        } else {
            _ = context.Users.Remove(entity);
        }
        _ = context.SaveChanges();
        return entity;
    }
}
