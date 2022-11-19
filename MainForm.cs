namespace Generic_Code_Editor {
    public partial class MainForm : Form {
        private List<ActiveCode> pages;
        private string activeDir;
        public MainForm() {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.pages = new();
            activeDir = "";
        }

        private void MainForm_Load(object sender, EventArgs e) {
            List<string> lines = new(File.ReadAllLines("./settings.config"));
            foreach (string line in lines) { /*Will get back to*/ }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            this.pages.Add(new() { Header = "New*" });
            this.TBCCode.TabPages.Add(this.pages[^1]);
            this.TBCCode.SelectedTab = this.pages[^1];
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                this.TBCCode.TabPages.Remove(TBCCode.SelectedTab);
            } catch (ArgumentNullException) {
                MessageBox.Show(this, "There are no tabs to close", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            this.pages[this.TBCCode.SelectedIndex].HasSaved();
        }
    }
}