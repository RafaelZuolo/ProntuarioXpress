namespace UI
{
    partial class CreatePacientForm
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
            createButton = new Button();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            cpfTextBox = new TextBox();
            cpfLabel = new Label();
            birthDateLabel = new Label();
            birthDaydateTimePicker = new DateTimePicker();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Cursor = Cursors.Hand;
            createButton.Location = new Point(93, 116);
            createButton.Name = "createButton";
            createButton.Size = new Size(117, 23);
            createButton.TabIndex = 2;
            createButton.Text = "Criar";
            createButton.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(9, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(120, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Nome Completo :";
            nameLabel.TextAlign = ContentAlignment.MiddleRight;
            nameLabel.Click += label1_Click;
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
            cpfLabel.Location = new Point(9, 49);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new Size(120, 15);
            cpfLabel.TabIndex = 5;
            cpfLabel.Text = "CPF:";
            cpfLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(9, 78);
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
            // cancelButton
            // 
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.Location = new Point(216, 116);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(117, 23);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // CreatePacientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 151);
            Controls.Add(cancelButton);
            Controls.Add(birthDaydateTimePicker);
            Controls.Add(birthDateLabel);
            Controls.Add(cpfTextBox);
            Controls.Add(cpfLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(createButton);
            Name = "CreatePacientForm";
            Text = "Criar novo paciente...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button createButton;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox cpfTextBox;
        private Label cpfLabel;
        private Label birthDateLabel;
        private DateTimePicker birthDaydateTimePicker;
        private Button cancelButton;
    }
}