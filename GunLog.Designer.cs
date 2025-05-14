namespace GunLog
{
    partial class GunLog
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
            this.GunListBox = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MakeBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.CaliberBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.MakeLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.CaliberLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AddRoundButton = new System.Windows.Forms.Button();
            this.FiredRoundsLabel = new System.Windows.Forms.Label();
            this.RoundsBox = new System.Windows.Forms.TextBox();
            this.AcquiredBox = new System.Windows.Forms.TextBox();
            this.AcquiredLabel = new System.Windows.Forms.Label();
            this.SerialLabel = new System.Windows.Forms.Label();
            this.SerialBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GunListBox
            // 
            this.GunListBox.FormattingEnabled = true;
            this.GunListBox.Location = new System.Drawing.Point(356, 13);
            this.GunListBox.Name = "GunListBox";
            this.GunListBox.Size = new System.Drawing.Size(420, 381);
            this.GunListBox.TabIndex = 0;
            this.GunListBox.SelectedIndexChanged += new System.EventHandler(this.GunListBox_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(122, 185);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(200, 25);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(122, 215);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(200, 25);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "EDIT";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(122, 245);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(200, 25);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MakeBox
            // 
            this.MakeBox.Location = new System.Drawing.Point(100, 39);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(250, 20);
            this.MakeBox.TabIndex = 4;
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(100, 69);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(250, 20);
            this.ModelBox.TabIndex = 5;
            // 
            // CaliberBox
            // 
            this.CaliberBox.Location = new System.Drawing.Point(100, 99);
            this.CaliberBox.Name = "CaliberBox";
            this.CaliberBox.Size = new System.Drawing.Size(250, 20);
            this.CaliberBox.TabIndex = 6;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(100, 129);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(250, 20);
            this.PriceBox.TabIndex = 7;
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Location = new System.Drawing.Point(60, 42);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(34, 13);
            this.MakeLabel.TabIndex = 10;
            this.MakeLabel.Text = "Make";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(58, 72);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(36, 13);
            this.ModelLabel.TabIndex = 11;
            this.ModelLabel.Text = "Model";
            // 
            // CaliberLabel
            // 
            this.CaliberLabel.AutoSize = true;
            this.CaliberLabel.Location = new System.Drawing.Point(55, 102);
            this.CaliberLabel.Name = "CaliberLabel";
            this.CaliberLabel.Size = new System.Drawing.Size(39, 13);
            this.CaliberLabel.TabIndex = 12;
            this.CaliberLabel.Text = "Caliber";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(63, 132);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PriceLabel.TabIndex = 13;
            this.PriceLabel.Text = "Price";
            // 
            // AddRoundButton
            // 
            this.AddRoundButton.Location = new System.Drawing.Point(122, 335);
            this.AddRoundButton.Name = "AddRoundButton";
            this.AddRoundButton.Size = new System.Drawing.Size(140, 25);
            this.AddRoundButton.TabIndex = 14;
            this.AddRoundButton.Text = "ADD ROUNDS";
            this.AddRoundButton.UseVisualStyleBackColor = true;
            this.AddRoundButton.Click += new System.EventHandler(this.AddRoundButton_Click);
            // 
            // FiredRoundsLabel
            // 
            this.FiredRoundsLabel.AutoSize = true;
            this.FiredRoundsLabel.Location = new System.Drawing.Point(12, 310);
            this.FiredRoundsLabel.Name = "FiredRoundsLabel";
            this.FiredRoundsLabel.Size = new System.Drawing.Size(82, 13);
            this.FiredRoundsLabel.TabIndex = 15;
            this.FiredRoundsLabel.Text = "If Rounds Fired:";
            // 
            // RoundsBox
            // 
            this.RoundsBox.Location = new System.Drawing.Point(15, 338);
            this.RoundsBox.Name = "RoundsBox";
            this.RoundsBox.Size = new System.Drawing.Size(90, 20);
            this.RoundsBox.TabIndex = 16;
            // 
            // AcquiredBox
            // 
            this.AcquiredBox.Location = new System.Drawing.Point(100, 159);
            this.AcquiredBox.Name = "AcquiredBox";
            this.AcquiredBox.Size = new System.Drawing.Size(250, 20);
            this.AcquiredBox.TabIndex = 17;
            // 
            // AcquiredLabel
            // 
            this.AcquiredLabel.AutoSize = true;
            this.AcquiredLabel.Location = new System.Drawing.Point(12, 159);
            this.AcquiredLabel.Name = "AcquiredLabel";
            this.AcquiredLabel.Size = new System.Drawing.Size(85, 26);
            this.AcquiredLabel.TabIndex = 18;
            this.AcquiredLabel.Text = "Date Acquired \r\n(MM/DD/YYYY)";
            // 
            // SerialLabel
            // 
            this.SerialLabel.AutoSize = true;
            this.SerialLabel.Location = new System.Drawing.Point(60, 16);
            this.SerialLabel.Name = "SerialLabel";
            this.SerialLabel.Size = new System.Drawing.Size(33, 13);
            this.SerialLabel.TabIndex = 20;
            this.SerialLabel.Text = "Serial";
            // 
            // SerialBox
            // 
            this.SerialBox.Location = new System.Drawing.Point(100, 13);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(250, 20);
            this.SerialBox.TabIndex = 19;
            // 
            // GunLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 411);
            this.Controls.Add(this.SerialLabel);
            this.Controls.Add(this.SerialBox);
            this.Controls.Add(this.AcquiredLabel);
            this.Controls.Add(this.AcquiredBox);
            this.Controls.Add(this.RoundsBox);
            this.Controls.Add(this.FiredRoundsLabel);
            this.Controls.Add(this.AddRoundButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CaliberLabel);
            this.Controls.Add(this.ModelLabel);
            this.Controls.Add(this.MakeLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.CaliberBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.MakeBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GunListBox);
            this.Name = "GunLog";
            this.Text = "GunLog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GunListBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox MakeBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox CaliberBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label CaliberLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button AddRoundButton;
        private System.Windows.Forms.Label FiredRoundsLabel;
        private System.Windows.Forms.TextBox RoundsBox;
        private System.Windows.Forms.TextBox AcquiredBox;
        private System.Windows.Forms.Label AcquiredLabel;
        private System.Windows.Forms.Label SerialLabel;
        private System.Windows.Forms.TextBox SerialBox;
    }
}

