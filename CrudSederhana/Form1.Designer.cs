namespace CrudSederhana
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNAMA = new System.Windows.Forms.TextBox();
            this.btnTAMBAH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.btnHAPUS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.btnUBAH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTELEPON = new System.Windows.Forms.TextBox();
            this.btnREFRESH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtALAMAT = new System.Windows.Forms.TextBox();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAMA";
            // 
            // txtNAMA
            // 
            this.txtNAMA.Location = new System.Drawing.Point(235, 59);
            this.txtNAMA.Name = "txtNAMA";
            this.txtNAMA.Size = new System.Drawing.Size(171, 22);
            this.txtNAMA.TabIndex = 1;
            // 
            // btnTAMBAH
            // 
            this.btnTAMBAH.Location = new System.Drawing.Point(443, 90);
            this.btnTAMBAH.Name = "btnTAMBAH";
            this.btnTAMBAH.Size = new System.Drawing.Size(80, 23);
            this.btnTAMBAH.TabIndex = 2;
            this.btnTAMBAH.Text = "TAMBAH";
            this.btnTAMBAH.UseVisualStyleBackColor = true;
            this.btnTAMBAH.Click += new System.EventHandler(this.btnTAMBAH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NIM";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(235, 121);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(171, 22);
            this.txtNIM.TabIndex = 4;
            // 
            // btnHAPUS
            // 
            this.btnHAPUS.Location = new System.Drawing.Point(443, 161);
            this.btnHAPUS.Name = "btnHAPUS";
            this.btnHAPUS.Size = new System.Drawing.Size(80, 24);
            this.btnHAPUS.TabIndex = 5;
            this.btnHAPUS.Text = "HAPUS";
            this.btnHAPUS.UseVisualStyleBackColor = true;
            this.btnHAPUS.Click += new System.EventHandler(this.btnHAPUS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "EMAIL";
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(235, 189);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(171, 22);
            this.txtEMAIL.TabIndex = 7;
            // 
            // btnUBAH
            // 
            this.btnUBAH.Location = new System.Drawing.Point(443, 227);
            this.btnUBAH.Name = "btnUBAH";
            this.btnUBAH.Size = new System.Drawing.Size(80, 23);
            this.btnUBAH.TabIndex = 8;
            this.btnUBAH.Text = "UBAH";
            this.btnUBAH.UseVisualStyleBackColor = true;
            this.btnUBAH.Click += new System.EventHandler(this.btnUBAH_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "TELEPON";
            // 
            // txtTELEPON
            // 
            this.txtTELEPON.Location = new System.Drawing.Point(235, 252);
            this.txtTELEPON.Name = "txtTELEPON";
            this.txtTELEPON.Size = new System.Drawing.Size(171, 22);
            this.txtTELEPON.TabIndex = 10;
            // 
            // btnREFRESH
            // 
            this.btnREFRESH.Location = new System.Drawing.Point(443, 299);
            this.btnREFRESH.Name = "btnREFRESH";
            this.btnREFRESH.Size = new System.Drawing.Size(80, 26);
            this.btnREFRESH.TabIndex = 11;
            this.btnREFRESH.Text = "REFRESH";
            this.btnREFRESH.UseVisualStyleBackColor = true;
            this.btnREFRESH.Click += new System.EventHandler(this.btnREFRESH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "ALAMAT";
            // 
            // txtALAMAT
            // 
            this.txtALAMAT.Location = new System.Drawing.Point(235, 314);
            this.txtALAMAT.Name = "txtALAMAT";
            this.txtALAMAT.Size = new System.Drawing.Size(171, 22);
            this.txtALAMAT.TabIndex = 13;
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.AllowUserToAddRows = false;
            this.dgvMahasiswa.AllowUserToDeleteRows = false;
            this.dgvMahasiswa.BackgroundColor = System.Drawing.Color.Bisque;
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Location = new System.Drawing.Point(162, 358);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.ReadOnly = true;
            this.dgvMahasiswa.RowHeadersWidth = 51;
            this.dgvMahasiswa.RowTemplate.Height = 24;
            this.dgvMahasiswa.Size = new System.Drawing.Size(361, 206);
            this.dgvMahasiswa.TabIndex = 14;
            this.dgvMahasiswa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMahasiswa_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.txtALAMAT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnREFRESH);
            this.Controls.Add(this.txtTELEPON);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUBAH);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHAPUS);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTAMBAH);
            this.Controls.Add(this.txtNAMA);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNAMA;
        private System.Windows.Forms.Button btnTAMBAH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.Button btnHAPUS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.Button btnUBAH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTELEPON;
        private System.Windows.Forms.Button btnREFRESH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtALAMAT;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
    }
}

