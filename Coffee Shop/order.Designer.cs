namespace Coffee_Shop
{
    partial class order
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.orderLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.totalpriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.totalpriceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.customeridTextBox = new System.Windows.Forms.TextBox();
            this.itemidTextBox = new System.Windows.Forms.TextBox();
            this.customeridLabel = new System.Windows.Forms.Label();
            this.itemidLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(544, 45);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(184, 23);
            this.searchLabel.TabIndex = 29;
            this.searchLabel.Text = "Search by Order Id :";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(617, 108);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(132, 22);
            this.searchTextBox.TabIndex = 28;
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(38, 45);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(220, 26);
            this.orderLabel.TabIndex = 27;
            this.orderLabel.Text = "Order Information :";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(786, 101);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 26;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(198, 125);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(132, 22);
            this.idTextBox.TabIndex = 25;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(39, 121);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(37, 22);
            this.idLabel.TabIndex = 24;
            this.idLabel.Text = "Id :";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(275, 361);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 28);
            this.updateButton.TabIndex = 23;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(158, 361);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(947, 97);
            this.showButton.Margin = new System.Windows.Forms.Padding(4);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(100, 28);
            this.showButton.TabIndex = 21;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(548, 152);
            this.showDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(509, 388);
            this.showDataGridView.TabIndex = 20;
            this.showDataGridView.UseWaitCursor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(43, 361);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 28);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // totalpriceTextBox
            // 
            this.totalpriceTextBox.Location = new System.Drawing.Point(198, 212);
            this.totalpriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.totalpriceTextBox.Name = "totalpriceTextBox";
            this.totalpriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.totalpriceTextBox.TabIndex = 18;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(198, 170);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(132, 22);
            this.quantityTextBox.TabIndex = 17;
            // 
            // totalpriceLabel
            // 
            this.totalpriceLabel.AutoSize = true;
            this.totalpriceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpriceLabel.Location = new System.Drawing.Point(39, 211);
            this.totalpriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalpriceLabel.Name = "totalpriceLabel";
            this.totalpriceLabel.Size = new System.Drawing.Size(109, 22);
            this.totalpriceLabel.TabIndex = 16;
            this.totalpriceLabel.Text = "Total Price :";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(39, 169);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(87, 22);
            this.quantityLabel.TabIndex = 15;
            this.quantityLabel.Text = "Quantity :";
            // 
            // customeridTextBox
            // 
            this.customeridTextBox.Location = new System.Drawing.Point(198, 303);
            this.customeridTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customeridTextBox.Name = "customeridTextBox";
            this.customeridTextBox.Size = new System.Drawing.Size(132, 22);
            this.customeridTextBox.TabIndex = 33;
            // 
            // itemidTextBox
            // 
            this.itemidTextBox.Location = new System.Drawing.Point(198, 255);
            this.itemidTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.itemidTextBox.Name = "itemidTextBox";
            this.itemidTextBox.Size = new System.Drawing.Size(132, 22);
            this.itemidTextBox.TabIndex = 32;
            // 
            // customeridLabel
            // 
            this.customeridLabel.AutoSize = true;
            this.customeridLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeridLabel.Location = new System.Drawing.Point(39, 302);
            this.customeridLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customeridLabel.Name = "customeridLabel";
            this.customeridLabel.Size = new System.Drawing.Size(117, 22);
            this.customeridLabel.TabIndex = 31;
            this.customeridLabel.Text = "Customer Id :";
            // 
            // itemidLabel
            // 
            this.itemidLabel.AutoSize = true;
            this.itemidLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemidLabel.Location = new System.Drawing.Point(39, 254);
            this.itemidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemidLabel.Name = "itemidLabel";
            this.itemidLabel.Size = new System.Drawing.Size(76, 22);
            this.itemidLabel.TabIndex = 30;
            this.itemidLabel.Text = "Item Id :";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(370, 170);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 28);
            this.calculateButton.TabIndex = 34;
            this.calculateButton.Text = "Calculate ";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 584);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.customeridTextBox);
            this.Controls.Add(this.itemidTextBox);
            this.Controls.Add(this.customeridLabel);
            this.Controls.Add(this.itemidLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.totalpriceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.totalpriceLabel);
            this.Controls.Add(this.quantityLabel);
            this.Name = "order";
            this.Text = "order";
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox totalpriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label totalpriceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox customeridTextBox;
        private System.Windows.Forms.TextBox itemidTextBox;
        private System.Windows.Forms.Label customeridLabel;
        private System.Windows.Forms.Label itemidLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}