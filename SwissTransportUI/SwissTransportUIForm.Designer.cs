namespace SwissTransportUI
{
    partial class SwissTransportUIForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearchConnections = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.listConnections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(566, 16);
            this.btnSearchConnections.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(116, 54);
            this.btnSearchConnections.TabIndex = 0;
            this.btnSearchConnections.Text = "Suchen Verbindungen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(20, 16);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(32, 16);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "Von";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(294, 16);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(40, 16);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Nach";
            // 
            // txtFrom
            // 
            this.txtFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFrom.Location = new System.Drawing.Point(24, 35);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(261, 22);
            this.txtFrom.TabIndex = 3;
            this.txtFrom.TextChanged += new System.EventHandler(this.GetStationSuggestions);
            // 
            // txtTo
            // 
            this.txtTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTo.Location = new System.Drawing.Point(298, 35);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(261, 22);
            this.txtTo.TabIndex = 4;
            this.txtTo.TextChanged += new System.EventHandler(this.GetStationSuggestions);
            // 
            // listConnections
            // 
            this.listConnections.FormattingEnabled = true;
            this.listConnections.ItemHeight = 16;
            this.listConnections.Location = new System.Drawing.Point(23, 74);
            this.listConnections.Name = "listConnections";
            this.listConnections.Size = new System.Drawing.Size(536, 276);
            this.listConnections.TabIndex = 5;
            // 
            // SwissTransportUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 381);
            this.Controls.Add(this.listConnections);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnSearchConnections);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SwissTransportUIForm";
            this.Text = "SwissTranport";
            this.Load += new System.EventHandler(this.SwissTransportUIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.ListBox listConnections;
    }
}

