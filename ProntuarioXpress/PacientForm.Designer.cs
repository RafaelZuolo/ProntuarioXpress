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
            birthdayDateTimePicker = new DateTimePicker();
            closelButton = new Button();
            ageLabel = new Label();
            ageTextBox = new TextBox();
            appointmentsListBox = new ListBox();
            appointmentsLabel = new Label();
            pacientExtraInfoButton = new Button();
            openAppointMentButton = new Button();
            newAppointmentButton = new Button();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Cursor = Cursors.Hand;
            saveButton.Location = new Point(46, 238);
            saveButton.Margin = new Padding(5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(157, 38);
            saveButton.TabIndex = 2;
            saveButton.Text = "Salvar";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(14, 25);
            nameLabel.Margin = new Padding(5, 0, 5, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(189, 25);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Nome :";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(209, 20);
            nameTextBox.Margin = new Padding(5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(312, 33);
            nameTextBox.TabIndex = 4;
            // 
            // cpfTextBox
            // 
            cpfTextBox.Location = new Point(209, 68);
            cpfTextBox.Margin = new Padding(5);
            cpfTextBox.Name = "cpfTextBox";
            cpfTextBox.Size = new Size(312, 33);
            cpfTextBox.TabIndex = 6;
            // 
            // cpfLabel
            // 
            cpfLabel.Location = new Point(15, 71);
            cpfLabel.Margin = new Padding(5, 0, 5, 0);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new Size(189, 25);
            cpfLabel.TabIndex = 5;
            cpfLabel.Text = "CPF :";
            cpfLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(16, 123);
            birthDateLabel.Margin = new Padding(5, 0, 5, 0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(188, 25);
            birthDateLabel.TabIndex = 7;
            birthDateLabel.Text = "Data de nascimento :";
            birthDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // birthdayDateTimePicker
            // 
            birthdayDateTimePicker.Format = DateTimePickerFormat.Short;
            birthdayDateTimePicker.Location = new Point(209, 117);
            birthdayDateTimePicker.Margin = new Padding(5);
            birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            birthdayDateTimePicker.RightToLeft = RightToLeft.No;
            birthdayDateTimePicker.Size = new Size(312, 33);
            birthdayDateTimePicker.TabIndex = 8;
            birthdayDateTimePicker.ValueChanged += birthdayDateTimePicker_ValueChanged;
            // 
            // closelButton
            // 
            closelButton.Cursor = Cursors.Hand;
            closelButton.Location = new Point(212, 238);
            closelButton.Margin = new Padding(5);
            closelButton.Name = "closelButton";
            closelButton.Size = new Size(157, 38);
            closelButton.TabIndex = 9;
            closelButton.Text = "Fechar";
            closelButton.UseVisualStyleBackColor = true;
            closelButton.Click += closelButton_Click;
            // 
            // ageLabel
            // 
            ageLabel.Location = new Point(14, 170);
            ageLabel.Margin = new Padding(5, 0, 5, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(189, 25);
            ageLabel.TabIndex = 10;
            ageLabel.Text = "Idade :";
            ageLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(209, 165);
            ageTextBox.Margin = new Padding(5);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.ReadOnly = true;
            ageTextBox.Size = new Size(312, 33);
            ageTextBox.TabIndex = 11;
            // 
            // appointmentsListBox
            // 
            appointmentsListBox.FormattingEnabled = true;
            appointmentsListBox.ItemHeight = 25;
            appointmentsListBox.Location = new Point(550, 68);
            appointmentsListBox.Margin = new Padding(5);
            appointmentsListBox.Name = "appointmentsListBox";
            appointmentsListBox.Size = new Size(381, 129);
            appointmentsListBox.TabIndex = 12;
            appointmentsListBox.SelectedIndexChanged += appointmentsListBox_SelectedIndexChanged;
            appointmentsListBox.DoubleClick += appointmentsListBox_DoubleClick;
            // 
            // appointmentsLabel
            // 
            appointmentsLabel.Location = new Point(550, 25);
            appointmentsLabel.Margin = new Padding(5, 0, 5, 0);
            appointmentsLabel.Name = "appointmentsLabel";
            appointmentsLabel.Size = new Size(189, 25);
            appointmentsLabel.TabIndex = 13;
            appointmentsLabel.Text = "Sessões realizadas:";
            appointmentsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pacientExtraInfoButton
            // 
            pacientExtraInfoButton.Cursor = Cursors.Hand;
            pacientExtraInfoButton.Location = new Point(379, 238);
            pacientExtraInfoButton.Margin = new Padding(5);
            pacientExtraInfoButton.Name = "pacientExtraInfoButton";
            pacientExtraInfoButton.Size = new Size(157, 38);
            pacientExtraInfoButton.TabIndex = 14;
            pacientExtraInfoButton.Text = "Informações";
            pacientExtraInfoButton.UseVisualStyleBackColor = true;
            pacientExtraInfoButton.Click += pacientExtraInfoButton_Click;
            // 
            // openAppointMentButton
            // 
            openAppointMentButton.Cursor = Cursors.Hand;
            openAppointMentButton.Location = new Point(776, 235);
            openAppointMentButton.Margin = new Padding(5);
            openAppointMentButton.Name = "openAppointMentButton";
            openAppointMentButton.Size = new Size(157, 38);
            openAppointMentButton.TabIndex = 15;
            openAppointMentButton.Text = "Abrir Sessão";
            openAppointMentButton.UseVisualStyleBackColor = true;
            openAppointMentButton.Click += openAppointmentButton_Click;
            // 
            // newAppointmentButton
            // 
            newAppointmentButton.Cursor = Cursors.Hand;
            newAppointmentButton.Location = new Point(610, 235);
            newAppointmentButton.Margin = new Padding(5);
            newAppointmentButton.Name = "newAppointmentButton";
            newAppointmentButton.Size = new Size(157, 38);
            newAppointmentButton.TabIndex = 16;
            newAppointmentButton.Text = "Nova Sessão";
            newAppointmentButton.UseVisualStyleBackColor = true;
            newAppointmentButton.Click += newAppointmentBtton_Click;
            // 
            // statusStrip
            // 
            statusStrip.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 322);
            statusStrip.MinimumSize = new Size(0, 30);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(949, 22);
            statusStrip.TabIndex = 17;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 17);
            // 
            // PacientForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 344);
            Controls.Add(statusStrip);
            Controls.Add(newAppointmentButton);
            Controls.Add(openAppointMentButton);
            Controls.Add(pacientExtraInfoButton);
            Controls.Add(appointmentsLabel);
            Controls.Add(appointmentsListBox);
            Controls.Add(ageTextBox);
            Controls.Add(ageLabel);
            Controls.Add(closelButton);
            Controls.Add(birthdayDateTimePicker);
            Controls.Add(birthDateLabel);
            Controls.Add(cpfTextBox);
            Controls.Add(cpfLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(saveButton);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "PacientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paciente";
            FormClosing += PacientForm_FormClosing;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
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
        private DateTimePicker birthdayDateTimePicker;
        private Button closelButton;
        private Label ageLabel;
        private TextBox ageTextBox;
        private ListBox appointmentsListBox;
        private Label appointmentsLabel;
        private Button pacientExtraInfoButton;
        private Button openAppointMentButton;
        private Button newAppointmentButton;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
    }
}