namespace UI
{
    partial class AppointmentForm
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
            appointmentLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            extraInfosLabel = new Label();
            extraInfosRichTextBox = new RichTextBox();
            ammountDueLabel = new Label();
            ammountDueNumericUpDown = new NumericUpDown();
            payDayDateTimePicker = new DateTimePicker();
            payDayLabel = new Label();
            wasPaidCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)ammountDueNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // appointmentLabel
            // 
            appointmentLabel.AutoSize = true;
            appointmentLabel.Location = new Point(109, 16);
            appointmentLabel.Margin = new Padding(5, 0, 5, 0);
            appointmentLabel.Name = "appointmentLabel";
            appointmentLabel.Size = new Size(141, 25);
            appointmentLabel.TabIndex = 0;
            appointmentLabel.Text = "Data da sessão:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(258, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(311, 33);
            dateTimePicker1.TabIndex = 1;
            // 
            // extraInfosLabel
            // 
            extraInfosLabel.AutoSize = true;
            extraInfosLabel.Location = new Point(14, 76);
            extraInfosLabel.Name = "extraInfosLabel";
            extraInfosLabel.Size = new Size(238, 25);
            extraInfosLabel.TabIndex = 2;
            extraInfosLabel.Text = "Ocorridos do atendimento:";
            // 
            // extraInfosRichTextBox
            // 
            extraInfosRichTextBox.Location = new Point(258, 73);
            extraInfosRichTextBox.Name = "extraInfosRichTextBox";
            extraInfosRichTextBox.Size = new Size(311, 179);
            extraInfosRichTextBox.TabIndex = 3;
            extraInfosRichTextBox.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ";
            // 
            // ammountDueLabel
            // 
            ammountDueLabel.AutoSize = true;
            ammountDueLabel.Location = new Point(631, 16);
            ammountDueLabel.Margin = new Padding(5, 0, 5, 0);
            ammountDueLabel.Name = "ammountDueLabel";
            ammountDueLabel.Size = new Size(135, 25);
            ammountDueLabel.TabIndex = 4;
            ammountDueLabel.Text = "Valor cobrado:";
            // 
            // ammountDueNumericUpDown
            // 
            ammountDueNumericUpDown.DecimalPlaces = 2;
            ammountDueNumericUpDown.Location = new Point(774, 14);
            ammountDueNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ammountDueNumericUpDown.Name = "ammountDueNumericUpDown";
            ammountDueNumericUpDown.Size = new Size(125, 33);
            ammountDueNumericUpDown.TabIndex = 6;
            ammountDueNumericUpDown.ValueChanged += ammountDueNumericUpDown_ValueChanged;
            // 
            // payDayDateTimePicker
            // 
            payDayDateTimePicker.Format = DateTimePickerFormat.Short;
            payDayDateTimePicker.Location = new Point(774, 73);
            payDayDateTimePicker.Name = "payDayDateTimePicker";
            payDayDateTimePicker.Size = new Size(125, 33);
            payDayDateTimePicker.TabIndex = 8;
            // 
            // payDayLabel
            // 
            payDayLabel.AutoSize = true;
            payDayLabel.Location = new Point(594, 76);
            payDayLabel.Margin = new Padding(5, 0, 5, 0);
            payDayLabel.Name = "payDayLabel";
            payDayLabel.Size = new Size(172, 25);
            payDayLabel.TabIndex = 7;
            payDayLabel.Text = "Dia do pagamento:";
            // 
            // wasPaidCheckBox
            // 
            wasPaidCheckBox.AutoSize = true;
            wasPaidCheckBox.Location = new Point(905, 78);
            wasPaidCheckBox.Name = "wasPaidCheckBox";
            wasPaidCheckBox.Size = new Size(113, 29);
            wasPaidCheckBox.TabIndex = 9;
            wasPaidCheckBox.Text = "Foi pago?";
            wasPaidCheckBox.UseVisualStyleBackColor = true;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 267);
            Controls.Add(wasPaidCheckBox);
            Controls.Add(payDayDateTimePicker);
            Controls.Add(payDayLabel);
            Controls.Add(ammountDueNumericUpDown);
            Controls.Add(ammountDueLabel);
            Controls.Add(extraInfosRichTextBox);
            Controls.Add(extraInfosLabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(appointmentLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "AppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppointmentForm";
            Load += AppointmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)ammountDueNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appointmentLabel;
        private DateTimePicker dateTimePicker1;
        private Label extraInfosLabel;
        private RichTextBox extraInfosRichTextBox;
        private Label ammountDueLabel;
        private NumericUpDown ammountDueNumericUpDown;
        private DateTimePicker payDayDateTimePicker;
        private Label payDayLabel;
        private CheckBox wasPaidCheckBox;
    }
}