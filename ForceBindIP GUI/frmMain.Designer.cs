namespace ForceBindIP_GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNetworkAdapter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTargetApp = new System.Windows.Forms.TextBox();
            this.btnOpenTargetApplication = new System.Windows.Forms.Button();
            this.chk64b = new System.Windows.Forms.CheckBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Network Adapter to bind:";
            // 
            // cmbNetworkAdapter
            // 
            this.cmbNetworkAdapter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.cmbNetworkAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetworkAdapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNetworkAdapter.ForeColor = System.Drawing.Color.White;
            this.cmbNetworkAdapter.FormattingEnabled = true;
            this.cmbNetworkAdapter.Location = new System.Drawing.Point(143, 6);
            this.cmbNetworkAdapter.Name = "cmbNetworkAdapter";
            this.cmbNetworkAdapter.Size = new System.Drawing.Size(273, 21);
            this.cmbNetworkAdapter.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Target Application:";
            // 
            // txtTargetApp
            // 
            this.txtTargetApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.txtTargetApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTargetApp.ForeColor = System.Drawing.Color.White;
            this.txtTargetApp.Location = new System.Drawing.Point(143, 33);
            this.txtTargetApp.Name = "txtTargetApp";
            this.txtTargetApp.Size = new System.Drawing.Size(239, 20);
            this.txtTargetApp.TabIndex = 6;
            // 
            // btnOpenTargetApplication
            // 
            this.btnOpenTargetApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.btnOpenTargetApplication.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.btnOpenTargetApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenTargetApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTargetApplication.ForeColor = System.Drawing.Color.White;
            this.btnOpenTargetApplication.Location = new System.Drawing.Point(386, 32);
            this.btnOpenTargetApplication.Name = "btnOpenTargetApplication";
            this.btnOpenTargetApplication.Size = new System.Drawing.Size(30, 21);
            this.btnOpenTargetApplication.TabIndex = 7;
            this.btnOpenTargetApplication.Text = "...";
            this.btnOpenTargetApplication.UseVisualStyleBackColor = false;
            // 
            // chk64b
            // 
            this.chk64b.AutoSize = true;
            this.chk64b.ForeColor = System.Drawing.Color.White;
            this.chk64b.Location = new System.Drawing.Point(15, 62);
            this.chk64b.Name = "chk64b";
            this.chk64b.Size = new System.Drawing.Size(109, 17);
            this.chk64b.TabIndex = 8;
            this.chk64b.Text = "64bits Application";
            this.chk64b.UseVisualStyleBackColor = true;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.btnLaunch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(122)))));
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunch.ForeColor = System.Drawing.Color.White;
            this.btnLaunch.Location = new System.Drawing.Point(143, 62);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(273, 21);
            this.btnLaunch.TabIndex = 9;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(425, 91);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.chk64b);
            this.Controls.Add(this.btnOpenTargetApplication);
            this.Controls.Add(this.txtTargetApp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNetworkAdapter);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForceBindIP GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNetworkAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTargetApp;
        private System.Windows.Forms.Button btnOpenTargetApplication;
        private System.Windows.Forms.CheckBox chk64b;
        private System.Windows.Forms.Button btnLaunch;
    }
}

