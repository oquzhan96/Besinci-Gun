
namespace YazıYazmaCocuk
{
    partial class Form2
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
            this.btStart = new System.Windows.Forms.Button();
            this.btStp = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(12, 395);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(121, 43);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Başlat";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStp
            // 
            this.btStp.Location = new System.Drawing.Point(161, 395);
            this.btStp.Name = "btStp";
            this.btStp.Size = new System.Drawing.Size(116, 42);
            this.btStp.TabIndex = 1;
            this.btStp.Text = "Durdur";
            this.btStp.UseVisualStyleBackColor = true;
            this.btStp.Click += new System.EventHandler(this.btStp_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(178, 30);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "00:00:00";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btStp);
            this.Controls.Add(this.btStart);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStp;
        private System.Windows.Forms.TextBox txtResult;
    }
}