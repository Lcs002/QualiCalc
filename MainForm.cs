using QualiCalc.core;
using QualiCalc.pages;

namespace QualiCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Panel contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            this.Controls.Add(contentPanel);

            BtnPareto.Click += (s, e) => SwitchPage(new ParetoUC());
            BtnVCC.Click += (s, e) => SwitchPage(new VariableControlChartUC());

            void SwitchPage(UserControl newPage)
            {
                contentPanel.Controls.Clear();  // Clear the current page
                contentPanel.Controls.Add(newPage);  // Add the new page
                newPage.Dock = DockStyle.Fill;
            }
        }
    }
}