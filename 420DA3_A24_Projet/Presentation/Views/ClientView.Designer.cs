namespace _420DA3_A24_Projet.Presentation.Views;

partial class ClientView {
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
        this.txtClientName = new TextBox();
        this.txtSearch = new TextBox();
        this.txtWarehouseId = new TextBox();
        this.txtContactTelephone = new TextBox();
        this.txtContactEmail = new TextBox();
        this.txtContactLastName = new TextBox();
        this.txtContactFirstName = new TextBox();
        this.label1 = new Label();
        this.label2 = new Label();
        this.label3 = new Label();
        this.label4 = new Label();
        this.label5 = new Label();
        this.label6 = new Label();
        this.label8 = new Label();
        this.btnCreate = new Button();
        this.btnClear = new Button();
        this.btnSearch = new Button();
        this.btnDelete = new Button();
        this.btnUpdate = new Button();
        this.lstClients = new ListBox();
        this.SuspendLayout();
        // 
        // txtClientName
        // 
        this.txtClientName.Location = new Point(183, 12);
        this.txtClientName.Name = "txtClientName";
        this.txtClientName.Size = new Size(150, 31);
        this.txtClientName.TabIndex = 0;
        this.txtClientName.TextChanged += this.txtClientName_TextChanged;
        // 
        // txtSearch
        // 
        this.txtSearch.Location = new Point(183, 424);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new Size(150, 31);
        this.txtSearch.TabIndex = 1;
        this.txtSearch.TextChanged += this.txtSearch_TextChanged;
        // 
        // txtWarehouseId
        // 
        this.txtWarehouseId.Location = new Point(183, 358);
        this.txtWarehouseId.Name = "txtWarehouseId";
        this.txtWarehouseId.Size = new Size(150, 31);
        this.txtWarehouseId.TabIndex = 3;
        this.txtWarehouseId.TextChanged += this.txtWarehouseId_TextChanged;
        // 
        // txtContactTelephone
        // 
        this.txtContactTelephone.Location = new Point(183, 290);
        this.txtContactTelephone.Name = "txtContactTelephone";
        this.txtContactTelephone.Size = new Size(150, 31);
        this.txtContactTelephone.TabIndex = 4;
        this.txtContactTelephone.TextChanged += this.txtContactTelephone_TextChanged;
        // 
        // txtContactEmail
        // 
        this.txtContactEmail.Location = new Point(183, 216);
        this.txtContactEmail.Name = "txtContactEmail";
        this.txtContactEmail.Size = new Size(150, 31);
        this.txtContactEmail.TabIndex = 5;
        this.txtContactEmail.TextChanged += this.txtContactEmail_TextChanged;
        // 
        // txtContactLastName
        // 
        this.txtContactLastName.Location = new Point(183, 141);
        this.txtContactLastName.Name = "txtContactLastName";
        this.txtContactLastName.Size = new Size(150, 31);
        this.txtContactLastName.TabIndex = 6;
        this.txtContactLastName.TextChanged += this.txtContactLastName_TextChanged;
        // 
        // txtContactFirstName
        // 
        this.txtContactFirstName.Location = new Point(183, 72);
        this.txtContactFirstName.Name = "txtContactFirstName";
        this.txtContactFirstName.Size = new Size(150, 31);
        this.txtContactFirstName.TabIndex = 7;
        this.txtContactFirstName.TextChanged += this.txtContactFirstName_TextChanged;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(27, 15);
        this.label1.Name = "label1";
        this.label1.Size = new Size(117, 25);
        this.label1.TabIndex = 8;
        this.label1.Text = "Client Name :";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(7, 147);
        this.label2.Name = "label2";
        this.label2.Size = new Size(170, 25);
        this.label2.TabIndex = 9;
        this.label2.Text = "Contact Last Name :";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new Point(15, 219);
        this.label3.Name = "label3";
        this.label3.Size = new Size(129, 25);
        this.label3.TabIndex = 10;
        this.label3.Text = "Contact Email :";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new Point(7, 296);
        this.label4.Name = "label4";
        this.label4.Size = new Size(167, 25);
        this.label4.TabIndex = 11;
        this.label4.Text = "Contact Telephone :";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new Point(15, 364);
        this.label5.Name = "label5";
        this.label5.Size = new Size(140, 25);
        this.label5.TabIndex = 12;
        this.label5.Text = "WareHouse ID : ";
        // 
        // label6
        // 
        this.label6.AutoSize = true;
        this.label6.Location = new Point(73, 424);
        this.label6.Name = "label6";
        this.label6.Size = new Size(73, 25);
        this.label6.TabIndex = 13;
        this.label6.Text = "Search :";
        // 
        // label8
        // 
        this.label8.AutoSize = true;
        this.label8.Location = new Point(27, 78);
        this.label8.Name = "label8";
        this.label8.Size = new Size(111, 25);
        this.label8.TabIndex = 15;
        this.label8.Text = "First Name : ";
        // 
        // btnCreate
        // 
        this.btnCreate.Location = new Point(465, 15);
        this.btnCreate.Name = "btnCreate";
        this.btnCreate.Size = new Size(112, 34);
        this.btnCreate.TabIndex = 16;
        this.btnCreate.Text = "Create";
        this.btnCreate.UseVisualStyleBackColor = true;
        this.btnCreate.Click += this.btnCreate_Click;
        // 
        // btnClear
        // 
        this.btnClear.Location = new Point(465, 219);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new Size(112, 34);
        this.btnClear.TabIndex = 17;
        this.btnClear.Text = "Clear";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += this.btnClear_Click;
        // 
        // btnSearch
        // 
        this.btnSearch.Location = new Point(374, 424);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new Size(112, 34);
        this.btnSearch.TabIndex = 18;
        this.btnSearch.Text = "Search";
        this.btnSearch.UseVisualStyleBackColor = true;
        this.btnSearch.Click += this.btnSearch_Click;
        // 
        // btnDelete
        // 
        this.btnDelete.Location = new Point(465, 147);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new Size(112, 34);
        this.btnDelete.TabIndex = 19;
        this.btnDelete.Text = "Delete";
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Click += this.btnDelete_Click;
        // 
        // btnUpdate
        // 
        this.btnUpdate.Location = new Point(465, 78);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new Size(112, 34);
        this.btnUpdate.TabIndex = 20;
        this.btnUpdate.Text = "Update";
        this.btnUpdate.UseVisualStyleBackColor = true;
        this.btnUpdate.Click += this.btnUpdate_Click;
        // 
        // lstClients
        // 
        this.lstClients.FormattingEnabled = true;
        this.lstClients.ItemHeight = 25;
        this.lstClients.Location = new Point(719, 20);
        this.lstClients.Name = "lstClients";
        this.lstClients.Size = new Size(263, 229);
        this.lstClients.TabIndex = 21;
        this.lstClients.SelectedIndexChanged += this.lstClients_SelectedIndexChanged;
        // 
        // ClientView
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1027, 518);
        this.Controls.Add(this.lstClients);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnSearch);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.btnCreate);
        this.Controls.Add(this.label8);
        this.Controls.Add(this.label6);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.txtContactFirstName);
        this.Controls.Add(this.txtContactLastName);
        this.Controls.Add(this.txtContactEmail);
        this.Controls.Add(this.txtContactTelephone);
        this.Controls.Add(this.txtWarehouseId);
        this.Controls.Add(this.txtSearch);
        this.Controls.Add(this.txtClientName);
        this.Name = "ClientView";
        this.Text = "ClientView";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private TextBox txtClientName;
    private TextBox txtSearch;
    private TextBox txtWarehouseId;
    private TextBox txtContactTelephone;
    private TextBox txtContactEmail;
    private TextBox txtContactLastName;
    private TextBox txtContactFirstName;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label8;
    private Button btnCreate;
    private Button btnClear;
    private Button btnSearch;
    private Button btnDelete;
    private Button btnUpdate;
    private ListBox lstClients;
}