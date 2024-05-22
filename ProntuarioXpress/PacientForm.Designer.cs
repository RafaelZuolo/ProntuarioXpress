namespace UI
{
    partial class PacientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveButton = new Button();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            cpfTextBox = new TextBox();
            cpfLabel = new Label();
            birthDateLabel = new Label();
            birthDaydateTimePicker = new DateTimePicker();
            closelButton = new Button();
            ageLabel = new Label();
            ageTextBox = new TextBox();
            appointmentsListBox = new ListBox();
            appointmentsLabel = new Label();
            pacientExtraInfoButton = new Button();
            openAppointMentButton = new Button();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Cursor = Cursors.Hand;
            saveButton.Location = new Point(29, 143);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(100, 23);
            saveButton.TabIndex = 2;
            saveButton.Text = "Salvar";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(9, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(120, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Nome :";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(133, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 23);
            nameTextBox.TabIndex = 4;
            // 
            // cpfTextBox
            // 
            cpfTextBox.Location = new Point(133, 41);
            cpfTextBox.Name = "cpfTextBox";
            cpfTextBox.Size = new Size(200, 23);
            cpfTextBox.TabIndex = 6;
            // 
            // cpfLabel
            // 
            cpfLabel.Location = new Point(12, 44);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new Size(120, 15);
            cpfLabel.TabIndex = 5;
            cpfLabel.Text = "CPF :";
            cpfLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(11, 76);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(118, 15);
            birthDateLabel.TabIndex = 7;
            birthDateLabel.Text = "Data de nascimento :";
            birthDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // birthDaydateTimePicker
            // 
            birthDaydateTimePicker.Location = new Point(133, 70);
            birthDaydateTimePicker.Name = "birthDaydateTimePicker";
            birthDaydateTimePicker.Size = new Size(200, 23);
            birthDaydateTimePicker.TabIndex = 8;
            // 
            // closelButton
            // 
            closelButton.Cursor = Cursors.Hand;
            closelButton.Location = new Point(135, 143);
            closelButton.Name = "closelButton";
            closelButton.Size = new Size(100, 23);
            closelButton.TabIndex = 9;
            closelButton.Text = "Fechar";
            closelButton.UseVisualStyleBackColor = true;
            closelButton.Click += closelButton_Click;
            // 
            // ageLabel
            // 
            ageLabel.Location = new Point(9, 102);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(120, 15);
            ageLabel.TabIndex = 10;
            ageLabel.Text = "Idade :";
            ageLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(133, 99);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.ReadOnly = true;
            ageTextBox.Size = new Size(200, 23);
            ageTextBox.TabIndex = 11;
            // 
            // appointmentsListBox
            // 
            appointmentsListBox.FormattingEnabled = true;
            appointmentsListBox.ItemHeight = 15;
            appointmentsListBox.Location = new Point(350, 41);
            appointmentsListBox.Name = "appointmentsListBox";
            appointmentsListBox.Size = new Size(244, 79);
            appointmentsListBox.TabIndex = 12;
            // 
            // appointmentsLabel
            // 
            appointmentsLabel.Location = new Point(350, 12);
            appointmentsLabel.Name = "appointmentsLabel";
            appointmentsLabel.Size = new Size(120, 15);
            appointmentsLabel.TabIndex = 13;
            appointmentsLabel.Text = "Sessões realizadas";
            appointmentsLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pacientExtraInfoButton
            // 
            pacientExtraInfoButton.Cursor = Cursors.Hand;
            pacientExtraInfoButton.Location = new Point(241, 143);
            pacientExtraInfoButton.Name = "pacientExtraInfoButton";
            pacientExtraInfoButton.Size = new Size(100, 23);
            pacientExtraInfoButton.TabIndex = 14;
            pacientExtraInfoButton.Text = "Informações";
            pacientExtraInfoButton.UseVisualStyleBackColor = true;
            pacientExtraInfoButton.Click += pacientExtraInfoButton_Click;
            // 
            // openAppointMentButton
            // 
            openAppointMentButton.Cursor = Cursors.Hand;
            openAppointMentButton.Location = new Point(494, 141);
            openAppointMentButton.Name = "openAppointMentButton";
            openAppointMentButton.Size = new Size(100, 23);
            openAppointMentButton.TabIndex = 15;
            openAppointMentButton.Text = "Abrir Sessão";
            openAppointMentButton.UseVisualStyleBackColor = true;
            openAppointMentButton.Click += openAppointmentButton_Click;
            // 
            // PacientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 176);
            Controls.Add(openAppointMentButton);
            Controls.Add(pacientExtraInfoButton);
            Controls.Add(appointmentsLabel);
            Controls.Add(appointmentsListBox);
            Controls.Add(ageTextBox);
            Controls.Add(ageLabel);
            Controls.Add(closelButton);
            Controls.Add(birthDaydateTimePicker);
            Controls.Add(birthDateLabel);
            Controls.Add(cpfTextBox);
            Controls.Add(cpfLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(saveButton);
            Name = "PacientForm";
            Text = "Paciente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button saveButton;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox cpfTextBox;
        private Label cpfLabel;
        private Label birthDateLabel;
        private DateTimePicker birthDaydateTimePicker;
        private Button closelButton;
        private Label ageLabel;
        private TextBox ageTextBox;
        private ListBox appointmentsListBox;
        private Label appointmentsLabel;
        private Button pacientExtraInfoButton;
        private Button openAppointMentButton;
    }
}