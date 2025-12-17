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
            this.ID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehiclePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildGridColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensureCreated)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ensureCreatedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
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
            this.btnRefresh.Location = new System.Drawing.Point(13, 277);
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
            this.btnSeed.Location = new System.Drawing.Point(13, 210);
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
            this.ID,
            this.Origin,
            this.Destination,
            this.DriverName,
            this.VehiclePlate,
            this.DepartureDate,
            this.ArrivalDate});
            this.DataGridView.DataSource = this.ensureCreatedBindingSource;
            this.DataGridView.Location = new System.Drawing.Point(188, 62);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(1084, 468);
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ID.Width = 60;
            // 
            // Origin
            // 
            this.Origin.DataPropertyName = "Origin";
            this.Origin.HeaderText = "Origin";
            this.Origin.Name = "Origin";
            this.Origin.Width = 130;
            // 
            // Destination
            // 
            this.Destination.DataPropertyName = "Destination";
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            this.Destination.Width = 130;
            // 
            // DriverName
            // 
            this.DriverName.DataPropertyName = "DriverName";
            this.DriverName.HeaderText = "Driver";
            this.DriverName.Name = "DriverName";
            this.DriverName.Width = 130;
            // 
            // VehiclePlate
            // 
            this.VehiclePlate.DataPropertyName = "VehiclePlate";
            this.VehiclePlate.HeaderText = "Vehicle";
            this.VehiclePlate.Name = "VehiclePlate";
            this.VehiclePlate.Width = 130;
            // 
            // DepartureDate
            // 
            this.DepartureDate.DataPropertyName = "DepartureDate";
            this.DepartureDate.HeaderText = "Departure";
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Width = 150;
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.DataPropertyName = "ArrivalDate";
            this.ArrivalDate.HeaderText = "Arrival";
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.Width = 150;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1284, 620);
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
        private System.Windows.Forms.DataGridViewButtonColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehiclePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalDate;
    }

    internal class DataGridView
    {
    }
}