using System.Text;
using TelephonStationLogic;
namespace TelephoneStation
{
    public partial class FormCallCenter : Form
    {
        public FormCallCenter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddConnection_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddAgent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAgentName.Text))
            {
                return;
                //TODO: В правой панели можно сделать оповещение)
            }
            LogicController.CreateAgent(textBoxAgentName.Text);
            //TODO: нужна обработка, если объект не добавлен
            RefreshAgentsList();
        }

        private void RefreshAgentsList()
        {
            var sb = new StringBuilder();
            foreach (var item in LogicController.Agents)
            { 
                sb.AppendLine(item.ToString());
            }
            richTextBoxAgentsNames.Text = sb.ToString();
            textBoxAgentName.Text = default(string);
        }
    }
}