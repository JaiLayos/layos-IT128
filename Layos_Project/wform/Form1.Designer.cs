namespace wform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.namelabel = new System.Windows.Forms.Label();
            this.codelabel = new System.Windows.Forms.Label();
            this.brandlabel = new System.Windows.Forms.Label();
            this.unitpricelabel = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.TxtBrand = new System.Windows.Forms.TextBox();
            this.TxtUPrice = new System.Windows.Forms.TextBox();
            this.PostBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.UpdateBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.AllBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.Color.Transparent;
            this.namelabel.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.ForeColor = System.Drawing.Color.White;
            this.namelabel.Location = new System.Drawing.Point(21, 128);
            this.namelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namelabel.Name = "namelabel";
            this.namelabel.Padding = new System.Windows.Forms.Padding(1);
            this.namelabel.Size = new System.Drawing.Size(50, 22);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name";
            this.namelabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // codelabel
            // 
            this.codelabel.AutoSize = true;
            this.codelabel.BackColor = System.Drawing.Color.Transparent;
            this.codelabel.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codelabel.ForeColor = System.Drawing.Color.White;
            this.codelabel.Location = new System.Drawing.Point(21, 158);
            this.codelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codelabel.Name = "codelabel";
            this.codelabel.Size = new System.Drawing.Size(42, 20);
            this.codelabel.TabIndex = 1;
            this.codelabel.Text = "Code";
            // 
            // brandlabel
            // 
            this.brandlabel.AutoSize = true;
            this.brandlabel.BackColor = System.Drawing.Color.Transparent;
            this.brandlabel.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandlabel.ForeColor = System.Drawing.Color.White;
            this.brandlabel.Location = new System.Drawing.Point(21, 185);
            this.brandlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.brandlabel.Name = "brandlabel";
            this.brandlabel.Size = new System.Drawing.Size(47, 20);
            this.brandlabel.TabIndex = 2;
            this.brandlabel.Text = "Brand";
            // 
            // unitpricelabel
            // 
            this.unitpricelabel.AutoSize = true;
            this.unitpricelabel.BackColor = System.Drawing.Color.Transparent;
            this.unitpricelabel.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitpricelabel.ForeColor = System.Drawing.Color.White;
            this.unitpricelabel.Location = new System.Drawing.Point(19, 215);
            this.unitpricelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unitpricelabel.Name = "unitpricelabel";
            this.unitpricelabel.Size = new System.Drawing.Size(74, 20);
            this.unitpricelabel.TabIndex = 3;
            this.unitpricelabel.Text = "Unit Price";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(97, 128);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(76, 20);
            this.TxtName.TabIndex = 4;
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(97, 158);
            this.TxtCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(76, 20);
            this.TxtCode.TabIndex = 5;
            // 
            // TxtBrand
            // 
            this.TxtBrand.Location = new System.Drawing.Point(97, 185);
            this.TxtBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(76, 20);
            this.TxtBrand.TabIndex = 6;
            // 
            // TxtUPrice
            // 
            this.TxtUPrice.Location = new System.Drawing.Point(97, 215);
            this.TxtUPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtUPrice.Name = "TxtUPrice";
            this.TxtUPrice.Size = new System.Drawing.Size(76, 20);
            this.TxtUPrice.TabIndex = 7;
            // 
            // PostBtn
            // 
            this.PostBtn.Location = new System.Drawing.Point(97, 248);
            this.PostBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PostBtn.Name = "PostBtn";
            this.PostBtn.Size = new System.Drawing.Size(56, 19);
            this.PostBtn.TabIndex = 8;
            this.PostBtn.Text = "ORDER";
            this.PostBtn.UseVisualStyleBackColor = true;
            this.PostBtn.Click += new System.EventHandler(this.PostBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.DeleteBTN);
            this.panel1.Controls.Add(this.UpdateBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Controls.Add(this.PostBtn);
            this.panel1.Controls.Add(this.codelabel);
            this.panel1.Controls.Add(this.TxtUPrice);
            this.panel1.Controls.Add(this.brandlabel);
            this.panel1.Controls.Add(this.TxtBrand);
            this.panel1.Controls.Add(this.unitpricelabel);
            this.panel1.Controls.Add(this.TxtCode);
            this.panel1.Controls.Add(this.TxtName);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 364);
            this.panel1.TabIndex = 9;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(104, 326);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 12;
            this.DeleteBTN.Text = "DELETE";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // UpdateBTN
            // 
            this.UpdateBTN.Location = new System.Drawing.Point(23, 326);
            this.UpdateBTN.Name = "UpdateBTN";
            this.UpdateBTN.Size = new System.Drawing.Size(75, 23);
            this.UpdateBTN.TabIndex = 11;
            this.UpdateBTN.Text = "UPDATE";
            this.UpdateBTN.UseVisualStyleBackColor = true;
            this.UpdateBTN.Click += new System.EventHandler(this.UpdateBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "*ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 289);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(76, 20);
            this.txtID.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(48)))), ((int)(((byte)(76)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.clearBTN);
            this.panel2.Location = new System.Drawing.Point(-2, 363);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 92);
            this.panel2.TabIndex = 10;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(224, 46);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(455, 263);
            this.txtResult.TabIndex = 11;
            this.txtResult.Text = "";
            // 
            // ShowBtn
            // 
            this.ShowBtn.Location = new System.Drawing.Point(315, 326);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowBtn.TabIndex = 12;
            this.ShowBtn.Text = "SHOW";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(411, 327);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(76, 20);
            this.txtShow.TabIndex = 13;
            // 
            // AllBTN
            // 
            this.AllBTN.Location = new System.Drawing.Point(504, 325);
            this.AllBTN.Name = "AllBTN";
            this.AllBTN.Size = new System.Drawing.Size(75, 23);
            this.AllBTN.TabIndex = 14;
            this.AllBTN.Text = "SHOW ALL";
            this.AllBTN.UseVisualStyleBackColor = true;
            this.AllBTN.Click += new System.EventHandler(this.AllBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(610, 35);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 23);
            this.clearBTN.TabIndex = 0;
            this.clearBTN.Text = "CLEAR";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(717, 455);
            this.Controls.Add(this.AllBTN);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "TETM Order Management System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label codelabel;
        private System.Windows.Forms.Label brandlabel;
        private System.Windows.Forms.Label unitpricelabel;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.TextBox TxtBrand;
        private System.Windows.Forms.TextBox TxtUPrice;
        private System.Windows.Forms.Button PostBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button UpdateBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button AllBTN;
        private System.Windows.Forms.Button clearBTN;
    }
}

