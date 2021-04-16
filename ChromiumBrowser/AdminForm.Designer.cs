
namespace ChromiumBrowser
{
    partial class AdminForm
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
            this.sendToSitesShtButton = new System.Windows.Forms.Button();
            this.siteShtTextArea = new System.Windows.Forms.RichTextBox();
            this.urlTextBox = new System.Windows.Forms.RichTextBox();
            this.addWebsiteLabel = new System.Windows.Forms.Label();
            this.addStatusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userShtTextArea = new System.Windows.Forms.RichTextBox();
            this.ipAddressTextBox = new System.Windows.Forms.RichTextBox();
            this.idTextBox = new System.Windows.Forms.RichTextBox();
            this.searchIDButton = new System.Windows.Forms.Button();
            this.searchIPButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchUserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendToSitesShtButton
            // 
            this.sendToSitesShtButton.Location = new System.Drawing.Point(941, 286);
            this.sendToSitesShtButton.Name = "sendToSitesShtButton";
            this.sendToSitesShtButton.Size = new System.Drawing.Size(134, 28);
            this.sendToSitesShtButton.TabIndex = 0;
            this.sendToSitesShtButton.Text = "Add To Database";
            this.sendToSitesShtButton.UseVisualStyleBackColor = true;
            this.sendToSitesShtButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // siteShtTextArea
            // 
            this.siteShtTextArea.Location = new System.Drawing.Point(12, 36);
            this.siteShtTextArea.Name = "siteShtTextArea";
            this.siteShtTextArea.ReadOnly = true;
            this.siteShtTextArea.Size = new System.Drawing.Size(1063, 244);
            this.siteShtTextArea.TabIndex = 1;
            this.siteShtTextArea.Text = "";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(117, 291);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(540, 21);
            this.urlTextBox.TabIndex = 4;
            this.urlTextBox.Text = "";
            // 
            // addWebsiteLabel
            // 
            this.addWebsiteLabel.AutoSize = true;
            this.addWebsiteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addWebsiteLabel.Location = new System.Drawing.Point(12, 294);
            this.addWebsiteLabel.Name = "addWebsiteLabel";
            this.addWebsiteLabel.Size = new System.Drawing.Size(102, 13);
            this.addWebsiteLabel.TabIndex = 5;
            this.addWebsiteLabel.Text = "Enter Website URL:";
            this.addWebsiteLabel.Click += new System.EventHandler(this.addWebsiteLabel_Click);
            // 
            // addStatusLabel
            // 
            this.addStatusLabel.AutoSize = true;
            this.addStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addStatusLabel.Location = new System.Drawing.Point(673, 294);
            this.addStatusLabel.Name = "addStatusLabel";
            this.addStatusLabel.Size = new System.Drawing.Size(73, 13);
            this.addStatusLabel.TabIndex = 6;
            this.addStatusLabel.Text = "Select Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Allowed",
            "Banned",
            "Blacklisted",
            "Whitelisted"});
            this.statusComboBox.Location = new System.Drawing.Point(749, 291);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(186, 21);
            this.statusComboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Eurostile Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(8, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "USER DATABASE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // userShtTextArea
            // 
            this.userShtTextArea.Location = new System.Drawing.Point(15, 362);
            this.userShtTextArea.Name = "userShtTextArea";
            this.userShtTextArea.ReadOnly = true;
            this.userShtTextArea.Size = new System.Drawing.Size(734, 241);
            this.userShtTextArea.TabIndex = 9;
            this.userShtTextArea.Text = "";
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(778, 378);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(286, 21);
            this.ipAddressTextBox.TabIndex = 15;
            this.ipAddressTextBox.Text = "Enter IP Address";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(778, 460);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(286, 21);
            this.idTextBox.TabIndex = 16;
            this.idTextBox.Text = "Enter User ID";
            this.idTextBox.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // searchIDButton
            // 
            this.searchIDButton.Location = new System.Drawing.Point(778, 487);
            this.searchIDButton.Name = "searchIDButton";
            this.searchIDButton.Size = new System.Drawing.Size(286, 23);
            this.searchIDButton.TabIndex = 17;
            this.searchIDButton.Text = "Search by User ID";
            this.searchIDButton.UseVisualStyleBackColor = true;
            // 
            // searchIPButton
            // 
            this.searchIPButton.Location = new System.Drawing.Point(778, 405);
            this.searchIPButton.Name = "searchIPButton";
            this.searchIPButton.Size = new System.Drawing.Size(286, 21);
            this.searchIPButton.TabIndex = 18;
            this.searchIPButton.Text = "Search by IP";
            this.searchIPButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InfoText;
            this.label4.Font = new System.Drawing.Font("Eurostile Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "WEBSITE DATABASE";
            // 
            // searchUserLabel
            // 
            this.searchUserLabel.AutoSize = true;
            this.searchUserLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchUserLabel.Location = new System.Drawing.Point(775, 362);
            this.searchUserLabel.Name = "searchUserLabel";
            this.searchUserLabel.Size = new System.Drawing.Size(115, 13);
            this.searchUserLabel.TabIndex = 21;
            this.searchUserLabel.Text = "Search User Database";
            this.searchUserLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1087, 622);
            this.Controls.Add(this.searchUserLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchIPButton);
            this.Controls.Add(this.searchIDButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userShtTextArea);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.addStatusLabel);
            this.Controls.Add(this.addWebsiteLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.siteShtTextArea);
            this.Controls.Add(this.sendToSitesShtButton);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administration Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendToSitesShtButton;
        private System.Windows.Forms.RichTextBox siteShtTextArea;
        private System.Windows.Forms.RichTextBox urlTextBox;
        private System.Windows.Forms.Label addWebsiteLabel;
        private System.Windows.Forms.Label addStatusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox userShtTextArea;
        private System.Windows.Forms.RichTextBox ipAddressTextBox;
        private System.Windows.Forms.RichTextBox idTextBox;
        private System.Windows.Forms.Button searchIDButton;
        private System.Windows.Forms.Button searchIPButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label searchUserLabel;
    }
}