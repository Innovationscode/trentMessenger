﻿namespace Trentmessenger.Forms
{
    partial class AccountProfile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountProfile));
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_username = new System.Windows.Forms.Panel();
            this.button_remove = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.pictureBox_photo = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_friendSince = new System.Windows.Forms.Label();
            this.label_friendSinceL = new System.Windows.Forms.Label();
            this.label_messages = new System.Windows.Forms.Label();
            this.label_messagesL = new System.Windows.Forms.Label();
            this.label_lastSeen = new System.Windows.Forms.Label();
            this.label_lastSeenL = new System.Windows.Forms.Label();
            this.richTextBox_about = new System.Windows.Forms.RichTextBox();
            this.label_aboutL = new System.Windows.Forms.Label();
            this.label_numberL = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.toolTip_info = new System.Windows.Forms.ToolTip(this.components);
            this.panel_header.SuspendLayout();
            this.panel_username.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Teal;
            this.panel_header.Controls.Add(this.panel_username);
            this.panel_header.Controls.Add(this.pictureBox_photo);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(476, 263);
            this.panel_header.TabIndex = 6;
            // 
            // panel_username
            // 
            this.panel_username.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel_username.Controls.Add(this.button_remove);
            this.panel_username.Controls.Add(this.label_username);
            this.panel_username.Location = new System.Drawing.Point(0, 197);
            this.panel_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_username.Name = "panel_username";
            this.panel_username.Size = new System.Drawing.Size(476, 51);
            this.panel_username.TabIndex = 4;
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.Purple;
            this.button_remove.BackgroundImage = global::Trentmessenger.Properties.Resources.icon_remove;
            this.button_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_remove.FlatAppearance.BorderSize = 0;
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove.Location = new System.Drawing.Point(92, 5);
            this.button_remove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(45, 42);
            this.button_remove.TabIndex = 4;
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label_username
            // 
            this.label_username.BackColor = System.Drawing.Color.Purple;
            this.label_username.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_username.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(0, 0);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(476, 51);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_photo
            // 
            this.pictureBox_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_photo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_photo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_photo.Image = global::Trentmessenger.Properties.Resources.Pic_Placeholder_Male;
            this.pictureBox_photo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_photo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_photo.Name = "pictureBox_photo";
            this.pictureBox_photo.Size = new System.Drawing.Size(476, 263);
            this.pictureBox_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_photo.TabIndex = 0;
            this.pictureBox_photo.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Purple;
            this.panel_main.Controls.Add(this.label_friendSince);
            this.panel_main.Controls.Add(this.label_friendSinceL);
            this.panel_main.Controls.Add(this.label_messages);
            this.panel_main.Controls.Add(this.label_messagesL);
            this.panel_main.Controls.Add(this.label_lastSeen);
            this.panel_main.Controls.Add(this.label_lastSeenL);
            this.panel_main.Controls.Add(this.richTextBox_about);
            this.panel_main.Controls.Add(this.label_aboutL);
            this.panel_main.Controls.Add(this.label_numberL);
            this.panel_main.Controls.Add(this.label_number);
            this.panel_main.Location = new System.Drawing.Point(0, 275);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(476, 377);
            this.panel_main.TabIndex = 7;
            // 
            // label_friendSince
            // 
            this.label_friendSince.AutoSize = true;
            this.label_friendSince.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_friendSince.ForeColor = System.Drawing.Color.White;
            this.label_friendSince.Location = new System.Drawing.Point(12, 252);
            this.label_friendSince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_friendSince.Name = "label_friendSince";
            this.label_friendSince.Size = new System.Drawing.Size(94, 21);
            this.label_friendSince.TabIndex = 18;
            this.label_friendSince.Text = "xx/xx/xxxx";
            // 
            // label_friendSinceL
            // 
            this.label_friendSinceL.AutoSize = true;
            this.label_friendSinceL.BackColor = System.Drawing.Color.White;
            this.label_friendSinceL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_friendSinceL.Location = new System.Drawing.Point(12, 215);
            this.label_friendSinceL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_friendSinceL.Name = "label_friendSinceL";
            this.label_friendSinceL.Padding = new System.Windows.Forms.Padding(3);
            this.label_friendSinceL.Size = new System.Drawing.Size(98, 30);
            this.label_friendSinceL.TabIndex = 17;
            this.label_friendSinceL.Text = "Add Date";
            // 
            // label_messages
            // 
            this.label_messages.AutoSize = true;
            this.label_messages.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_messages.ForeColor = System.Drawing.Color.White;
            this.label_messages.Location = new System.Drawing.Point(12, 185);
            this.label_messages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_messages.Name = "label_messages";
            this.label_messages.Size = new System.Drawing.Size(114, 21);
            this.label_messages.TabIndex = 16;
            this.label_messages.Text = "x message(s)";
            // 
            // label_messagesL
            // 
            this.label_messagesL.AutoSize = true;
            this.label_messagesL.BackColor = System.Drawing.Color.White;
            this.label_messagesL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_messagesL.Location = new System.Drawing.Point(12, 148);
            this.label_messagesL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_messagesL.Name = "label_messagesL";
            this.label_messagesL.Padding = new System.Windows.Forms.Padding(3);
            this.label_messagesL.Size = new System.Drawing.Size(160, 30);
            this.label_messagesL.TabIndex = 15;
            this.label_messagesL.Text = "Total Messages ";
            // 
            // label_lastSeen
            // 
            this.label_lastSeen.AutoSize = true;
            this.label_lastSeen.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastSeen.ForeColor = System.Drawing.Color.White;
            this.label_lastSeen.Location = new System.Drawing.Point(12, 117);
            this.label_lastSeen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lastSeen.Name = "label_lastSeen";
            this.label_lastSeen.Size = new System.Drawing.Size(46, 21);
            this.label_lastSeen.TabIndex = 14;
            this.label_lastSeen.Text = "Time";
            // 
            // label_lastSeenL
            // 
            this.label_lastSeenL.AutoSize = true;
            this.label_lastSeenL.BackColor = System.Drawing.Color.White;
            this.label_lastSeenL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastSeenL.Location = new System.Drawing.Point(12, 82);
            this.label_lastSeenL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lastSeenL.Name = "label_lastSeenL";
            this.label_lastSeenL.Padding = new System.Windows.Forms.Padding(3);
            this.label_lastSeenL.Size = new System.Drawing.Size(130, 30);
            this.label_lastSeenL.TabIndex = 13;
            this.label_lastSeenL.Text = "Last Seen At";
            // 
            // richTextBox_about
            // 
            this.richTextBox_about.BackColor = System.Drawing.Color.Purple;
            this.richTextBox_about.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_about.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox_about.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_about.ForeColor = System.Drawing.Color.White;
            this.richTextBox_about.Location = new System.Drawing.Point(12, 322);
            this.richTextBox_about.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox_about.Name = "richTextBox_about";
            this.richTextBox_about.ReadOnly = true;
            this.richTextBox_about.Size = new System.Drawing.Size(441, 46);
            this.richTextBox_about.TabIndex = 10;
            this.richTextBox_about.Text = "AboutUser text.";
            // 
            // label_aboutL
            // 
            this.label_aboutL.AutoSize = true;
            this.label_aboutL.BackColor = System.Drawing.Color.White;
            this.label_aboutL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_aboutL.Location = new System.Drawing.Point(12, 286);
            this.label_aboutL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_aboutL.Name = "label_aboutL";
            this.label_aboutL.Padding = new System.Windows.Forms.Padding(3);
            this.label_aboutL.Size = new System.Drawing.Size(112, 30);
            this.label_aboutL.TabIndex = 12;
            this.label_aboutL.Text = "AboutUser";
            // 
            // label_numberL
            // 
            this.label_numberL.AutoSize = true;
            this.label_numberL.BackColor = System.Drawing.Color.White;
            this.label_numberL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numberL.Location = new System.Drawing.Point(12, 12);
            this.label_numberL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_numberL.Name = "label_numberL";
            this.label_numberL.Padding = new System.Windows.Forms.Padding(3);
            this.label_numberL.Size = new System.Drawing.Size(150, 30);
            this.label_numberL.TabIndex = 11;
            this.label_numberL.Text = "Phone Number";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_number.ForeColor = System.Drawing.Color.White;
            this.label_number.Location = new System.Drawing.Point(12, 49);
            this.label_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(123, 21);
            this.label_number.TabIndex = 6;
            this.label_number.Text = "Phone Number";
            // 
            // toolTip_info
            // 
            this.toolTip_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // AccountProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trentmessenger.Properties.Resources.background_159244_12801;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 652);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Someone\'s account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountProfile_FormClosed);
            this.panel_header.ResumeLayout(false);
            this.panel_username.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_photo)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.PictureBox pictureBox_photo;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Label label_numberL;
        private System.Windows.Forms.Label label_aboutL;
        private System.Windows.Forms.Label label_lastSeenL;
        private System.Windows.Forms.RichTextBox richTextBox_about;
        private System.Windows.Forms.Label label_lastSeen;
        private System.Windows.Forms.Label label_messages;
        private System.Windows.Forms.Label label_messagesL;
        private System.Windows.Forms.Panel panel_username;
        private System.Windows.Forms.Label label_friendSince;
        private System.Windows.Forms.Label label_friendSinceL;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ToolTip toolTip_info;
    }
}