namespace Analiz
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
            this.updtbtn = new System.Windows.Forms.Button();
            this.srchbtn = new System.Windows.Forms.Button();
            this.grphbtn = new System.Windows.Forms.Button();
            this.wnlstbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updtbtn
            // 
            this.updtbtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updtbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.updtbtn.Location = new System.Drawing.Point(217, 70);
            this.updtbtn.Name = "updtbtn";
            this.updtbtn.Size = new System.Drawing.Size(293, 92);
            this.updtbtn.TabIndex = 0;
            this.updtbtn.Text = "UPDATE";
            this.updtbtn.UseVisualStyleBackColor = true;
            this.updtbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // srchbtn
            // 
            this.srchbtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.srchbtn.Location = new System.Drawing.Point(217, 184);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(293, 92);
            this.srchbtn.TabIndex = 1;
            this.srchbtn.Text = "SEARCH";
            this.srchbtn.UseVisualStyleBackColor = true;
            this.srchbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // grphbtn
            // 
            this.grphbtn.BackColor = System.Drawing.SystemColors.Control;
            this.grphbtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grphbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grphbtn.Location = new System.Drawing.Point(217, 411);
            this.grphbtn.Name = "grphbtn";
            this.grphbtn.Size = new System.Drawing.Size(293, 92);
            this.grphbtn.TabIndex = 2;
            this.grphbtn.Text = "GRAPH";
            this.grphbtn.UseVisualStyleBackColor = false;
            this.grphbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // wnlstbtn
            // 
            this.wnlstbtn.BackColor = System.Drawing.SystemColors.Control;
            this.wnlstbtn.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wnlstbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.wnlstbtn.Location = new System.Drawing.Point(217, 296);
            this.wnlstbtn.Name = "wnlstbtn";
            this.wnlstbtn.Size = new System.Drawing.Size(293, 92);
            this.wnlstbtn.TabIndex = 3;
            this.wnlstbtn.Text = "LIST WON BETS";
            this.wnlstbtn.UseVisualStyleBackColor = false;
            this.wnlstbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(758, 623);
            this.Controls.Add(this.wnlstbtn);
            this.Controls.Add(this.grphbtn);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.updtbtn);
            this.Name = "Form1";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updtbtn;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.Button grphbtn;
        private System.Windows.Forms.Button wnlstbtn;
    }
}

