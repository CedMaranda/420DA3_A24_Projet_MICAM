using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// TODO @PROF : documenter
/// </summary>
internal class UserService {

    private WsysApplication parentApp;
    private UserDAO userDAO;
    private UserView userWindow;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public UserService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.userDAO = new UserDAO(context);
        this.userWindow = new UserView(parentApp);
    }


    #region METHODS

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <returns></returns>
    public Product? OpenUserManagementWindowForCreation() {
        Product newEmptyUser = (Product) FormatterServices.GetUninitializedObject(typeof(Product));
        DialogResult result = this.userWindow.OpenForCreation(newEmptyUser);
        return result == DialogResult.OK
            ? this.userWindow.CurrentEntityInstance
            : null;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="userToEdit"></param>
    /// <returns></returns>
    public Product OpenUserManagementWindowForEdition(Product userToEdit) {
        _ = this.userWindow.OpenForModification(userToEdit);
        return userToEdit;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="userToView"></param>
    /// <returns></returns>
    public Product OpenUserManagementWindowForVisualization(Product userToView) {
        _ = this.userWindow.OpenForDetailsView(userToView);
        return userToView;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="userToDelete"></param>
    /// <returns></returns>
    public Product OpenUserManagementWindowForDeletion(Product userToDelete) {
        _ = this.userWindow.OpenForDeletion(userToDelete);
        return userToDelete;
    }



    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Product? GetUserById(int id) {
        return this.userDAO.GetById(id);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public Product? GetUserByUsername(string username) {
        return this.userDAO.GetByUsername(username);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <returns></returns>
    public List<Product> SearchUsers(string criterion) {
        return this.userDAO.Search(criterion);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public Product CreateUserInDatabase(Product user) {
        return this.userDAO.Create(user);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public Product UpdateUserInDatabase(Product user) {
        return this.userDAO.Update(user);
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public Product DeleteUserFromDatabase(Product user) {
        return this.userDAO.Delete(user);
    }

    #endregion

}
