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
            this.groupBoxConsoleLogMessageTypes = new System.Windows.Forms.GroupBox();
            this.buttonAddConnection = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxConsoleLogsAC = new System.Windows.Forms.CheckBox();
            this.checkBoxConsoleLogsEC = new System.Windows.Forms.CheckBox();
            this.checkBoxConsoleLogsNC = new System.Windows.Forms.CheckBox();
            this.panelAgents.SuspendLayout();
            this.panelActionWithAgents.SuspendLayout();
            this.groupBoxAgents.SuspendLayout();
            this.groupBoxLogsConsole.SuspendLayout();
            this.panelControlPanel.SuspendLayout();
            this.groupBoxConsoleLogMessageTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAgents
            // 
            this.panelAgents.Controls.Add(this.panelActionWithAgents);
            this.panelAgents.Controls.Add(this.groupBoxAgents);
            this.panelAgents.Location = new System.Drawing.Point(10, 16);
            this.panelAgents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAgents.Name = "panelAgents";
            this.panelAgents.Size = new System.Drawing.Size(229, 296);
            this.panelAgents.TabIndex = 0;
            // 
            // panelActionWithAgents
            // 
            this.panelActionWithAgents.Controls.Add(this.buttonDeleteAgent);
            this.panelActionWithAgents.Controls.Add(this.buttonAddAgent);
            this.panelActionWithAgents.Controls.Add(this.label1);
            this.panelActionWithAgents.Controls.Add(this.textBoxAgentName);
            this.panelActionWithAgents.Location = new System.Drawing.Point(13, 213);
            this.panelActionWithAgents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelActionWithAgents.Name = "panelActionWithAgents";
            this.panelActionWithAgents.Size = new System.Drawing.Size(200, 76);
            this.panelActionWithAgents.TabIndex = 3;
            // 
            // buttonDeleteAgent
            // 
            this.buttonDeleteAgent.Location = new System.Drawing.Point(104, 43);
            this.buttonDeleteAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteAgent.Name = "buttonDeleteAgent";
            this.buttonDeleteAgent.Size = new System.Drawing.Size(82, 22);
            this.buttonDeleteAgent.TabIndex = 1;
            this.buttonDeleteAgent.Text = "Удалить";
            this.buttonDeleteAgent.UseVisualStyleBackColor = true;
            this.buttonDeleteAgent.Click += new System.EventHandler(this.button2DeleteAgent_Click);
            // 
            // buttonAddAgent
            // 
            this.buttonAddAgent.Location = new System.Drawing.Point(9, 43);
            this.buttonAddAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddAgent.Name = "buttonAddAgent";
            this.buttonAddAgent.Size = new System.Drawing.Size(82, 22);
            this.buttonAddAgent.TabIndex = 1;
            this.buttonAddAgent.Text = "Добавить";
            this.buttonAddAgent.UseVisualStyleBackColor = true;
            this.buttonAddAgent.Click += new System.EventHandler(this.buttonAddAgent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxAgentName
            // 
            this.textBoxAgentName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAgentName.Location = new System.Drawing.Point(90, 5);
            this.textBoxAgentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAgentName.Name = "textBoxAgentName";
            this.textBoxAgentName.Size = new System.Drawing.Size(97, 26);
            this.textBoxAgentName.TabIndex = 2;
            // 
            // groupBoxAgents
            // 
            this.groupBoxAgents.Controls.Add(this.richTextBoxAgentsNames);
            this.groupBoxAgents.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAgents.Location = new System.Drawing.Point(13, 11);
            this.groupBoxAgents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAgents.Name = "groupBoxAgents";
            this.groupBoxAgents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAgents.Size = new System.Drawing.Size(200, 197);
            this.groupBoxAgents.TabIndex = 1;
            this.groupBoxAgents.TabStop = false;
            this.groupBoxAgents.Text = "Список диспетчеров";
            // 
            // richTextBoxAgentsNames
            // 
            this.richTextBoxAgentsNames.Location = new System.Drawing.Point(10, 22);
            this.richTextBoxAgentsNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxAgentsNames.Name = "richTextBoxAgentsNames";
            this.richTextBoxAgentsNames.Size = new System.Drawing.Size(182, 159);
            this.richTextBoxAgentsNames.TabIndex = 0;
            this.richTextBoxAgentsNames.Text = "";
            // 
            // groupBoxLogsConsole
            // 
            this.groupBoxLogsConsole.Controls.Add(this.richTextBoxLogConsole);
            this.groupBoxLogsConsole.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxLogsConsole.Location = new System.Drawing.Point(256, 16);
            this.groupBoxLogsConsole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogsConsole.Name = "groupBoxLogsConsole";
            this.groupBoxLogsConsole.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLogsConsole.Size = new System.Drawing.Size(631, 296);
            this.groupBoxLogsConsole.TabIndex = 1;
            this.groupBoxLogsConsole.TabStop = false;
            this.groupBoxLogsConsole.Text = "Консоль логов";
            // 
            // richTextBoxLogConsole
            // 
            this.richTextBoxLogConsole.Location = new System.Drawing.Point(11, 20);
            this.richTextBoxLogConsole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxLogConsole.Name = "richTextBoxLogConsole";
            this.richTextBoxLogConsole.Size = new System.Drawing.Size(606, 259);
            this.richTextBoxLogConsole.TabIndex = 0;
            this.richTextBoxLogConsole.Text = "";
            // 
            // panelControlPanel
            // 
            this.panelControlPanel.Controls.Add(this.groupBoxConsoleLogMessageTypes);
            this.panelControlPanel.Controls.Add(this.buttonAddConnection);
            this.panelControlPanel.Location = new System.Drawing.Point(908, 16);
            this.panelControlPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControlPanel.Name = "panelControlPanel";
            this.panelControlPanel.Size = new System.Drawing.Size(200, 296);
            this.panelControlPanel.TabIndex = 2;
            // 
            // groupBoxConsoleLogMessageTypes
            // 
            this.groupBoxConsoleLogMessageTypes.Controls.Add(this.checkBoxConsoleLogsNC);
            this.groupBoxConsoleLogMessageTypes.Controls.Add(this.checkBoxConsoleLogsEC);
            this.groupBoxConsoleLogMessageTypes.Controls.Add(this.checkBoxConsoleLogsAC);
            this.groupBoxConsoleLogMessageTypes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxConsoleLogMessageTypes.Location = new System.Drawing.Point(3, 20);
            this.groupBoxConsoleLogMessageTypes.Name = "groupBoxConsoleLogMessageTypes";
            this.groupBoxConsoleLogMessageTypes.Size = new System.Drawing.Size(190, 73);
            this.groupBoxConsoleLogMessageTypes.TabIndex = 1;
            this.groupBoxConsoleLogMessageTypes.TabStop = false;
            this.groupBoxConsoleLogMessageTypes.Text = "Тип сообщений консоли";
            // 
            // buttonAddConnection
            // 
            this.buttonAddConnection.Location = new System.Drawing.Point(10, 115);
            this.buttonAddConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddConnection.Name = "buttonAddConnection";
            this.buttonAddConnection.Size = new System.Drawing.Size(181, 29);
            this.buttonAddConnection.TabIndex = 0;
            this.buttonAddConnection.Text = "Добавить соединение";
            this.buttonAddConnection.UseVisualStyleBackColor = true;
            this.buttonAddConnection.Click += new System.EventHandler(this.buttonAddConnection_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxConsoleLogsAC
            // 
            this.checkBoxConsoleLogsAC.AutoSize = true;
            this.checkBoxConsoleLogsAC.Location = new System.Drawing.Point(12, 34);
            this.checkBoxConsoleLogsAC.Name = "checkBoxConsoleLogsAC";
            this.checkBoxConsoleLogsAC.Size = new System.Drawing.Size(46, 24);
            this.checkBoxConsoleLogsAC.TabIndex = 4;
            this.checkBoxConsoleLogsAC.Text = "AC";
            this.checkBoxConsoleLogsAC.UseVisualStyleBackColor = true;
            this.checkBoxConsoleLogsAC.CheckedChanged += new System.EventHandler(this.checkBoxConsoleLogsAC_CheckedChanged);
            // 
            // checkBoxConsoleLogsEC
            // 
            this.checkBoxConsoleLogsEC.AutoSize = true;
            this.checkBoxConsoleLogsEC.Location = new System.Drawing.Point(71, 34);
            this.checkBoxConsoleLogsEC.Name = "checkBoxConsoleLogsEC";
            this.checkBoxConsoleLogsEC.Size = new System.Drawing.Size(46, 24);
            this.checkBoxConsoleLogsEC.TabIndex = 5;
            this.checkBoxConsoleLogsEC.Text = "EC";
            this.checkBoxConsoleLogsEC.UseVisualStyleBackColor = true;
            this.checkBoxConsoleLogsEC.CheckedChanged += new System.EventHandler(this.checkBoxConsoleLogsEC_CheckedChanged);
            // 
            // checkBoxConsoleLogsNC
            // 
            this.checkBoxConsoleLogsNC.AutoSize = true;
            this.checkBoxConsoleLogsNC.Location = new System.Drawing.Point(132, 34);
            this.checkBoxConsoleLogsNC.Name = "checkBoxConsoleLogsNC";
            this.checkBoxConsoleLogsNC.Size = new System.Drawing.Size(46, 24);
            this.checkBoxConsoleLogsNC.TabIndex = 6;
            this.checkBoxConsoleLogsNC.Text = "NC";
            this.checkBoxConsoleLogsNC.UseVisualStyleBackColor = true;
            this.checkBoxConsoleLogsNC.CheckedChanged += new System.EventHandler(this.checkBoxConsoleLogsNC_CheckedChanged);
            // 
            // FormCallCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 330);
            this.Controls.Add(this.panelControlPanel);
            this.Controls.Add(this.groupBoxLogsConsole);
            this.Controls.Add(this.panelAgents);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCallCenter";
            this.Text = "Телефонная станция";
            this.panelAgents.ResumeLayout(false);
            this.panelActionWithAgents.ResumeLayout(false);
            this.panelActionWithAgents.PerformLayout();
            this.groupBoxAgents.ResumeLayout(false);
            this.groupBoxLogsConsole.ResumeLayout(false);
            this.panelControlPanel.ResumeLayout(false);
            this.groupBoxConsoleLogMessageTypes.ResumeLayout(false);
            this.groupBoxConsoleLogMessageTypes.PerformLayout();
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
        private GroupBox groupBoxConsoleLogMessageTypes;
        private CheckBox checkBoxConsoleLogsNC;
        private CheckBox checkBoxConsoleLogsEC;
        private CheckBox checkBoxConsoleLogsAC;
    }
}