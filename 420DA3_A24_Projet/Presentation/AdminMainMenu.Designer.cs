﻿namespace _420DA3_A24_Projet.Presentation;

partial class AdminMainMenu {
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
        this.topBarPanel = new Panel();
        this.bottomBarPanel = new Panel();
        this.buttonLogout = new Button();
        this.centerTableLayoutPanel = new TableLayoutPanel();
        this.purchaseOrderMainPanel = new Panel();
        this.poSearchResults = new ListBox();
        this.poButtonsTLP = new TableLayoutPanel();
        this.panel3 = new Panel();
        this.buttonViewPO = new Button();
        this.poSearchTextBox = new TextBox();
        this.createPOTLP = new TableLayoutPanel();
        this.buttonCreatePO = new Button();
        this.purchaseOrderManagementLabel = new Label();
        this.shipmentMainPanel = new Panel();
        this.createShipmentTLP = new TableLayoutPanel();
        this.buttonCreateShipment = new Button();
        this.shipmentSearchSOResults = new ListBox();
        this.shipmentSearchSOTextBox = new TextBox();
        this.shipmentManagementLabel = new Label();
        this.shipOrderMainPanel = new Panel();
        this.soSearchResults = new ListBox();
        this.tableLayoutPanel3 = new TableLayoutPanel();
        this.panel1 = new Panel();
        this.buttonDeleteSO = new Button();
        this.buttonEditSO = new Button();
        this.buttonViewSO = new Button();
        this.soSearchTextBox = new TextBox();
        this.createSOTLP = new TableLayoutPanel();
        this.buttonCreateSO = new Button();
        this.shipOrderManagementLabel = new Label();
        this.addressMainPanel = new Panel();
        this.addressManagementLabel = new Label();
        this.warehouseMainPanel = new Panel();
        this.createWarehouseTLP = new TableLayoutPanel();
        this.buttonCreateWarehouse = new Button();
        this.warehouseManagementLabel = new Label();
        this.supplierMainPanel = new Panel();
        this.supplierManagementLabel = new Label();
        this.productMainPanel = new Panel();
        this.productManagementLabel = new Label();
        this.clientMainPanel = new Panel();
        this.clientManagementLabel = new Label();
        this.roleMainPanel = new Panel();
        this.roleSearchResults = new ListBox();
        this.roleSearchTextBox = new TextBox();
        this.roleButtonsTLP = new TableLayoutPanel();
        this.panel2 = new Panel();
        this.buttonDeleteRole = new Button();
        this.buttonEditRole = new Button();
        this.buttonViewRole = new Button();
        this.createRoleTLP = new TableLayoutPanel();
        this.buttonCreateRole = new Button();
        this.roleManagementLabel = new Label();
        this.userMainPanel = new Panel();
        this.userSearchResults = new ListBox();
        this.userSearchTextBox = new TextBox();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.userActionButtonsPanel = new Panel();
        this.buttonDeleteUser = new Button();
        this.buttonEditUser = new Button();
        this.buttonViewUser = new Button();
        this.createUserTLP = new TableLayoutPanel();
        this.buttonCreateUser = new Button();
        this.userManagementLabel = new Label();
        this.bottomBarPanel.SuspendLayout();
        this.centerTableLayoutPanel.SuspendLayout();
        this.purchaseOrderMainPanel.SuspendLayout();
        this.poButtonsTLP.SuspendLayout();
        this.panel3.SuspendLayout();
        this.createPOTLP.SuspendLayout();
        this.shipmentMainPanel.SuspendLayout();
        this.createShipmentTLP.SuspendLayout();
        this.shipOrderMainPanel.SuspendLayout();
        this.tableLayoutPanel3.SuspendLayout();
        this.panel1.SuspendLayout();
        this.createSOTLP.SuspendLayout();
        this.addressMainPanel.SuspendLayout();
        this.warehouseMainPanel.SuspendLayout();
        this.createWarehouseTLP.SuspendLayout();
        this.supplierMainPanel.SuspendLayout();
        this.productMainPanel.SuspendLayout();
        this.clientMainPanel.SuspendLayout();
        this.roleMainPanel.SuspendLayout();
        this.roleButtonsTLP.SuspendLayout();
        this.panel2.SuspendLayout();
        this.createRoleTLP.SuspendLayout();
        this.userMainPanel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.userActionButtonsPanel.SuspendLayout();
        this.createUserTLP.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Margin = new Padding(4, 5, 4, 5);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1436, 83);
        this.topBarPanel.TabIndex = 0;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.buttonLogout);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 907);
        this.bottomBarPanel.Margin = new Padding(4, 5, 4, 5);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1436, 83);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // buttonLogout
        // 
        this.buttonLogout.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonLogout.Location = new Point(1241, 10);
        this.buttonLogout.Margin = new Padding(4, 5, 4, 5);
        this.buttonLogout.Name = "buttonLogout";
        this.buttonLogout.Size = new Size(177, 53);
        this.buttonLogout.TabIndex = 0;
        this.buttonLogout.Text = "DÉCONNEXION";
        this.buttonLogout.UseVisualStyleBackColor = true;
        this.buttonLogout.Click += this.ButtonLogout_Click;
        // 
        // centerTableLayoutPanel
        // 
        this.centerTableLayoutPanel.ColumnCount = 5;
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.centerTableLayoutPanel.Controls.Add(this.purchaseOrderMainPanel, 4, 1);
        this.centerTableLayoutPanel.Controls.Add(this.shipmentMainPanel, 3, 1);
        this.centerTableLayoutPanel.Controls.Add(this.shipOrderMainPanel, 2, 1);
        this.centerTableLayoutPanel.Controls.Add(this.addressMainPanel, 1, 1);
        this.centerTableLayoutPanel.Controls.Add(this.warehouseMainPanel, 0, 1);
        this.centerTableLayoutPanel.Controls.Add(this.supplierMainPanel, 4, 0);
        this.centerTableLayoutPanel.Controls.Add(this.productMainPanel, 3, 0);
        this.centerTableLayoutPanel.Controls.Add(this.clientMainPanel, 2, 0);
        this.centerTableLayoutPanel.Controls.Add(this.roleMainPanel, 1, 0);
        this.centerTableLayoutPanel.Controls.Add(this.userMainPanel, 0, 0);
        this.centerTableLayoutPanel.Dock = DockStyle.Fill;
        this.centerTableLayoutPanel.Location = new Point(0, 83);
        this.centerTableLayoutPanel.Margin = new Padding(4, 5, 4, 5);
        this.centerTableLayoutPanel.Name = "centerTableLayoutPanel";
        this.centerTableLayoutPanel.RowCount = 2;
        this.centerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.centerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.centerTableLayoutPanel.Size = new Size(1436, 824);
        this.centerTableLayoutPanel.TabIndex = 2;
        // 
        // purchaseOrderMainPanel
        // 
        this.purchaseOrderMainPanel.Controls.Add(this.poSearchResults);
        this.purchaseOrderMainPanel.Controls.Add(this.poButtonsTLP);
        this.purchaseOrderMainPanel.Controls.Add(this.poSearchTextBox);
        this.purchaseOrderMainPanel.Controls.Add(this.createPOTLP);
        this.purchaseOrderMainPanel.Controls.Add(this.purchaseOrderManagementLabel);
        this.purchaseOrderMainPanel.Dock = DockStyle.Fill;
        this.purchaseOrderMainPanel.Location = new Point(1152, 417);
        this.purchaseOrderMainPanel.Margin = new Padding(4, 5, 4, 5);
        this.purchaseOrderMainPanel.Name = "purchaseOrderMainPanel";
        this.purchaseOrderMainPanel.Size = new Size(280, 402);
        this.purchaseOrderMainPanel.TabIndex = 9;
        // 
        // poSearchResults
        // 
        this.poSearchResults.Dock = DockStyle.Fill;
        this.poSearchResults.FormattingEnabled = true;
        this.poSearchResults.ItemHeight = 25;
        this.poSearchResults.Location = new Point(0, 136);
        this.poSearchResults.Margin = new Padding(4, 5, 4, 5);
        this.poSearchResults.Name = "poSearchResults";
        this.poSearchResults.Size = new Size(280, 133);
        this.poSearchResults.TabIndex = 14;
        // 
        // poButtonsTLP
        // 
        this.poButtonsTLP.ColumnCount = 3;
        this.poButtonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.poButtonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
        this.poButtonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.poButtonsTLP.Controls.Add(this.panel3, 1, 0);
        this.poButtonsTLP.Dock = DockStyle.Bottom;
        this.poButtonsTLP.Location = new Point(0, 269);
        this.poButtonsTLP.Margin = new Padding(4, 5, 4, 5);
        this.poButtonsTLP.Name = "poButtonsTLP";
        this.poButtonsTLP.RowCount = 1;
        this.poButtonsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.poButtonsTLP.Size = new Size(280, 133);
        this.poButtonsTLP.TabIndex = 13;
        // 
        // panel3
        // 
        this.panel3.Controls.Add(this.buttonViewPO);
        this.panel3.Dock = DockStyle.Fill;
        this.panel3.Location = new Point(54, 8);
        this.panel3.Margin = new Padding(0, 8, 0, 0);
        this.panel3.Name = "panel3";
        this.panel3.Size = new Size(171, 125);
        this.panel3.TabIndex = 0;
        // 
        // buttonViewPO
        // 
        this.buttonViewPO.Dock = DockStyle.Top;
        this.buttonViewPO.Enabled = false;
        this.buttonViewPO.Location = new Point(0, 0);
        this.buttonViewPO.Margin = new Padding(4, 5, 4, 5);
        this.buttonViewPO.Name = "buttonViewPO";
        this.buttonViewPO.Size = new Size(171, 38);
        this.buttonViewPO.TabIndex = 0;
        this.buttonViewPO.Text = "Voir Détails";
        this.buttonViewPO.UseVisualStyleBackColor = true;
        // 
        // poSearchTextBox
        // 
        this.poSearchTextBox.Dock = DockStyle.Top;
        this.poSearchTextBox.Location = new Point(0, 105);
        this.poSearchTextBox.Margin = new Padding(4, 5, 4, 5);
        this.poSearchTextBox.Name = "poSearchTextBox";
        this.poSearchTextBox.PlaceholderText = "Rechercher ordre de restockage";
        this.poSearchTextBox.Size = new Size(280, 31);
        this.poSearchTextBox.TabIndex = 12;
        // 
        // createPOTLP
        // 
        this.createPOTLP.ColumnCount = 3;
        this.createPOTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createPOTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
        this.createPOTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createPOTLP.Controls.Add(this.buttonCreatePO, 1, 0);
        this.createPOTLP.Dock = DockStyle.Top;
        this.createPOTLP.Location = new Point(0, 38);
        this.createPOTLP.Margin = new Padding(4, 5, 4, 5);
        this.createPOTLP.Name = "createPOTLP";
        this.createPOTLP.RowCount = 1;
        this.createPOTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.createPOTLP.Size = new Size(280, 67);
        this.createPOTLP.TabIndex = 11;
        // 
        // buttonCreatePO
        // 
        this.buttonCreatePO.Dock = DockStyle.Bottom;
        this.buttonCreatePO.Location = new Point(37, 24);
        this.buttonCreatePO.Margin = new Padding(4, 5, 4, 5);
        this.buttonCreatePO.Name = "buttonCreatePO";
        this.buttonCreatePO.Size = new Size(206, 38);
        this.buttonCreatePO.TabIndex = 0;
        this.buttonCreatePO.Text = "Créer Ordre Restockage";
        this.buttonCreatePO.UseVisualStyleBackColor = true;
        // 
        // purchaseOrderManagementLabel
        // 
        this.purchaseOrderManagementLabel.Dock = DockStyle.Top;
        this.purchaseOrderManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.purchaseOrderManagementLabel.Location = new Point(0, 0);
        this.purchaseOrderManagementLabel.Margin = new Padding(4, 0, 4, 0);
        this.purchaseOrderManagementLabel.Name = "purchaseOrderManagementLabel";
        this.purchaseOrderManagementLabel.Size = new Size(280, 38);
        this.purchaseOrderManagementLabel.TabIndex = 0;
        this.purchaseOrderManagementLabel.Text = "Gestion des ordres de restockage";
        this.purchaseOrderManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // shipmentMainPanel
        // 
        this.shipmentMainPanel.Controls.Add(this.createShipmentTLP);
        this.shipmentMainPanel.Controls.Add(this.shipmentSearchSOResults);
        this.shipmentMainPanel.Controls.Add(this.shipmentSearchSOTextBox);
        this.shipmentMainPanel.Controls.Add(this.shipmentManagementLabel);
        this.shipmentMainPanel.Dock = DockStyle.Fill;
        this.shipmentMainPanel.Location = new Point(865, 417);
        this.shipmentMainPanel.Margin = new Padding(4, 5, 4, 5);
        this.shipmentMainPanel.Name = "shipmentMainPanel";
        this.shipmentMainPanel.Size = new Size(279, 402);
        this.shipmentMainPanel.TabIndex = 8;
        // 
        // createShipmentTLP
        // 
        this.createShipmentTLP.ColumnCount = 3;
        this.createShipmentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createShipmentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
        this.createShipmentTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createShipmentTLP.Controls.Add(this.buttonCreateShipment, 1, 0);
        this.createShipmentTLP.Dock = DockStyle.Top;
        this.createShipmentTLP.Location = new Point(0, 273);
        this.createShipmentTLP.Margin = new Padding(4, 5, 4, 5);
        this.createShipmentTLP.Name = "createShipmentTLP";
        this.createShipmentTLP.RowCount = 1;
        this.createShipmentTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.createShipmentTLP.Size = new Size(279, 67);
        this.createShipmentTLP.TabIndex = 9;
        // 
        // buttonCreateShipment
        // 
        this.buttonCreateShipment.Dock = DockStyle.Bottom;
        this.buttonCreateShipment.Location = new Point(36, 24);
        this.buttonCreateShipment.Margin = new Padding(4, 5, 4, 5);
        this.buttonCreateShipment.Name = "buttonCreateShipment";
        this.buttonCreateShipment.Size = new Size(206, 38);
        this.buttonCreateShipment.TabIndex = 0;
        this.buttonCreateShipment.Text = "Créer Expédition";
        this.buttonCreateShipment.UseVisualStyleBackColor = true;
        this.buttonCreateShipment.Click += this.ButtonCreateShipment_Click_1;
        // 
        // shipmentSearchSOResults
        // 
        this.shipmentSearchSOResults.Dock = DockStyle.Top;
        this.shipmentSearchSOResults.FormattingEnabled = true;
        this.shipmentSearchSOResults.ItemHeight = 25;
        this.shipmentSearchSOResults.Location = new Point(0, 69);
        this.shipmentSearchSOResults.Margin = new Padding(4, 5, 4, 5);
        this.shipmentSearchSOResults.Name = "shipmentSearchSOResults";
        this.shipmentSearchSOResults.Size = new Size(279, 204);
        this.shipmentSearchSOResults.TabIndex = 8;
        this.shipmentSearchSOResults.SelectedIndexChanged += this.ShipmentSearchSOResults_SelectedIndexChanged;
        // 
        // shipmentSearchSOTextBox
        // 
        this.shipmentSearchSOTextBox.Dock = DockStyle.Top;
        this.shipmentSearchSOTextBox.Location = new Point(0, 38);
        this.shipmentSearchSOTextBox.Margin = new Padding(4, 5, 4, 5);
        this.shipmentSearchSOTextBox.Name = "shipmentSearchSOTextBox";
        this.shipmentSearchSOTextBox.PlaceholderText = "Rechercher ordre d'expédition";
        this.shipmentSearchSOTextBox.Size = new Size(279, 31);
        this.shipmentSearchSOTextBox.TabIndex = 7;
        this.shipmentSearchSOTextBox.TextChanged += this.ShipmentSearchSOTextBox_TextChanged;
        // 
        // shipmentManagementLabel
        // 
        this.shipmentManagementLabel.Dock = DockStyle.Top;
        this.shipmentManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.shipmentManagementLabel.Location = new Point(0, 0);
        this.shipmentManagementLabel.Margin = new Padding(4, 0, 4, 0);
        this.shipmentManagementLabel.Name = "shipmentManagementLabel";
        this.shipmentManagementLabel.Size = new Size(279, 38);
        this.shipmentManagementLabel.TabIndex = 0;
        this.shipmentManagementLabel.Text = "Gestion des expéditions";
        this.shipmentManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // shipOrderMainPanel
        // 
        this.shipOrderMainPanel.Controls.Add(this.soSearchResults);
        this.shipOrderMainPanel.Controls.Add(this.tableLayoutPanel3);
        this.shipOrderMainPanel.Controls.Add(this.soSearchTextBox);
        this.shipOrderMainPanel.Controls.Add(this.createSOTLP);
        this.shipOrderMainPanel.Controls.Add(this.shipOrderManagementLabel);
        this.shipOrderMainPanel.Dock = DockStyle.Fill;
        this.shipOrderMainPanel.Location = new Point(578, 417);
        this.shipOrderMainPanel.Margin = new Padding(4, 5, 4, 5);
        this.shipOrderMainPanel.Name = "shipOrderMainPanel";
        this.shipOrderMainPanel.Size = new Size(279, 402);
        this.shipOrderMainPanel.TabIndex = 7;
        // 
        // soSearchResults
        // 
        this.soSearchResults.Dock = DockStyle.Fill;
        this.soSearchResults.FormattingEnabled = true;
        this.soSearchResults.ItemHeight = 25;
        this.soSearchResults.Location = new Point(0, 136);
        this.soSearchResults.Margin = new Padding(4, 5, 4, 5);
        this.soSearchResults.Name = "soSearchResults";
        this.soSearchResults.Size = new Size(279, 133);
        this.soSearchResults.TabIndex = 6;
        this.soSearchResults.SelectedIndexChanged += this.SoSearchResults_SelectedIndexChanged;
        // 
        // tableLayoutPanel3
        // 
        this.tableLayoutPanel3.ColumnCount = 3;
        this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
        this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
        this.tableLayoutPanel3.Dock = DockStyle.Bottom;
        this.tableLayoutPanel3.Location = new Point(0, 269);
        this.tableLayoutPanel3.Margin = new Padding(4, 5, 4, 5);
        this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        this.tableLayoutPanel3.RowCount = 1;
        this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel3.Size = new Size(279, 133);
        this.tableLayoutPanel3.TabIndex = 5;
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.buttonDeleteSO);
        this.panel1.Controls.Add(this.buttonEditSO);
        this.panel1.Controls.Add(this.buttonViewSO);
        this.panel1.Dock = DockStyle.Fill;
        this.panel1.Location = new Point(54, 8);
        this.panel1.Margin = new Padding(0, 8, 0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(171, 125);
        this.panel1.TabIndex = 0;
        // 
        // buttonDeleteSO
        // 
        this.buttonDeleteSO.Dock = DockStyle.Top;
        this.buttonDeleteSO.Enabled = false;
        this.buttonDeleteSO.Location = new Point(0, 76);
        this.buttonDeleteSO.Margin = new Padding(4, 5, 4, 5);
        this.buttonDeleteSO.Name = "buttonDeleteSO";
        this.buttonDeleteSO.Size = new Size(171, 38);
        this.buttonDeleteSO.TabIndex = 2;
        this.buttonDeleteSO.Text = "Supprimer";
        this.buttonDeleteSO.UseVisualStyleBackColor = true;
        this.buttonDeleteSO.Click += this.ButtonDeleteSO_Click;
        // 
        // buttonEditSO
        // 
        this.buttonEditSO.Dock = DockStyle.Top;
        this.buttonEditSO.Enabled = false;
        this.buttonEditSO.Location = new Point(0, 38);
        this.buttonEditSO.Margin = new Padding(4, 5, 4, 5);
        this.buttonEditSO.Name = "buttonEditSO";
        this.buttonEditSO.Size = new Size(171, 38);
        this.buttonEditSO.TabIndex = 1;
        this.buttonEditSO.Text = "Modifier";
        this.buttonEditSO.UseVisualStyleBackColor = true;
        this.buttonEditSO.Click += this.ButtonEditSO_Click;
        // 
        // buttonViewSO
        // 
        this.buttonViewSO.Dock = DockStyle.Top;
        this.buttonViewSO.Enabled = false;
        this.buttonViewSO.Location = new Point(0, 0);
        this.buttonViewSO.Margin = new Padding(4, 5, 4, 5);
        this.buttonViewSO.Name = "buttonViewSO";
        this.buttonViewSO.Size = new Size(171, 38);
        this.buttonViewSO.TabIndex = 0;
        this.buttonViewSO.Text = "Voir Détails";
        this.buttonViewSO.UseVisualStyleBackColor = true;
        this.buttonViewSO.Click += this.ButtonViewSO_Click;
        // 
        // soSearchTextBox
        // 
        this.soSearchTextBox.Dock = DockStyle.Top;
        this.soSearchTextBox.Location = new Point(0, 105);
        this.soSearchTextBox.Margin = new Padding(4, 5, 4, 5);
        this.soSearchTextBox.Name = "soSearchTextBox";
        this.soSearchTextBox.PlaceholderText = "Rechercher ordre d'expédition";
        this.soSearchTextBox.Size = new Size(279, 31);
        this.soSearchTextBox.TabIndex = 4;
        this.soSearchTextBox.TextChanged += this.SoSearchTextBox_TextChanged;
        // 
        // createSOTLP
        // 
        this.createSOTLP.ColumnCount = 3;
        this.createSOTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createSOTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
        this.createSOTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createSOTLP.Controls.Add(this.buttonCreateSO, 1, 0);
        this.createSOTLP.Dock = DockStyle.Top;
        this.createSOTLP.Location = new Point(0, 38);
        this.createSOTLP.Margin = new Padding(4, 5, 4, 5);
        this.createSOTLP.Name = "createSOTLP";
        this.createSOTLP.RowCount = 1;
        this.createSOTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.createSOTLP.Size = new Size(279, 67);
        this.createSOTLP.TabIndex = 2;
        // 
        // buttonCreateSO
        // 
        this.buttonCreateSO.Dock = DockStyle.Bottom;
        this.buttonCreateSO.Location = new Point(36, 24);
        this.buttonCreateSO.Margin = new Padding(4, 5, 4, 5);
        this.buttonCreateSO.Name = "buttonCreateSO";
        this.buttonCreateSO.Size = new Size(206, 38);
        this.buttonCreateSO.TabIndex = 0;
        this.buttonCreateSO.Text = "Créer Ordre Expédition";
        this.buttonCreateSO.UseVisualStyleBackColor = true;
        this.buttonCreateSO.Click += this.ButtonCreateSO_Click;
        // 
        // shipOrderManagementLabel
        // 
        this.shipOrderManagementLabel.Dock = DockStyle.Top;
        this.shipOrderManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.shipOrderManagementLabel.Location = new Point(0, 0);
        this.shipOrderManagementLabel.Margin = new Padding(4, 0, 4, 0);
        this.shipOrderManagementLabel.Name = "shipOrderManagementLabel";
        this.shipOrderManagementLabel.Size = new Size(279, 38);
        this.shipOrderManagementLabel.TabIndex = 0;
        this.shipOrderManagementLabel.Text = "Gestion des ordres d'expédition";
        this.shipOrderManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // addressMainPanel
        // 
        this.addressMainPanel.Controls.Add(this.addressManagementLabel);
        this.addressMainPanel.Dock = DockStyle.Fill;
        this.addressMainPanel.Location = new Point(291, 417);
        this.addressMainPanel.Margin = new Padding(4, 5, 4, 5);
        this.addressMainPanel.Name = "addressMainPanel";
        this.addressMainPanel.Size = new Size(279, 402);
        this.addressMainPanel.TabIndex = 6;
        // 
        // addressManagementLabel
        // 
        this.addressManagementLabel.Dock = DockStyle.Top;
        this.addressManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.addressManagementLabel.Location = new Point(0, 0);
        this.addressManagementLabel.Margin = new Padding(4, 0, 4, 0);
        this.addressManagementLabel.Name = "addressManagementLabel";
        this.addressManagementLabel.Size = new Size(279, 38);
        this.addressManagementLabel.TabIndex = 0;
        this.addressManagementLabel.Text = "Gestion des addresses";
        this.addressManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // warehouseMainPanel
        // 
        this.warehouseMainPanel.Controls.Add(this.createWarehouseTLP);
        this.warehouseMainPanel.Controls.Add(this.warehouseManagementLabel);
        this.warehouseMainPanel.Dock = DockStyle.Fill;
        this.warehouseMainPanel.Location = new Point(4, 417);
        this.warehouseMainPanel.Margin = new Padding(4, 5, 4, 5);
        this.warehouseMainPanel.Name = "warehouseMainPanel";
        this.warehouseMainPanel.Size = new Size(279, 402);
        this.warehouseMainPanel.TabIndex = 5;
        // 
        // createWarehouseTLP
        // 
        this.createWarehouseTLP.ColumnCount = 3;
        this.createWarehouseTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createWarehouseTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 214F));
        this.createWarehouseTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createWarehouseTLP.Controls.Add(this.buttonCreateWarehouse, 1, 0);
        this.createWarehouseTLP.Dock = DockStyle.Top;
        this.createWarehouseTLP.Location = new Point(0, 38);
        this.createWarehouseTLP.Margin = new Padding(4, 5, 4, 5);
        this.createWarehouseTLP.Name = "createWarehouseTLP";
        this.createWarehouseTLP.RowCount = 1;
        this.createWarehouseTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.createWarehouseTLP.Size = new Size(279, 67);
        this.createWarehouseTLP.TabIndex = 3;
        // 
        // buttonCreateWarehouse
        // 
        this.buttonCreateWarehouse.Dock = DockStyle.Bottom;
        this.buttonCreateWarehouse.Location = new Point(36, 24);
        this.buttonCreateWarehouse.Margin = new Padding(4, 5, 4, 5);
        this.buttonCreateWarehouse.Name = "buttonCreateWarehouse";
        this.buttonCreateWarehouse.Size = new Size(206, 38);
        this.buttonCreateWarehouse.TabIndex = 0;
        this.buttonCreateWarehouse.Text = "Créer Entrepôt";
        this.buttonCreateWarehouse.UseVisualStyleBackColor = true;
        this.buttonCreateWarehouse.Click += this.ButtonCreateWarehouse_Click;
        // 
        // warehouseManagementLabel
        // 
        this.warehouseManagementLabel.Dock = DockStyle.Top;
        this.warehouseManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.warehouseManagementLabel.Location = new Point(0, 0);
        this.warehouseManagementLabel.Margin = new Padding(4, 0, 4, 0);
        this.warehouseManagementLabel.Name = "warehouseManagementLabel";
        this.warehouseManagementLabel.Size = new Size(279, 38);
        this.warehouseManagementLabel.TabIndex = 0;
        this.warehouseManagementLabel.Text = "Gestion des entrepôts";
        this.warehouseManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // supplierMainPanel
        // 
        this.supplierMainPanel.Controls.Add(this.supplierManagementLabel);
        this.supplierMainPanel.Dock = DockStyle.Fill;
        this.supplierMainPanel.Location = new Point(1152, 5);
        this.supplierMainPanel.Margin = new Padding(4, 5, 4, 5);
        this.supplierMainPanel.Name = "supplierMainPanel";
        this.supplierMainPanel.Size = new Size(280, 402);
        this.supplierMainPanel.TabIndex = 4;
        // 
        // supplierManagementLabel
        // 
        this.supplierManagementLabel.Dock = DockStyle.Top;
        this.supplierManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.supplierManagementLabel.Location = new Point(0, 0);
        this.supplierManagementLabel.Margin = new Padding(4, 0, 4, 0);
        this.supplierManagementLabel.Name = "supplierManagementLabel";
        this.supplierManagementLabel.Size = new Size(280, 38);
        this.supplierManagementLabel.TabIndex = 0;
        this.supplierManagementLabel.Text = "Gestion des fournisseurs";
        this.supplierManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // productMainPanel
        // 
        this.productMainPanel.Controls.Add(this.productManagementLabel);
        this.productMainPanel.Dock = DockStyle.Fill;
        this.productMainPanel.Location = new Point(865, 5);
        this.productMainPanel.Margin = new Padding(4, 5, 4, 5);
        this.productMainPanel.Name = "productMainPanel";
        this.productMainPanel.Size = new Size(279, 402);
        this.productMainPanel.TabIndex = 3;
        // 
        // productManagementLabel
        // 
        this.productManagementLabel.Dock = DockStyle.Top;
        this.productManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.productManagementLabel.Location = new Point(0, 0);
        this.productManagementLabel.Margin = new Padding(4, 0, 4, 0);
        this.productManagementLabel.Name = "productManagementLabel";
        this.productManagementLabel.Size = new Size(279, 38);
        this.productManagementLabel.TabIndex = 0;
        this.productManagementLabel.Text = "Gestion des produits";
        this.productManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // clientMainPanel
        // 
        this.clientMainPanel.Controls.Add(this.clientManagementLabel);
        this.clientMainPanel.Dock = DockStyle.Fill;
        this.clientMainPanel.Location = new Point(578, 5);
        this.clientMainPanel.Margin = new Padding(4, 5, 4, 5);
        this.clientMainPanel.Name = "clientMainPanel";
        this.clientMainPanel.Size = new Size(279, 402);
        this.clientMainPanel.TabIndex = 2;
        // 
        // clientManagementLabel
        // 
        this.clientManagementLabel.Dock = DockStyle.Top;
        this.clientManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.clientManagementLabel.Location = new Point(0, 0);
        this.clientManagementLabel.Margin = new Padding(4, 0, 4, 0);
        this.clientManagementLabel.Name = "clientManagementLabel";
        this.clientManagementLabel.Size = new Size(279, 38);
        this.clientManagementLabel.TabIndex = 0;
        this.clientManagementLabel.Text = "Gestion des clients";
        this.clientManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // roleMainPanel
        // 
        this.roleMainPanel.Controls.Add(this.roleSearchResults);
        this.roleMainPanel.Controls.Add(this.roleSearchTextBox);
        this.roleMainPanel.Controls.Add(this.roleButtonsTLP);
        this.roleMainPanel.Controls.Add(this.createRoleTLP);
        this.roleMainPanel.Controls.Add(this.roleManagementLabel);
        this.roleMainPanel.Dock = DockStyle.Fill;
        this.roleMainPanel.Location = new Point(291, 5);
        this.roleMainPanel.Margin = new Padding(4, 5, 4, 5);
        this.roleMainPanel.Name = "roleMainPanel";
        this.roleMainPanel.Size = new Size(279, 402);
        this.roleMainPanel.TabIndex = 1;
        // 
        // roleSearchResults
        // 
        this.roleSearchResults.Dock = DockStyle.Fill;
        this.roleSearchResults.FormattingEnabled = true;
        this.roleSearchResults.ItemHeight = 25;
        this.roleSearchResults.Location = new Point(0, 136);
        this.roleSearchResults.Margin = new Padding(4, 5, 4, 5);
        this.roleSearchResults.Name = "roleSearchResults";
        this.roleSearchResults.Size = new Size(279, 133);
        this.roleSearchResults.TabIndex = 12;
        // 
        // roleSearchTextBox
        // 
        this.roleSearchTextBox.Dock = DockStyle.Top;
        this.roleSearchTextBox.Location = new Point(0, 105);
        this.roleSearchTextBox.Margin = new Padding(4, 5, 4, 5);
        this.roleSearchTextBox.Name = "roleSearchTextBox";
        this.roleSearchTextBox.PlaceholderText = "Rechercher un utilisateur";
        this.roleSearchTextBox.Size = new Size(279, 31);
        this.roleSearchTextBox.TabIndex = 11;
        // 
        // roleButtonsTLP
        // 
        this.roleButtonsTLP.ColumnCount = 3;
        this.roleButtonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.roleButtonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
        this.roleButtonsTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.roleButtonsTLP.Controls.Add(this.panel2, 1, 0);
        this.roleButtonsTLP.Dock = DockStyle.Bottom;
        this.roleButtonsTLP.Location = new Point(0, 269);
        this.roleButtonsTLP.Margin = new Padding(4, 5, 4, 5);
        this.roleButtonsTLP.Name = "roleButtonsTLP";
        this.roleButtonsTLP.RowCount = 1;
        this.roleButtonsTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.roleButtonsTLP.Size = new Size(279, 133);
        this.roleButtonsTLP.TabIndex = 10;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.buttonDeleteRole);
        this.panel2.Controls.Add(this.buttonEditRole);
        this.panel2.Controls.Add(this.buttonViewRole);
        this.panel2.Dock = DockStyle.Fill;
        this.panel2.Location = new Point(54, 8);
        this.panel2.Margin = new Padding(0, 8, 0, 0);
        this.panel2.Name = "panel2";
        this.panel2.Size = new Size(171, 125);
        this.panel2.TabIndex = 0;
        // 
        // buttonDeleteRole
        // 
        this.buttonDeleteRole.Dock = DockStyle.Top;
        this.buttonDeleteRole.Enabled = false;
        this.buttonDeleteRole.Location = new Point(0, 76);
        this.buttonDeleteRole.Margin = new Padding(4, 5, 4, 5);
        this.buttonDeleteRole.Name = "buttonDeleteRole";
        this.buttonDeleteRole.Size = new Size(171, 38);
        this.buttonDeleteRole.TabIndex = 2;
        this.buttonDeleteRole.Text = "Supprimer";
        this.buttonDeleteRole.UseVisualStyleBackColor = true;
        // 
        // buttonEditRole
        // 
        this.buttonEditRole.Dock = DockStyle.Top;
        this.buttonEditRole.Enabled = false;
        this.buttonEditRole.Location = new Point(0, 38);
        this.buttonEditRole.Margin = new Padding(4, 5, 4, 5);
        this.buttonEditRole.Name = "buttonEditRole";
        this.buttonEditRole.Size = new Size(171, 38);
        this.buttonEditRole.TabIndex = 1;
        this.buttonEditRole.Text = "Modifier";
        this.buttonEditRole.UseVisualStyleBackColor = true;
        // 
        // buttonViewRole
        // 
        this.buttonViewRole.Dock = DockStyle.Top;
        this.buttonViewRole.Enabled = false;
        this.buttonViewRole.Location = new Point(0, 0);
        this.buttonViewRole.Margin = new Padding(4, 5, 4, 5);
        this.buttonViewRole.Name = "buttonViewRole";
        this.buttonViewRole.Size = new Size(171, 38);
        this.buttonViewRole.TabIndex = 0;
        this.buttonViewRole.Text = "Voir Détails";
        this.buttonViewRole.UseVisualStyleBackColor = true;
        // 
        // createRoleTLP
        // 
        this.createRoleTLP.ColumnCount = 3;
        this.createRoleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createRoleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
        this.createRoleTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createRoleTLP.Controls.Add(this.buttonCreateRole, 1, 0);
        this.createRoleTLP.Dock = DockStyle.Top;
        this.createRoleTLP.Location = new Point(0, 38);
        this.createRoleTLP.Margin = new Padding(4, 5, 4, 5);
        this.createRoleTLP.Name = "createRoleTLP";
        this.createRoleTLP.RowCount = 1;
        this.createRoleTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.createRoleTLP.Size = new Size(279, 67);
        this.createRoleTLP.TabIndex = 9;
        // 
        // buttonCreateRole
        // 
        this.buttonCreateRole.Dock = DockStyle.Bottom;
        this.buttonCreateRole.Location = new Point(58, 24);
        this.buttonCreateRole.Margin = new Padding(4, 5, 4, 5);
        this.buttonCreateRole.Name = "buttonCreateRole";
        this.buttonCreateRole.Size = new Size(163, 38);
        this.buttonCreateRole.TabIndex = 0;
        this.buttonCreateRole.Text = "Créer Role";
        this.buttonCreateRole.UseVisualStyleBackColor = true;
        this.buttonCreateRole.Click += this.buttonCreateRole_Click_1;
        // 
        // roleManagementLabel
        // 
        this.roleManagementLabel.Dock = DockStyle.Top;
        this.roleManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.roleManagementLabel.Location = new Point(0, 0);
        this.roleManagementLabel.Margin = new Padding(4, 0, 4, 0);
        this.roleManagementLabel.Name = "roleManagementLabel";
        this.roleManagementLabel.Size = new Size(279, 38);
        this.roleManagementLabel.TabIndex = 0;
        this.roleManagementLabel.Text = "Gestion des rôles";
        this.roleManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // userMainPanel
        // 
        this.userMainPanel.Controls.Add(this.userSearchResults);
        this.userMainPanel.Controls.Add(this.userSearchTextBox);
        this.userMainPanel.Controls.Add(this.tableLayoutPanel1);
        this.userMainPanel.Controls.Add(this.createUserTLP);
        this.userMainPanel.Controls.Add(this.userManagementLabel);
        this.userMainPanel.Dock = DockStyle.Fill;
        this.userMainPanel.Location = new Point(4, 5);
        this.userMainPanel.Margin = new Padding(4, 5, 4, 5);
        this.userMainPanel.Name = "userMainPanel";
        this.userMainPanel.Size = new Size(279, 402);
        this.userMainPanel.TabIndex = 0;
        // 
        // userSearchResults
        // 
        this.userSearchResults.Dock = DockStyle.Fill;
        this.userSearchResults.FormattingEnabled = true;
        this.userSearchResults.ItemHeight = 25;
        this.userSearchResults.Location = new Point(0, 136);
        this.userSearchResults.Margin = new Padding(4, 5, 4, 5);
        this.userSearchResults.Name = "userSearchResults";
        this.userSearchResults.Size = new Size(279, 133);
        this.userSearchResults.TabIndex = 4;
        this.userSearchResults.SelectedIndexChanged += this.UserSearchResults_SelectedIndexChanged;
        // 
        // userSearchTextBox
        // 
        this.userSearchTextBox.Dock = DockStyle.Top;
        this.userSearchTextBox.Location = new Point(0, 105);
        this.userSearchTextBox.Margin = new Padding(4, 5, 4, 5);
        this.userSearchTextBox.Name = "userSearchTextBox";
        this.userSearchTextBox.PlaceholderText = "Rechercher un utilisateur";
        this.userSearchTextBox.Size = new Size(279, 31);
        this.userSearchTextBox.TabIndex = 3;
        this.userSearchTextBox.TextChanged += this.UserSearchTextBox_TextChanged;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.userActionButtonsPanel, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Bottom;
        this.tableLayoutPanel1.Location = new Point(0, 269);
        this.tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(279, 133);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // userActionButtonsPanel
        // 
        this.userActionButtonsPanel.Controls.Add(this.buttonDeleteUser);
        this.userActionButtonsPanel.Controls.Add(this.buttonEditUser);
        this.userActionButtonsPanel.Controls.Add(this.buttonViewUser);
        this.userActionButtonsPanel.Dock = DockStyle.Fill;
        this.userActionButtonsPanel.Location = new Point(54, 8);
        this.userActionButtonsPanel.Margin = new Padding(0, 8, 0, 0);
        this.userActionButtonsPanel.Name = "userActionButtonsPanel";
        this.userActionButtonsPanel.Size = new Size(171, 125);
        this.userActionButtonsPanel.TabIndex = 0;
        // 
        // buttonDeleteUser
        // 
        this.buttonDeleteUser.Dock = DockStyle.Top;
        this.buttonDeleteUser.Enabled = false;
        this.buttonDeleteUser.Location = new Point(0, 76);
        this.buttonDeleteUser.Margin = new Padding(4, 5, 4, 5);
        this.buttonDeleteUser.Name = "buttonDeleteUser";
        this.buttonDeleteUser.Size = new Size(171, 38);
        this.buttonDeleteUser.TabIndex = 2;
        this.buttonDeleteUser.Text = "Supprimer";
        this.buttonDeleteUser.UseVisualStyleBackColor = true;
        this.buttonDeleteUser.Click += this.ButtonDeleteUser_Click;
        // 
        // buttonEditUser
        // 
        this.buttonEditUser.Dock = DockStyle.Top;
        this.buttonEditUser.Enabled = false;
        this.buttonEditUser.Location = new Point(0, 38);
        this.buttonEditUser.Margin = new Padding(4, 5, 4, 5);
        this.buttonEditUser.Name = "buttonEditUser";
        this.buttonEditUser.Size = new Size(171, 38);
        this.buttonEditUser.TabIndex = 1;
        this.buttonEditUser.Text = "Modifier";
        this.buttonEditUser.UseVisualStyleBackColor = true;
        this.buttonEditUser.Click += this.ButtonEditUser_Click;
        // 
        // buttonViewUser
        // 
        this.buttonViewUser.Dock = DockStyle.Top;
        this.buttonViewUser.Enabled = false;
        this.buttonViewUser.Location = new Point(0, 0);
        this.buttonViewUser.Margin = new Padding(4, 5, 4, 5);
        this.buttonViewUser.Name = "buttonViewUser";
        this.buttonViewUser.Size = new Size(171, 38);
        this.buttonViewUser.TabIndex = 0;
        this.buttonViewUser.Text = "Voir Détails";
        this.buttonViewUser.UseVisualStyleBackColor = true;
        this.buttonViewUser.Click += this.ButtonViewUser_Click;
        // 
        // createUserTLP
        // 
        this.createUserTLP.ColumnCount = 3;
        this.createUserTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createUserTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
        this.createUserTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createUserTLP.Controls.Add(this.buttonCreateUser, 1, 0);
        this.createUserTLP.Dock = DockStyle.Top;
        this.createUserTLP.Location = new Point(0, 38);
        this.createUserTLP.Margin = new Padding(4, 5, 4, 5);
        this.createUserTLP.Name = "createUserTLP";
        this.createUserTLP.RowCount = 1;
        this.createUserTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.createUserTLP.Size = new Size(279, 67);
        this.createUserTLP.TabIndex = 1;
        // 
        // buttonCreateUser
        // 
        this.buttonCreateUser.Dock = DockStyle.Bottom;
        this.buttonCreateUser.Location = new Point(58, 24);
        this.buttonCreateUser.Margin = new Padding(4, 5, 4, 5);
        this.buttonCreateUser.Name = "buttonCreateUser";
        this.buttonCreateUser.Size = new Size(163, 38);
        this.buttonCreateUser.TabIndex = 0;
        this.buttonCreateUser.Text = "Créer Utilisateur";
        this.buttonCreateUser.UseVisualStyleBackColor = true;
        this.buttonCreateUser.Click += this.ButtonCreateUser_Click;
        // 
        // userManagementLabel
        // 
        this.userManagementLabel.Dock = DockStyle.Top;
        this.userManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.userManagementLabel.Location = new Point(0, 0);
        this.userManagementLabel.Margin = new Padding(4, 0, 4, 0);
        this.userManagementLabel.Name = "userManagementLabel";
        this.userManagementLabel.Size = new Size(279, 38);
        this.userManagementLabel.TabIndex = 0;
        this.userManagementLabel.Text = "Gestion des utilisateurs";
        this.userManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AdminMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1436, 990);
        this.Controls.Add(this.centerTableLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Margin = new Padding(4, 5, 4, 5);
        this.Name = "AdminMainMenu";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Menu Principal Administrateur";
        this.WindowState = FormWindowState.Maximized;
        this.bottomBarPanel.ResumeLayout(false);
        this.centerTableLayoutPanel.ResumeLayout(false);
        this.purchaseOrderMainPanel.ResumeLayout(false);
        this.purchaseOrderMainPanel.PerformLayout();
        this.poButtonsTLP.ResumeLayout(false);
        this.panel3.ResumeLayout(false);
        this.createPOTLP.ResumeLayout(false);
        this.shipmentMainPanel.ResumeLayout(false);
        this.shipmentMainPanel.PerformLayout();
        this.createShipmentTLP.ResumeLayout(false);
        this.shipOrderMainPanel.ResumeLayout(false);
        this.shipOrderMainPanel.PerformLayout();
        this.tableLayoutPanel3.ResumeLayout(false);
        this.panel1.ResumeLayout(false);
        this.createSOTLP.ResumeLayout(false);
        this.addressMainPanel.ResumeLayout(false);
        this.warehouseMainPanel.ResumeLayout(false);
        this.createWarehouseTLP.ResumeLayout(false);
        this.supplierMainPanel.ResumeLayout(false);
        this.productMainPanel.ResumeLayout(false);
        this.clientMainPanel.ResumeLayout(false);
        this.roleMainPanel.ResumeLayout(false);
        this.roleMainPanel.PerformLayout();
        this.roleButtonsTLP.ResumeLayout(false);
        this.panel2.ResumeLayout(false);
        this.createRoleTLP.ResumeLayout(false);
        this.userMainPanel.ResumeLayout(false);
        this.userMainPanel.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.userActionButtonsPanel.ResumeLayout(false);
        this.createUserTLP.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel centerTableLayoutPanel;
    private Panel userMainPanel;
    private Label userManagementLabel;
    private Panel purchaseOrderMainPanel;
    private Label purchaseOrderManagementLabel;
    private Panel shipmentMainPanel;
    private Label shipmentManagementLabel;
    private Panel shipOrderMainPanel;
    private Label shipOrderManagementLabel;
    private Panel addressMainPanel;
    private Label addressManagementLabel;
    private Panel warehouseMainPanel;
    private Label warehouseManagementLabel;
    private Panel supplierMainPanel;
    private Label supplierManagementLabel;
    private Panel productMainPanel;
    private Label productManagementLabel;
    private Panel clientMainPanel;
    private Label clientManagementLabel;
    private Panel roleMainPanel;
    private Label roleManagementLabel;
    private Button buttonLogout;
    private TableLayoutPanel createUserTLP;
    private Button buttonCreateUser;
    private TableLayoutPanel tableLayoutPanel1;
    private ListBox userSearchResults;
    private TextBox userSearchTextBox;
    private Panel userActionButtonsPanel;
    private Button buttonDeleteUser;
    private Button buttonEditUser;
    private Button buttonViewUser;
    private ListBox soSearchResults;
    private TableLayoutPanel tableLayoutPanel3;
    private Panel panel1;
    private Button buttonDeleteSO;
    private Button buttonEditSO;
    private Button buttonViewSO;
    private TextBox soSearchTextBox;
    private TableLayoutPanel createSOTLP;
    private Button buttonCreateSO;
    private ListBox roleSearchResults;
    private TextBox roleSearchTextBox;
    private TableLayoutPanel roleButtonsTLP;
    private Panel panel2;
    private Button buttonDeleteRole;
    private Button buttonEditRole;
    private Button buttonViewRole;
    private TableLayoutPanel createRoleTLP;
    private Button buttonCreateRole;
    private ListBox poSearchResults;
    private TableLayoutPanel poButtonsTLP;
    private Panel panel3;
    private Button buttonViewPO;
    private TextBox poSearchTextBox;
    private TableLayoutPanel createPOTLP;
    private Button buttonCreatePO;
    private TableLayoutPanel createWarehouseTLP;
    private Button buttonCreateWarehouse;
    private TableLayoutPanel createShipmentTLP;
    private Button buttonCreateShipment;
    private ListBox shipmentSearchSOResults;
    private TextBox shipmentSearchSOTextBox;
}