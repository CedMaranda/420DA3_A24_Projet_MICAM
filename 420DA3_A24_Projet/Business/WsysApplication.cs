﻿using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.Presentation;
using System.Diagnostics;
using System.Text;

namespace _420DA3_A24_Projet.Business;
internal class WsysApplication {

    private readonly WsysDbContext context;
    private readonly AdminMainMenu adminMainMenu;
    private readonly OfficeEmpMainMenu officeEmployeeMainMenu;
    private readonly WhEmpMainMenu warehouseEmployeeMainMenu;


    public PasswordService PasswordService { get; private set; }
    public TrackingNumberFactory TrackingNumberFactory { get; private set; }
    public AdresseService AdresseService { get; private set; }
    public ClientService ClientService { get; private set; }
    public UserService UserService { get; private set; }
    public RoleService RoleService { get; private set; }
    public ShippingOrderService ShippingOrderService { get; private set; }
    public PurchaseOrderService PurchaseOrderService { get; private set; }
    public WarehouseService WarehouseService { get; private set; }
    public ShipmentService ShipmentService { get; private set; }
    public LoginService LoginService { get; private set; }




    public WsysApplication() {

        this.context = new WsysDbContext();
        this.LoginService = new LoginService(this);
        this.PasswordService = PasswordService.GetInstance();
        this.TrackingNumberFactory = TrackingNumberFactory.GetInstance();
        this.AdresseService = new AdresseService();
        this.ClientService = new ClientService();
        this.UserService = new UserService(this, this.context);
        this.RoleService = new RoleService(this, this.context);
        this.ShippingOrderService = new ShippingOrderService(this, this.context);
        this.PurchaseOrderService = new PurchaseOrderService(this, this.context);
        this.WarehouseService = new WarehouseService(this, this.context);
        this.ShipmentService = new ShipmentService(this, this.context);



        this.adminMainMenu = new AdminMainMenu(this);
        this.officeEmployeeMainMenu = new OfficeEmpMainMenu(this);
        this.warehouseEmployeeMainMenu = new WhEmpMainMenu(this);

    }


    /// <summary>
    /// Démarre l'application.
    /// </summary>
    /// <remarks>
    /// L'application est démarrée en boucle infinie. L'utilisateur doit se connecter pour accéder au menu principal.
    /// </remarks>
    /// <exception cref="Exception">En cas d'erreur insurmontable.</exception>
    public void Start() {
        Application.Run(); // UI event loop without a form.
        while (true) {
            this.LoginService.RequireLoggedInUser();
            if (this.LoginService.LoggedInUserRole is null) {
                throw new Exception("Login system failure: no logged in user role loaded after login process.");
            }
            try {
                DialogResult mainMenuDialogResult;
                if (this.LoginService.LoggedInUserRole.IsAdministratorRole()) {
                    mainMenuDialogResult = this.adminMainMenu.ShowAdminMainMenu();

                } else if (this.LoginService.LoggedInUserRole.IsOfficeEmployeeRole()) {
                    mainMenuDialogResult = this.officeEmployeeMainMenu.ShowOfficeEmpMainMenu();

                } else if (this.LoginService.LoggedInUserRole.IsWarehouseEmployeeRole()) {
                    mainMenuDialogResult = this.warehouseEmployeeMainMenu.ShowWhEmpMainMenu();

                } else {
                    throw new Exception($"Role unrecognized: no main menu exists for role [{this.LoginService.LoggedInUserRole.Name}].");
                }

                if (mainMenuDialogResult == DialogResult.OK) {
                    this.LoginService.Logout();
                }

            } catch (Exception ex) {
                this.HandleException(ex);
            }
        }
    }


    /// <summary>
    /// Gestion générale d'une exception.
    /// </summary>
    /// <remarks>
    /// Affiche les détails de l'exception dans la console, dans la fenêtre de débogage et dans une boîte de dialogue.
    /// </remarks>
    /// <param name="ex">L'exception à gérer.</param>
    public void HandleException(Exception ex) {
        string? stack = ex.StackTrace;
        StringBuilder messageBuilder = new StringBuilder();
        Console.Error.WriteLine(ex.Message);
        Debug.WriteLine(ex.Message);
        _ = messageBuilder.Append(ex.Message);
        while (ex.InnerException != null) {
            ex = ex.InnerException;
            Console.Error.WriteLine(ex.Message);
            Debug.WriteLine(ex.Message);
            _ = messageBuilder.Append(Environment.NewLine + "Caused By: " + ex.Message);
        }
        Console.Error.WriteLine("Stack trace:");
        Console.Error.WriteLine(stack);
        Debug.WriteLine("Stack trace:");
        Debug.WriteLine(stack);
        _ = MessageBox.Show(messageBuilder.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

    }

}


