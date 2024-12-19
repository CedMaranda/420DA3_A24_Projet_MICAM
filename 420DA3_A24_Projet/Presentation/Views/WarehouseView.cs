using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class WarehouseView : Form {

    private readonly WsysApplication parentApp;

    /// <summary>
    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window
    /// is currently opened or was opened last.
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// The working <see cref="Warehouse"/> value with which the window is currently
    /// opened or was opened last.
    /// </summary>
    public Warehouse CurrentEntityInstance { get; private set; } = null!;

    public WarehouseView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// Opens a <see cref="WarehouseView"/> modal window in entity creation mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un entrepôt", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="WarehouseView"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un entrepôt", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="WarehouseView"/> modal window in entity edition mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un entrepôt", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="WarehouseView"/> modal window in entity deletion mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Warehouse instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un entrepôt", "Supprimer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Performs pre-opening initialization, clean-up and preparation for the <see cref="WarehouseView"/> window.
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(Warehouse instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.actionButton.Text = actionButtonText;
        // display the current action in the top bar
        this.openendModeValue.Text = Enum.GetName(action);
        // activate or deactivate the editable controls depending on the action
        if (action == ViewActionsEnum.Creation) {
            this.ActivateControls();
        } else {
            this.DeactivateControls();
        }
    }

    private void ActivateControls() { 
        this.actionButton.Enabled = true;
    }

    private void DeactivateControls() {
        this.actionButton.Enabled = false;
    }

    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        if (this.CurrentAction == ViewActionsEnum.Creation) {
            this.CurrentEntityInstance = this.parentApp.WarehouseService.GenerateAutomaticWarehouse();
            this.DialogResult = DialogResult.OK;
        } else {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
