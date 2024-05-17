namespace ProntuarioXpress
{
    partial class MainForm
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
            listBox1 = new ListBox();
            createPacientButton = new Button();
            retrievePacientButton = new Button();
            deletePacientButton = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(353, 259);
            listBox1.TabIndex = 0;
            // 
            // createPacientButton
            // 
            createPacientButton.Location = new Point(12, 277);
            createPacientButton.Name = "createPacientButton";
            createPacientButton.Size = new Size(115, 41);
            createPacientButton.TabIndex = 1;
            createPacientButton.Text = "Novo Paciente";
            createPacientButton.UseVisualStyleBackColor = true;
            createPacientButton.Click += createPacientButton_Click;
            // 
            // retrievePacientButton
            // 
            retrievePacientButton.Anchor = AnchorStyles.Top;
            retrievePacientButton.Location = new Point(133, 277);
            retrievePacientButton.Name = "retrievePacientButton";
            retrievePacientButton.Size = new Size(108, 41);
            retrievePacientButton.TabIndex = 2;
            retrievePacientButton.Text = "Abrir Paciente";
            retrievePacientButton.UseVisualStyleBackColor = true;
            retrievePacientButton.Click += retrievePacientButton_Click;
            // 
            // deletePacientButton
            // 
            deletePacientButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deletePacientButton.Location = new Point(247, 277);
            deletePacientButton.Name = "deletePacientButton";
            deletePacientButton.Size = new Size(118, 41);
            deletePacientButton.TabIndex = 3;
            deletePacientButton.Text = "Deletar Paciente";
            deletePacientButton.UseVisualStyleBackColor = true;
            deletePacientButton.Click += deletePacientButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 350);
            Controls.Add(deletePacientButton);
            Controls.Add(retrievePacientButton);
            Controls.Add(createPacientButton);
            Controls.Add(listBox1);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button createPacientButton;
        private Button retrievePacientButton;
        private Button deletePacientButton;
    }
}
