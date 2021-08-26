namespace CameraScanner
{
    partial class FMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.p_main = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lLength = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lFormat = new System.Windows.Forms.Label();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bStateScanOff = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.bStateScanOn = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.ddlCamera = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.p_main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // p_main
            // 
            this.p_main.Controls.Add(this.tableLayoutPanel1);
            this.p_main.Controls.Add(this.tbBarcode);
            this.p_main.Controls.Add(this.panel1);
            this.p_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_main.Location = new System.Drawing.Point(0, 0);
            this.p_main.Name = "p_main";
            this.p_main.Size = new System.Drawing.Size(1240, 635);
            this.p_main.TabIndex = 0;
            this.p_main.Paint += new System.Windows.Forms.PaintEventHandler(this.p_main_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5283F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.47169F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lLength, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lFormat, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(693, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 113);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lunghezza [GS]";
            // 
            // lLength
            // 
            this.lLength.AutoSize = true;
            this.lLength.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLength.ForeColor = System.Drawing.Color.Red;
            this.lLength.Location = new System.Drawing.Point(134, 43);
            this.lLength.Name = "lLength";
            this.lLength.Size = new System.Drawing.Size(16, 16);
            this.lLength.TabIndex = 5;
            this.lLength.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipologia";
            // 
            // lFormat
            // 
            this.lFormat.AutoSize = true;
            this.lFormat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFormat.ForeColor = System.Drawing.Color.Red;
            this.lFormat.Location = new System.Drawing.Point(134, 1);
            this.lFormat.Name = "lFormat";
            this.lFormat.Size = new System.Drawing.Size(23, 16);
            this.lFormat.TabIndex = 3;
            this.lFormat.Text = "---";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBarcode.Location = new System.Drawing.Point(693, 150);
            this.tbBarcode.Multiline = true;
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbBarcode.Size = new System.Drawing.Size(531, 261);
            this.tbBarcode.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bStateScanOff);
            this.panel1.Controls.Add(this.bReset);
            this.panel1.Controls.Add(this.bStateScanOn);
            this.panel1.Controls.Add(this.pb);
            this.panel1.Controls.Add(this.bStop);
            this.panel1.Controls.Add(this.bStart);
            this.panel1.Controls.Add(this.ddlCamera);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 635);
            this.panel1.TabIndex = 1;
            // 
            // bStateScanOff
            // 
            this.bStateScanOff.AutoSize = true;
            this.bStateScanOff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bStateScanOff.BackColor = System.Drawing.Color.Transparent;
            this.bStateScanOff.FlatAppearance.BorderSize = 0;
            this.bStateScanOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bStateScanOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bStateScanOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStateScanOff.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStateScanOff.ForeColor = System.Drawing.Color.Navy;
            this.bStateScanOff.Image = ((System.Drawing.Image)(resources.GetObject("bStateScanOff.Image")));
            this.bStateScanOff.Location = new System.Drawing.Point(188, 38);
            this.bStateScanOff.Name = "bStateScanOff";
            this.bStateScanOff.Size = new System.Drawing.Size(54, 54);
            this.bStateScanOff.TabIndex = 5;
            this.toolTip1.SetToolTip(this.bStateScanOff, "Scansione completata");
            this.bStateScanOff.UseVisualStyleBackColor = false;
            this.bStateScanOff.Visible = false;
            this.bStateScanOff.Click += new System.EventHandler(this.bStateScanOff_Click);
            // 
            // bReset
            // 
            this.bReset.AutoSize = true;
            this.bReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bReset.FlatAppearance.BorderSize = 0;
            this.bReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReset.ForeColor = System.Drawing.Color.Navy;
            this.bReset.Image = ((System.Drawing.Image)(resources.GetObject("bReset.Image")));
            this.bReset.Location = new System.Drawing.Point(291, 41);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(54, 54);
            this.bReset.TabIndex = 4;
            this.toolTip1.SetToolTip(this.bReset, "Reset scansione");
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Visible = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bStateScanOn
            // 
            this.bStateScanOn.AutoSize = true;
            this.bStateScanOn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bStateScanOn.BackColor = System.Drawing.Color.Transparent;
            this.bStateScanOn.FlatAppearance.BorderSize = 0;
            this.bStateScanOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bStateScanOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bStateScanOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStateScanOn.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStateScanOn.ForeColor = System.Drawing.Color.Navy;
            this.bStateScanOn.Image = ((System.Drawing.Image)(resources.GetObject("bStateScanOn.Image")));
            this.bStateScanOn.Location = new System.Drawing.Point(188, 37);
            this.bStateScanOn.Name = "bStateScanOn";
            this.bStateScanOn.Size = new System.Drawing.Size(54, 54);
            this.bStateScanOn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.bStateScanOn, "Scansione in corso...");
            this.bStateScanOn.UseVisualStyleBackColor = false;
            this.bStateScanOn.Visible = false;
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb.Location = new System.Drawing.Point(0, 101);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(679, 532);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 3;
            this.pb.TabStop = false;
            // 
            // bStop
            // 
            this.bStop.AutoSize = true;
            this.bStop.FlatAppearance.BorderSize = 0;
            this.bStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStop.ForeColor = System.Drawing.Color.Navy;
            this.bStop.Image = ((System.Drawing.Image)(resources.GetObject("bStop.Image")));
            this.bStop.Location = new System.Drawing.Point(70, 39);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(54, 54);
            this.bStop.TabIndex = 2;
            this.toolTip1.SetToolTip(this.bStop, "Arresta camera");
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Visible = false;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bStart
            // 
            this.bStart.AutoSize = true;
            this.bStart.FlatAppearance.BorderSize = 0;
            this.bStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.ForeColor = System.Drawing.Color.Navy;
            this.bStart.Image = ((System.Drawing.Image)(resources.GetObject("bStart.Image")));
            this.bStart.Location = new System.Drawing.Point(70, 39);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(54, 54);
            this.bStart.TabIndex = 1;
            this.bStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.bStart, "Avvia camera");
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // ddlCamera
            // 
            this.ddlCamera.Dock = System.Windows.Forms.DockStyle.Top;
            this.ddlCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCamera.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlCamera.FormattingEnabled = true;
            this.ddlCamera.Location = new System.Drawing.Point(0, 0);
            this.ddlCamera.Name = "ddlCamera";
            this.ddlCamera.Size = new System.Drawing.Size(679, 24);
            this.ddlCamera.TabIndex = 0;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 635);
            this.Controls.Add(this.p_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.Text = " mFCameraScanner (Prototype)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.p_main.ResumeLayout(false);
            this.p_main.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_main;
        private System.Windows.Forms.ComboBox ddlCamera;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TextBox tbBarcode;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Label lFormat;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Label lLength;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bStateScanOn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bStateScanOff;
    }
}

