namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rbSinus = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbCarre = new System.Windows.Forms.RadioButton();
            this.rbDentScie = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numFrequence = new System.Windows.Forms.NumericUpDown();
            this.numAmplitude = new System.Windows.Forms.NumericUpDown();
            this.numOffset = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtemission = new System.Windows.Forms.TextBox();
            this.txtReception = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPortNames = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnrefresh = new System.Windows.Forms.Button();
            this.Sauvegarde = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFrequence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // rbSinus
            // 
            this.rbSinus.AutoSize = true;
            this.rbSinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbSinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSinus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbSinus.Location = new System.Drawing.Point(44, 43);
            this.rbSinus.Name = "rbSinus";
            this.rbSinus.Size = new System.Drawing.Size(85, 30);
            this.rbSinus.TabIndex = 1;
            this.rbSinus.TabStop = true;
            this.rbSinus.Text = "Sinus";
            this.rbSinus.UseVisualStyleBackColor = false;
            this.rbSinus.CheckedChanged += new System.EventHandler(this.rbSinus_CheckedChanged);
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTriangle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTriangle.Location = new System.Drawing.Point(221, 43);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(107, 30);
            this.rbTriangle.TabIndex = 2;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Triangle";
            this.rbTriangle.UseVisualStyleBackColor = false;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.rbTriangle_CheckedChanged);
            // 
            // rbCarre
            // 
            this.rbCarre.AutoSize = true;
            this.rbCarre.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbCarre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCarre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbCarre.Location = new System.Drawing.Point(418, 43);
            this.rbCarre.Name = "rbCarre";
            this.rbCarre.Size = new System.Drawing.Size(84, 30);
            this.rbCarre.TabIndex = 3;
            this.rbCarre.TabStop = true;
            this.rbCarre.Text = "Carré";
            this.rbCarre.UseVisualStyleBackColor = false;
            this.rbCarre.CheckedChanged += new System.EventHandler(this.rbCarre_CheckedChanged);
            // 
            // rbDentScie
            // 
            this.rbDentScie.AutoSize = true;
            this.rbDentScie.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rbDentScie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDentScie.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbDentScie.Location = new System.Drawing.Point(587, 43);
            this.rbDentScie.Name = "rbDentScie";
            this.rbDentScie.Size = new System.Drawing.Size(155, 30);
            this.rbDentScie.TabIndex = 4;
            this.rbDentScie.TabStop = true;
            this.rbDentScie.Text = "Dent de Scie";
            this.rbDentScie.UseVisualStyleBackColor = false;
            this.rbDentScie.CheckedChanged += new System.EventHandler(this.rbDentScie_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(331, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Amplitude [mV]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(115, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fréquence [Hz]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(551, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Offset [mV]";
            // 
            // numFrequence
            // 
            this.numFrequence.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFrequence.Location = new System.Drawing.Point(138, 141);
            this.numFrequence.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numFrequence.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFrequence.Name = "numFrequence";
            this.numFrequence.Size = new System.Drawing.Size(120, 20);
            this.numFrequence.TabIndex = 11;
            this.numFrequence.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFrequence.ValueChanged += new System.EventHandler(this.NumFreq_ValueChanged);
            // 
            // numAmplitude
            // 
            this.numAmplitude.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numAmplitude.Location = new System.Drawing.Point(349, 141);
            this.numAmplitude.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAmplitude.Name = "numAmplitude";
            this.numAmplitude.Size = new System.Drawing.Size(120, 20);
            this.numAmplitude.TabIndex = 12;
            this.numAmplitude.ValueChanged += new System.EventHandler(this.NumAmpli_ValueChanged);
            // 
            // numOffset
            // 
            this.numOffset.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numOffset.Location = new System.Drawing.Point(553, 141);
            this.numOffset.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOffset.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.numOffset.Name = "numOffset";
            this.numOffset.Size = new System.Drawing.Size(120, 20);
            this.numOffset.TabIndex = 13;
            this.numOffset.ValueChanged += new System.EventHandler(this.NumOffset_ValueChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txtemission
            // 
            this.txtemission.Location = new System.Drawing.Point(155, 198);
            this.txtemission.Name = "txtemission";
            this.txtemission.Size = new System.Drawing.Size(458, 20);
            this.txtemission.TabIndex = 14;
            // 
            // txtReception
            // 
            this.txtReception.Location = new System.Drawing.Point(155, 251);
            this.txtReception.Name = "txtReception";
            this.txtReception.Size = new System.Drawing.Size(458, 20);
            this.txtReception.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(47, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Emission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(47, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Réception";
            // 
            // cboPortNames
            // 
            this.cboPortNames.FormattingEnabled = true;
            this.cboPortNames.Location = new System.Drawing.Point(154, 321);
            this.cboPortNames.Name = "cboPortNames";
            this.cboPortNames.Size = new System.Drawing.Size(79, 21);
            this.cboPortNames.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(47, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "PORT:";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(643, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 46);
            this.button2.TabIndex = 21;
            this.button2.Text = "Envoie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bntSend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(299, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Choix du signal";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(11, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 46);
            this.button3.TabIndex = 23;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(165, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 46);
            this.button4.TabIndex = 24;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatAppearance.BorderSize = 2;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(254, 316);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(89, 32);
            this.btnrefresh.TabIndex = 25;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.Btnrefresh_Click);
            // 
            // Sauvegarde
            // 
            this.Sauvegarde.Appearance = System.Windows.Forms.Appearance.Button;
            this.Sauvegarde.AutoSize = true;
            this.Sauvegarde.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sauvegarde.Location = new System.Drawing.Point(415, 372);
            this.Sauvegarde.Name = "Sauvegarde";
            this.Sauvegarde.Size = new System.Drawing.Size(198, 47);
            this.Sauvegarde.TabIndex = 27;
            this.Sauvegarde.Text = "Sauvegarde";
            this.Sauvegarde.UseVisualStyleBackColor = true;
            this.Sauvegarde.CheckedChanged += new System.EventHandler(this.Sauvegarde_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sauvegarde);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboPortNames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReception);
            this.Controls.Add(this.txtemission);
            this.Controls.Add(this.numOffset);
            this.Controls.Add(this.numAmplitude);
            this.Controls.Add(this.numFrequence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbDentScie);
            this.Controls.Add(this.rbCarre);
            this.Controls.Add(this.rbTriangle);
            this.Controls.Add(this.rbSinus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numFrequence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbSinus;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.RadioButton rbCarre;
        private System.Windows.Forms.RadioButton rbDentScie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numAmplitude;
        private System.Windows.Forms.NumericUpDown numOffset;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txtemission;
        private System.Windows.Forms.TextBox txtReception;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPortNames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        protected internal System.Windows.Forms.NumericUpDown numFrequence;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.CheckBox Sauvegarde;
    }
}

