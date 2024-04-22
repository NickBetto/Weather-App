namespace Weather_App
{
    partial class DailyScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.highLowLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chanceLabel = new System.Windows.Forms.Label();
            this.rainLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.conditionImage = new System.Windows.Forms.PictureBox();
            this.directionBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.White;
            this.cityLabel.Location = new System.Drawing.Point(12, 16);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(148, 32);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "Stratford";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tempLabel
            // 
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(231, 158);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(116, 98);
            this.tempLabel.TabIndex = 2;
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(13, 49);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(136, 32);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // conditionLabel
            // 
            this.conditionLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.ForeColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(199, 89);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(163, 69);
            this.conditionLabel.TabIndex = 4;
            this.conditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // speedLabel
            // 
            this.speedLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(12, 486);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(146, 70);
            this.speedLabel.TabIndex = 6;
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highLowLabel
            // 
            this.highLowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highLowLabel.ForeColor = System.Drawing.Color.White;
            this.highLowLabel.Location = new System.Drawing.Point(231, 248);
            this.highLowLabel.Name = "highLowLabel";
            this.highLowLabel.Size = new System.Drawing.Size(116, 47);
            this.highLowLabel.TabIndex = 8;
            this.highLowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windLabel
            // 
            this.windLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.ForeColor = System.Drawing.Color.White;
            this.windLabel.Location = new System.Drawing.Point(14, 319);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(103, 49);
            this.windLabel.TabIndex = 10;
            this.windLabel.Text = "WIND";
            this.windLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 49);
            this.label1.TabIndex = 11;
            this.label1.Text = "PRECIPITATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chanceLabel
            // 
            this.chanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceLabel.ForeColor = System.Drawing.Color.White;
            this.chanceLabel.Location = new System.Drawing.Point(140, 385);
            this.chanceLabel.Name = "chanceLabel";
            this.chanceLabel.Size = new System.Drawing.Size(207, 98);
            this.chanceLabel.TabIndex = 12;
            this.chanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rainLabel
            // 
            this.rainLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainLabel.ForeColor = System.Drawing.Color.White;
            this.rainLabel.Location = new System.Drawing.Point(164, 486);
            this.rainLabel.Name = "rainLabel";
            this.rainLabel.Size = new System.Drawing.Size(165, 70);
            this.rainLabel.TabIndex = 13;
            this.rainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(199, 16);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(148, 32);
            this.forecastLabel.TabIndex = 14;
            this.forecastLabel.Text = "Forecast";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // conditionImage
            // 
            this.conditionImage.Location = new System.Drawing.Point(17, 112);
            this.conditionImage.Name = "conditionImage";
            this.conditionImage.Size = new System.Drawing.Size(171, 183);
            this.conditionImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conditionImage.TabIndex = 15;
            this.conditionImage.TabStop = false;
            // 
            // directionBox
            // 
            this.directionBox.Image = global::Weather_App.Properties.Resources.northArrow;
            this.directionBox.Location = new System.Drawing.Point(17, 383);
            this.directionBox.Name = "directionBox";
            this.directionBox.Size = new System.Drawing.Size(100, 100);
            this.directionBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.directionBox.TabIndex = 7;
            this.directionBox.TabStop = false;
            // 
            // DailyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.conditionImage);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.rainLabel);
            this.Controls.Add(this.chanceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.highLowLabel);
            this.Controls.Add(this.directionBox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.cityLabel);
            this.Name = "DailyScreen";
            this.Size = new System.Drawing.Size(365, 585);
            ((System.ComponentModel.ISupportInitialize)(this.conditionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.PictureBox directionBox;
        private System.Windows.Forms.Label highLowLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label chanceLabel;
        private System.Windows.Forms.Label rainLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.PictureBox conditionImage;
    }
}
