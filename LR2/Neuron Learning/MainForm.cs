using System;
using System.Windows.Forms;

namespace Neuron_Learning
{
    public partial class MainForm : Form
    {
        private Neuron Neuron { get; set; } = new Neuron();
        private int CountOfLearning { get; set; } = 0;

        public MainForm()
        {
            InitializeComponent();
            
            lblCompletedIterations.Text = $"Ітерацій виконано: {CountOfLearning}";
            
            Numbers[] enums = (Numbers[])Enum.GetValues(typeof(Numbers));
            pBarNeuronLearned.Minimum = 0;
            pBarNeuronLearned.Maximum = Convert.ToInt32(enums.Length);
            
            cBoxChooseNumber.Items.Clear();
            cBoxChooseNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Numbers number in Enum.GetValues(typeof(Numbers)))
            {
                cBoxChooseNumber.Items.Add((int)number);
            }
            cBoxChooseNumber.SelectedItem = cBoxChooseNumber.Items[0];

            RewriteLog();
            RewriteProgress();
        }

        private void btnLearn_Click(object sender, EventArgs e)
        {
            int n = (int)Math.Floor(nUdNumberOfIterations.Value);

            for (int i = 0; i < n; i++)
            {
                Neuron.Learn();
                CountOfLearning++;
            }

            lblCompletedIterations.Text = $"Ітерацій виконано: {CountOfLearning}";
            RewriteLog();
            RewriteProgress();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int number = (int)cBoxChooseNumber.SelectedItem;
            int Y = Neuron.GetY((Numbers)number);
            MessageBox.Show($"{number} => {(Y == 1 ? "Парна" : "Непарна")} цифра");
        }

        private void btnNewNeuron_Click(object sender, EventArgs e)
        {
            Neuron = new Neuron();
            CountOfLearning = 0;
            lblCompletedIterations.Text = $"Ітерацій виконано: {CountOfLearning}";
            pBarNeuronLearned.Value = 0;
            
            RewriteLog();
            RewriteProgress();
        }

        private void RewriteProgress()
        {
            int result = 0;
            foreach (Numbers number in Enum.GetValues(typeof(Numbers)))
            {
                int Y = Neuron.GetY(number);
                int remainder = (int)number % 2;
                if(remainder == 0 && Y == 1 || remainder != 0 && Y == 0)
                {
                    result++;
                }
            }

            pBarNeuronLearned.Value = result;
        }

        private void RewriteLog()
        {
            lblLog.Text = "";

            foreach (Numbers number in Enum.GetValues(typeof(Numbers)))
            {
                lblLog.Text += $"{(int)number} => {(Neuron.GetY(number) == 1 ? "П" : "Н")}\n";
            }
        }
    }
}
