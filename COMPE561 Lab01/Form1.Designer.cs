namespace COMPE561_Lab01
{
    partial class Form1
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.addbutton = new System.Windows.Forms.Button();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.isbnbox = new System.Windows.Forms.TextBox();
            this.authorbox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.maingrid = new System.Windows.Forms.DataGridView();
            this.droplabel = new System.Windows.Forms.Label();
            this.authorlabel = new System.Windows.Forms.Label();
            this.isbnlabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.qtybox = new System.Windows.Forms.TextBox();
            this.qtylabel = new System.Windows.Forms.Label();
            this.subtotalbox = new System.Windows.Forms.TextBox();
            this.taxbox = new System.Windows.Forms.TextBox();
            this.totalbox = new System.Windows.Forms.TextBox();
            this.totallabel = new System.Windows.Forms.Label();
            this.subtotallabel = new System.Windows.Forms.Label();
            this.taxlabel = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.confirmbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maingrid)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(358, 167);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 34);
            this.addbutton.TabIndex = 0;
            this.addbutton.Text = "Add titles";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // dropdown
            // 
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(170, 40);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(273, 21);
            this.dropdown.TabIndex = 1;
            this.dropdown.SelectedIndexChanged += new System.EventHandler(this.dropdown_SelectedIndexChanged);
            // 
            // isbnbox
            // 
            this.isbnbox.Location = new System.Drawing.Point(368, 123);
            this.isbnbox.Name = "isbnbox";
            this.isbnbox.Size = new System.Drawing.Size(100, 20);
            this.isbnbox.TabIndex = 2;
            // 
            // authorbox
            // 
            this.authorbox.Location = new System.Drawing.Point(170, 123);
            this.authorbox.Name = "authorbox";
            this.authorbox.Size = new System.Drawing.Size(100, 20);
            this.authorbox.TabIndex = 3;
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(580, 123);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(100, 20);
            this.pricebox.TabIndex = 4;
            // 
            // maingrid
            // 
            this.maingrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maingrid.Location = new System.Drawing.Point(170, 218);
            this.maingrid.Name = "maingrid";
            this.maingrid.Size = new System.Drawing.Size(445, 134);
            this.maingrid.TabIndex = 5;
            // 
            // droplabel
            // 
            this.droplabel.AutoSize = true;
            this.droplabel.Location = new System.Drawing.Point(86, 44);
            this.droplabel.Name = "droplabel";
            this.droplabel.Size = new System.Drawing.Size(78, 13);
            this.droplabel.TabIndex = 6;
            this.droplabel.Text = "Book selected:";
            // 
            // authorlabel
            // 
            this.authorlabel.AutoSize = true;
            this.authorlabel.Location = new System.Drawing.Point(120, 126);
            this.authorlabel.Name = "authorlabel";
            this.authorlabel.Size = new System.Drawing.Size(44, 13);
            this.authorlabel.TabIndex = 7;
            this.authorlabel.Text = " Author:";
            // 
            // isbnlabel
            // 
            this.isbnlabel.AutoSize = true;
            this.isbnlabel.Location = new System.Drawing.Point(327, 126);
            this.isbnlabel.Name = "isbnlabel";
            this.isbnlabel.Size = new System.Drawing.Size(35, 13);
            this.isbnlabel.TabIndex = 8;
            this.isbnlabel.Text = "ISBN:";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(540, 126);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(34, 13);
            this.pricelabel.TabIndex = 9;
            this.pricelabel.Text = "Price:";
            // 
            // qtybox
            // 
            this.qtybox.Location = new System.Drawing.Point(580, 41);
            this.qtybox.Name = "qtybox";
            this.qtybox.Size = new System.Drawing.Size(100, 20);
            this.qtybox.TabIndex = 10;
            // 
            // qtylabel
            // 
            this.qtylabel.AutoSize = true;
            this.qtylabel.Location = new System.Drawing.Point(482, 44);
            this.qtylabel.Name = "qtylabel";
            this.qtylabel.Size = new System.Drawing.Size(92, 13);
            this.qtylabel.TabIndex = 11;
            this.qtylabel.Text = "Quantity selected:";
            // 
            // subtotalbox
            // 
            this.subtotalbox.Location = new System.Drawing.Point(170, 378);
            this.subtotalbox.Name = "subtotalbox";
            this.subtotalbox.Size = new System.Drawing.Size(100, 20);
            this.subtotalbox.TabIndex = 12;
            // 
            // taxbox
            // 
            this.taxbox.Location = new System.Drawing.Point(368, 378);
            this.taxbox.Name = "taxbox";
            this.taxbox.Size = new System.Drawing.Size(100, 20);
            this.taxbox.TabIndex = 13;
            // 
            // totalbox
            // 
            this.totalbox.Location = new System.Drawing.Point(580, 378);
            this.totalbox.Name = "totalbox";
            this.totalbox.Size = new System.Drawing.Size(100, 20);
            this.totalbox.TabIndex = 14;
            // 
            // totallabel
            // 
            this.totallabel.AutoSize = true;
            this.totallabel.Location = new System.Drawing.Point(540, 381);
            this.totallabel.Name = "totallabel";
            this.totallabel.Size = new System.Drawing.Size(34, 13);
            this.totallabel.TabIndex = 15;
            this.totallabel.Text = "Total:";
            // 
            // subtotallabel
            // 
            this.subtotallabel.AutoSize = true;
            this.subtotallabel.Location = new System.Drawing.Point(120, 381);
            this.subtotallabel.Name = "subtotallabel";
            this.subtotallabel.Size = new System.Drawing.Size(49, 13);
            this.subtotallabel.TabIndex = 16;
            this.subtotallabel.Text = "Subtotal:";
            // 
            // taxlabel
            // 
            this.taxlabel.AutoSize = true;
            this.taxlabel.Location = new System.Drawing.Point(334, 381);
            this.taxlabel.Name = "taxlabel";
            this.taxlabel.Size = new System.Drawing.Size(28, 13);
            this.taxlabel.TabIndex = 17;
            this.taxlabel.Text = "Tax:";
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(540, 415);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 18;
            this.cancelbutton.Text = "Cancel order";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // confirmbutton
            // 
            this.confirmbutton.Location = new System.Drawing.Point(636, 415);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(78, 23);
            this.confirmbutton.TabIndex = 19;
            this.confirmbutton.Text = "Confirm order";
            this.confirmbutton.UseVisualStyleBackColor = true;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.taxlabel);
            this.Controls.Add(this.subtotallabel);
            this.Controls.Add(this.totallabel);
            this.Controls.Add(this.totalbox);
            this.Controls.Add(this.taxbox);
            this.Controls.Add(this.subtotalbox);
            this.Controls.Add(this.qtylabel);
            this.Controls.Add(this.qtybox);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.isbnlabel);
            this.Controls.Add(this.authorlabel);
            this.Controls.Add(this.droplabel);
            this.Controls.Add(this.maingrid);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.authorbox);
            this.Controls.Add(this.isbnbox);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.addbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.maingrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.TextBox isbnbox;
        private System.Windows.Forms.TextBox authorbox;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.DataGridView maingrid;
        private System.Windows.Forms.Label droplabel;
        private System.Windows.Forms.Label authorlabel;
        private System.Windows.Forms.Label isbnlabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.TextBox qtybox;
        private System.Windows.Forms.Label qtylabel;
        private System.Windows.Forms.TextBox subtotalbox;
        private System.Windows.Forms.TextBox taxbox;
        private System.Windows.Forms.TextBox totalbox;
        private System.Windows.Forms.Label totallabel;
        private System.Windows.Forms.Label subtotallabel;
        private System.Windows.Forms.Label taxlabel;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button confirmbutton;
    }
}

