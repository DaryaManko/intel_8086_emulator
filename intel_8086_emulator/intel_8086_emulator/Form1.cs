using System.Collections;

namespace intel_8086_emulator
{
    public partial class Emulator : Form
    {
        public Emulator()
        {
            InitializeComponent();
            result.Visible = false;
        }

        private void startRegisterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            duplicateComboCheck();
        }

        private void finishRegisterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            duplicateComboCheck();
        }

        public void duplicateComboCheck()
        {
            if (startRegisterBox.SelectedItem == finishRegisterBox.SelectedItem && 
                startRegisterBox.SelectedIndex != -1)
            {
                MessageBox.Show("nie mozesz wprowadzic te same rejesrty", "Error");
                return;
            }
        }

        private void mov_Click(object sender, EventArgs e)
        {
            value.Text = valuebox.Text;
            register.Text = finishRegisterBox.Text;
            result.Visible = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            result.Visible = false;
            valuebox.Clear();
            register.Clear();
            value.Clear();
            startRegisterBox.SelectedIndex = - 1;
            finishRegisterBox.SelectedIndex = - 1;
            
        }
    }
}