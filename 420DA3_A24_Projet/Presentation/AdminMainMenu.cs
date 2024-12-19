using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using Project_Utilities.Presentation;

namespace _420DA3_A24_Projet.Presentation;
internal partial class AdminMainMenu : Form {

    /// <summary>
    /// Valeur générique pour indiquer qu'aucun élément n'est sélectionné dans une liste.
    /// À ajouter à vos listes pour offrir l'option "Aucun" aux utilisateurs.
    /// </summary>
    private static readonly object listNoneSelectedValue = "Aucun";

    private readonly WsysApplication parentApp;

    public AdminMainMenu(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    public DialogResult ShowAdminMainMenu() {
        return this.ShowDialog();
    }

    private void ButtonLogout_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.None;
    }


    #region GESTION DES UTILISATEURS

    /// <summary>
    /// Empties the <see cref="Product"/> search results <see cref="ListBox"/> then fills it with the given
    /// <paramref name="searchResults"/>.
    /// </summary>
    /// <param name="searchResults"></param>
    private void ReloadUserSearchResults(List<Product> searchResults) {
        try {
            this.userSearchResults.SelectedItem = null;
            this.userSearchResults.SelectedIndex = -1;
            this.userSearchResults.Items.Clear();
            _ = this.userSearchResults.Items.Add(listNoneSelectedValue);
            foreach (Product user in searchResults) {
                _ = this.userSearchResults.Items.Add(user);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// Enables the role action buttons.
    /// </summary>
    private void ActivateUserActionButtons() {
        this.buttonDeleteUser.Enabled = true;
        this.buttonEditUser.Enabled = true;
        this.buttonViewUser.Enabled = true;
    }

    /// <summary>
    /// Disables the user action buttons.
    /// </summary>
    private void DeactivateUserActionButtons() {
        this.buttonDeleteUser.Enabled = false;
        this.buttonEditUser.Enabled = false;
        this.buttonViewUser.Enabled = false;
    }

    private void ButtonCreateUser_Click(object sender, EventArgs e) {
        try {
            Product? userCree = this.parentApp.UserService.OpenManagementWindowForCreation();
            if (userCree != null) {
                _ = this.userSearchResults.Items.Add(userCree);
                this.userSearchResults.SelectedItem = userCree;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void UserSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            string searchCriterion = this.userSearchTextBox.Text.Trim();
            List<Product> results = this.parentApp.UserService.SearchUsers(searchCriterion);
            this.ReloadUserSearchResults(results);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void UserSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        Product? selectedUSer = this.userSearchResults.SelectedItem as Product;
        if (selectedUSer != null) {
            this.ActivateUserActionButtons();
        } else {
            this.DeactivateUserActionButtons();
        }
    }

    private void ButtonViewUser_Click(object sender, EventArgs e) {
        try {
            Product selectedUser = (Product) this.userSearchResults.SelectedItem;
            Product? createdUser = this.parentApp.UserService.OpenManagementWindowForVisualization(selectedUser);
            if (createdUser != null) {
                _ = this.userSearchResults.Items.Add(createdUser);
                this.userSearchResults.SelectedItem = createdUser;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonEditUser_Click(object sender, EventArgs e) {
        try {
            Product selectedUser = (Product) this.userSearchResults.SelectedItem;
            bool wasUpdated = this.parentApp.UserService.OpenManagementWindowForEdition(selectedUser);
            if (wasUpdated) {
                this.userSearchResults.RefreshDisplay();
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonDeleteUser_Click(object sender, EventArgs e) {
        try {
            Product selectedUser = (Product) this.userSearchResults.SelectedItem;
            bool wasDeleted = this.parentApp.UserService.OpenManagementWindowForDeletion(selectedUser);

            if (wasDeleted) {
                this.userSearchResults.SelectedItem = null;
                this.userSearchResults.SelectedIndex = -1;
                this.userSearchResults.Items.Remove(selectedUser);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    #endregion


    #region GESTION DES ROLES

    /// <summary>
    /// Empties the <see cref="Role"/> search results <see cref="ListBox"/> then fills it with the given
    /// <paramref name="searchResults"/>.
    /// </summary>
    /// <param name="searchResults"></param>
    private void ReloadRoleSearchResults(List<Role> searchResults) {
        try {
            this.roleSearchResults.SelectedItem = null;
            this.roleSearchResults.SelectedIndex = -1;
            this.roleSearchResults.Items.Clear();
            foreach (Role role in searchResults) {
                _ = this.roleSearchResults.Items.Add(role);
            }
            this.roleSearchResults.Refresh();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// Enables the role action buttons.
    /// </summary>
    private void ActivateRoleActionButtons() {
        this.buttonDeleteRole.Enabled = true;
        this.buttonEditRole.Enabled = true;
        this.buttonViewRole.Enabled = true;
    }

    /// <summary>
    /// Disables the role action buttons.
    /// </summary>
    private void DeactivateRoleActionButtons() {
        this.buttonDeleteRole.Enabled = false;
        this.buttonEditRole.Enabled = false;
        this.buttonViewRole.Enabled = false;
    }

    private void ButtonCreateRole_Click(object sender, EventArgs e) {
        try {
            Role? createdRole = this.parentApp.RoleService.OpenManagementWindowForCreation();
            if (createdRole != null) {
                _ = this.roleSearchResults.Items.Add(createdRole);
                this.roleSearchResults.SelectedItem = createdRole;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void RoleSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            List<Role> results = this.parentApp.RoleService.SearchRoles(this.roleSearchTextBox.Text.Trim());
            this.ReloadRoleSearchResults(results);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void RoleSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
        if (selectedRole != null) {
            this.ActivateRoleActionButtons();
        } else {
            this.DeactivateRoleActionButtons();
        }
    }

    private void ButtonViewRole_Click(object sender, EventArgs e) {
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
            if (selectedRole != null) {
                _ = this.parentApp.RoleService.OpenManagementWindowForVisualization(selectedRole);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonEditRole_Click(object sender, EventArgs e) {
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
            if (selectedRole != null) {
                bool wasUpdated = this.parentApp.RoleService.OpenManagementWindowForEdition(selectedRole);
                if (wasUpdated) {
                    this.roleSearchResults.RefreshDisplay();
                }
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonDeleteRole_Click(object sender, EventArgs e) {
        try {
            Role? selectedRole = this.roleSearchResults.SelectedItem as Role;
            if (selectedRole != null) {
                bool wasDeleted = this.parentApp.RoleService.OpenManagementWindowForDeletion(selectedRole);
                if (wasDeleted) {
                    this.roleSearchResults.SelectedItem = null;
                    this.roleSearchResults.SelectedIndex = -1;
                    this.roleSearchResults.Items.Remove(selectedRole);
                }
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    #endregion


    #region GESTION DES SHIPPING ORDERS

    private void ReloadSOSearchResults(List<ShippingOrder> searchResults) {
        this.soSearchResults.Items.Clear();
        this.soSearchResults.SelectedItem = null;
        foreach (ShippingOrder so in searchResults) {
            _ = this.soSearchResults.Items.Add(so);
        }
    }

    private void ButtonCreateSO_Click(object sender, EventArgs e) {
        ShippingOrder? createdOrder = this.parentApp.ShippingOrderService.OpenManagementWindowForCreation();
        if (createdOrder != null) {
            _ = this.soSearchResults.Items.Add(createdOrder);
            this.soSearchResults.SelectedItem = createdOrder;
        }
    }

    private void SoSearchTextBox_TextChanged(object sender, EventArgs e) {
        List<ShippingOrder> results = this.parentApp.ShippingOrderService.SearchOrders(this.soSearchTextBox.Text.Trim());
        this.ReloadSOSearchResults(results);
    }

    private void SoSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        ShippingOrder? selectedSO = this.soSearchResults.SelectedItem as ShippingOrder;
        if (selectedSO != null) {
            if (selectedSO.Status == ShippingOrderStatusEnum.Unassigned || selectedSO.Status == ShippingOrderStatusEnum.New) {
                this.buttonDeleteSO.Enabled = true;
                this.buttonEditSO.Enabled = true;
            } else {
                this.buttonDeleteSO.Enabled = false;
                this.buttonEditSO.Enabled = false;
            }
            this.buttonViewSO.Enabled = true;
        } else {
            this.buttonDeleteSO.Enabled = false;
            this.buttonEditSO.Enabled = false;
            this.buttonViewSO.Enabled = false;
        }

    }

    private void ButtonViewSO_Click(object sender, EventArgs e) {
        ShippingOrder? selectedSO = this.soSearchResults.SelectedItem as ShippingOrder;
        if (selectedSO != null) {
            _ = this.parentApp.ShippingOrderService.OpenManagementWindowForVisualization(selectedSO);
        }
    }

    private void ButtonEditSO_Click(object sender, EventArgs e) {
        ShippingOrder? selectedSO = this.soSearchResults.SelectedItem as ShippingOrder;
        if (selectedSO != null) {
            if (selectedSO.Status != ShippingOrderStatusEnum.Unassigned || selectedSO.Status != ShippingOrderStatusEnum.New) {
                throw new Exception("Seuls les ordres d'expédition non assignés ou nouveaux peuvent être modifiés.");
            }
            _ = this.parentApp.ShippingOrderService.OpenManagementWindowForEdition(selectedSO);
        }

    }

    private void ButtonDeleteSO_Click(object sender, EventArgs e) {
        ShippingOrder? selectedSO = this.soSearchResults.SelectedItem as ShippingOrder;
        if (selectedSO != null) {
            if (selectedSO.Status != ShippingOrderStatusEnum.Unassigned || selectedSO.Status != ShippingOrderStatusEnum.New) {
                throw new Exception("Seuls les ordres d'expédition non assignés ou nouveaux peuvent être supprimés.");
            }
            _ = this.parentApp.ShippingOrderService.OpenManagementWindowForDeletion(selectedSO);
        }

    }


    #endregion


    #region GESTION DES ORDRES DE RESTOCKAGE

    /// <summary>
    /// Empties the <see cref="PurchaseOrder"/> search results <see cref="ListBox"/> then fills it with the given
    /// <paramref name="searchResults"/>.
    /// </summary>
    /// <param name="searchResults"></param>
    private void ReloadPOSearchResults(List<PurchaseOrder> searchResults) {
        try {
            this.poSearchResults.SelectedItem = null;
            this.poSearchResults.SelectedIndex = -1;
            this.poSearchResults.Items.Clear();
            foreach (PurchaseOrder role in searchResults) {
                _ = this.poSearchResults.Items.Add(role);
            }
            this.poSearchResults.Refresh();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonCreatePO_Click(object sender, EventArgs e) {
        try {
            PurchaseOrder? createdPO = this.parentApp.PurchaseOrderService.OpenManagementWindowForCreation();
            if (createdPO != null) {
                _ = this.poSearchResults.Items.Add(createdPO);
                this.poSearchResults.SelectedItem = createdPO;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void PoSearchTextBox_TextChanged(object sender, EventArgs e) {
        try {
            List<PurchaseOrder> results = this.parentApp.PurchaseOrderService.Search(this.poSearchTextBox.Text.Trim());
            this.ReloadPOSearchResults(results);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void PoSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        PurchaseOrder? selectedPO = this.poSearchResults.SelectedItem as PurchaseOrder;
        this.buttonViewPO.Enabled = selectedPO != null;
    }

    private void ButtonViewPO_Click(object sender, EventArgs e) {
        try {
            PurchaseOrder? selectedPO = this.poSearchResults.SelectedItem as PurchaseOrder;
            if (selectedPO != null) {
                this.parentApp.PurchaseOrderService.OpenManagementWindowForVisualization(selectedPO);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    #endregion


    #region ENTREPOTS ET SHIPMENTS

    private void ButtonCreateWarehouse_Click(object sender, EventArgs e) {
        try {
            Warehouse? wh = this.parentApp.WarehouseService.OpenViewForCreation();
            if (wh != null) {
                _ = MessageBox.Show("Warehouse created!\n" + wh.ToString());
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }
    private void ReloadShipmentSOSearchResults(List<ShippingOrder> searchResults) {
        this.shipmentSearchSOResults.Items.Clear();
        this.shipmentSearchSOResults.SelectedItem = null;
        foreach (ShippingOrder so in searchResults) {
            _ = this.shipmentSearchSOResults.Items.Add(so);
        }
    }

    private void ShipmentSearchSOTextBox_TextChanged(object sender, EventArgs e) {
        try {
            List<ShippingOrder> results = this.parentApp.ShippingOrderService.SearchOrders(this.soSearchTextBox.Text.Trim());
            this.ReloadShipmentSOSearchResults(results);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ShipmentSearchSOResults_SelectedIndexChanged(object sender, EventArgs e) {

        ShippingOrder? selectedSO = this.shipmentSearchSOResults.SelectedItem as ShippingOrder;
        this.buttonCreateShipment.Enabled = selectedSO != null && selectedSO.Status == ShippingOrderStatusEnum.Processing;
    }

    private void ButtonCreateShipment_Click_1(object sender, EventArgs e) {
        try {
            ShippingOrder selectedSO = this.shipmentSearchSOResults.SelectedItem as ShippingOrder
                ?? throw new Exception("Please select a shipping order first.");
            Shipment? shipment = this.parentApp.ShipmentService.OpenViewForCreation(selectedSO);
            if (shipment != null) {
                _ = MessageBox.Show("Shipment created!\n" + shipment.ToString());
            }


        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    #endregion

    private void buttonCreateRole_Click_1(object sender, EventArgs e) {

    }
}
