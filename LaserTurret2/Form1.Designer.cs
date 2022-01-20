
namespace LaserTurret2
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
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.portSelector = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.portToggle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.portSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM7";
            // 
            // portSelector
            // 
            this.portSelector.Location = new System.Drawing.Point(3, 529);
            this.portSelector.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.portSelector.Name = "portSelector";
            this.portSelector.Size = new System.Drawing.Size(120, 20);
            this.portSelector.TabIndex = 0;
            this.portSelector.ValueChanged += new System.EventHandler(this.portSelector_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // portToggle
            // 
            this.portToggle.Location = new System.Drawing.Point(129, 529);
            this.portToggle.Name = "portToggle";
            this.portToggle.Size = new System.Drawing.Size(157, 23);
            this.portToggle.TabIndex = 2;
            this.portToggle.Text = "Close Port";
            this.portToggle.UseVisualStyleBackColor = true;
            this.portToggle.Click += new System.EventHandler(this.portToggle_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.portToggle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portSelector);
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.portSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort port;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.NumericUpDown portSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button portToggle;
    }
}

