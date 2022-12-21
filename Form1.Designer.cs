namespace TaxiDispatcher
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
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.txtTaxi = new System.Windows.Forms.TextBox();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRequest.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(13, 16);
            this.btnRequest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(107, 25);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Request a Taxi:";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(607, 136);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(135, 27);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "End of Shift Report:";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // txtTaxi
            // 
            this.txtTaxi.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTaxi.Location = new System.Drawing.Point(13, 47);
            this.txtTaxi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTaxi.Multiline = true;
            this.txtTaxi.Name = "txtTaxi";
            this.txtTaxi.Size = new System.Drawing.Size(212, 105);
            this.txtTaxi.TabIndex = 2;
            this.txtTaxi.TextChanged += new System.EventHandler(this.txtTaxi_TextChanged);
            // 
            // txtReport
            // 
            this.txtReport.ForeColor = System.Drawing.Color.Firebrick;
            this.txtReport.Location = new System.Drawing.Point(235, 169);
            this.txtReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(507, 139);
            this.txtReport.TabIndex = 3;
            this.txtReport.TextChanged += new System.EventHandler(this.txtReport_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(756, 320);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.txtTaxi);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRequest);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Welcome to CTC Taxi App";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtTaxi;
        private System.Windows.Forms.TextBox txtReport;
    }
}

