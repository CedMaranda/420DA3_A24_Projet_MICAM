namespace _420DA3_A24_Projet.Presentation.Views;

partial class ProductView {
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
        this.tabLayPanProduct = new TableLayoutPanel();
        this.dataGroupPanel = new Panel();
        this.qtyValue = new NumericUpDown();
        this.productWeightTxt = new TextBox();
        this.prodWeightLabel = new Label();
        this.qtyProdTargetedLabel = new Label();
        this.productQuantityLabel = new Label();
        this.prodSupplierCodeTxt = new TextBox();
        this.productSupplierCodeLabel = new Label();
        this.supplierNameCombo = new ComboBox();
        this.supplierLabel = new Label();
        this.imageFileNameTxt = new TextBox();
        this.imageFileNameLabel = new Label();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.clientNameCombo = new ComboBox();
        this.upcCodeTxt = new TextBox();
        this.prodDescTxt = new TextBox();
        this.productNameTxt = new TextBox();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.clientLabel = new Label();
        this.upcCodeLabel = new Label();
        this.productDescriptionLabel = new Label();
        this.productNameLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.qtyTargetedValue = new NumericUpDown();
        this.addBtn = new Button();
        this.updateBtn = new Button();
        this.deleteBtn = new Button();
        this.tabLayPanProduct.SuspendLayout();
        this.dataGroupPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.qtyValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.qtyTargetedValue).BeginInit();
        this.SuspendLayout();
        // 
        // tabLayPanProduct
        // 
        this.tabLayPanProduct.ColumnCount = 3;
        this.tabLayPanProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tabLayPanProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        this.tabLayPanProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.tabLayPanProduct.Controls.Add(this.dataGroupPanel, 1, 0);
        this.tabLayPanProduct.Dock = DockStyle.Fill;
        this.tabLayPanProduct.Location = new Point(0, 0);
        this.tabLayPanProduct.Name = "tabLayPanProduct";
        this.tabLayPanProduct.RowCount = 1;
        this.tabLayPanProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tabLayPanProduct.Size = new Size(840, 760);
        this.tabLayPanProduct.TabIndex = 0;
        // 
        // dataGroupPanel
        // 
        this.dataGroupPanel.Controls.Add(this.deleteBtn);
        this.dataGroupPanel.Controls.Add(this.updateBtn);
        this.dataGroupPanel.Controls.Add(this.qtyTargetedValue);
        this.dataGroupPanel.Controls.Add(this.addBtn);
        this.dataGroupPanel.Controls.Add(this.qtyValue);
        this.dataGroupPanel.Controls.Add(this.productWeightTxt);
        this.dataGroupPanel.Controls.Add(this.prodWeightLabel);
        this.dataGroupPanel.Controls.Add(this.qtyProdTargetedLabel);
        this.dataGroupPanel.Controls.Add(this.productQuantityLabel);
        this.dataGroupPanel.Controls.Add(this.prodSupplierCodeTxt);
        this.dataGroupPanel.Controls.Add(this.productSupplierCodeLabel);
        this.dataGroupPanel.Controls.Add(this.supplierNameCombo);
        this.dataGroupPanel.Controls.Add(this.supplierLabel);
        this.dataGroupPanel.Controls.Add(this.imageFileNameTxt);
        this.dataGroupPanel.Controls.Add(this.imageFileNameLabel);
        this.dataGroupPanel.Controls.Add(this.dateDeletedValue);
        this.dataGroupPanel.Controls.Add(this.dateModifiedValue);
        this.dataGroupPanel.Controls.Add(this.dateCreatedValue);
        this.dataGroupPanel.Controls.Add(this.clientNameCombo);
        this.dataGroupPanel.Controls.Add(this.upcCodeTxt);
        this.dataGroupPanel.Controls.Add(this.prodDescTxt);
        this.dataGroupPanel.Controls.Add(this.productNameTxt);
        this.dataGroupPanel.Controls.Add(this.dateDeletedLabel);
        this.dataGroupPanel.Controls.Add(this.dateModifiedLabel);
        this.dataGroupPanel.Controls.Add(this.dateCreatedLabel);
        this.dataGroupPanel.Controls.Add(this.clientLabel);
        this.dataGroupPanel.Controls.Add(this.upcCodeLabel);
        this.dataGroupPanel.Controls.Add(this.productDescriptionLabel);
        this.dataGroupPanel.Controls.Add(this.productNameLabel);
        this.dataGroupPanel.Controls.Add(this.idValue);
        this.dataGroupPanel.Controls.Add(this.idLabel);
        this.dataGroupPanel.Dock = DockStyle.Fill;
        this.dataGroupPanel.Location = new Point(171, 3);
        this.dataGroupPanel.Name = "dataGroupPanel";
        this.dataGroupPanel.Size = new Size(498, 754);
        this.dataGroupPanel.TabIndex = 0;
        // 
        // qtyValue
        // 
        this.qtyValue.Enabled = false;
        this.qtyValue.Location = new Point(188, 419);
        this.qtyValue.Margin = new Padding(3, 4, 3, 4);
        this.qtyValue.Name = "qtyValue";
        this.qtyValue.Size = new Size(271, 27);
        this.qtyValue.TabIndex = 44;
        // 
        // productWeightTxt
        // 
        this.productWeightTxt.Enabled = false;
        this.productWeightTxt.Location = new Point(188, 516);
        this.productWeightTxt.Margin = new Padding(3, 4, 3, 4);
        this.productWeightTxt.Name = "productWeightTxt";
        this.productWeightTxt.PlaceholderText = "Poids du produit";
        this.productWeightTxt.Size = new Size(271, 27);
        this.productWeightTxt.TabIndex = 43;
        // 
        // prodWeightLabel
        // 
        this.prodWeightLabel.Location = new Point(7, 515);
        this.prodWeightLabel.Margin = new Padding(6, 7, 6, 7);
        this.prodWeightLabel.Name = "prodWeightLabel";
        this.prodWeightLabel.Size = new Size(177, 27);
        this.prodWeightLabel.TabIndex = 42;
        this.prodWeightLabel.Text = "Poids du produit : ";
        this.prodWeightLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // qtyProdTargetedLabel
        // 
        this.qtyProdTargetedLabel.Location = new Point(7, 470);
        this.qtyProdTargetedLabel.Margin = new Padding(6, 7, 6, 7);
        this.qtyProdTargetedLabel.Name = "qtyProdTargetedLabel";
        this.qtyProdTargetedLabel.Size = new Size(177, 27);
        this.qtyProdTargetedLabel.TabIndex = 40;
        this.qtyProdTargetedLabel.Text = "Quantité de produit visé : ";
        this.qtyProdTargetedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // productQuantityLabel
        // 
        this.productQuantityLabel.Location = new Point(7, 418);
        this.productQuantityLabel.Margin = new Padding(6, 7, 6, 7);
        this.productQuantityLabel.Name = "productQuantityLabel";
        this.productQuantityLabel.Size = new Size(177, 27);
        this.productQuantityLabel.TabIndex = 38;
        this.productQuantityLabel.Text = "Quantité : ";
        this.productQuantityLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // prodSupplierCodeTxt
        // 
        this.prodSupplierCodeTxt.Enabled = false;
        this.prodSupplierCodeTxt.Location = new Point(221, 371);
        this.prodSupplierCodeTxt.Margin = new Padding(3, 4, 3, 4);
        this.prodSupplierCodeTxt.Name = "prodSupplierCodeTxt";
        this.prodSupplierCodeTxt.PlaceholderText = "Code produit du fournisseur";
        this.prodSupplierCodeTxt.Size = new Size(238, 27);
        this.prodSupplierCodeTxt.TabIndex = 37;
        // 
        // productSupplierCodeLabel
        // 
        this.productSupplierCodeLabel.Location = new Point(7, 370);
        this.productSupplierCodeLabel.Margin = new Padding(6, 7, 6, 7);
        this.productSupplierCodeLabel.Name = "productSupplierCodeLabel";
        this.productSupplierCodeLabel.Size = new Size(205, 27);
        this.productSupplierCodeLabel.TabIndex = 36;
        this.productSupplierCodeLabel.Text = "Code produit du fournisseur : ";
        this.productSupplierCodeLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // supplierNameCombo
        // 
        this.supplierNameCombo.FormattingEnabled = true;
        this.supplierNameCombo.Location = new Point(188, 326);
        this.supplierNameCombo.Margin = new Padding(3, 4, 3, 4);
        this.supplierNameCombo.Name = "supplierNameCombo";
        this.supplierNameCombo.Size = new Size(271, 28);
        this.supplierNameCombo.TabIndex = 35;
        // 
        // supplierLabel
        // 
        this.supplierLabel.Location = new Point(15, 325);
        this.supplierLabel.Margin = new Padding(6, 7, 6, 7);
        this.supplierLabel.Name = "supplierLabel";
        this.supplierLabel.Size = new Size(169, 31);
        this.supplierLabel.TabIndex = 34;
        this.supplierLabel.Text = "Fournisseur : ";
        this.supplierLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // imageFileNameTxt
        // 
        this.imageFileNameTxt.Enabled = false;
        this.imageFileNameTxt.Location = new Point(188, 236);
        this.imageFileNameTxt.Margin = new Padding(3, 4, 3, 4);
        this.imageFileNameTxt.Name = "imageFileNameTxt";
        this.imageFileNameTxt.PlaceholderText = "Nom fichier d'image";
        this.imageFileNameTxt.Size = new Size(271, 27);
        this.imageFileNameTxt.TabIndex = 33;
        // 
        // imageFileNameLabel
        // 
        this.imageFileNameLabel.Location = new Point(7, 235);
        this.imageFileNameLabel.Margin = new Padding(6, 7, 6, 7);
        this.imageFileNameLabel.Name = "imageFileNameLabel";
        this.imageFileNameLabel.Size = new Size(177, 27);
        this.imageFileNameLabel.TabIndex = 32;
        this.imageFileNameLabel.Text = "Nom du fichier d'image : ";
        this.imageFileNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(188, 650);
        this.dateDeletedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(271, 27);
        this.dateDeletedValue.TabIndex = 31;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(188, 606);
        this.dateModifiedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(271, 27);
        this.dateModifiedValue.TabIndex = 30;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(188, 562);
        this.dateCreatedValue.Margin = new Padding(3, 4, 3, 4);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(271, 27);
        this.dateCreatedValue.TabIndex = 29;
        // 
        // clientNameCombo
        // 
        this.clientNameCombo.FormattingEnabled = true;
        this.clientNameCombo.Location = new Point(188, 280);
        this.clientNameCombo.Margin = new Padding(3, 4, 3, 4);
        this.clientNameCombo.Name = "clientNameCombo";
        this.clientNameCombo.Size = new Size(271, 28);
        this.clientNameCombo.TabIndex = 28;
        // 
        // upcCodeTxt
        // 
        this.upcCodeTxt.Enabled = false;
        this.upcCodeTxt.Location = new Point(188, 191);
        this.upcCodeTxt.Margin = new Padding(3, 4, 3, 4);
        this.upcCodeTxt.Name = "upcCodeTxt";
        this.upcCodeTxt.PlaceholderText = "Code UPC";
        this.upcCodeTxt.Size = new Size(271, 27);
        this.upcCodeTxt.TabIndex = 27;
        // 
        // prodDescTxt
        // 
        this.prodDescTxt.Location = new Point(188, 118);
        this.prodDescTxt.Margin = new Padding(3, 4, 3, 4);
        this.prodDescTxt.Multiline = true;
        this.prodDescTxt.Name = "prodDescTxt";
        this.prodDescTxt.PlaceholderText = "Description du produit";
        this.prodDescTxt.Size = new Size(271, 55);
        this.prodDescTxt.TabIndex = 26;
        this.prodDescTxt.UseSystemPasswordChar = true;
        // 
        // productNameTxt
        // 
        this.productNameTxt.Location = new Point(188, 74);
        this.productNameTxt.Margin = new Padding(3, 4, 3, 4);
        this.productNameTxt.Name = "productNameTxt";
        this.productNameTxt.PlaceholderText = "Nom du produit";
        this.productNameTxt.Size = new Size(271, 27);
        this.productNameTxt.TabIndex = 25;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(15, 650);
        this.dateDeletedLabel.Margin = new Padding(6, 7, 6, 7);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(169, 31);
        this.dateDeletedLabel.TabIndex = 24;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(15, 606);
        this.dateModifiedLabel.Margin = new Padding(6, 7, 6, 7);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(169, 31);
        this.dateModifiedLabel.TabIndex = 23;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(15, 562);
        this.dateCreatedLabel.Margin = new Padding(6, 7, 6, 7);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(169, 31);
        this.dateCreatedLabel.TabIndex = 22;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // clientLabel
        // 
        this.clientLabel.Location = new Point(15, 279);
        this.clientLabel.Margin = new Padding(6, 7, 6, 7);
        this.clientLabel.Name = "clientLabel";
        this.clientLabel.Size = new Size(169, 31);
        this.clientLabel.TabIndex = 21;
        this.clientLabel.Text = "Client : ";
        this.clientLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // upcCodeLabel
        // 
        this.upcCodeLabel.Location = new Point(15, 190);
        this.upcCodeLabel.Margin = new Padding(6, 7, 6, 7);
        this.upcCodeLabel.Name = "upcCodeLabel";
        this.upcCodeLabel.Size = new Size(169, 31);
        this.upcCodeLabel.TabIndex = 20;
        this.upcCodeLabel.Text = "Code UPC : ";
        this.upcCodeLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // productDescriptionLabel
        // 
        this.productDescriptionLabel.Location = new Point(15, 120);
        this.productDescriptionLabel.Margin = new Padding(6, 7, 6, 7);
        this.productDescriptionLabel.Name = "productDescriptionLabel";
        this.productDescriptionLabel.Size = new Size(169, 31);
        this.productDescriptionLabel.TabIndex = 19;
        this.productDescriptionLabel.Text = "Description du produit : ";
        this.productDescriptionLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // productNameLabel
        // 
        this.productNameLabel.Location = new Point(15, 73);
        this.productNameLabel.Margin = new Padding(6, 7, 6, 7);
        this.productNameLabel.Name = "productNameLabel";
        this.productNameLabel.Size = new Size(169, 31);
        this.productNameLabel.TabIndex = 18;
        this.productNameLabel.Text = "Nom du produit : ";
        this.productNameLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(188, 32);
        this.idValue.Margin = new Padding(3, 4, 3, 4);
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(271, 27);
        this.idValue.TabIndex = 17;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(15, 29);
        this.idLabel.Margin = new Padding(6, 7, 6, 7);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(169, 31);
        this.idLabel.TabIndex = 16;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // qtyTargetedValue
        // 
        this.qtyTargetedValue.Enabled = false;
        this.qtyTargetedValue.Location = new Point(188, 470);
        this.qtyTargetedValue.Margin = new Padding(3, 4, 3, 4);
        this.qtyTargetedValue.Name = "qtyTargetedValue";
        this.qtyTargetedValue.Size = new Size(271, 27);
        this.qtyTargetedValue.TabIndex = 45;
        // 
        // addBtn
        // 
        this.addBtn.Location = new Point(15, 716);
        this.addBtn.Name = "addBtn";
        this.addBtn.Size = new Size(94, 29);
        this.addBtn.TabIndex = 1;
        this.addBtn.Text = "Ajouter";
        this.addBtn.UseVisualStyleBackColor = true;
        // 
        // updateBtn
        // 
        this.updateBtn.Location = new Point(175, 716);
        this.updateBtn.Name = "updateBtn";
        this.updateBtn.Size = new Size(123, 29);
        this.updateBtn.TabIndex = 46;
        this.updateBtn.Text = "Mettre à jour";
        this.updateBtn.UseVisualStyleBackColor = true;
        // 
        // deleteBtn
        // 
        this.deleteBtn.Location = new Point(365, 716);
        this.deleteBtn.Name = "deleteBtn";
        this.deleteBtn.Size = new Size(94, 29);
        this.deleteBtn.TabIndex = 47;
        this.deleteBtn.Text = "Supprimer";
        this.deleteBtn.UseVisualStyleBackColor = true;
        // 
        // ProductView
        // 
        this.AutoScaleDimensions = new SizeF(8F, 20F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(840, 760);
        this.Controls.Add(this.tabLayPanProduct);
        this.Name = "ProductView";
        this.Text = "Gestion des produits";
        this.tabLayPanProduct.ResumeLayout(false);
        this.dataGroupPanel.ResumeLayout(false);
        this.dataGroupPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.qtyValue).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.qtyTargetedValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tabLayPanProduct;
    private Panel dataGroupPanel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private ComboBox clientNameCombo;
    private TextBox upcCodeTxt;
    private TextBox prodDescTxt;
    private TextBox productNameTxt;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Label clientLabel;
    private Label upcCodeLabel;
    private Label productDescriptionLabel;
    private Label productNameLabel;
    private NumericUpDown idValue;
    private Label idLabel;
    private TextBox imageFileNameTxt;
    private Label imageFileNameLabel;
    private TextBox productWeightTxt;
    private Label prodWeightLabel;
    private Label qtyProdTargetedLabel;
    private Label productQuantityLabel;
    private TextBox prodSupplierCodeTxt;
    private Label productSupplierCodeLabel;
    private ComboBox supplierNameCombo;
    private Label supplierLabel;
    private NumericUpDown qtyValue;
    private NumericUpDown qtyTargetedValue;
    private Button deleteBtn;
    private Button updateBtn;
    private Button addBtn;
}