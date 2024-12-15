using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Enums;
using Project_Utilities.Exceptions;
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
internal partial class ShipmentView : Form {

    private WsysApplication parentApp;

    /// <summary>
    /// The <see cref="ViewActionsEnum"/> value indicating the intent for which the window
    /// is currently opened or was opened last.
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// The working <see cref="Shipment"/> value with which the window is currently
    /// opened or was opened last.
    /// </summary>
    public Shipment CurrentEntityInstance { get; private set; } = null!;


    public ShipmentView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// Opens a <see cref="ShipmentView"/> modal window in entity creation mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Shipment instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un entrepôt", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="ShipmentView"/> modal window in entity visualization mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Shipment instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un entrepôt", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="ShipmentView"/> modal window in entity edition mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(Shipment instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un entrepôt", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// Opens a <see cref="ShipmentView"/> modal window in entity deletion mode.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Shipment instance) {
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
    private void PreOpenSetup(Shipment instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
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
        try {
            if (this.CurrentAction == ViewActionsEnum.Creation) {
                string selectedProvider = this.shmipmentProviderCombobox.SelectedItem as string 
                    ?? throw new ValidationException("Please select a shipment service provider first.");
                ShippingProvidersEnum provider
                    = Enum.Parse<ShippingProvidersEnum>(selectedProvider);

                this.CurrentEntityInstance.ShippingProvider = provider;
                this.CurrentEntityInstance.TrackingNumber = this.parentApp.TrackingNumberFactory.GetNewTrackingNumber(provider);
                _ = this.parentApp.ShipmentService.Create(this.CurrentEntityInstance);
                this.DialogResult = DialogResult.OK;
            } else {
                this.DialogResult = DialogResult.Cancel;
            }

        } catch (Exception ex) { 
            this.parentApp.HandleException(ex);
        }
    }
}
