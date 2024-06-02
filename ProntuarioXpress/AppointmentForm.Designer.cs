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
            components = new System.ComponentModel.Container();
            appointmentLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            appointmentViewItemBindingSource = new BindingSource(components);
            extraInfosLabel = new Label();
            extraInfosRichTextBox = new RichTextBox();
            appointmentExtraInfoButton = new Button();
            closeButton = new Button();
            saveButton = new Button();
            billingButton = new Button();
            ((System.ComponentModel.ISupportInitialize)appointmentViewItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // appointmentLabel
            // 
            appointmentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            appointmentLabel.AutoSize = true;
            appointmentLabel.Location = new Point(56, 16);
            appointmentLabel.Margin = new Padding(5, 0, 5, 0);
            appointmentLabel.Name = "appointmentLabel";
            appointmentLabel.Size = new Size(194, 25);
            appointmentLabel.TabIndex = 0;
            appointmentLabel.Text = "Data do atendimento:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Value", appointmentViewItemBindingSource, "Date", true));
            dateTimePicker1.Location = new Point(258, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(311, 33);
            dateTimePicker1.TabIndex = 1;
            // 
            // appointmentViewItemBindingSource
            // 
            appointmentViewItemBindingSource.DataSource = typeof(ViewItems.AppointmentViewItem);
            // 
            // extraInfosLabel
            // 
            extraInfosLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            extraInfosLabel.AutoSize = true;
            extraInfosLabel.Location = new Point(14, 54);
            extraInfosLabel.Name = "extraInfosLabel";
            extraInfosLabel.Size = new Size(238, 25);
            extraInfosLabel.TabIndex = 2;
            extraInfosLabel.Text = "Ocorridos do atendimento:";
            // 
            // extraInfosRichTextBox
            // 
            extraInfosRichTextBox.DataBindings.Add(new Binding("Text", appointmentViewItemBindingSource, "Occurrences", true));
            extraInfosRichTextBox.Location = new Point(258, 51);
            extraInfosRichTextBox.Name = "extraInfosRichTextBox";
            extraInfosRichTextBox.Size = new Size(500, 273);
            extraInfosRichTextBox.TabIndex = 3;
            extraInfosRichTextBox.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ";
            // 
            // appointmentExtraInfoButton
            // 
            appointmentExtraInfoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            appointmentExtraInfoButton.Cursor = Cursors.Hand;
            appointmentExtraInfoButton.Location = new Point(354, 355);
            appointmentExtraInfoButton.Margin = new Padding(5);
            appointmentExtraInfoButton.Name = "appointmentExtraInfoButton";
            appointmentExtraInfoButton.Size = new Size(160, 40);
            appointmentExtraInfoButton.TabIndex = 17;
            appointmentExtraInfoButton.Text = "Informações";
            appointmentExtraInfoButton.UseVisualStyleBackColor = true;
            appointmentExtraInfoButton.Click += appointmentExtraInfoButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeButton.Cursor = Cursors.Hand;
            closeButton.Location = new Point(184, 355);
            closeButton.Margin = new Padding(5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(160, 40);
            closeButton.TabIndex = 16;
            closeButton.Text = "Fechar";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveButton.Cursor = Cursors.Hand;
            saveButton.Location = new Point(14, 355);
            saveButton.Margin = new Padding(5);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(160, 40);
            saveButton.TabIndex = 15;
            saveButton.Text = "Salvar";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // billingButton
            // 
            billingButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            billingButton.Cursor = Cursors.Hand;
            billingButton.Location = new Point(598, 355);
            billingButton.Margin = new Padding(5);
            billingButton.Name = "billingButton";
            billingButton.Size = new Size(160, 40);
            billingButton.TabIndex = 18;
            billingButton.Text = "Cobrança";
            billingButton.UseVisualStyleBackColor = true;
            billingButton.Click += billingButton_Click;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 409);
            Controls.Add(billingButton);
            Controls.Add(appointmentExtraInfoButton);
            Controls.Add(closeButton);
            Controls.Add(saveButton);
            Controls.Add(extraInfosRichTextBox);
            Controls.Add(extraInfosLabel);
            Controls.Add(dateTimePicker1);
            Controls.Add(appointmentLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "AppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atendimento";
            Load += AppointmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentViewItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label appointmentLabel;
        private DateTimePicker dateTimePicker1;
        private Label extraInfosLabel;
        private RichTextBox extraInfosRichTextBox;
        private BindingSource appointmentViewItemBindingSource;
        private Button appointmentExtraInfoButton;
        private Button closeButton;
        private Button saveButton;
        private Button billingButton;
    }
}