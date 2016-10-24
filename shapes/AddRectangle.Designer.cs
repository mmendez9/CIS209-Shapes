namespace shapes
{
    partial class AddRectangle
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxSide2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSide1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAreaR = new System.Windows.Forms.Label();
            this.lblPerR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(194, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add Shape";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxSide2
            // 
            this.tbxSide2.Location = new System.Drawing.Point(60, 61);
            this.tbxSide2.Name = "tbxSide2";
            this.tbxSide2.Size = new System.Drawing.Size(100, 20);
            this.tbxSide2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Side 2";
            // 
            // tbxSide1
            // 
            this.tbxSide1.Location = new System.Drawing.Point(60, 35);
            this.tbxSide1.Name = "tbxSide1";
            this.tbxSide1.Size = new System.Drawing.Size(100, 20);
            this.tbxSide1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Side 1";
            // 
            // lblAreaR
            // 
            this.lblAreaR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAreaR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAreaR.Location = new System.Drawing.Point(83, 171);
            this.lblAreaR.Name = "lblAreaR";
            this.lblAreaR.Size = new System.Drawing.Size(103, 22);
            this.lblAreaR.TabIndex = 19;
            this.lblAreaR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPerR
            // 
            this.lblPerR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPerR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPerR.Location = new System.Drawing.Point(83, 140);
            this.lblPerR.Name = "lblPerR";
            this.lblPerR.Size = new System.Drawing.Size(103, 22);
            this.lblPerR.TabIndex = 18;
            this.lblPerR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Perimeter";
            // 
            // AddRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblAreaR);
            this.Controls.Add(this.lblPerR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxSide2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxSide1);
            this.Controls.Add(this.label1);
            this.Name = "AddRectangle";
            this.Text = "AddRectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxSide2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSide1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAreaR;
        private System.Windows.Forms.Label lblPerR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}