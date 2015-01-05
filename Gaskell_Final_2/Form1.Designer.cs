namespace Gaskell_Final_2
{
    partial class frmAddIncident
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblCustID;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblDateOpened;
            System.Windows.Forms.Label lblProductName;
            System.Windows.Forms.Label lblTitle;
            System.Windows.Forms.Label lblDescription;
            this.techSupportDataSet = new Gaskell_Final_2.TechSupportDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new Gaskell_Final_2.TechSupportDataSetTableAdapters.CustomersTableAdapter();
            this.tableAdapterManager = new Gaskell_Final_2.TechSupportDataSetTableAdapters.TableAdapterManager();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.fillByCustomerIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.customerIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.customerIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByCustomerIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentsTableAdapter = new Gaskell_Final_2.TechSupportDataSetTableAdapters.IncidentsTableAdapter();
            this.txtDateOpened = new System.Windows.Forms.TextBox();
            this.registrationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Gaskell_Final_2.TechSupportDataSetTableAdapters.ProductsTableAdapter();
            this.registrationsTableAdapter = new Gaskell_Final_2.TechSupportDataSetTableAdapters.RegistrationsTableAdapter();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.registrationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.fKRegistrationsCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKRegistrationsProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKRegistrationsProductsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKRegistrationsCustomersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            lblCustID = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblDateOpened = new System.Windows.Forms.Label();
            lblProductName = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.fillByCustomerIDToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRegistrationsCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRegistrationsProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRegistrationsProductsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRegistrationsCustomersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustID
            // 
            lblCustID.AutoSize = true;
            lblCustID.Location = new System.Drawing.Point(12, 38);
            lblCustID.Name = "lblCustID";
            lblCustID.Size = new System.Drawing.Size(89, 17);
            lblCustID.TabIndex = 1;
            lblCustID.Text = "Customer ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(12, 69);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(49, 17);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblDateOpened
            // 
            lblDateOpened.AutoSize = true;
            lblDateOpened.Location = new System.Drawing.Point(12, 112);
            lblDateOpened.Name = "lblDateOpened";
            lblDateOpened.Size = new System.Drawing.Size(97, 17);
            lblDateOpened.TabIndex = 5;
            lblDateOpened.Text = "Date Opened:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new System.Drawing.Point(12, 151);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new System.Drawing.Size(61, 17);
            lblProductName.TabIndex = 7;
            lblProductName.Text = "Product:";
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.techSupportDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.IncidentsTableAdapter = null;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RegistrationsTableAdapter = null;
            this.tableAdapterManager.StatesTableAdapter = null;
            this.tableAdapterManager.TechniciansTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Gaskell_Final_2.TechSupportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtCustID
            // 
            this.txtCustID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.txtCustID.Location = new System.Drawing.Point(107, 35);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(65, 22);
            this.txtCustID.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "Name", true));
            this.txtName.Location = new System.Drawing.Point(107, 73);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(265, 22);
            this.txtName.TabIndex = 4;
            // 
            // fillByCustomerIDToolStrip
            // 
            this.fillByCustomerIDToolStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fillByCustomerIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripLabel,
            this.customerIDToolStripTextBox,
            this.fillByCustomerIDToolStripButton});
            this.fillByCustomerIDToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByCustomerIDToolStrip.Name = "fillByCustomerIDToolStrip";
            this.fillByCustomerIDToolStrip.Size = new System.Drawing.Size(429, 27);
            this.fillByCustomerIDToolStrip.TabIndex = 0;
            this.fillByCustomerIDToolStrip.TabStop = true;
            this.fillByCustomerIDToolStrip.Text = "fillByCustomerIDToolStrip";
            // 
            // customerIDToolStripLabel
            // 
            this.customerIDToolStripLabel.Name = "customerIDToolStripLabel";
            this.customerIDToolStripLabel.Size = new System.Drawing.Size(94, 24);
            this.customerIDToolStripLabel.Text = "Customer ID:";
            // 
            // customerIDToolStripTextBox
            // 
            this.customerIDToolStripTextBox.Name = "customerIDToolStripTextBox";
            this.customerIDToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByCustomerIDToolStripButton
            // 
            this.fillByCustomerIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByCustomerIDToolStripButton.Name = "fillByCustomerIDToolStripButton";
            this.fillByCustomerIDToolStripButton.Size = new System.Drawing.Size(103, 24);
            this.fillByCustomerIDToolStripButton.Text = "Get Customer";
            this.fillByCustomerIDToolStripButton.Click += new System.EventHandler(this.fillByCustomerIDToolStripButton_Click);
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "FK_Incidents_Customers";
            this.incidentsBindingSource.DataSource = this.customersBindingSource;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // txtDateOpened
            // 
            this.txtDateOpened.Location = new System.Drawing.Point(124, 111);
            this.txtDateOpened.Name = "txtDateOpened";
            this.txtDateOpened.ReadOnly = true;
            this.txtDateOpened.Size = new System.Drawing.Size(100, 22);
            this.txtDateOpened.TabIndex = 6;
            // 
            // registrationsBindingSource
            // 
            this.registrationsBindingSource.DataMember = "Registrations";
            this.registrationsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // registrationsTableAdapter
            // 
            this.registrationsTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(12, 193);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(39, 17);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentsBindingSource, "Title", true));
            this.txtTitle.Location = new System.Drawing.Point(124, 189);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(248, 22);
            this.txtTitle.TabIndex = 10;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(12, 229);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(83, 17);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incidentsBindingSource, "Description", true));
            this.txtDescription.Location = new System.Drawing.Point(124, 227);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(248, 86);
            this.txtDescription.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(97, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(196, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(297, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // registrationsBindingSource1
            // 
            this.registrationsBindingSource1.DataMember = "FK_Registrations_Customers";
            this.registrationsBindingSource1.DataSource = this.customersBindingSource;
            // 
            // cboProduct
            // 
            this.cboProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Name", true));
            this.cboProduct.DataSource = this.fKRegistrationsCustomersBindingSource1;
            this.cboProduct.DisplayMember = "ProductCode";
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(124, 148);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(121, 24);
            this.cboProduct.TabIndex = 16;
            this.cboProduct.ValueMember = "ProductCode";
            // 
            // fKRegistrationsCustomersBindingSource
            // 
            this.fKRegistrationsCustomersBindingSource.DataMember = "FK_Registrations_Customers";
            this.fKRegistrationsCustomersBindingSource.DataSource = this.customersBindingSource;
            // 
            // fKRegistrationsProductsBindingSource
            // 
            this.fKRegistrationsProductsBindingSource.DataMember = "FK_Registrations_Products";
            this.fKRegistrationsProductsBindingSource.DataSource = this.productsBindingSource;
            // 
            // fKRegistrationsProductsBindingSource1
            // 
            this.fKRegistrationsProductsBindingSource1.DataMember = "FK_Registrations_Products";
            this.fKRegistrationsProductsBindingSource1.DataSource = this.productsBindingSource;
            // 
            // fKRegistrationsCustomersBindingSource1
            // 
            this.fKRegistrationsCustomersBindingSource1.DataMember = "FK_Registrations_Customers";
            this.fKRegistrationsCustomersBindingSource1.DataSource = this.customersBindingSource;
            // 
            // frmAddIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 397);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(lblProductName);
            this.Controls.Add(lblDateOpened);
            this.Controls.Add(this.txtDateOpened);
            this.Controls.Add(this.fillByCustomerIDToolStrip);
            this.Controls.Add(lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(lblCustID);
            this.Controls.Add(this.txtCustID);
            this.Name = "frmAddIncident";
            this.Text = "Add Incident";
            this.Load += new System.EventHandler(this.frmAddIncident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.fillByCustomerIDToolStrip.ResumeLayout(false);
            this.fillByCustomerIDToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRegistrationsCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRegistrationsProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRegistrationsProductsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRegistrationsCustomersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TechSupportDataSet techSupportDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private TechSupportDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private TechSupportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStrip fillByCustomerIDToolStrip;
        private System.Windows.Forms.ToolStripLabel customerIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox customerIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByCustomerIDToolStripButton;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private TechSupportDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private System.Windows.Forms.TextBox txtDateOpened;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TechSupportDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource registrationsBindingSource;
        private TechSupportDataSetTableAdapters.RegistrationsTableAdapter registrationsTableAdapter;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource registrationsBindingSource1;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.BindingSource fKRegistrationsCustomersBindingSource;
        private System.Windows.Forms.BindingSource fKRegistrationsProductsBindingSource1;
        private System.Windows.Forms.BindingSource fKRegistrationsProductsBindingSource;
        private System.Windows.Forms.BindingSource fKRegistrationsCustomersBindingSource1;
    }
}

