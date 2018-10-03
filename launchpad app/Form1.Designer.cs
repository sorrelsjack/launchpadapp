namespace launchpad_app {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.launchAllButton = new System.Windows.Forms.Button();
            this.habiticaButton = new System.Windows.Forms.Button();
            this.myNoiseButton = new System.Windows.Forms.Button();
            this.twitterButton = new System.Windows.Forms.Button();
            this.FAbutton = new System.Windows.Forms.Button();
            this.tumblrButton = new System.Windows.Forms.Button();
            this.facebookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // launchAllButton
            // 
            this.launchAllButton.BackColor = System.Drawing.Color.Azure;
            this.launchAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.launchAllButton.Location = new System.Drawing.Point(201, 134);
            this.launchAllButton.Name = "launchAllButton";
            this.launchAllButton.Size = new System.Drawing.Size(187, 47);
            this.launchAllButton.TabIndex = 0;
            this.launchAllButton.Text = "Launch All";
            this.launchAllButton.UseVisualStyleBackColor = false;
            this.launchAllButton.Click += new System.EventHandler(this.launchAllButton_Click);
            // 
            // habiticaButton
            // 
            this.habiticaButton.BackColor = System.Drawing.Color.Azure;
            this.habiticaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.habiticaButton.Location = new System.Drawing.Point(47, 49);
            this.habiticaButton.Name = "habiticaButton";
            this.habiticaButton.Size = new System.Drawing.Size(87, 39);
            this.habiticaButton.TabIndex = 1;
            this.habiticaButton.Text = "Habitica";
            this.habiticaButton.UseVisualStyleBackColor = false;
            this.habiticaButton.Click += new System.EventHandler(this.habiticaButton_Click);
            // 
            // myNoiseButton
            // 
            this.myNoiseButton.BackColor = System.Drawing.Color.Azure;
            this.myNoiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myNoiseButton.Location = new System.Drawing.Point(47, 138);
            this.myNoiseButton.Name = "myNoiseButton";
            this.myNoiseButton.Size = new System.Drawing.Size(87, 39);
            this.myNoiseButton.TabIndex = 2;
            this.myNoiseButton.Text = "myNoise";
            this.myNoiseButton.UseVisualStyleBackColor = false;
            this.myNoiseButton.Click += new System.EventHandler(this.myNoiseButton_Click);
            // 
            // twitterButton
            // 
            this.twitterButton.BackColor = System.Drawing.Color.Azure;
            this.twitterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twitterButton.Location = new System.Drawing.Point(47, 218);
            this.twitterButton.Name = "twitterButton";
            this.twitterButton.Size = new System.Drawing.Size(87, 39);
            this.twitterButton.TabIndex = 3;
            this.twitterButton.Text = "Twitter";
            this.twitterButton.UseVisualStyleBackColor = false;
            this.twitterButton.Click += new System.EventHandler(this.twitterButton_Click);
            // 
            // FAbutton
            // 
            this.FAbutton.BackColor = System.Drawing.Color.Azure;
            this.FAbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FAbutton.Location = new System.Drawing.Point(445, 49);
            this.FAbutton.Name = "FAbutton";
            this.FAbutton.Size = new System.Drawing.Size(87, 39);
            this.FAbutton.TabIndex = 4;
            this.FAbutton.Text = "FA";
            this.FAbutton.UseVisualStyleBackColor = false;
            this.FAbutton.Click += new System.EventHandler(this.FAbutton_Click);
            // 
            // tumblrButton
            // 
            this.tumblrButton.BackColor = System.Drawing.Color.Azure;
            this.tumblrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tumblrButton.Location = new System.Drawing.Point(445, 138);
            this.tumblrButton.Name = "tumblrButton";
            this.tumblrButton.Size = new System.Drawing.Size(87, 39);
            this.tumblrButton.TabIndex = 5;
            this.tumblrButton.Text = "tumblr";
            this.tumblrButton.UseVisualStyleBackColor = false;
            this.tumblrButton.Click += new System.EventHandler(this.tumblrButton_Click);
            // 
            // facebookButton
            // 
            this.facebookButton.BackColor = System.Drawing.Color.Azure;
            this.facebookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facebookButton.Location = new System.Drawing.Point(445, 218);
            this.facebookButton.Name = "facebookButton";
            this.facebookButton.Size = new System.Drawing.Size(87, 39);
            this.facebookButton.TabIndex = 6;
            this.facebookButton.Text = "Facebook";
            this.facebookButton.UseVisualStyleBackColor = false;
            this.facebookButton.Click += new System.EventHandler(this.facebookButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(583, 304);
            this.Controls.Add(this.facebookButton);
            this.Controls.Add(this.tumblrButton);
            this.Controls.Add(this.FAbutton);
            this.Controls.Add(this.twitterButton);
            this.Controls.Add(this.myNoiseButton);
            this.Controls.Add(this.habiticaButton);
            this.Controls.Add(this.launchAllButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launchpad!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button launchAllButton;
        private System.Windows.Forms.Button habiticaButton;
        private System.Windows.Forms.Button myNoiseButton;
        private System.Windows.Forms.Button twitterButton;
        private System.Windows.Forms.Button FAbutton;
        private System.Windows.Forms.Button tumblrButton;
        private System.Windows.Forms.Button facebookButton;
    }
}

