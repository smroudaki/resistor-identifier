namespace ResistorIdentifier
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
            this.groupBoxBandColors = new System.Windows.Forms.GroupBox();
            this.lblFirstBand = new System.Windows.Forms.Label();
            this.cmbThirdBand = new System.Windows.Forms.ComboBox();
            this.cmbFirstBand = new System.Windows.Forms.ComboBox();
            this.lblThirdBand = new System.Windows.Forms.Label();
            this.cmbSecondBand = new System.Windows.Forms.ComboBox();
            this.lblSecondBand = new System.Windows.Forms.Label();
            this.lblResistance = new System.Windows.Forms.Label();
            this.lblTolerance = new System.Windows.Forms.Label();
            this.txtTolerance = new System.Windows.Forms.TextBox();
            this.lblOmega = new System.Windows.Forms.Label();
            this.lblPercentageSign = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.groupBoxBandColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBandColors
            // 
            this.groupBoxBandColors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxBandColors.Controls.Add(this.lblFirstBand);
            this.groupBoxBandColors.Controls.Add(this.cmbThirdBand);
            this.groupBoxBandColors.Controls.Add(this.cmbFirstBand);
            this.groupBoxBandColors.Controls.Add(this.lblThirdBand);
            this.groupBoxBandColors.Controls.Add(this.cmbSecondBand);
            this.groupBoxBandColors.Controls.Add(this.lblSecondBand);
            this.groupBoxBandColors.Font = new System.Drawing.Font("Bernard MT Condensed", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBandColors.Location = new System.Drawing.Point(108, 85);
            this.groupBoxBandColors.Name = "groupBoxBandColors";
            this.groupBoxBandColors.Size = new System.Drawing.Size(715, 249);
            this.groupBoxBandColors.TabIndex = 0;
            this.groupBoxBandColors.TabStop = false;
            this.groupBoxBandColors.Text = "Select Band Colors";
            // 
            // lblFirstBand
            // 
            this.lblFirstBand.AutoSize = true;
            this.lblFirstBand.Font = new System.Drawing.Font("Bernard MT Condensed", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstBand.Location = new System.Drawing.Point(78, 93);
            this.lblFirstBand.Name = "lblFirstBand";
            this.lblFirstBand.Size = new System.Drawing.Size(106, 33);
            this.lblFirstBand.TabIndex = 0;
            this.lblFirstBand.Text = "1st Band";
            // 
            // cmbThirdBand
            // 
            this.cmbThirdBand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbThirdBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThirdBand.FormattingEnabled = true;
            this.cmbThirdBand.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White"});
            this.cmbThirdBand.Location = new System.Drawing.Point(503, 139);
            this.cmbThirdBand.Name = "cmbThirdBand";
            this.cmbThirdBand.Size = new System.Drawing.Size(159, 46);
            this.cmbThirdBand.TabIndex = 3;
            this.cmbThirdBand.Text = "Select";
            this.cmbThirdBand.SelectedIndexChanged += new System.EventHandler(this.cmbThirdBand_SelectedIndexChanged);
            // 
            // cmbFirstBand
            // 
            this.cmbFirstBand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFirstBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFirstBand.FormattingEnabled = true;
            this.cmbFirstBand.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White"});
            this.cmbFirstBand.Location = new System.Drawing.Point(52, 139);
            this.cmbFirstBand.Name = "cmbFirstBand";
            this.cmbFirstBand.Size = new System.Drawing.Size(159, 46);
            this.cmbFirstBand.TabIndex = 1;
            this.cmbFirstBand.Text = "Select";
            this.cmbFirstBand.SelectedIndexChanged += new System.EventHandler(this.cmbFirstBand_SelectedIndexChanged);
            this.cmbFirstBand.Enter += new System.EventHandler(this.cmbFirstBand_SelectedIndexChanged);
            // 
            // lblThirdBand
            // 
            this.lblThirdBand.AutoSize = true;
            this.lblThirdBand.Font = new System.Drawing.Font("Bernard MT Condensed", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdBand.Location = new System.Drawing.Point(524, 93);
            this.lblThirdBand.Name = "lblThirdBand";
            this.lblThirdBand.Size = new System.Drawing.Size(116, 33);
            this.lblThirdBand.TabIndex = 2;
            this.lblThirdBand.Text = "3rd Band";
            // 
            // cmbSecondBand
            // 
            this.cmbSecondBand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSecondBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSecondBand.FormattingEnabled = true;
            this.cmbSecondBand.Items.AddRange(new object[] {
            "Black",
            "Brown",
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Purple",
            "Gray",
            "White"});
            this.cmbSecondBand.Location = new System.Drawing.Point(274, 139);
            this.cmbSecondBand.Name = "cmbSecondBand";
            this.cmbSecondBand.Size = new System.Drawing.Size(159, 46);
            this.cmbSecondBand.TabIndex = 2;
            this.cmbSecondBand.Text = "Select";
            this.cmbSecondBand.SelectedIndexChanged += new System.EventHandler(this.cmbSecondBand_SelectedIndexChanged);
            // 
            // lblSecondBand
            // 
            this.lblSecondBand.AutoSize = true;
            this.lblSecondBand.Font = new System.Drawing.Font("Bernard MT Condensed", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondBand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSecondBand.Location = new System.Drawing.Point(293, 93);
            this.lblSecondBand.Name = "lblSecondBand";
            this.lblSecondBand.Size = new System.Drawing.Size(120, 33);
            this.lblSecondBand.TabIndex = 1;
            this.lblSecondBand.Text = "2nd Band";
            // 
            // lblResistance
            // 
            this.lblResistance.AutoSize = true;
            this.lblResistance.Font = new System.Drawing.Font("Andalus", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResistance.Location = new System.Drawing.Point(247, 410);
            this.lblResistance.Name = "lblResistance";
            this.lblResistance.Size = new System.Drawing.Size(135, 43);
            this.lblResistance.TabIndex = 8;
            this.lblResistance.Text = "Resistance";
            // 
            // lblTolerance
            // 
            this.lblTolerance.AutoSize = true;
            this.lblTolerance.Font = new System.Drawing.Font("Andalus", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTolerance.Location = new System.Drawing.Point(247, 465);
            this.lblTolerance.Name = "lblTolerance";
            this.lblTolerance.Size = new System.Drawing.Size(132, 43);
            this.lblTolerance.TabIndex = 10;
            this.lblTolerance.Text = "Tolerance";
            // 
            // txtTolerance
            // 
            this.txtTolerance.Location = new System.Drawing.Point(435, 470);
            this.txtTolerance.Name = "txtTolerance";
            this.txtTolerance.ReadOnly = true;
            this.txtTolerance.Size = new System.Drawing.Size(192, 38);
            this.txtTolerance.TabIndex = 8;
            // 
            // lblOmega
            // 
            this.lblOmega.AutoSize = true;
            this.lblOmega.Location = new System.Drawing.Point(643, 410);
            this.lblOmega.Name = "lblOmega";
            this.lblOmega.Size = new System.Drawing.Size(37, 32);
            this.lblOmega.TabIndex = 12;
            this.lblOmega.Text = "Ω";
            // 
            // lblPercentageSign
            // 
            this.lblPercentageSign.AutoSize = true;
            this.lblPercentageSign.Location = new System.Drawing.Point(643, 476);
            this.lblPercentageSign.Name = "lblPercentageSign";
            this.lblPercentageSign.Size = new System.Drawing.Size(40, 32);
            this.lblPercentageSign.TabIndex = 13;
            this.lblPercentageSign.Text = "%";
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Location = new System.Drawing.Point(0, 746);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(931, 60);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.Location = new System.Drawing.Point(0, 686);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(931, 60);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Reset";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(435, 410);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(192, 38);
            this.txtResult.TabIndex = 7;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "Kiloo",
            "Mega"});
            this.cmbUnit.Location = new System.Drawing.Point(253, 528);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(136, 39);
            this.cmbUnit.TabIndex = 4;
            this.cmbUnit.Text = "Unit";
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.cmbUnit_SelectedIndexChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(435, 529);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(192, 38);
            this.txtUnit.TabIndex = 9;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(643, 535);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(0, 32);
            this.lblUnit.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(931, 806);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPercentageSign);
            this.Controls.Add(this.lblOmega);
            this.Controls.Add(this.txtTolerance);
            this.Controls.Add(this.lblTolerance);
            this.Controls.Add(this.lblResistance);
            this.Controls.Add(this.groupBoxBandColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxBandColors.ResumeLayout(false);
            this.groupBoxBandColors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBandColors;
        private System.Windows.Forms.Label lblFirstBand;
        private System.Windows.Forms.ComboBox cmbThirdBand;
        private System.Windows.Forms.ComboBox cmbFirstBand;
        private System.Windows.Forms.Label lblThirdBand;
        private System.Windows.Forms.ComboBox cmbSecondBand;
        private System.Windows.Forms.Label lblSecondBand;
        private System.Windows.Forms.Label lblResistance;
        private System.Windows.Forms.Label lblTolerance;
        private System.Windows.Forms.TextBox txtTolerance;
        private System.Windows.Forms.Label lblOmega;
        private System.Windows.Forms.Label lblPercentageSign;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnit;
    }
}

