using System.Text;
using TelephonStationLogic;
namespace TelephoneStation
{
    public partial class FormCallCenter : Form
    {
        Queue<(string,string)> ConsoleMessages = new Queue<(string,string)> ();
        public FormCallCenter()
        {
            InitializeComponent();
            timer1.Start();
            Agent.Info += AddLineInLogConsole;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddConnection_Click(object sender, EventArgs e)
        {
            
            var call = CallsController.AddCall();
            AddLineInLogConsole(call.ToString(), "NC");
           
        }

       

        private void buttonAddAgent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAgentName.Text))
            {
                return;
                //TODO: В правой панели можно сделать оповещение)
            }
            AgentsController.CreateAgent(textBoxAgentName.Text);
            //TODO: нужна обработка, если объект не добавлен
            RefreshAgentsList();
        }

        private void RefreshAgentsList()
        {
            var sb = new StringBuilder();
            foreach (var item in AgentsController.Agents)
            { 
                sb.AppendLine(item.ToString());
            }
            richTextBoxAgentsNames.Text = sb.ToString();
            textBoxAgentName.Text = default(string);
        }

        private void button2DeleteAgent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAgentName.Text))
            {
                return;
                //TODO: В правой панели можно сделать оповещение)
            }
            AgentsController.DeleteAgent(textBoxAgentName.Text);
            //TODO: нужна обработка, если объект не удалён(и если удалён)
            RefreshAgentsList();
        }
        private void AddLineInLogConsole(string line, string type)
        {
            //TODO: string type возможно лучше сделать Enum
            ConsoleMessages.Enqueue((line, type));
            //richTextBoxLogConsole.AppendText($"{DateTime.Now}_{type}_{line}\n");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ConsoleMessages.Count > 0)
            {
                var text = ConsoleMessages.Dequeue();
                richTextBoxLogConsole.AppendText($"{DateTime.Now}_{text.Item2}_{text.Item1}\n");
            
            }
        }
    }
}