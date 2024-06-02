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
            components = new System.ComponentModel.Container();
            saveButton = new Button();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            pacientViewItemBindingSource = new BindingSource(components);
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
            meanBillValueLabel = new Label();
            meanBillValueLNumericUpDown = new NumericUpDown();
            exportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pacientViewItemBindingSource).BeginInit();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)meanBillValueLNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveButton.Cursor = Cursors.Hand;
            saveButton.Location = new Point(21, 259);
            saveButton.Margin = new Padding(5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(160, 40);
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
            nameTextBox.DataBindings.Add(new Binding("Text", pacientViewItemBindingSource, "FullName", true));
            nameTextBox.Location = new Point(209, 20);
            nameTextBox.Margin = new Padding(5);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(312, 33);
            nameTextBox.TabIndex = 4;
            // 
            // pacientViewItemBindingSource
            // 
            pacientViewItemBindingSource.DataSource = typeof(ViewItems.PacientViewItem);
            // 
            // cpfTextBox
            // 
            cpfTextBox.DataBindings.Add(new Binding("Text", pacientViewItemBindingSource, "CPF", true));
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
            birthdayDateTimePicker.DataBindings.Add(new Binding("Value", pacientViewItemBindingSource, "BirthDate", true));
            birthdayDateTimePicker.Format = DateTimePickerFormat.Short;
            birthdayDateTimePicker.Location = new Point(209, 117);
            birthdayDateTimePicker.Margin = new Padding(5);
            birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            birthdayDateTimePicker.RightToLeft = RightToLeft.No;
            birthdayDateTimePicker.Size = new Size(312, 33);
            birthdayDateTimePicker.TabIndex = 8;
            // 
            // closelButton
            // 
            closelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closelButton.Cursor = Cursors.Hand;
            closelButton.Location = new Point(191, 259);
            closelButton.Margin = new Padding(5);
            closelButton.Name = "closelButton";
            closelButton.Size = new Size(160, 40);
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
            ageTextBox.DataBindings.Add(new Binding("Text", pacientViewItemBindingSource, "LongAge", true));
            ageTextBox.Location = new Point(209, 167);
            ageTextBox.Margin = new Padding(5);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.ReadOnly = true;
            ageTextBox.Size = new Size(312, 33);
            ageTextBox.TabIndex = 11;
            // 
            // appointmentsListBox
            // 
            appointmentsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            appointmentsListBox.FormattingEnabled = true;
            appointmentsListBox.ItemHeight = 25;
            appointmentsListBox.Location = new Point(550, 68);
            appointmentsListBox.Margin = new Padding(5);
            appointmentsListBox.Name = "appointmentsListBox";
            appointmentsListBox.Size = new Size(366, 129);
            appointmentsListBox.TabIndex = 12;
            appointmentsListBox.SelectedIndexChanged += appointmentsListBox_SelectedIndexChanged;
            appointmentsListBox.DoubleClick += appointmentsListBox_DoubleClick;
            // 
            // appointmentsLabel
            // 
            appointmentsLabel.Location = new Point(550, 25);
            appointmentsLabel.Margin = new Padding(5, 0, 5, 0);
            appointmentsLabel.Name = "appointmentsLabel";
            appointmentsLabel.Size = new Size(381, 25);
            appointmentsLabel.TabIndex = 13;
            appointmentsLabel.Text = "Atendimentos realizados:";
            appointmentsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pacientExtraInfoButton
            // 
            pacientExtraInfoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pacientExtraInfoButton.Cursor = Cursors.Hand;
            pacientExtraInfoButton.Location = new Point(361, 259);
            pacientExtraInfoButton.Margin = new Padding(5);
            pacientExtraInfoButton.Name = "pacientExtraInfoButton";
            pacientExtraInfoButton.Size = new Size(160, 40);
            pacientExtraInfoButton.TabIndex = 14;
            pacientExtraInfoButton.Text = "Informações";
            pacientExtraInfoButton.UseVisualStyleBackColor = true;
            pacientExtraInfoButton.Click += pacientExtraInfoButton_Click;
            // 
            // openAppointMentButton
            // 
            openAppointMentButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            openAppointMentButton.Cursor = Cursors.Hand;
            openAppointMentButton.Location = new Point(745, 259);
            openAppointMentButton.Margin = new Padding(5);
            openAppointMentButton.Name = "openAppointMentButton";
            openAppointMentButton.Size = new Size(160, 60);
            openAppointMentButton.TabIndex = 15;
            openAppointMentButton.Text = "Abrir Atendimento";
            openAppointMentButton.UseVisualStyleBackColor = true;
            openAppointMentButton.Click += openAppointmentButton_Click;
            // 
            // newAppointmentButton
            // 
            newAppointmentButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newAppointmentButton.Cursor = Cursors.Hand;
            newAppointmentButton.Location = new Point(579, 259);
            newAppointmentButton.Margin = new Padding(5);
            newAppointmentButton.Name = "newAppointmentButton";
            newAppointmentButton.Size = new Size(160, 60);
            newAppointmentButton.TabIndex = 16;
            newAppointmentButton.Text = "Novo Atendimento";
            newAppointmentButton.UseVisualStyleBackColor = true;
            newAppointmentButton.Click += newAppointmentBtton_Click;
            // 
            // statusStrip
            // 
            statusStrip.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 324);
            statusStrip.MinimumSize = new Size(0, 30);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(923, 30);
            statusStrip.TabIndex = 17;
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 25);
            // 
            // meanBillValueLabel
            // 
            meanBillValueLabel.AutoSize = true;
            meanBillValueLabel.Location = new Point(25, 213);
            meanBillValueLabel.Name = "meanBillValueLabel";
            meanBillValueLabel.Size = new Size(179, 25);
            meanBillValueLabel.TabIndex = 18;
            meanBillValueLabel.Text = "Cobrança esperada:";
            // 
            // meanBillValueLNumericUpDown
            // 
            meanBillValueLNumericUpDown.DecimalPlaces = 2;
            meanBillValueLNumericUpDown.Location = new Point(209, 213);
            meanBillValueLNumericUpDown.Name = "meanBillValueLNumericUpDown";
            meanBillValueLNumericUpDown.Size = new Size(120, 33);
            meanBillValueLNumericUpDown.TabIndex = 19;
            // 
            // exportButton
            // 
            exportButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exportButton.Location = new Point(745, 211);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(160, 40);
            exportButton.TabIndex = 20;
            exportButton.Text = "Exportar Excel...";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // PacientForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 354);
            Controls.Add(exportButton);
            Controls.Add(meanBillValueLNumericUpDown);
            Controls.Add(meanBillValueLabel);
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
            ((System.ComponentModel.ISupportInitialize)pacientViewItemBindingSource).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)meanBillValueLNumericUpDown).EndInit();
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
        private BindingSource pacientViewItemBindingSource;
        private Label meanBillValueLabel;
        private NumericUpDown meanBillValueLNumericUpDown;
        private Button exportButton;
    }
}