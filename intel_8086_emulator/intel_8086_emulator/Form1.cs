using System.Collections;

namespace intel_8086_emulator
{
    public partial class Emulator : Form
    {
        public Emulator()
        {
            InitializeComponent();
            foreach(string items in getRegisterElements())
            {
                startRegisterBox.Items.Add(items);
                finishRegisterBox.Items.Add(items);
            }
            result.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Emulator_Load(object sender, EventArgs e)
        {

        }

        private void startRegisterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            duplicateComboCheck();
        }

        private void finishRegisterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            duplicateComboCheck();
        }



        public ArrayList getRegisterElements()
        {
            ArrayList element = new ArrayList() { "AX", "BX", "CX" };
            return element;

        }

        public void duplicateComboCheck()
        {
            if (startRegisterBox.SelectedItem == finishRegisterBox.SelectedItem)
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
            startRegisterBox.ResetText();
            
        }
    }
}