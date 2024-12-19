namespace _420DA3_A24_Projet.Presentation.Views;

partial class AdresseView {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.btnCreate = new Button();
        this.btnUpdate = new Button();
        this.btnSearch = new Button();
        this.btnDelete = new Button();
        this.btnClear = new Button();
        this.txtAdresse = new TextBox();
        this.txtPostalCode = new TextBox();
        this.txtCountry = new TextBox();
        this.txtState = new TextBox();
        this.txtCity = new TextBox();
        this.txtStreet = new TextBox();
        this.txtCivicNumber = new TextBox();
        this.Adresse = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.label4 = new Label();
        this.label5 = new Label();
        this.label6 = new Label();
        this.label7 = new Label();
        this.txtSearch = new TextBox();
        this.lstAdresses = new ListBox();
        this.SuspendLayout();
        // 
        // btnCreate
        // 
        this.btnCreate.Location = new Point(131, 439);
        this.btnCreate.Name = "btnCreate";
        this.btnCreate.Size = new Size(91, 33);
        this.btnCreate.TabIndex = 0;
        this.btnCreate.Text = "Creer";
        this.btnCreate.UseVisualStyleBackColor = true;
        this.btnCreate.Click += this.btnCreate_Click;
        // 
        // btnUpdate
        // 
        this.btnUpdate.Location = new Point(356, 439);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new Size(91, 33);
        this.btnUpdate.TabIndex = 1;
        this.btnUpdate.Text = "Update";
        this.btnUpdate.UseVisualStyleBackColor = true;
        this.btnUpdate.Click += this.btnUpdate_Click;
        // 
        // btnSearch
        // 
        this.btnSearch.Location = new Point(761, 182);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new Size(91, 33);
        this.btnSearch.TabIndex = 2;
        this.btnSearch.Text = "Search";
        this.btnSearch.UseVisualStyleBackColor = true;
        this.btnSearch.Click += this.btnSearch_Click;
        // 
        // btnDelete
        // 
        this.btnDelete.Location = new Point(624, 439);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new Size(91, 33);
        this.btnDelete.TabIndex = 3;
        this.btnDelete.Text = "Delete";
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Click += this.btnDelete_Click;
        // 
        // btnClear
        // 
        this.btnClear.Location = new Point(835, 439);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new Size(91, 33);
        this.btnClear.TabIndex = 4;
        this.btnClear.Text = "Clear";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += this.btnClear_Click;
        // 
        // txtAdresse
        // 
        this.txtAdresse.Location = new Point(222, 35);
        this.txtAdresse.Name = "txtAdresse";
        this.txtAdresse.Size = new Size(164, 31);
        this.txtAdresse.TabIndex = 5;
        this.txtAdresse.TextChanged += this.txtAdresse_TextChanged;
        // 
        // txtPostalCode
        // 
        this.txtPostalCode.Location = new Point(569, 124);
        this.txtPostalCode.Name = "txtPostalCode";
        this.txtPostalCode.Size = new Size(164, 31);
        this.txtPostalCode.TabIndex = 6;
        this.txtPostalCode.TextChanged += this.txtPostalCode_TextChanged;
        // 
        // txtCountry
        // 
        this.txtCountry.Location = new Point(569, 35);
        this.txtCountry.Name = "txtCountry";
        this.txtCountry.Size = new Size(164, 31);
        this.txtCountry.TabIndex = 7;
        this.txtCountry.TextChanged += this.txtCountry_TextChanged;
        // 
        // txtState
        // 
        this.txtState.Location = new Point(222, 355);
        this.txtState.Name = "txtState";
        this.txtState.Size = new Size(164, 31);
        this.txtState.TabIndex = 8;
        this.txtState.TextChanged += this.txtState_TextChanged;
        // 
        // txtCity
        // 
        this.txtCity.Location = new Point(222, 284);
        this.txtCity.Name = "txtCity";
        this.txtCity.Size = new Size(164, 31);
        this.txtCity.TabIndex = 9;
        this.txtCity.TextChanged += this.txtCity_TextChanged;
        // 
        // txtStreet
        // 
        this.txtStreet.Location = new Point(222, 195);
        this.txtStreet.Name = "txtStreet";
        this.txtStreet.Size = new Size(164, 31);
        this.txtStreet.TabIndex = 10;
        this.txtStreet.TextChanged += this.txtStreet_TextChanged;
        // 
        // txtCivicNumber
        // 
        this.txtCivicNumber.Location = new Point(222, 106);
        this.txtCivicNumber.Name = "txtCivicNumber";
        this.txtCivicNumber.Size = new Size(164, 31);
        this.txtCivicNumber.TabIndex = 11;
        this.txtCivicNumber.TextChanged += this.txtCivicNumber_TextChanged;
        // 
        // Adresse
        // 
        this.Adresse.AutoSize = true;
        this.Adresse.Location = new Point(131, 35);
        this.Adresse.Name = "Adresse";
        this.Adresse.Size = new Size(84, 25);
        this.Adresse.TabIndex = 12;
        this.Adresse.Text = "Adresse :";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(76, 112);
        this.label2.Name = "label2";
        this.label2.Size = new Size(127, 25);
        this.label2.TabIndex = 13;
        this.label2.Text = "Civic Number :";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(131, 201);
        this.label3.Name = "label3";
        this.label3.Size = new Size(66, 25);
        this.label3.TabIndex = 14;
        this.label3.Text = "Street :";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(131, 290);
        this.label4.Name = "label4";
        this.label4.Size = new Size(51, 25);
        this.label4.TabIndex = 15;
        this.label4.Text = "City :";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(131, 361);
        this.label5.Name = "label5";
        this.label5.Size = new Size(60, 25);
        this.label5.TabIndex = 16;
        this.label5.Text = "State :";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new Point(485, 38);
        this.label6.Name = "label6";
        this.label6.Size = new Size(84, 25);
        this.label6.TabIndex = 17;
        this.label6.Text = "Country :";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new Point(453, 127);
        this.label7.Name = "label7";
        this.label7.Size = new Size(115, 25);
        this.label7.TabIndex = 18;
        this.label7.Text = "Postal Code :";
        // 
        // txtSearch
        // 
        this.txtSearch.Location = new Point(569, 184);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new Size(164, 31);
        this.txtSearch.TabIndex = 19;
        this.txtSearch.Text = "Search";
        this.txtSearch.TextChanged += this.txtSearch_TextChanged;
        // 
        // lstAdresses
        // 
        this.lstAdresses.FormattingEnabled = true;
        this.lstAdresses.ItemHeight = 25;
        this.lstAdresses.Location = new Point(479, 238);
        this.lstAdresses.Name = "lstAdresses";
        this.lstAdresses.Size = new Size(412, 154);
        this.lstAdresses.TabIndex = 20;
        this.lstAdresses.SelectedIndexChanged += this.lstAdresses_SelectedIndexChanged;
        // 
        // AdresseView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1064, 513);
        this.Controls.Add(this.lstAdresses);
        this.Controls.Add(this.txtSearch);
        this.Controls.Add(this.label7);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.Adresse);
        this.Controls.Add(this.txtCivicNumber);
        this.Controls.Add(this.txtStreet);
        this.Controls.Add(this.txtCity);
        this.Controls.Add(this.txtState);
        this.Controls.Add(this.txtCountry);
        this.Controls.Add(this.txtPostalCode);
        this.Controls.Add(this.txtAdresse);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnSearch);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnCreate);
        this.Name = "AdresseView";
        this.Text = "AdresseView";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Button btnCreate;
    private Button btnUpdate;
    private Button btnSearch;
    private Button btnDelete;
    private Button btnClear;
    private TextBox txtAdresse;
    private TextBox txtPostalCode;
    private TextBox txtCountry;
    private TextBox txtState;
    private TextBox txtCity;
    private TextBox txtStreet;
    private TextBox txtCivicNumber;
    private Label Adresse;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private TextBox txtSearch;
    private ListBox lstAdresses;
}