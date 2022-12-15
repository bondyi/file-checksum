using MaterialSkin;
using MaterialSkin.Controls;
using FileChecksum.Algorithms;

namespace FileChecksum.WindowsForms
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeMaterialForm();
            InitializeHistory();
        }

        private void InitializeMaterialForm()
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900, 
                Primary.Grey900, 
                Primary.Grey900, 
                Accent.Cyan700, 
                TextShade.WHITE);
        }

        private static void InitializeHistory()
        {
            HistoryManager.Initialize();
        }

        private void SelectFileButton_MouseClick(object sender, MouseEventArgs e)
        {
            using OpenFileDialog openFileDialog = new();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var currentComboBoxItem = (string)algorithmComboBox.SelectedItem;

                var bytes = File.ReadAllBytes(openFileDialog.FileName);

                var checksum = currentComboBoxItem switch
                {
                    "CRC-32-IEEE 802.3" => CRC32.ComputeBytes(bytes),
                    _ => throw new NotImplementedException()
                };

                SetChecksum(checksum);

                var fileName = openFileDialog.FileName.Split('\\').Last();

                HistoryManager.AddRecord(DateTime.Now, fileName, string.Format("{0:X}", checksum));
            }
        }

        private void SetChecksum(uint checksum)
        {
            checksumHexLabel.Text = "HEX: " + string.Format("{0:X}", checksum);
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = materialTabControl1.SelectedTab.Text;

            if (materialTabControl1.SelectedIndex == 1)
            {
                UpdateHistory();
            }
        }

        private void UpdateHistory()
        {
            materialListView1.Items.Clear();

            HistoryManager.SortRecords();

            foreach (var record in HistoryManager.GetRecords())
            {
                var strings = record.ToString().Split('|');
                materialListView1.Items.Add(new ListViewItem(strings));
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HistoryManager.SaveRecords();
        }
    }
}
