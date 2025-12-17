namespace Cargo_Transportation_Management_System
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSeed = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.dgvShipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.BuildGridColumn = new System.Windows.Forms.DataGridView();
            this.ensureCreated = new Cargo_Transportation_Management_System.EnsureCreated();
            this.ensureCreatedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panelk2 = new System.Windows.Forms.Panel();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.txtVehicle = new System.Windows.Forms.TextBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildGridColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensureCreated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensureCreatedBindingSource)).BeginInit();
            this.panelk2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSeed);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 596);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(26, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "C.T.M.S.";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(13, 313);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 42);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSeed
            // 
            this.btnSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeed.Location = new System.Drawing.Point(13, 246);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(104, 42);
            this.btnSeed.TabIndex = 3;
            this.btnSeed.Text = "Seed";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(13, 486);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(86, 32);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colOrigin,
            this.colDestination,
            this.colDriver,
            this.colVehicle,
            this.colDeparture,
            this.colArrival,
            this.colWeight});
            this.DataGridView.DataSource = this.ensureCreatedBindingSource;
            this.DataGridView.Location = new System.Drawing.Point(188, 62);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(1084, 433);
            this.DataGridView.TabIndex = 1;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // dgvShipmentBindingSource
            // 
            this.dgvShipmentBindingSource.CurrentChanged += new System.EventHandler(this.dgvShipmentBindingSource_CurrentChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Location = new System.Drawing.Point(188, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 44);
            this.panel2.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(188, 62);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1084, 523);
            this.dgv.TabIndex = 1;
            // 
            // BuildGridColumn
            // 
            this.BuildGridColumn.AutoGenerateColumns = false;
            this.BuildGridColumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuildGridColumn.DataSource = this.dgvShipmentBindingSource;
            this.BuildGridColumn.Location = new System.Drawing.Point(188, 62);
            this.BuildGridColumn.Name = "BuildGridColumn";
            this.BuildGridColumn.Size = new System.Drawing.Size(1084, 523);
            this.BuildGridColumn.TabIndex = 1;
            // 
            // ensureCreated
            // 
            this.ensureCreated.DataSetName = "EnsureCreated";
            this.ensureCreated.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ensureCreatedBindingSource
            // 
            this.ensureCreatedBindingSource.DataSource = this.ensureCreated;
            this.ensureCreatedBindingSource.Position = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(13, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(13, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 42);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelk2
            // 
            this.panelk2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelk2.Controls.Add(this.label9);
            this.panelk2.Controls.Add(this.txtWeight);
            this.panelk2.Controls.Add(this.label8);
            this.panelk2.Controls.Add(this.label6);
            this.panelk2.Controls.Add(this.label5);
            this.panelk2.Controls.Add(this.label4);
            this.panelk2.Controls.Add(this.label3);
            this.panelk2.Controls.Add(this.txtArrival);
            this.panelk2.Controls.Add(this.txtVehicle);
            this.panelk2.Controls.Add(this.txtDriver);
            this.panelk2.Controls.Add(this.txtDestination);
            this.panelk2.Controls.Add(this.txtOrigin);
            this.panelk2.Location = new System.Drawing.Point(188, 508);
            this.panelk2.Name = "panelk2";
            this.panelk2.Size = new System.Drawing.Size(952, 100);
            this.panelk2.TabIndex = 3;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(18, 53);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(146, 20);
            this.txtOrigin.TabIndex = 1;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(170, 53);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(146, 20);
            this.txtDestination.TabIndex = 2;
            // 
            // txtDriver
            // 
            this.txtDriver.Location = new System.Drawing.Point(322, 53);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(146, 20);
            this.txtDriver.TabIndex = 3;
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(474, 53);
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(146, 20);
            this.txtVehicle.TabIndex = 4;
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(626, 53);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(146, 20);
            this.txtArrival.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Driver";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vehicle";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Arrival";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(775, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(778, 53);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(146, 20);
            this.txtWeight.TabIndex = 13;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colID.Width = 60;
            // 
            // colOrigin
            // 
            this.colOrigin.DataPropertyName = "Origin";
            this.colOrigin.HeaderText = "Origin";
            this.colOrigin.Name = "colOrigin";
            this.colOrigin.Width = 130;
            // 
            // colDestination
            // 
            this.colDestination.DataPropertyName = "Destination";
            this.colDestination.HeaderText = "Destination";
            this.colDestination.Name = "colDestination";
            this.colDestination.Width = 130;
            // 
            // colDriver
            // 
            this.colDriver.DataPropertyName = "DriverName";
            this.colDriver.HeaderText = "Driver";
            this.colDriver.Name = "colDriver";
            this.colDriver.Width = 130;
            // 
            // colVehicle
            // 
            this.colVehicle.DataPropertyName = "VehiclePlate";
            this.colVehicle.HeaderText = "Vehicle";
            this.colVehicle.Name = "colVehicle";
            this.colVehicle.Width = 130;
            // 
            // colDeparture
            // 
            this.colDeparture.DataPropertyName = "DepartureDate";
            this.colDeparture.HeaderText = "Departure";
            this.colDeparture.Name = "colDeparture";
            this.colDeparture.Width = 150;
            // 
            // colArrival
            // 
            this.colArrival.DataPropertyName = "ArrivalDate";
            this.colArrival.HeaderText = "Arrival";
            this.colArrival.Name = "colArrival";
            this.colArrival.Width = 150;
            // 
            // colWeight
            // 
            this.colWeight.DataPropertyName = "TotalCargoWeightKg";
            this.colWeight.HeaderText = "Total Weight (kg)";
            this.colWeight.Name = "colWeight";
            this.colWeight.Width = 120;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1284, 620);
            this.Controls.Add(this.panelk2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildGridColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensureCreated)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensureCreatedBindingSource)).EndInit();
            this.panelk2.ResumeLayout(false);
            this.panelk2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource dgvShipmentBindingSource;
        private System.Windows.Forms.DataGridView dgv;
        private Cargo_Transportation_Management_System.DataGridView dgvShipment;
        private System.Windows.Forms.DataGridView BuildGridColumn;
        private System.Windows.Forms.BindingSource ensureCreatedBindingSource;
        private EnsureCreated ensureCreated;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeparture;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.Panel panelk2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.TextBox txtVehicle;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtOrigin;
    }

    internal class DataGridView
    {
    }
}