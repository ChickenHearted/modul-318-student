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
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.tabTimeTable = new System.Windows.Forms.TabPage();
            this.listTimeTable = new System.Windows.Forms.ListBox();
            this.btnCreateTimeTable = new System.Windows.Forms.Button();
            this.txtStartStation = new System.Windows.Forms.TextBox();
            this.lblStartStation = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.rdBtnDeparture = new System.Windows.Forms.RadioButton();
            this.rdBtnArrival = new System.Windows.Forms.RadioButton();
            this.tabTimeTablePage.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.tabTimeTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchConnections
            // 
            this.btnSearchConnections.Location = new System.Drawing.Point(388, 72);
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
            this.lblTo.Location = new System.Drawing.Point(290, 18);
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
            this.txtTo.Location = new System.Drawing.Point(293, 37);
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
            this.listConnections.Location = new System.Drawing.Point(23, 139);
            this.listConnections.Name = "listConnections";
            this.listConnections.Size = new System.Drawing.Size(531, 276);
            this.listConnections.TabIndex = 5;
            // 
            // tabTimeTablePage
            // 
            this.tabTimeTablePage.Controls.Add(this.tabConnection);
            this.tabTimeTablePage.Controls.Add(this.tabTimeTable);
            this.tabTimeTablePage.Location = new System.Drawing.Point(12, 12);
            this.tabTimeTablePage.Name = "tabTimeTablePage";
            this.tabTimeTablePage.SelectedIndex = 0;
            this.tabTimeTablePage.Size = new System.Drawing.Size(587, 490);
            this.tabTimeTablePage.TabIndex = 6;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.rdBtnArrival);
            this.tabConnection.Controls.Add(this.rdBtnDeparture);
            this.tabConnection.Controls.Add(this.dtpTime);
            this.tabConnection.Controls.Add(this.dtpDate);
            this.tabConnection.Controls.Add(this.txtFrom);
            this.tabConnection.Controls.Add(this.listConnections);
            this.tabConnection.Controls.Add(this.btnSearchConnections);
            this.tabConnection.Controls.Add(this.txtTo);
            this.tabConnection.Controls.Add(this.lblFrom);
            this.tabConnection.Controls.Add(this.lblTo);
            this.tabConnection.Location = new System.Drawing.Point(4, 25);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(579, 461);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Verbindungen";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // tabTimeTable
            // 
            this.tabTimeTable.Controls.Add(this.listTimeTable);
            this.tabTimeTable.Controls.Add(this.btnCreateTimeTable);
            this.tabTimeTable.Controls.Add(this.txtStartStation);
            this.tabTimeTable.Controls.Add(this.lblStartStation);
            this.tabTimeTable.Location = new System.Drawing.Point(4, 25);
            this.tabTimeTable.Name = "tabTimeTable";
            this.tabTimeTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimeTable.Size = new System.Drawing.Size(579, 461);
            this.tabTimeTable.TabIndex = 1;
            this.tabTimeTable.Text = "Abfahrttafel";
            this.tabTimeTable.UseVisualStyleBackColor = true;
            // 
            // listTimeTable
            // 
            this.listTimeTable.FormattingEnabled = true;
            this.listTimeTable.ItemHeight = 16;
            this.listTimeTable.Location = new System.Drawing.Point(21, 116);
            this.listTimeTable.Name = "listTimeTable";
            this.listTimeTable.Size = new System.Drawing.Size(534, 276);
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
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(24, 78);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(103, 22);
            this.dtpDate.TabIndex = 6;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(24, 106);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(103, 22);
            this.dtpTime.TabIndex = 7;
            // 
            // rdBtnDeparture
            // 
            this.rdBtnDeparture.AutoSize = true;
            this.rdBtnDeparture.Checked = true;
            this.rdBtnDeparture.Location = new System.Drawing.Point(142, 81);
            this.rdBtnDeparture.Name = "rdBtnDeparture";
            this.rdBtnDeparture.Size = new System.Drawing.Size(68, 20);
            this.rdBtnDeparture.TabIndex = 8;
            this.rdBtnDeparture.TabStop = true;
            this.rdBtnDeparture.Text = "Abfahrt";
            this.rdBtnDeparture.UseVisualStyleBackColor = true;
            // 
            // rdBtnArrival
            // 
            this.rdBtnArrival.AutoSize = true;
            this.rdBtnArrival.Location = new System.Drawing.Point(142, 106);
            this.rdBtnArrival.Name = "rdBtnArrival";
            this.rdBtnArrival.Size = new System.Drawing.Size(69, 20);
            this.rdBtnArrival.TabIndex = 9;
            this.rdBtnArrival.Text = "Ankunft";
            this.rdBtnArrival.UseVisualStyleBackColor = true;
            // 
            // SwissTransportUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 537);
            this.Controls.Add(this.tabTimeTablePage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SwissTransportUIForm";
            this.Text = "SwissTranport";
            this.Load += new System.EventHandler(this.SwissTransportUIForm_Load);
            this.tabTimeTablePage.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tabConnection.PerformLayout();
            this.tabTimeTable.ResumeLayout(false);
            this.tabTimeTable.PerformLayout();
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
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.TabPage tabTimeTable;
        private System.Windows.Forms.Button btnCreateTimeTable;
        private System.Windows.Forms.TextBox txtStartStation;
        private System.Windows.Forms.Label lblStartStation;
        private System.Windows.Forms.ListBox listTimeTable;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rdBtnArrival;
        private System.Windows.Forms.RadioButton rdBtnDeparture;
    }
}

