
namespace SqlViewer
{
    partial class MainForm
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
            this.TbQuery = new System.Windows.Forms.TextBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.FlpQueryTables = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlMessages = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.PnlMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbQuery
            // 
            this.TbQuery.Location = new System.Drawing.Point(19, 42);
            this.TbQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbQuery.Multiline = true;
            this.TbQuery.Name = "TbQuery";
            this.TbQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbQuery.Size = new System.Drawing.Size(1404, 294);
            this.TbQuery.TabIndex = 18;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Location = new System.Drawing.Point(317, 9);
            this.BtnExecute.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(100, 28);
            this.BtnExecute.TabIndex = 23;
            this.BtnExecute.Text = "Execute";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // FlpQueryTables
            // 
            this.FlpQueryTables.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FlpQueryTables.AutoScroll = true;
            this.FlpQueryTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlpQueryTables.Location = new System.Drawing.Point(19, 354);
            this.FlpQueryTables.Margin = new System.Windows.Forms.Padding(4);
            this.FlpQueryTables.Name = "FlpQueryTables";
            this.FlpQueryTables.Size = new System.Drawing.Size(1054, 345);
            this.FlpQueryTables.TabIndex = 26;
            // 
            // PnlMessages
            // 
            this.PnlMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlMessages.Controls.Add(this.lblMsg);
            this.PnlMessages.Location = new System.Drawing.Point(1103, 354);
            this.PnlMessages.Margin = new System.Windows.Forms.Padding(4);
            this.PnlMessages.Name = "PnlMessages";
            this.PnlMessages.Size = new System.Drawing.Size(319, 345);
            this.PnlMessages.TabIndex = 27;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(18, 20);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(12, 17);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases";
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(116, 11);
            this.CbDatabases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(177, 24);
            this.CbDatabases.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 715);
            this.Controls.Add(this.PnlMessages);
            this.Controls.Add(this.FlpQueryTables);
            this.Controls.Add(this.BtnExecute);
            this.Controls.Add(this.TbQuery);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Main form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.PnlMessages.ResumeLayout(false);
            this.PnlMessages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbQuery;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.FlowLayoutPanel FlpQueryTables;
        private System.Windows.Forms.Panel PnlMessages;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDatabases;
    }
}

