namespace Moonbase
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.GRBXLocationInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LBLRoomDesc = new System.Windows.Forms.Label();
            this.TXBXRoomDesc = new System.Windows.Forms.TextBox();
            this.TBRoomName = new System.Windows.Forms.TextBox();
            this.personalNav = new System.Windows.Forms.GroupBox();
            this.LobbyBTN = new System.Windows.Forms.Button();
            this.medBayBTN = new System.Windows.Forms.Button();
            this.commandCenterBTN = new System.Windows.Forms.Button();
            this.livingQtBTN = new System.Windows.Forms.Button();
            this.labBTN = new System.Windows.Forms.Button();
            this.GRBXLocationInfo.SuspendLayout();
            this.personalNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRBXLocationInfo
            // 
            this.GRBXLocationInfo.BackColor = System.Drawing.Color.Transparent;
            this.GRBXLocationInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GRBXLocationInfo.Controls.Add(this.label1);
            this.GRBXLocationInfo.Controls.Add(this.LBLRoomDesc);
            this.GRBXLocationInfo.Controls.Add(this.TXBXRoomDesc);
            this.GRBXLocationInfo.Controls.Add(this.TBRoomName);
            this.GRBXLocationInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRBXLocationInfo.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.GRBXLocationInfo.Location = new System.Drawing.Point(22, 23);
            this.GRBXLocationInfo.Margin = new System.Windows.Forms.Padding(4);
            this.GRBXLocationInfo.Name = "GRBXLocationInfo";
            this.GRBXLocationInfo.Padding = new System.Windows.Forms.Padding(4);
            this.GRBXLocationInfo.Size = new System.Drawing.Size(664, 829);
            this.GRBXLocationInfo.TabIndex = 0;
            this.GRBXLocationInfo.TabStop = false;
            this.GRBXLocationInfo.Text = "Location Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Name";
            // 
            // LBLRoomDesc
            // 
            this.LBLRoomDesc.AutoSize = true;
            this.LBLRoomDesc.BackColor = System.Drawing.Color.Silver;
            this.LBLRoomDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRoomDesc.ForeColor = System.Drawing.Color.Black;
            this.LBLRoomDesc.Location = new System.Drawing.Point(24, 292);
            this.LBLRoomDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLRoomDesc.Name = "LBLRoomDesc";
            this.LBLRoomDesc.Size = new System.Drawing.Size(406, 55);
            this.LBLRoomDesc.TabIndex = 2;
            this.LBLRoomDesc.Text = "Room Description";
            this.LBLRoomDesc.Click += new System.EventHandler(this.label2_Click);
            // 
            // TXBXRoomDesc
            // 
            this.TXBXRoomDesc.BackColor = System.Drawing.Color.Silver;
            this.TXBXRoomDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXBXRoomDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXBXRoomDesc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TXBXRoomDesc.Location = new System.Drawing.Point(24, 340);
            this.TXBXRoomDesc.Margin = new System.Windows.Forms.Padding(4);
            this.TXBXRoomDesc.Multiline = true;
            this.TXBXRoomDesc.Name = "TXBXRoomDesc";
            this.TXBXRoomDesc.ReadOnly = true;
            this.TXBXRoomDesc.Size = new System.Drawing.Size(612, 463);
            this.TXBXRoomDesc.TabIndex = 3;
            // 
            // TBRoomName
            // 
            this.TBRoomName.BackColor = System.Drawing.Color.Silver;
            this.TBRoomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBRoomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRoomName.Location = new System.Drawing.Point(24, 162);
            this.TBRoomName.Margin = new System.Windows.Forms.Padding(4);
            this.TBRoomName.Name = "TBRoomName";
            this.TBRoomName.ReadOnly = true;
            this.TBRoomName.Size = new System.Drawing.Size(600, 37);
            this.TBRoomName.TabIndex = 1;
            this.TBRoomName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBRoomName.TextChanged += new System.EventHandler(this.TBRoomName_TextChanged);
            // 
            // personalNav
            // 
            this.personalNav.BackColor = System.Drawing.Color.Transparent;
            this.personalNav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personalNav.Controls.Add(this.LobbyBTN);
            this.personalNav.Controls.Add(this.medBayBTN);
            this.personalNav.Controls.Add(this.commandCenterBTN);
            this.personalNav.Controls.Add(this.livingQtBTN);
            this.personalNav.Controls.Add(this.labBTN);
            this.personalNav.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalNav.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.personalNav.Location = new System.Drawing.Point(834, 51);
            this.personalNav.Margin = new System.Windows.Forms.Padding(6);
            this.personalNav.Name = "personalNav";
            this.personalNav.Padding = new System.Windows.Forms.Padding(6);
            this.personalNav.Size = new System.Drawing.Size(743, 815);
            this.personalNav.TabIndex = 1;
            this.personalNav.TabStop = false;
            this.personalNav.Text = "Personal Nav Device";
            // 
            // LobbyBTN
            // 
            this.LobbyBTN.BackColor = System.Drawing.Color.Transparent;
            this.LobbyBTN.BackgroundImage = global::Moonbase.Properties.Resources.LOBBY_icon;
            this.LobbyBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LobbyBTN.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.LobbyBTN.FlatAppearance.BorderSize = 0;
            this.LobbyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LobbyBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LobbyBTN.ForeColor = System.Drawing.Color.Transparent;
            this.LobbyBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LobbyBTN.Location = new System.Drawing.Point(248, 320);
            this.LobbyBTN.Margin = new System.Windows.Forms.Padding(6);
            this.LobbyBTN.Name = "LobbyBTN";
            this.LobbyBTN.Size = new System.Drawing.Size(247, 236);
            this.LobbyBTN.TabIndex = 4;
            this.LobbyBTN.UseVisualStyleBackColor = false;
            this.LobbyBTN.Click += new System.EventHandler(this.LobbyBTN_Click);
            // 
            // medBayBTN
            // 
            this.medBayBTN.BackgroundImage = global::Moonbase.Properties.Resources.Medbay_ICON;
            this.medBayBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.medBayBTN.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.medBayBTN.FlatAppearance.BorderSize = 0;
            this.medBayBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medBayBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medBayBTN.ForeColor = System.Drawing.Color.Transparent;
            this.medBayBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.medBayBTN.Location = new System.Drawing.Point(248, 566);
            this.medBayBTN.Margin = new System.Windows.Forms.Padding(6);
            this.medBayBTN.Name = "medBayBTN";
            this.medBayBTN.Size = new System.Drawing.Size(247, 247);
            this.medBayBTN.TabIndex = 3;
            this.medBayBTN.UseVisualStyleBackColor = true;
            this.medBayBTN.Click += new System.EventHandler(this.medBayBTN_Click);
            // 
            // commandCenterBTN
            // 
            this.commandCenterBTN.BackColor = System.Drawing.Color.Transparent;
            this.commandCenterBTN.BackgroundImage = global::Moonbase.Properties.Resources.COMMAND_ICON;
            this.commandCenterBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.commandCenterBTN.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.commandCenterBTN.FlatAppearance.BorderSize = 0;
            this.commandCenterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commandCenterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandCenterBTN.ForeColor = System.Drawing.Color.Transparent;
            this.commandCenterBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.commandCenterBTN.Location = new System.Drawing.Point(248, 63);
            this.commandCenterBTN.Margin = new System.Windows.Forms.Padding(6);
            this.commandCenterBTN.Name = "commandCenterBTN";
            this.commandCenterBTN.Size = new System.Drawing.Size(247, 245);
            this.commandCenterBTN.TabIndex = 0;
            this.commandCenterBTN.UseVisualStyleBackColor = false;
            this.commandCenterBTN.Click += new System.EventHandler(this.commandCenterBTN_Click);
            // 
            // livingQtBTN
            // 
            this.livingQtBTN.BackgroundImage = global::Moonbase.Properties.Resources.Living_ICON;
            this.livingQtBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.livingQtBTN.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.livingQtBTN.FlatAppearance.BorderSize = 0;
            this.livingQtBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.livingQtBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livingQtBTN.ForeColor = System.Drawing.Color.Transparent;
            this.livingQtBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.livingQtBTN.Location = new System.Drawing.Point(503, 320);
            this.livingQtBTN.Margin = new System.Windows.Forms.Padding(6);
            this.livingQtBTN.Name = "livingQtBTN";
            this.livingQtBTN.Size = new System.Drawing.Size(231, 238);
            this.livingQtBTN.TabIndex = 2;
            this.livingQtBTN.UseVisualStyleBackColor = true;
            this.livingQtBTN.Click += new System.EventHandler(this.livingQtBTN_Click);
            // 
            // labBTN
            // 
            this.labBTN.BackColor = System.Drawing.Color.Transparent;
            this.labBTN.BackgroundImage = global::Moonbase.Properties.Resources.Lab_ICON;
            this.labBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.labBTN.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.labBTN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.labBTN.FlatAppearance.BorderSize = 0;
            this.labBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBTN.ForeColor = System.Drawing.Color.Transparent;
            this.labBTN.Location = new System.Drawing.Point(14, 320);
            this.labBTN.Margin = new System.Windows.Forms.Padding(6);
            this.labBTN.Name = "labBTN";
            this.labBTN.Size = new System.Drawing.Size(230, 236);
            this.labBTN.TabIndex = 1;
            this.labBTN.UseVisualStyleBackColor = false;
            this.labBTN.Click += new System.EventHandler(this.labBTN_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::Moonbase.Properties.Resources.lobby;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.personalNav);
            this.Controls.Add(this.GRBXLocationInfo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LUNA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GRBXLocationInfo.ResumeLayout(false);
            this.GRBXLocationInfo.PerformLayout();
            this.personalNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRBXLocationInfo;
        private System.Windows.Forms.TextBox TBRoomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBLRoomDesc;
        private System.Windows.Forms.GroupBox personalNav;
        private System.Windows.Forms.Button medBayBTN;
        private System.Windows.Forms.Button livingQtBTN;
        private System.Windows.Forms.Button commandCenterBTN;
        private System.Windows.Forms.Button LobbyBTN;
        private System.Windows.Forms.TextBox TXBXRoomDesc;
        private System.Windows.Forms.Button labBTN;
    }
}

