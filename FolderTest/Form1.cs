namespace FolderTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder";
                folderBrowserDialog.ShowNewFolderButton = true;

                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    label1.Text = folderBrowserDialog.SelectedPath;
                    string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                    var st = "";
                    foreach (string file in files)
                    {
                        st = st + file + "\n";
                    }
                    label2.Text = st;
                }
            }
        }
    }
}
