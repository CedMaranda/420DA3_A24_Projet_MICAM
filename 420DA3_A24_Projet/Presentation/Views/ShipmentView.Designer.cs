namespace _420DA3_A24_Projet.Presentation.Views;

partial class ShipmentView {
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
        this.centerTLP = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.optionsPanel = new Panel();
        this.label2 = new Label();
        this.shmipmentProviderCombobox = new ComboBox();
        this.label1 = new Label();
        this.header = new Label();
        this.bottomBarPanel = new Panel();
        this.actionButton = new Button();
        this.cancelButton = new Button();
        this.topBarPanel = new Panel();
        this.openendModeValue = new Label();
        this.openedModeLabel = new Label();
        this.centerTLP.SuspendLayout();
        this.centerPanel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.optionsPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.topBarPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // centerTLP
        // 
        this.centerTLP.ColumnCount = 3;
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.Controls.Add(this.centerPanel, 1, 0);
        this.centerTLP.Dock = DockStyle.Fill;
        this.centerTLP.Location = new Point(0, 50);
        this.centerTLP.Name = "centerTLP";
        this.centerTLP.RowCount = 1;
        this.centerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTLP.Size = new Size(542, 247);
        this.centerTLP.TabIndex = 5;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.tableLayoutPanel1);
        this.centerPanel.Controls.Add(this.header);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(24, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(494, 241);
        this.centerPanel.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.optionsPanel, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Fill;
        this.tableLayoutPanel1.Location = new Point(0, 50);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(494, 191);
        this.tableLayoutPanel1.TabIndex = 1;
        // 
        // optionsPanel
        // 
        this.optionsPanel.Controls.Add(this.label2);
        this.optionsPanel.Controls.Add(this.shmipmentProviderCombobox);
        this.optionsPanel.Controls.Add(this.label1);
        this.optionsPanel.Dock = DockStyle.Fill;
        this.optionsPanel.Location = new Point(150, 3);
        this.optionsPanel.Name = "optionsPanel";
        this.optionsPanel.Size = new Size(194, 185);
        this.optionsPanel.TabIndex = 0;
        // 
        // label2
        // 
        this.label2.Location = new Point(3, 93);
        this.label2.Name = "label2";
        this.label2.Size = new Size(188, 23);
        this.label2.TabIndex = 3;
        this.label2.Text = "Shipment service provider:";
        this.label2.TextAlign = ContentAlignment.BottomLeft;
        // 
        // shmipmentProviderCombobox
        // 
        this.shmipmentProviderCombobox.FormattingEnabled = true;
        this.shmipmentProviderCombobox.Location = new Point(3, 119);
        this.shmipmentProviderCombobox.Name = "shmipmentProviderCombobox";
        this.shmipmentProviderCombobox.Size = new Size(188, 23);
        this.shmipmentProviderCombobox.TabIndex = 2;
        // 
        // label1
        // 
        this.label1.Dock = DockStyle.Top;
        this.label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.label1.Location = new Point(0, 0);
        this.label1.Name = "label1";
        this.label1.Size = new Size(194, 76);
        this.label1.TabIndex = 1;
        this.label1.Text = "Vous ne pouvez que faire créer un shipment.";
        this.label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // header
        // 
        this.header.Dock = DockStyle.Top;
        this.header.Location = new Point(0, 0);
        this.header.Name = "header";
        this.header.Size = new Size(494, 50);
        this.header.TabIndex = 0;
        this.header.Text = "Fenêtre de remplacement si la personne devant faire les shipment n'a pas fait son travail";
        this.header.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.actionButton);
        this.bottomBarPanel.Controls.Add(this.cancelButton);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 297);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(542, 50);
        this.bottomBarPanel.TabIndex = 4;
        // 
        // actionButton
        // 
        this.actionButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.actionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.actionButton.Location = new Point(304, 15);
        this.actionButton.Name = "actionButton";
        this.actionButton.Size = new Size(120, 23);
        this.actionButton.TabIndex = 1;
        this.actionButton.Text = "PLACEHOLDER";
        this.actionButton.UseVisualStyleBackColor = true;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.cancelButton.Location = new Point(430, 15);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new Size(100, 23);
        this.cancelButton.TabIndex = 0;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.openendModeValue);
        this.topBarPanel.Controls.Add(this.openedModeLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(542, 50);
        this.topBarPanel.TabIndex = 3;
        // 
        // openendModeValue
        // 
        this.openendModeValue.AutoSize = true;
        this.openendModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.openendModeValue.Location = new Point(62, 9);
        this.openendModeValue.Name = "openendModeValue";
        this.openendModeValue.Size = new Size(72, 15);
        this.openendModeValue.TabIndex = 3;
        this.openendModeValue.Text = "Placeholder";
        // 
        // openedModeLabel
        // 
        this.openedModeLabel.AutoSize = true;
        this.openedModeLabel.Location = new Point(12, 9);
        this.openedModeLabel.Name = "openedModeLabel";
        this.openedModeLabel.Size = new Size(44, 15);
        this.openedModeLabel.TabIndex = 2;
        this.openedModeLabel.Text = "Mode :";
        // 
        // ShipmentView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(542, 347);
        this.Controls.Add(this.centerTLP);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "ShipmentView";
        this.Text = "ShipmentView";
        this.centerTLP.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.optionsPanel.ResumeLayout(false);
        this.bottomBarPanel.ResumeLayout(false);
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel centerTLP;
    private Panel centerPanel;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel optionsPanel;
    private Label label1;
    private Label header;
    private Panel bottomBarPanel;
    private Panel topBarPanel;
    private Label openendModeValue;
    private Label openedModeLabel;
    private Button actionButton;
    private Button cancelButton;
    private Label label2;
    private ComboBox shmipmentProviderCombobox;
}