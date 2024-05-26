﻿namespace UI
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
            pacientListBox = new ListBox();
            createPacientButton = new Button();
            retrievePacientButton = new Button();
            deletePacientButton = new Button();
            menuStrip1 = new MenuStrip();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pacientListBox
            // 
            pacientListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pacientListBox.FormattingEnabled = true;
            pacientListBox.ItemHeight = 25;
            pacientListBox.Location = new Point(19, 45);
            pacientListBox.Margin = new Padding(5, 5, 5, 5);
            pacientListBox.Name = "pacientListBox";
            pacientListBox.Size = new Size(552, 429);
            pacientListBox.TabIndex = 0;
            pacientListBox.SelectedIndexChanged += pacientListBox_SelectedIndexChanged;
            pacientListBox.DoubleClick += pacientListBox_DoubleClick;
            // 
            // createPacientButton
            // 
            createPacientButton.Location = new Point(19, 487);
            createPacientButton.Margin = new Padding(5, 5, 5, 5);
            createPacientButton.Name = "createPacientButton";
            createPacientButton.Size = new Size(181, 68);
            createPacientButton.TabIndex = 1;
            createPacientButton.Text = "Novo Paciente";
            createPacientButton.UseVisualStyleBackColor = true;
            createPacientButton.Click += createPacientButton_Click;
            // 
            // retrievePacientButton
            // 
            retrievePacientButton.Anchor = AnchorStyles.Top;
            retrievePacientButton.Location = new Point(209, 487);
            retrievePacientButton.Margin = new Padding(5, 5, 5, 5);
            retrievePacientButton.Name = "retrievePacientButton";
            retrievePacientButton.Size = new Size(170, 68);
            retrievePacientButton.TabIndex = 2;
            retrievePacientButton.Text = "Abrir Paciente";
            retrievePacientButton.UseVisualStyleBackColor = true;
            retrievePacientButton.Click += retrievePacientButton_Click;
            // 
            // deletePacientButton
            // 
            deletePacientButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deletePacientButton.Location = new Point(388, 487);
            deletePacientButton.Margin = new Padding(5, 5, 5, 5);
            deletePacientButton.Name = "deletePacientButton";
            deletePacientButton.Size = new Size(185, 68);
            deletePacientButton.TabIndex = 3;
            deletePacientButton.Text = "Deletar Paciente";
            deletePacientButton.UseVisualStyleBackColor = true;
            deletePacientButton.Click += deletePacientButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(586, 25);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1 });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(50, 20);
            sobreToolStripMenuItem.Text = "&Ajuda";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(113, 22);
            aboutToolStripMenuItem1.Text = "&Sobre...";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 563);
            Controls.Add(deletePacientButton);
            Controls.Add(retrievePacientButton);
            Controls.Add(createPacientButton);
            Controls.Add(pacientListBox);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 5, 5, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProntuarioXpress";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox pacientListBox;
        private Button createPacientButton;
        private Button retrievePacientButton;
        private Button deletePacientButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
    }
}
