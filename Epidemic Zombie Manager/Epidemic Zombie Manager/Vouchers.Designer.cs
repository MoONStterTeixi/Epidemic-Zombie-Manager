namespace Epidemic_Zombie_Manager
{
    partial class Vouchers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vouchers));
            this.dgv_datavouchers = new System.Windows.Forms.DataGridView();
            this.bt_Update = new System.Windows.Forms.Button();
            this.bt_Eliminar = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datavouchers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_datavouchers
            // 
            this.dgv_datavouchers.AllowUserToAddRows = false;
            this.dgv_datavouchers.AllowUserToDeleteRows = false;
            this.dgv_datavouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datavouchers.Location = new System.Drawing.Point(8, 31);
            this.dgv_datavouchers.Name = "dgv_datavouchers";
            this.dgv_datavouchers.ReadOnly = true;
            this.dgv_datavouchers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_datavouchers.Size = new System.Drawing.Size(394, 198);
            this.dgv_datavouchers.TabIndex = 0;
            this.dgv_datavouchers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_datavouchers_CellClick);
            // 
            // bt_Update
            // 
            this.bt_Update.Location = new System.Drawing.Point(408, 184);
            this.bt_Update.Name = "bt_Update";
            this.bt_Update.Size = new System.Drawing.Size(147, 45);
            this.bt_Update.TabIndex = 1;
            this.bt_Update.Text = "Update";
            this.bt_Update.UseVisualStyleBackColor = true;
            this.bt_Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Eliminar
            // 
            this.bt_Eliminar.Enabled = false;
            this.bt_Eliminar.Location = new System.Drawing.Point(408, 133);
            this.bt_Eliminar.Name = "bt_Eliminar";
            this.bt_Eliminar.Size = new System.Drawing.Size(147, 45);
            this.bt_Eliminar.TabIndex = 2;
            this.bt_Eliminar.Text = "Delete";
            this.bt_Eliminar.UseVisualStyleBackColor = true;
            this.bt_Eliminar.Click += new System.EventHandler(this.bt_Eliminar_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.Enabled = false;
            this.bt_Edit.Location = new System.Drawing.Point(408, 82);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(147, 45);
            this.bt_Edit.TabIndex = 3;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = true;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(408, 31);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(147, 45);
            this.bt_Add.TabIndex = 4;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // Vouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 241);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.bt_Eliminar);
            this.Controls.Add(this.bt_Update);
            this.Controls.Add(this.dgv_datavouchers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Vouchers";
            this.Text = "Epidemiz Zombie Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datavouchers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_datavouchers;
        private System.Windows.Forms.Button bt_Update;
        private System.Windows.Forms.Button bt_Eliminar;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Button bt_Add;
    }
}