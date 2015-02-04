namespace CardIdentifier
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.twoclubsPicBox = new System.Windows.Forms.PictureBox();
            this.acediamondsPicBox = new System.Windows.Forms.PictureBox();
            this.eightspadesPicBox = new System.Windows.Forms.PictureBox();
            this.kingheartsPicBox = new System.Windows.Forms.PictureBox();
            this.queenheartsPicBox = new System.Windows.Forms.PictureBox();
            this.cardLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.twoclubsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acediamondsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightspadesPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingheartsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenheartsPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // twoclubsPicBox
            // 
            this.twoclubsPicBox.Image = ((System.Drawing.Image)(resources.GetObject("twoclubsPicBox.Image")));
            this.twoclubsPicBox.Location = new System.Drawing.Point(25, 29);
            this.twoclubsPicBox.Name = "twoclubsPicBox";
            this.twoclubsPicBox.Size = new System.Drawing.Size(190, 250);
            this.twoclubsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoclubsPicBox.TabIndex = 0;
            this.twoclubsPicBox.TabStop = false;
            this.twoclubsPicBox.Click += new System.EventHandler(this.twoclubsPicBox_Click);
            // 
            // acediamondsPicBox
            // 
            this.acediamondsPicBox.Image = ((System.Drawing.Image)(resources.GetObject("acediamondsPicBox.Image")));
            this.acediamondsPicBox.Location = new System.Drawing.Point(240, 29);
            this.acediamondsPicBox.Name = "acediamondsPicBox";
            this.acediamondsPicBox.Size = new System.Drawing.Size(190, 250);
            this.acediamondsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acediamondsPicBox.TabIndex = 1;
            this.acediamondsPicBox.TabStop = false;
            this.acediamondsPicBox.Click += new System.EventHandler(this.acediamondsPicBox_Click);
            // 
            // eightspadesPicBox
            // 
            this.eightspadesPicBox.Image = ((System.Drawing.Image)(resources.GetObject("eightspadesPicBox.Image")));
            this.eightspadesPicBox.Location = new System.Drawing.Point(455, 29);
            this.eightspadesPicBox.Name = "eightspadesPicBox";
            this.eightspadesPicBox.Size = new System.Drawing.Size(190, 250);
            this.eightspadesPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eightspadesPicBox.TabIndex = 2;
            this.eightspadesPicBox.TabStop = false;
            this.eightspadesPicBox.Click += new System.EventHandler(this.eightspadesPicBox_Click);
            // 
            // kingheartsPicBox
            // 
            this.kingheartsPicBox.Image = ((System.Drawing.Image)(resources.GetObject("kingheartsPicBox.Image")));
            this.kingheartsPicBox.Location = new System.Drawing.Point(669, 29);
            this.kingheartsPicBox.Name = "kingheartsPicBox";
            this.kingheartsPicBox.Size = new System.Drawing.Size(190, 250);
            this.kingheartsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kingheartsPicBox.TabIndex = 3;
            this.kingheartsPicBox.TabStop = false;
            this.kingheartsPicBox.Click += new System.EventHandler(this.kingheartsPicBox_Click);
            // 
            // queenheartsPicBox
            // 
            this.queenheartsPicBox.Image = ((System.Drawing.Image)(resources.GetObject("queenheartsPicBox.Image")));
            this.queenheartsPicBox.Location = new System.Drawing.Point(885, 29);
            this.queenheartsPicBox.Name = "queenheartsPicBox";
            this.queenheartsPicBox.Size = new System.Drawing.Size(190, 250);
            this.queenheartsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.queenheartsPicBox.TabIndex = 4;
            this.queenheartsPicBox.TabStop = false;
            this.queenheartsPicBox.Click += new System.EventHandler(this.queenheartsPicBox_Click);
            // 
            // cardLabel
            // 
            this.cardLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cardLabel.Location = new System.Drawing.Point(0, 282);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(1105, 118);
            this.cardLabel.TabIndex = 5;
            this.cardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 400);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.queenheartsPicBox);
            this.Controls.Add(this.kingheartsPicBox);
            this.Controls.Add(this.eightspadesPicBox);
            this.Controls.Add(this.acediamondsPicBox);
            this.Controls.Add(this.twoclubsPicBox);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.twoclubsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acediamondsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eightspadesPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingheartsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenheartsPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox twoclubsPicBox;
        private System.Windows.Forms.PictureBox acediamondsPicBox;
        private System.Windows.Forms.PictureBox eightspadesPicBox;
        private System.Windows.Forms.PictureBox kingheartsPicBox;
        private System.Windows.Forms.PictureBox queenheartsPicBox;
        private System.Windows.Forms.Label cardLabel;
    }
}

