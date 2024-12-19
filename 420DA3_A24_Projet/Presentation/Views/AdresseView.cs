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

namespace _420DA3_A24_Projet.Presentation.Views {
    public partial class AdresseView : Form {
        private readonly AdresseService adresseService;

        public AdresseView(AdresseService adresseService) {
            this.adresseService = adresseService;
            InitializeComponent();
            LoadAdresses();
        }

        private void LoadAdresses() {
            try {
                List<Adresse> adresses = adresseService.GetAllAdresses();
                lstAdresses.DataSource = adresses;
            } catch (Exception ex) {
                MessageBox.Show($"Erreur lors du chargement des adresses : {ex.Message}");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            try {
                Adresse adresse = new Adresse(
                    txtAdresse.Text,
                    txtCivicNumber.Text,
                    txtStreet.Text,
                    txtCity.Text,
                    txtState.Text,
                    txtCountry.Text,
                    txtPostalCode.Text,
                    AddressTypesEnum.ShippingDestination 
                );

                adresseService.CreateAdresse(adresse);
                MessageBox.Show("Adresse créée avec succès !");
                LoadAdresses();
            } catch (Exception ex) {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e) {
            try {
                if (lstAdresses.SelectedItem is Adresse selectedAdresse) {
                    selectedAdresse.Addressee = txtAdresse.Text;
                    selectedAdresse.CivicNumber = txtCivicNumber.Text;
                    selectedAdresse.Street = txtStreet.Text;
                    selectedAdresse.City = txtCity.Text;
                    selectedAdresse.State = txtState.Text;
                    selectedAdresse.Country = txtCountry.Text;
                    selectedAdresse.PostalCode = txtPostalCode.Text;

                    adresseService.UpdateAdresse(selectedAdresse);
                    MessageBox.Show("Adresse mise à jour avec succès !");
                    LoadAdresses();
                } else {
                    MessageBox.Show("Veuillez sélectionner une adresse à modifier.");
                }
            } catch (Exception ex) {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            try {
                string filter = txtSearch.Text;
                List<Adresse> results = adresseService.SearchAdresses(filter);
                lstAdresses.DataSource = results;
            } catch (Exception ex) {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                if (lstAdresses.SelectedItem is Adresse selectedAdresse) {
                    adresseService.DeleteAdresse(selectedAdresse.Id);
                    MessageBox.Show("Adresse supprimée avec succès !");
                    LoadAdresses();
                } else {
                    MessageBox.Show("Veuillez sélectionner une adresse à supprimer.");
                }
            } catch (Exception ex) {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            try {
                txtAdresse.Clear();
                txtCivicNumber.Clear();
                txtStreet.Clear();
                txtCity.Clear();
                txtState.Clear();
                txtCountry.Clear();
                txtPostalCode.Clear();
                txtSearch.Clear();
                lstAdresses.DataSource = null;
            } catch (Exception ex) {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void lstAdresses_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                if (lstAdresses.SelectedItem is Adresse selectedAdresse) {
                    txtAdresse.Text = selectedAdresse.Addressee;
                    txtCivicNumber.Text = selectedAdresse.CivicNumber;
                    txtStreet.Text = selectedAdresse.Street;
                    txtCity.Text = selectedAdresse.City;
                    txtState.Text = selectedAdresse.State;
                    txtCountry.Text = selectedAdresse.Country;
                    txtPostalCode.Text = selectedAdresse.PostalCode;
                }
            } catch (Exception ex) {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void txtCountry_TextChanged(object sender, EventArgs e) { }
        private void txtAdresse_TextChanged(object sender, EventArgs e) { }
        private void txtCivicNumber_TextChanged(object sender, EventArgs e) { }
        private void txtStreet_TextChanged(object sender, EventArgs e) { }
        private void txtCity_TextChanged(object sender, EventArgs e) { }
        private void txtState_TextChanged(object sender, EventArgs e) { }
        private void txtPostalCode_TextChanged(object sender, EventArgs e) { }
        private void txtSearch_TextChanged(object sender, EventArgs e) { }

        private void MessageBox_TextChanged(object sender, EventArgs e) {

        }
    }
}