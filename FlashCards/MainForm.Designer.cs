﻿namespace FlashCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lstTopics = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenFlashCards = new System.Windows.Forms.Button();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.btnEditTopic = new System.Windows.Forms.Button();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.btnDeleteTopic = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.flashCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTopics
            // 
            this.lstTopics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.items});
            this.lstTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstTopics.FullRowSelect = true;
            this.lstTopics.Location = new System.Drawing.Point(12, 38);
            this.lstTopics.MultiSelect = false;
            this.lstTopics.Name = "lstTopics";
            this.lstTopics.Size = new System.Drawing.Size(528, 225);
            this.lstTopics.TabIndex = 0;
            this.lstTopics.UseCompatibleStateImageBehavior = false;
            this.lstTopics.View = System.Windows.Forms.View.Details;
            this.lstTopics.SelectedIndexChanged += new System.EventHandler(this.lstTopics_SelectedIndexChanged);
            this.lstTopics.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTopics_MouseDoubleClick);
            // 
            // name
            // 
            this.name.Text = "Topic";
            this.name.Width = 362;
            // 
            // items
            // 
            this.items.Text = "Number of Cards";
            this.items.Width = 131;
            // 
            // btnOpenFlashCards
            // 
            this.btnOpenFlashCards.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFlashCards.BackgroundImage")));
            this.btnOpenFlashCards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenFlashCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFlashCards.Location = new System.Drawing.Point(439, 269);
            this.btnOpenFlashCards.Name = "btnOpenFlashCards";
            this.btnOpenFlashCards.Size = new System.Drawing.Size(101, 31);
            this.btnOpenFlashCards.TabIndex = 1;
            this.btnOpenFlashCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFlashCards.UseVisualStyleBackColor = true;
            this.btnOpenFlashCards.Click += new System.EventHandler(this.btnOpenFlashCards_Click);
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRandom.Location = new System.Drawing.Point(335, 275);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(80, 21);
            this.chkRandom.TabIndex = 5;
            this.chkRandom.Text = "Random";
            this.chkRandom.UseVisualStyleBackColor = true;
            // 
            // btnEditTopic
            // 
            this.btnEditTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTopic.Location = new System.Drawing.Point(220, 269);
            this.btnEditTopic.Name = "btnEditTopic";
            this.btnEditTopic.Size = new System.Drawing.Size(98, 31);
            this.btnEditTopic.TabIndex = 6;
            this.btnEditTopic.Text = "Edit Topic";
            this.btnEditTopic.UseVisualStyleBackColor = true;
            this.btnEditTopic.Click += new System.EventHandler(this.btnEditTopic_Click);
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTopic.Location = new System.Drawing.Point(12, 269);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(98, 31);
            this.btnAddTopic.TabIndex = 7;
            this.btnAddTopic.Text = "Add Topic";
            this.btnAddTopic.UseVisualStyleBackColor = true;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // btnDeleteTopic
            // 
            this.btnDeleteTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTopic.Location = new System.Drawing.Point(116, 269);
            this.btnDeleteTopic.Name = "btnDeleteTopic";
            this.btnDeleteTopic.Size = new System.Drawing.Size(98, 31);
            this.btnDeleteTopic.TabIndex = 8;
            this.btnDeleteTopic.Text = "Delete Topic";
            this.btnDeleteTopic.UseVisualStyleBackColor = true;
            this.btnDeleteTopic.Click += new System.EventHandler(this.btnDeleteTopic_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flashCardToolStripMenuItem,
            this.mnuAbout});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(553, 24);
            this.mnuMain.TabIndex = 9;
            this.mnuMain.Text = "menuStrip1";
            // 
            // flashCardToolStripMenuItem
            // 
            this.flashCardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearch});
            this.flashCardToolStripMenuItem.Name = "flashCardToolStripMenuItem";
            this.flashCardToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.flashCardToolStripMenuItem.Text = "&Flash Cards";
            // 
            // mnuSearch
            // 
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuSearch.Size = new System.Drawing.Size(180, 22);
            this.mnuSearch.Text = "&Search...";
            this.mnuSearch.Click += new System.EventHandler(this.mnuSearch_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(52, 20);
            this.mnuAbout.Text = "&About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 316);
            this.Controls.Add(this.btnDeleteTopic);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.btnOpenFlashCards);
            this.Controls.Add(this.btnAddTopic);
            this.Controls.Add(this.lstTopics);
            this.Controls.Add(this.btnEditTopic);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Cards - Make learning easy!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTopics;
        private System.Windows.Forms.Button btnOpenFlashCards;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader items;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.Button btnEditTopic;
        private System.Windows.Forms.Button btnDeleteTopic;
        private System.Windows.Forms.Button btnAddTopic;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem flashCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    }
}

