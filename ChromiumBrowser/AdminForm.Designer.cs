
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
            this.searchUserTextBox = new System.Windows.Forms.RichTextBox();
            this.searchUserButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchUserLabel = new System.Windows.Forms.Label();
            this.wordShtTextArea = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchWordLabel = new System.Windows.Forms.Label();
            this.searchWordButton = new System.Windows.Forms.Button();
            this.wordSearchTextBox = new System.Windows.Forms.RichTextBox();
            this.wordStatusComboBox = new System.Windows.Forms.ComboBox();
            this.addWordLabel = new System.Windows.Forms.Label();
            this.wordAddTextBox = new System.Windows.Forms.RichTextBox();
            this.removeWebsiteLabel = new System.Windows.Forms.Label();
            this.removeWebsiteTextBox = new System.Windows.Forms.RichTextBox();
            this.removeFromSiteShtButton = new System.Windows.Forms.Button();
            this.userStatusTextBox = new System.Windows.Forms.RichTextBox();
            this.websiteStatusLabel = new System.Windows.Forms.Label();
            this.websiteStatusTextBox = new System.Windows.Forms.RichTextBox();
            this.userStatusLabel = new System.Windows.Forms.Label();
            this.wordStatusLabel = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Label();
            this.addWordButton = new System.Windows.Forms.Button();
            this.removeWordButton = new System.Windows.Forms.Button();
            this.removeWordTextBox = new System.Windows.Forms.RichTextBox();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.removeUserTextBox = new System.Windows.Forms.RichTextBox();
            this.removeUserLabel = new System.Windows.Forms.Label();
            this.wordStatusTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // sendToSitesShtButton
            // 
            this.sendToSitesShtButton.Location = new System.Drawing.Point(701, 82);
            this.sendToSitesShtButton.Name = "sendToSitesShtButton";
            this.sendToSitesShtButton.Size = new System.Drawing.Size(124, 21);
            this.sendToSitesShtButton.TabIndex = 0;
            this.sendToSitesShtButton.Text = "Add to Database";
            this.sendToSitesShtButton.UseVisualStyleBackColor = true;
            this.sendToSitesShtButton.Click += new System.EventHandler(this.addWebsite_Click);
            // 
            // siteShtTextArea
            // 
            this.siteShtTextArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.siteShtTextArea.Location = new System.Drawing.Point(12, 36);
            this.siteShtTextArea.Name = "siteShtTextArea";
            this.siteShtTextArea.ReadOnly = true;
            this.siteShtTextArea.Size = new System.Drawing.Size(492, 241);
            this.siteShtTextArea.TabIndex = 1;
            this.siteShtTextArea.Text = "";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(510, 53);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(315, 21);
            this.urlTextBox.TabIndex = 4;
            this.urlTextBox.Text = "Type a URL";
            this.urlTextBox.Enter += new System.EventHandler(this.urlTextBox_Enter);
            // 
            // addWebsiteLabel
            // 
            this.addWebsiteLabel.AutoSize = true;
            this.addWebsiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWebsiteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addWebsiteLabel.Location = new System.Drawing.Point(507, 37);
            this.addWebsiteLabel.Name = "addWebsiteLabel";
            this.addWebsiteLabel.Size = new System.Drawing.Size(167, 13);
            this.addWebsiteLabel.TabIndex = 5;
            this.addWebsiteLabel.Text = "Add a Website to Database:";
            // 
            // addStatusLabel
            // 
            this.addStatusLabel.AutoSize = true;
            this.addStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStatusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addStatusLabel.Location = new System.Drawing.Point(508, 85);
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
            this.statusComboBox.Location = new System.Drawing.Point(597, 82);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(98, 21);
            this.statusComboBox.TabIndex = 7;
            this.statusComboBox.Text = "Choose one";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Eurostile Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "USER DATABASE";
            // 
            // userShtTextArea
            // 
            this.userShtTextArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userShtTextArea.Location = new System.Drawing.Point(12, 307);
            this.userShtTextArea.Name = "userShtTextArea";
            this.userShtTextArea.ReadOnly = true;
            this.userShtTextArea.Size = new System.Drawing.Size(492, 241);
            this.userShtTextArea.TabIndex = 9;
            this.userShtTextArea.Text = "";
            // 
            // searchUserTextBox
            // 
            this.searchUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchUserTextBox.Location = new System.Drawing.Point(515, 322);
            this.searchUserTextBox.Name = "searchUserTextBox";
            this.searchUserTextBox.Size = new System.Drawing.Size(207, 21);
            this.searchUserTextBox.TabIndex = 15;
            this.searchUserTextBox.Text = "Enter IP Address OR User ID";
            this.searchUserTextBox.Enter += new System.EventHandler(this.ipAddressTextBox_Enter);
            // 
            // searchUserButton
            // 
            this.searchUserButton.Location = new System.Drawing.Point(728, 321);
            this.searchUserButton.Name = "searchUserButton";
            this.searchUserButton.Size = new System.Drawing.Size(96, 22);
            this.searchUserButton.TabIndex = 18;
            this.searchUserButton.Text = "Search";
            this.searchUserButton.UseVisualStyleBackColor = true;
            this.searchUserButton.Click += new System.EventHandler(this.searchUserButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InfoText;
            this.label4.Font = new System.Drawing.Font("Eurostile Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "WEBSITE DATABASE";
            // 
            // searchUserLabel
            // 
            this.searchUserLabel.AutoSize = true;
            this.searchUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchUserLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchUserLabel.Location = new System.Drawing.Point(510, 306);
            this.searchUserLabel.Name = "searchUserLabel";
            this.searchUserLabel.Size = new System.Drawing.Size(135, 13);
            this.searchUserLabel.TabIndex = 21;
            this.searchUserLabel.Text = "Search User Database";
            // 
            // wordShtTextArea
            // 
            this.wordShtTextArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordShtTextArea.Location = new System.Drawing.Point(12, 581);
            this.wordShtTextArea.Name = "wordShtTextArea";
            this.wordShtTextArea.ReadOnly = true;
            this.wordShtTextArea.Size = new System.Drawing.Size(492, 241);
            this.wordShtTextArea.TabIndex = 22;
            this.wordShtTextArea.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.WindowText;
            this.label6.Font = new System.Drawing.Font("Eurostile Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "WORD DATABASE";
            // 
            // searchWordLabel
            // 
            this.searchWordLabel.AutoSize = true;
            this.searchWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchWordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchWordLabel.Location = new System.Drawing.Point(512, 583);
            this.searchWordLabel.Name = "searchWordLabel";
            this.searchWordLabel.Size = new System.Drawing.Size(139, 13);
            this.searchWordLabel.TabIndex = 45;
            this.searchWordLabel.Text = "Search Word Database";
            // 
            // searchWordButton
            // 
            this.searchWordButton.Location = new System.Drawing.Point(726, 598);
            this.searchWordButton.Name = "searchWordButton";
            this.searchWordButton.Size = new System.Drawing.Size(98, 21);
            this.searchWordButton.TabIndex = 44;
            this.searchWordButton.Text = "Search for Word";
            this.searchWordButton.UseVisualStyleBackColor = true;
            this.searchWordButton.Click += new System.EventHandler(this.wordSearchButton_Click);
            // 
            // wordSearchTextBox
            // 
            this.wordSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordSearchTextBox.Location = new System.Drawing.Point(513, 599);
            this.wordSearchTextBox.Name = "wordSearchTextBox";
            this.wordSearchTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.wordSearchTextBox.Size = new System.Drawing.Size(207, 21);
            this.wordSearchTextBox.TabIndex = 41;
            this.wordSearchTextBox.Text = "Enter Word";
            this.wordSearchTextBox.Enter += new System.EventHandler(this.wordSearchTextBox_Enter);
            // 
            // wordStatusComboBox
            // 
            this.wordStatusComboBox.FormattingEnabled = true;
            this.wordStatusComboBox.Items.AddRange(new object[] {
            "Whitelisted",
            "Blacklisted"});
            this.wordStatusComboBox.Location = new System.Drawing.Point(726, 655);
            this.wordStatusComboBox.Name = "wordStatusComboBox";
            this.wordStatusComboBox.Size = new System.Drawing.Size(98, 21);
            this.wordStatusComboBox.TabIndex = 53;
            this.wordStatusComboBox.Text = "Choose one";
            // 
            // addWordLabel
            // 
            this.addWordLabel.AutoSize = true;
            this.addWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addWordLabel.Location = new System.Drawing.Point(512, 639);
            this.addWordLabel.Name = "addWordLabel";
            this.addWordLabel.Size = new System.Drawing.Size(147, 13);
            this.addWordLabel.TabIndex = 54;
            this.addWordLabel.Text = "Add a Word to Database";
            // 
            // wordAddTextBox
            // 
            this.wordAddTextBox.Location = new System.Drawing.Point(513, 655);
            this.wordAddTextBox.Name = "wordAddTextBox";
            this.wordAddTextBox.Size = new System.Drawing.Size(207, 21);
            this.wordAddTextBox.TabIndex = 55;
            this.wordAddTextBox.Text = "Enter Word";
            this.wordAddTextBox.Enter += new System.EventHandler(this.wordAddTextBox_Enter);
            // 
            // removeWebsiteLabel
            // 
            this.removeWebsiteLabel.AutoSize = true;
            this.removeWebsiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeWebsiteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.removeWebsiteLabel.Location = new System.Drawing.Point(507, 120);
            this.removeWebsiteLabel.Name = "removeWebsiteLabel";
            this.removeWebsiteLabel.Size = new System.Drawing.Size(204, 13);
            this.removeWebsiteLabel.TabIndex = 58;
            this.removeWebsiteLabel.Text = "Remove a Website from Database:";
            // 
            // removeWebsiteTextBox
            // 
            this.removeWebsiteTextBox.Location = new System.Drawing.Point(510, 136);
            this.removeWebsiteTextBox.Name = "removeWebsiteTextBox";
            this.removeWebsiteTextBox.Size = new System.Drawing.Size(164, 21);
            this.removeWebsiteTextBox.TabIndex = 57;
            this.removeWebsiteTextBox.Text = "Enter Website ID";
            this.removeWebsiteTextBox.Enter += new System.EventHandler(this.removeWebsiteTextBox_Enter);
            // 
            // removeFromSiteShtButton
            // 
            this.removeFromSiteShtButton.Location = new System.Drawing.Point(680, 136);
            this.removeFromSiteShtButton.Name = "removeFromSiteShtButton";
            this.removeFromSiteShtButton.Size = new System.Drawing.Size(145, 21);
            this.removeFromSiteShtButton.TabIndex = 56;
            this.removeFromSiteShtButton.Text = "Remove from Database";
            this.removeFromSiteShtButton.UseVisualStyleBackColor = true;
            // 
            // userStatusTextBox
            // 
            this.userStatusTextBox.BackColor = System.Drawing.Color.Silver;
            this.userStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userStatusTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.userStatusTextBox.Location = new System.Drawing.Point(834, 321);
            this.userStatusTextBox.Name = "userStatusTextBox";
            this.userStatusTextBox.Size = new System.Drawing.Size(240, 227);
            this.userStatusTextBox.TabIndex = 59;
            this.userStatusTextBox.Text = "";
            // 
            // websiteStatusLabel
            // 
            this.websiteStatusLabel.AutoSize = true;
            this.websiteStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.websiteStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.websiteStatusLabel.Location = new System.Drawing.Point(832, 37);
            this.websiteStatusLabel.Name = "websiteStatusLabel";
            this.websiteStatusLabel.Size = new System.Drawing.Size(171, 13);
            this.websiteStatusLabel.TabIndex = 62;
            this.websiteStatusLabel.Text = "Add/Remove Website Status";
            // 
            // websiteStatusTextBox
            // 
            this.websiteStatusTextBox.BackColor = System.Drawing.Color.Silver;
            this.websiteStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.websiteStatusTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.websiteStatusTextBox.Location = new System.Drawing.Point(834, 53);
            this.websiteStatusTextBox.Name = "websiteStatusTextBox";
            this.websiteStatusTextBox.Size = new System.Drawing.Size(240, 224);
            this.websiteStatusTextBox.TabIndex = 61;
            this.websiteStatusTextBox.Text = "";
            // 
            // userStatusLabel
            // 
            this.userStatusLabel.AutoSize = true;
            this.userStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.userStatusLabel.Location = new System.Drawing.Point(831, 306);
            this.userStatusLabel.Name = "userStatusLabel";
            this.userStatusLabel.Size = new System.Drawing.Size(151, 13);
            this.userStatusLabel.TabIndex = 63;
            this.userStatusLabel.Text = "Add/Remove User Status";
            // 
            // wordStatusLabel
            // 
            this.wordStatusLabel.AutoSize = true;
            this.wordStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.wordStatusLabel.Location = new System.Drawing.Point(832, 582);
            this.wordStatusLabel.Name = "wordStatusLabel";
            this.wordStatusLabel.Size = new System.Drawing.Size(201, 13);
            this.wordStatusLabel.TabIndex = 65;
            this.wordStatusLabel.Text = "Search/Add/Remove Word Status";
            // 
            // remove
            // 
            this.remove.AutoSize = true;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.remove.Location = new System.Drawing.Point(510, 721);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(184, 13);
            this.remove.TabIndex = 67;
            this.remove.Text = "Remove a Word from Database";
            // 
            // addWordButton
            // 
            this.addWordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addWordButton.Location = new System.Drawing.Point(726, 682);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(98, 22);
            this.addWordButton.TabIndex = 69;
            this.addWordButton.Text = "Add Word";
            this.addWordButton.UseVisualStyleBackColor = true;
            // 
            // removeWordButton
            // 
            this.removeWordButton.Location = new System.Drawing.Point(726, 739);
            this.removeWordButton.Name = "removeWordButton";
            this.removeWordButton.Size = new System.Drawing.Size(98, 21);
            this.removeWordButton.TabIndex = 71;
            this.removeWordButton.Text = "Remove Word";
            this.removeWordButton.UseVisualStyleBackColor = true;
            // 
            // removeWordTextBox
            // 
            this.removeWordTextBox.Location = new System.Drawing.Point(513, 739);
            this.removeWordTextBox.Name = "removeWordTextBox";
            this.removeWordTextBox.Size = new System.Drawing.Size(207, 21);
            this.removeWordTextBox.TabIndex = 70;
            this.removeWordTextBox.Text = "Enter Word";
            this.removeWordTextBox.Enter += new System.EventHandler(this.removeWordTextBox_Enter);
            // 
            // removeUserButton
            // 
            this.removeUserButton.Location = new System.Drawing.Point(728, 376);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(98, 21);
            this.removeUserButton.TabIndex = 74;
            this.removeUserButton.Text = "Remove";
            this.removeUserButton.UseVisualStyleBackColor = true;
            // 
            // removeUserTextBox
            // 
            this.removeUserTextBox.Location = new System.Drawing.Point(515, 376);
            this.removeUserTextBox.Name = "removeUserTextBox";
            this.removeUserTextBox.Size = new System.Drawing.Size(207, 21);
            this.removeUserTextBox.TabIndex = 73;
            this.removeUserTextBox.Text = "Enter User ID";
            this.removeUserTextBox.Enter += new System.EventHandler(this.removeUserTextBox_Enter);
            // 
            // removeUserLabel
            // 
            this.removeUserLabel.AutoSize = true;
            this.removeUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUserLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.removeUserLabel.Location = new System.Drawing.Point(512, 358);
            this.removeUserLabel.Name = "removeUserLabel";
            this.removeUserLabel.Size = new System.Drawing.Size(180, 13);
            this.removeUserLabel.TabIndex = 72;
            this.removeUserLabel.Text = "Remove a User from Database";
            // 
            // wordStatusTextBox
            // 
            this.wordStatusTextBox.BackColor = System.Drawing.Color.Silver;
            this.wordStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordStatusTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.wordStatusTextBox.Location = new System.Drawing.Point(834, 598);
            this.wordStatusTextBox.Name = "wordStatusTextBox";
            this.wordStatusTextBox.Size = new System.Drawing.Size(240, 224);
            this.wordStatusTextBox.TabIndex = 64;
            this.wordStatusTextBox.Text = "";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1083, 834);
            this.Controls.Add(this.removeUserButton);
            this.Controls.Add(this.removeUserTextBox);
            this.Controls.Add(this.removeUserLabel);
            this.Controls.Add(this.removeWordButton);
            this.Controls.Add(this.removeWordTextBox);
            this.Controls.Add(this.addWordButton);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.wordStatusLabel);
            this.Controls.Add(this.wordStatusTextBox);
            this.Controls.Add(this.userStatusLabel);
            this.Controls.Add(this.websiteStatusLabel);
            this.Controls.Add(this.websiteStatusTextBox);
            this.Controls.Add(this.userStatusTextBox);
            this.Controls.Add(this.removeWebsiteLabel);
            this.Controls.Add(this.removeWebsiteTextBox);
            this.Controls.Add(this.removeFromSiteShtButton);
            this.Controls.Add(this.wordAddTextBox);
            this.Controls.Add(this.addWordLabel);
            this.Controls.Add(this.wordStatusComboBox);
            this.Controls.Add(this.searchWordLabel);
            this.Controls.Add(this.searchWordButton);
            this.Controls.Add(this.wordSearchTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wordShtTextArea);
            this.Controls.Add(this.searchUserLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchUserButton);
            this.Controls.Add(this.searchUserTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userShtTextArea);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.addStatusLabel);
            this.Controls.Add(this.addWebsiteLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.siteShtTextArea);
            this.Controls.Add(this.sendToSitesShtButton);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration Database";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AdminForm_Load);
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
        private System.Windows.Forms.RichTextBox searchUserTextBox;
        private System.Windows.Forms.Button searchUserButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label searchUserLabel;
        private System.Windows.Forms.RichTextBox wordShtTextArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label searchWordLabel;
        private System.Windows.Forms.Button searchWordButton;
        private System.Windows.Forms.RichTextBox wordSearchTextBox;
        private System.Windows.Forms.ComboBox wordStatusComboBox;
        private System.Windows.Forms.Label addWordLabel;
        private System.Windows.Forms.RichTextBox wordAddTextBox;
        private System.Windows.Forms.Label removeWebsiteLabel;
        private System.Windows.Forms.RichTextBox removeWebsiteTextBox;
        private System.Windows.Forms.Button removeFromSiteShtButton;
        private System.Windows.Forms.RichTextBox userStatusTextBox;
        private System.Windows.Forms.Label websiteStatusLabel;
        private System.Windows.Forms.RichTextBox websiteStatusTextBox;
        private System.Windows.Forms.Label userStatusLabel;
        private System.Windows.Forms.Label wordStatusLabel;
        private System.Windows.Forms.Label remove;
        private System.Windows.Forms.Button addWordButton;
        private System.Windows.Forms.Button removeWordButton;
        private System.Windows.Forms.RichTextBox removeWordTextBox;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.RichTextBox removeUserTextBox;
        private System.Windows.Forms.Label removeUserLabel;
        private System.Windows.Forms.RichTextBox wordStatusTextBox;
    }
}