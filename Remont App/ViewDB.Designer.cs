using System;

namespace Remont_App
{
    partial class ViewDB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDB));
            this.OutputGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fueltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enginevalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malfunctionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientDBDataSet = new Remont_App.ClientDBDataSet();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.clientTableAdapter = new Remont_App.ClientDBDataSetTableAdapters.ClientTableAdapter();
            this.Search = new System.Windows.Forms.PictureBox();
            this.Delete = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.PictureBox();
            this.Leftback = new System.Windows.Forms.PictureBox();
            this.searchparam = new System.Windows.Forms.ComboBox();
            this.clientDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OutputGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leftback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputGridView
            // 
            this.OutputGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputGridView.AutoGenerateColumns = false;
            this.OutputGridView.BackgroundColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OutputGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OutputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.fueltypeDataGridViewTextBoxColumn,
            this.enginevalueDataGridViewTextBoxColumn,
            this.clientphoneDataGridViewTextBoxColumn,
            this.malfunctionDataGridViewTextBoxColumn});
            this.OutputGridView.DataSource = this.clientBindingSource;
            this.OutputGridView.Location = new System.Drawing.Point(0, 117);
            this.OutputGridView.Name = "OutputGridView";
            this.OutputGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.OutputGridView.Size = new System.Drawing.Size(1126, 542);
            this.OutputGridView.TabIndex = 99;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // fueltypeDataGridViewTextBoxColumn
            // 
            this.fueltypeDataGridViewTextBoxColumn.DataPropertyName = "Fueltype";
            this.fueltypeDataGridViewTextBoxColumn.HeaderText = "Fueltype";
            this.fueltypeDataGridViewTextBoxColumn.Name = "fueltypeDataGridViewTextBoxColumn";
            // 
            // enginevalueDataGridViewTextBoxColumn
            // 
            this.enginevalueDataGridViewTextBoxColumn.DataPropertyName = "Enginevalue";
            this.enginevalueDataGridViewTextBoxColumn.HeaderText = "Enginevalue";
            this.enginevalueDataGridViewTextBoxColumn.Name = "enginevalueDataGridViewTextBoxColumn";
            // 
            // clientphoneDataGridViewTextBoxColumn
            // 
            this.clientphoneDataGridViewTextBoxColumn.DataPropertyName = "Clientphone";
            this.clientphoneDataGridViewTextBoxColumn.HeaderText = "Clientphone";
            this.clientphoneDataGridViewTextBoxColumn.Name = "clientphoneDataGridViewTextBoxColumn";
            // 
            // malfunctionDataGridViewTextBoxColumn
            // 
            this.malfunctionDataGridViewTextBoxColumn.DataPropertyName = "Malfunction";
            this.malfunctionDataGridViewTextBoxColumn.HeaderText = "Malfunction";
            this.malfunctionDataGridViewTextBoxColumn.Name = "malfunctionDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.clientDBDataSet;
            // 
            // clientDBDataSet
            // 
            this.clientDBDataSet.DataSetName = "ClientDBDataSet";
            this.clientDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchbox.Location = new System.Drawing.Point(149, 60);
            this.searchbox.Multiline = true;
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(159, 29);
            this.searchbox.TabIndex = 101;
            this.searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged_1);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // Search
            // 
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.Image = global::Remont_App.Properties.Resources.depositphotos_80565476_stock_illustration_magnifier_vector_icon;
            this.Search.Location = new System.Drawing.Point(314, 60);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(33, 29);
            this.Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Search.TabIndex = 103;
            this.Search.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Image = global::Remont_App.Properties.Resources.delete1;
            this.Delete.Location = new System.Drawing.Point(1093, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(33, 29);
            this.Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Delete.TabIndex = 102;
            this.Delete.TabStop = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Image = global::Remont_App.Properties.Resources.save;
            this.Save.Location = new System.Drawing.Point(1054, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(33, 29);
            this.Save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Save.TabIndex = 100;
            this.Save.TabStop = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Leftback
            // 
            this.Leftback.BackColor = System.Drawing.Color.Transparent;
            this.Leftback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Leftback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Leftback.Image = global::Remont_App.Properties.Resources.Back;
            this.Leftback.Location = new System.Drawing.Point(0, 1);
            this.Leftback.Name = "Leftback";
            this.Leftback.Size = new System.Drawing.Size(35, 28);
            this.Leftback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Leftback.TabIndex = 94;
            this.Leftback.TabStop = false;
            this.Leftback.Click += new System.EventHandler(this.Leftback_Click);
            // 
            // searchparam
            // 
            this.searchparam.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchparam.FormattingEnabled = true;
            this.searchparam.Items.AddRange(new object[] {
            "Дата",
            "Ім\'я",
            "Номер телефону",
            "Фамілія"});
            this.searchparam.Location = new System.Drawing.Point(149, 27);
            this.searchparam.Name = "searchparam";
            this.searchparam.Size = new System.Drawing.Size(161, 27);
            this.searchparam.Sorted = true;
            this.searchparam.TabIndex = 104;
            // 
            // clientDBDataSetBindingSource
            // 
            this.clientDBDataSetBindingSource.DataSource = this.clientDBDataSet;
            this.clientDBDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF UI Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(125, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "Виберіть параметр для пошуку";
            // 
            // ViewDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1126, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchparam);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.OutputGridView);
            this.Controls.Add(this.Leftback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "й";
            this.Load += new System.EventHandler(this.BaseFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OutputGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Leftback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Leftback;
        private System.Windows.Forms.DataGridView OutputGridView;
        private System.Windows.Forms.PictureBox Save;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.PictureBox Delete;
        private ClientDBDataSet clientDBDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ClientDBDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueltypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enginevalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malfunctionDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox Search;
        private System.Windows.Forms.ComboBox searchparam;
        private System.Windows.Forms.BindingSource clientDBDataSetBindingSource;
        private System.Windows.Forms.Label label1;
    }
}