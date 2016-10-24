namespace shapes
{
    partial class AddSquare
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSide1S = new System.Windows.Forms.TextBox();
            this.lblPerS = new System.Windows.Forms.Label();
            this.lblAreaS = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Perimeter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Area";
            // 
            // tbxSide1S
            // 
            this.tbxSide1S.Location = new System.Drawing.Point(86, 40);
            this.tbxSide1S.Name = "tbxSide1S";
            this.tbxSide1S.Size = new System.Drawing.Size(100, 20);
            this.tbxSide1S.TabIndex = 4;
            // 
            // lblPerS
            // 
            this.lblPerS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPerS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPerS.Location = new System.Drawing.Point(91, 106);
            this.lblPerS.Name = "lblPerS";
            this.lblPerS.Size = new System.Drawing.Size(103, 22);
            this.lblPerS.TabIndex = 6;
            this.lblPerS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAreaS
            // 
            this.lblAreaS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAreaS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAreaS.Location = new System.Drawing.Point(91, 139);
            this.lblAreaS.Name = "lblAreaS";
            this.lblAreaS.Size = new System.Drawing.Size(103, 22);
            this.lblAreaS.TabIndex = 7;
            this.lblAreaS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(197, 37);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 8;
            this.add.Text = "Add Shape";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // AddSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.add);
            this.Controls.Add(this.lblAreaS);
            this.Controls.Add(this.lblPerS);
            this.Controls.Add(this.tbxSide1S);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddSquare";
            this.Text = "AddSquare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSide1S;
        private System.Windows.Forms.Label lblPerS;
        private System.Windows.Forms.Label lblAreaS;
        private System.Windows.Forms.Button add;
    }
}