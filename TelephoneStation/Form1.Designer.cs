namespace TelephoneStation
{
    partial class FormCallCenter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelAgents = new System.Windows.Forms.Panel();
            this.panelActionWithAgents = new System.Windows.Forms.Panel();
            this.buttonDeleteAgent = new System.Windows.Forms.Button();
            this.buttonAddAgent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAgentName = new System.Windows.Forms.TextBox();
            this.groupBoxAgents = new System.Windows.Forms.GroupBox();
            this.richTextBoxAgentsNames = new System.Windows.Forms.RichTextBox();
            this.groupBoxLogsConsole = new System.Windows.Forms.GroupBox();
            this.richTextBoxLogConsole = new System.Windows.Forms.RichTextBox();
            this.panelControlPanel = new System.Windows.Forms.Panel();
            this.buttonAddConnection = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelAgents.SuspendLayout();
            this.panelActionWithAgents.SuspendLayout();
            this.groupBoxAgents.SuspendLayout();
            this.groupBoxLogsConsole.SuspendLayout();
            this.panelControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgents
            // 
            this.panelAgents.Controls.Add(this.panelActionWithAgents);
            this.panelAgents.Controls.Add(this.groupBoxAgents);
            this.panelAgents.Location = new System.Drawing.Point(12, 21);
            this.panelAgents.Name = "panelAgents";
            this.panelAgents.Size = new System.Drawing.Size(262, 395);
            this.panelAgents.TabIndex = 0;
            // 
            // panelActionWithAgents
            // 
            this.panelActionWithAgents.Controls.Add(this.buttonDeleteAgent);
            this.panelActionWithAgents.Controls.Add(this.buttonAddAgent);
            this.panelActionWithAgents.Controls.Add(this.label1);
            this.panelActionWithAgents.Controls.Add(this.textBoxAgentName);
            this.panelActionWithAgents.Location = new System.Drawing.Point(15, 284);
            this.panelActionWithAgents.Name = "panelActionWithAgents";
            this.panelActionWithAgents.Size = new System.Drawing.Size(229, 102);
            this.panelActionWithAgents.TabIndex = 3;
            // 
            // buttonDeleteAgent
            // 
            this.buttonDeleteAgent.Location = new System.Drawing.Point(119, 57);
            this.buttonDeleteAgent.Name = "buttonDeleteAgent";
            this.buttonDeleteAgent.Size = new System.Drawing.Size(94, 29);
            this.buttonDeleteAgent.TabIndex = 1;
            this.buttonDeleteAgent.Text = "Удалить";
            this.buttonDeleteAgent.UseVisualStyleBackColor = true;
            this.buttonDeleteAgent.Click += new System.EventHandler(this.button2DeleteAgent_Click);
            // 
            // buttonAddAgent
            // 
            this.buttonAddAgent.Location = new System.Drawing.Point(10, 57);
            this.buttonAddAgent.Name = "buttonAddAgent";
            this.buttonAddAgent.Size = new System.Drawing.Size(94, 29);
            this.buttonAddAgent.TabIndex = 1;
            this.buttonAddAgent.Text = "Добавить";
            this.buttonAddAgent.UseVisualStyleBackColor = true;
            this.buttonAddAgent.Click += new System.EventHandler(this.buttonAddAgent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAgentName
            // 
            this.textBoxAgentName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAgentName.Location = new System.Drawing.Point(103, 7);
            this.textBoxAgentName.Name = "textBoxAgentName";
            this.textBoxAgentName.Size = new System.Drawing.Size(110, 30);
            this.textBoxAgentName.TabIndex = 2;
            // 
            // groupBoxAgents
            // 
            this.groupBoxAgents.Controls.Add(this.richTextBoxAgentsNames);
            this.groupBoxAgents.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAgents.Location = new System.Drawing.Point(15, 15);
            this.groupBoxAgents.Name = "groupBoxAgents";
            this.groupBoxAgents.Size = new System.Drawing.Size(229, 263);
            this.groupBoxAgents.TabIndex = 1;
            this.groupBoxAgents.TabStop = false;
            this.groupBoxAgents.Text = "Список диспетчеров";
            // 
            // richTextBoxAgentsNames
            // 
            this.richTextBoxAgentsNames.Location = new System.Drawing.Point(12, 29);
            this.richTextBoxAgentsNames.Name = "richTextBoxAgentsNames";
            this.richTextBoxAgentsNames.Size = new System.Drawing.Size(207, 211);
            this.richTextBoxAgentsNames.TabIndex = 0;
            this.richTextBoxAgentsNames.Text = "";
            // 
            // groupBoxLogsConsole
            // 
            this.groupBoxLogsConsole.Controls.Add(this.richTextBoxLogConsole);
            this.groupBoxLogsConsole.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxLogsConsole.Location = new System.Drawing.Point(293, 21);
            this.groupBoxLogsConsole.Name = "groupBoxLogsConsole";
            this.groupBoxLogsConsole.Size = new System.Drawing.Size(721, 395);
            this.groupBoxLogsConsole.TabIndex = 1;
            this.groupBoxLogsConsole.TabStop = false;
            this.groupBoxLogsConsole.Text = "Консоль логов";
            // 
            // richTextBoxLogConsole
            // 
            this.richTextBoxLogConsole.Location = new System.Drawing.Point(13, 26);
            this.richTextBoxLogConsole.Name = "richTextBoxLogConsole";
            this.richTextBoxLogConsole.Size = new System.Drawing.Size(692, 344);
            this.richTextBoxLogConsole.TabIndex = 0;
            this.richTextBoxLogConsole.Text = "";
            // 
            // panelControlPanel
            // 
            this.panelControlPanel.Controls.Add(this.buttonAddConnection);
            this.panelControlPanel.Location = new System.Drawing.Point(1038, 21);
            this.panelControlPanel.Name = "panelControlPanel";
            this.panelControlPanel.Size = new System.Drawing.Size(228, 395);
            this.panelControlPanel.TabIndex = 2;
            // 
            // buttonAddConnection
            // 
            this.buttonAddConnection.Location = new System.Drawing.Point(11, 153);
            this.buttonAddConnection.Name = "buttonAddConnection";
            this.buttonAddConnection.Size = new System.Drawing.Size(207, 39);
            this.buttonAddConnection.TabIndex = 0;
            this.buttonAddConnection.Text = "Добавить соединение";
            this.buttonAddConnection.UseVisualStyleBackColor = true;
            this.buttonAddConnection.Click += new System.EventHandler(this.buttonAddConnection_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormCallCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 440);
            this.Controls.Add(this.panelControlPanel);
            this.Controls.Add(this.groupBoxLogsConsole);
            this.Controls.Add(this.panelAgents);
            this.Name = "FormCallCenter";
            this.Text = "Телефонная станция";
            this.panelAgents.ResumeLayout(false);
            this.panelActionWithAgents.ResumeLayout(false);
            this.panelActionWithAgents.PerformLayout();
            this.groupBoxAgents.ResumeLayout(false);
            this.groupBoxLogsConsole.ResumeLayout(false);
            this.panelControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelAgents;
        private GroupBox groupBoxAgents;
        private Label label1;
        private TextBox textBoxAgentName;
        private Panel panelActionWithAgents;
        private Button buttonDeleteAgent;
        private Button buttonAddAgent;
        private RichTextBox richTextBoxAgentsNames;
        private GroupBox groupBoxLogsConsole;
        private RichTextBox richTextBoxLogConsole;
        private Panel panelControlPanel;
        private Button buttonAddConnection;
        private System.Windows.Forms.Timer timer1;
    }
}