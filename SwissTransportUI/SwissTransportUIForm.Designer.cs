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
            this.tabTimeTablePage = new System.Windows.Forms.TabControl();
            this.tabConnectionPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listTimeTable = new System.Windows.Forms.ListBox();
            this.btnCreateTimeTable = new System.Windows.Forms.Button();
            this.txtStartStation = new System.Windows.Forms.TextBox();
            this.lblStartStation = new System.Windows.Forms.Label();
            this.tabTimeTablePage.SuspendLayout();
            this.tabConnectionPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(566, 18);
            this.btnSearchConnections.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchConnections.Name = "btnSearchConnections";
            this.btnSearchConnections.Size = new System.Drawing.Size(166, 54);
            this.btnSearchConnections.TabIndex = 0;
            this.btnSearchConnections.Text = "Verbindungen Suchen";
            this.btnSearchConnections.UseVisualStyleBackColor = true;
            this.btnSearchConnections.Click += new System.EventHandler(this.btnSearchConnections_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(20, 18);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(32, 16);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "Von";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(294, 18);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(40, 16);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Nach";
            // 
            // txtFrom
            // 
            this.txtFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFrom.Location = new System.Drawing.Point(24, 37);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(4);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(261, 22);
            this.txtFrom.TabIndex = 3;
            this.txtFrom.TextChanged += new System.EventHandler(this.GetStationSuggestions);
            // 
            // txtTo
            // 
            this.txtTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTo.Location = new System.Drawing.Point(298, 37);
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
            this.listConnections.Location = new System.Drawing.Point(23, 76);
            this.listConnections.Name = "listConnections";
            this.listConnections.Size = new System.Drawing.Size(709, 276);
            this.listConnections.TabIndex = 5;
            // 
            // tabTimeTablePage
            // 
            this.tabTimeTablePage.Controls.Add(this.tabConnectionPage);
            this.tabTimeTablePage.Controls.Add(this.tabPage2);
            this.tabTimeTablePage.Location = new System.Drawing.Point(12, 12);
            this.tabTimeTablePage.Name = "tabTimeTablePage";
            this.tabTimeTablePage.SelectedIndex = 0;
            this.tabTimeTablePage.Size = new System.Drawing.Size(794, 407);
            this.tabTimeTablePage.TabIndex = 6;
            // 
            // tabConnectionPage
            // 
            this.tabConnectionPage.Controls.Add(this.txtFrom);
            this.tabConnectionPage.Controls.Add(this.listConnections);
            this.tabConnectionPage.Controls.Add(this.btnSearchConnections);
            this.tabConnectionPage.Controls.Add(this.txtTo);
            this.tabConnectionPage.Controls.Add(this.lblFrom);
            this.tabConnectionPage.Controls.Add(this.lblTo);
            this.tabConnectionPage.Location = new System.Drawing.Point(4, 25);
            this.tabConnectionPage.Name = "tabConnectionPage";
            this.tabConnectionPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnectionPage.Size = new System.Drawing.Size(786, 378);
            this.tabConnectionPage.TabIndex = 0;
            this.tabConnectionPage.Text = "Verbindungen";
            this.tabConnectionPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listTimeTable);
            this.tabPage2.Controls.Add(this.btnCreateTimeTable);
            this.tabPage2.Controls.Add(this.txtStartStation);
            this.tabPage2.Controls.Add(this.lblStartStation);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrttafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listTimeTable
            // 
            this.listTimeTable.FormattingEnabled = true;
            this.listTimeTable.ItemHeight = 16;
            this.listTimeTable.Location = new System.Drawing.Point(21, 87);
            this.listTimeTable.Name = "listTimeTable";
            this.listTimeTable.Size = new System.Drawing.Size(744, 276);
            this.listTimeTable.TabIndex = 3;
            // 
            // btnCreateTimeTable
            // 
            this.btnCreateTimeTable.Location = new System.Drawing.Point(230, 29);
            this.btnCreateTimeTable.Name = "btnCreateTimeTable";
            this.btnCreateTimeTable.Size = new System.Drawing.Size(162, 41);
            this.btnCreateTimeTable.TabIndex = 2;
            this.btnCreateTimeTable.Text = "Abfahrtplan erstellen";
            this.btnCreateTimeTable.UseVisualStyleBackColor = true;
            this.btnCreateTimeTable.Click += new System.EventHandler(this.btnCreateTimeTable_Click);
            // 
            // txtStartStation
            // 
            this.txtStartStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtStartStation.Location = new System.Drawing.Point(21, 38);
            this.txtStartStation.Name = "txtStartStation";
            this.txtStartStation.Size = new System.Drawing.Size(203, 22);
            this.txtStartStation.TabIndex = 1;
            this.txtStartStation.TextChanged += new System.EventHandler(this.GetStationSuggestions);
            // 
            // lblStartStation
            // 
            this.lblStartStation.AutoSize = true;
            this.lblStartStation.Location = new System.Drawing.Point(18, 19);
            this.lblStartStation.Name = "lblStartStation";
            this.lblStartStation.Size = new System.Drawing.Size(79, 16);
            this.lblStartStation.TabIndex = 0;
            this.lblStartStation.Text = "Start Station";
            // 
            // SwissTransportUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 538);
            this.Controls.Add(this.tabTimeTablePage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SwissTransportUIForm";
            this.Text = "SwissTranport";
            this.Load += new System.EventHandler(this.SwissTransportUIForm_Load);
            this.tabTimeTablePage.ResumeLayout(false);
            this.tabConnectionPage.ResumeLayout(false);
            this.tabConnectionPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchConnections;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.ListBox listConnections;
        private System.Windows.Forms.TabControl tabTimeTablePage;
        private System.Windows.Forms.TabPage tabConnectionPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreateTimeTable;
        private System.Windows.Forms.TextBox txtStartStation;
        private System.Windows.Forms.Label lblStartStation;
        private System.Windows.Forms.ListBox listTimeTable;
    }
}

