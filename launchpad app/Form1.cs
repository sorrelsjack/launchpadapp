using System;
using System.Windows.Forms;

namespace launchpad_app {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void launchAllButton_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://habitica.com/");
            System.Diagnostics.Process.Start("https://mynoise.net/");
            System.Diagnostics.Process.Start("https://twitter.com/");
            System.Diagnostics.Process.Start("http://www.furaffinity.net/");
            System.Diagnostics.Process.Start("https://www.tumblr.com/dashboard");
            System.Diagnostics.Process.Start("https://www.facebook.com/");
            this.Close();
        }

        private void habiticaButton_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://habitica.com/");
        }

        private void myNoiseButton_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://mynoise.net/");
        }

        private void twitterButton_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://twitter.com/");
        }

        private void FAbutton_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("http://www.furaffinity.net/");
        }

        private void tumblrButton_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.tumblr.com/dashboard");
        }

        private void facebookButton_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }
    }
}
