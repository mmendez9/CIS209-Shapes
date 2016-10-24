namespace shapes
{
    partial class AddCircle
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
            this.tbxRadio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAreaC = new System.Windows.Forms.Label();
            this.lblCir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radio";
            // 
            // tbxRadio
            // 
            this.tbxRadio.Location = new System.Drawing.Point(91, 31);
            this.tbxRadio.Name = "tbxRadio";
            this.tbxRadio.Size = new System.Drawing.Size(100, 20);
            this.tbxRadio.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Shape";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAreaC
            // 
            this.lblAreaC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAreaC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAreaC.Location = new System.Drawing.Point(103, 143);
            this.lblAreaC.Name = "lblAreaC";
            this.lblAreaC.Size = new System.Drawing.Size(103, 22);
            this.lblAreaC.TabIndex = 11;
            this.lblAreaC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCir
            // 
            this.lblCir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCir.Location = new System.Drawing.Point(105, 111);
            this.lblCir.Name = "lblCir";
            this.lblCir.Size = new System.Drawing.Size(103, 22);
            this.lblCir.TabIndex = 10;
            this.lblCir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Circumference";
            // 
            // AddCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.lblAreaC);
            this.Controls.Add(this.lblCir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxRadio);
            this.Controls.Add(this.label1);
            this.Name = "AddCircle";
            this.Text = "AddCircle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRadio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAreaC;
        private System.Windows.Forms.Label lblCir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}