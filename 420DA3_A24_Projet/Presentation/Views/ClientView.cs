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
internal partial class ClientView : Form {
    private readonly ClientService clientService;

    public ClientView(ClientService clientService) {
        this.clientService = clientService;
        InitializeComponent();
        LoadClients();
    }

    private void LoadClients() {
        try {
            List<Client> clients = clientService.GetAllClients();
            lstClients.DataSource = clients;
            lstClients.DisplayMember = "ClientName"; 
        } catch (Exception ex) {
            MessageBox.Show($"Erreur lors du chargement des clients : {ex.Message}");
        }
    }

    private void btnSearch_Click(object sender, EventArgs e) {
        try {
            string filter = txtSearch.Text;
            List<Client> results = clientService.SearchClients(filter);
            lstClients.DataSource = results;
        } catch (Exception ex) {
            MessageBox.Show($"Erreur : {ex.Message}");
        }
    }


    private void btnCreate_Click(object sender, EventArgs e) {
        // ??????
        try {
            Client client = new Client {
                ClientName = txtClientName.Text,
                ContactFirstName = txtContactFirstName.Text,
                ContactLastName = txtContactLastName.Text,
                ContactEmail = txtContactEmail.Text,
                ContactTelephone = txtContactTelephone.Text,
                WarehouseId = int.Parse(txtWarehouseId.Text)
            };

            clientService.CreateClient(client);
            MessageBox.Show("Client créé avec succès !");
            LoadClients();
        } catch (Exception ex) {
            MessageBox.Show($"Erreur : {ex.Message}");
        }
    }

   
    private void btnUpdate_Click(object sender, EventArgs e) {
        try {
            if (lstClients.SelectedItem is Client selectedClient) {
                selectedClient.ClientName = txtClientName.Text;
                selectedClient.ContactFirstName = txtContactFirstName.Text;
                selectedClient.ContactLastName = txtContactLastName.Text;
                selectedClient.ContactEmail = txtContactEmail.Text;
                selectedClient.ContactTelephone = txtContactTelephone.Text;
                selectedClient.WarehouseId = int.Parse(txtWarehouseId.Text);

                clientService.UpdateClient(selectedClient);
                MessageBox.Show("Client mis à jour avec succès !");
                LoadClients();
            }
        } catch (Exception ex) {
            MessageBox.Show($"Erreur : {ex.Message}");
        }
    }

    
    private void btnDelete_Click(object sender, EventArgs e) {
        try {
            if (lstClients.SelectedItem is Client selectedClient) {
                clientService.DeleteClient(selectedClient.Id);
                MessageBox.Show("Client supprimé avec succès !");
                LoadClients();
            }
        } catch (Exception ex) {
            MessageBox.Show($"Erreur : {ex.Message}");
        }
    }

   
    private void btnClear_Click(object sender, EventArgs e) {
        txtClientName.Clear();
        txtContactFirstName.Clear();
        txtContactLastName.Clear();
        txtContactEmail.Clear();
        txtContactTelephone.Clear();
        txtWarehouseId.Clear();
        txtSearch.Clear();
        lstClients.ClearSelected();
    }

   
    private void lstClients_SelectedIndexChanged(object sender, EventArgs e) {
        if (lstClients.SelectedItem is Client selectedClient) {
            txtClientName.Text = selectedClient.ClientName;
            txtContactFirstName.Text = selectedClient.ContactFirstName;
            txtContactLastName.Text = selectedClient.ContactLastName;
            txtContactEmail.Text = selectedClient.ContactEmail;
            txtContactTelephone.Text = selectedClient.ContactTelephone;
            txtWarehouseId.Text = selectedClient.WarehouseId.ToString();
        }
    }

    
    private void txtClientName_TextChanged(object sender, EventArgs e) { }
    private void txtContactFirstName_TextChanged(object sender, EventArgs e) { }
    private void txtContactLastName_TextChanged(object sender, EventArgs e) { }
    private void txtContactEmail_TextChanged(object sender, EventArgs e) { }
    private void txtContactTelephone_TextChanged(object sender, EventArgs e) { }
    private void txtWarehouseId_TextChanged(object sender, EventArgs e) { }
    private void txtSearch_TextChanged(object sender, EventArgs e) { }
}

