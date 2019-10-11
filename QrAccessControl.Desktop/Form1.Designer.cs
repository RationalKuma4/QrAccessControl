namespace QrAccessControl.Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboCamera = new System.Windows.Forms.ComboBox();
            this.comboLabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.regData = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.activateButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 482);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboCamera
            // 
            this.comboCamera.FormattingEnabled = true;
            this.comboCamera.Location = new System.Drawing.Point(666, 12);
            this.comboCamera.Name = "comboCamera";
            this.comboCamera.Size = new System.Drawing.Size(121, 21);
            this.comboCamera.TabIndex = 1;
            // 
            // comboLabel
            // 
            this.comboLabel.AutoSize = true;
            this.comboLabel.Location = new System.Drawing.Point(617, 15);
            this.comboLabel.Name = "comboLabel";
            this.comboLabel.Size = new System.Drawing.Size(43, 13);
            this.comboLabel.TabIndex = 2;
            this.comboLabel.Text = "Camara";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(534, 93);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "labelName";
            // 
            // regData
            // 
            this.regData.AutoSize = true;
            this.regData.Location = new System.Drawing.Point(537, 110);
            this.regData.Name = "regData";
            this.regData.Size = new System.Drawing.Size(30, 13);
            this.regData.TabIndex = 4;
            this.regData.Text = "Dato";
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(537, 165);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(75, 23);
            this.scanButton.TabIndex = 5;
            this.scanButton.Text = "Escanear";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // activateButton
            // 
            this.activateButton.Location = new System.Drawing.Point(537, 471);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(75, 23);
            this.activateButton.TabIndex = 6;
            this.activateButton.Text = "Activar";
            this.activateButton.UseVisualStyleBackColor = true;
            this.activateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(821, 471);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 7;
            this.printButton.Text = "Imprimir";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 506);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.regData);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboLabel);
            this.Controls.Add(this.comboCamera);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboCamera;
        private System.Windows.Forms.Label comboLabel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label regData;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Timer timer1;
    }
}

