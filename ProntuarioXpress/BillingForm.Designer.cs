namespace UI;

partial class BillingForm
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
        wasPaidCheckBox = new CheckBox();
        payDayDateTimePicker = new DateTimePicker();
        payDayLabel = new Label();
        ammountDueNumericUpDown = new NumericUpDown();
        ammountDueLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)ammountDueNumericUpDown).BeginInit();
        SuspendLayout();
        // 
        // wasPaidCheckBox
        // 
        wasPaidCheckBox.AutoSize = true;
        wasPaidCheckBox.CheckAlign = ContentAlignment.MiddleRight;
        wasPaidCheckBox.Location = new Point(76, 214);
        wasPaidCheckBox.Margin = new Padding(3, 2, 3, 2);
        wasPaidCheckBox.Name = "wasPaidCheckBox";
        wasPaidCheckBox.Size = new Size(113, 29);
        wasPaidCheckBox.TabIndex = 23;
        wasPaidCheckBox.Text = "Foi pago?";
        wasPaidCheckBox.UseVisualStyleBackColor = true;
        // 
        // payDayDateTimePicker
        // 
        payDayDateTimePicker.Format = DateTimePickerFormat.Short;
        payDayDateTimePicker.Location = new Point(197, 169);
        payDayDateTimePicker.Margin = new Padding(3, 2, 3, 2);
        payDayDateTimePicker.Name = "payDayDateTimePicker";
        payDayDateTimePicker.Size = new Size(115, 33);
        payDayDateTimePicker.TabIndex = 22;
        // 
        // payDayLabel
        // 
        payDayLabel.AutoSize = true;
        payDayLabel.Location = new Point(13, 177);
        payDayLabel.Margin = new Padding(5, 0, 5, 0);
        payDayLabel.Name = "payDayLabel";
        payDayLabel.Size = new Size(172, 25);
        payDayLabel.TabIndex = 21;
        payDayLabel.Text = "Dia do pagamento:";
        // 
        // ammountDueNumericUpDown
        // 
        ammountDueNumericUpDown.DecimalPlaces = 2;
        ammountDueNumericUpDown.Location = new Point(197, 126);
        ammountDueNumericUpDown.Margin = new Padding(3, 2, 3, 2);
        ammountDueNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        ammountDueNumericUpDown.Name = "ammountDueNumericUpDown";
        ammountDueNumericUpDown.Size = new Size(115, 33);
        ammountDueNumericUpDown.TabIndex = 20;
        // 
        // ammountDueLabel
        // 
        ammountDueLabel.AutoSize = true;
        ammountDueLabel.Location = new Point(54, 128);
        ammountDueLabel.Margin = new Padding(5, 0, 5, 0);
        ammountDueLabel.Name = "ammountDueLabel";
        ammountDueLabel.Size = new Size(135, 25);
        ammountDueLabel.TabIndex = 19;
        ammountDueLabel.Text = "Valor cobrado:";
        // 
        // BillingForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(785, 612);
        Controls.Add(wasPaidCheckBox);
        Controls.Add(payDayDateTimePicker);
        Controls.Add(payDayLabel);
        Controls.Add(ammountDueNumericUpDown);
        Controls.Add(ammountDueLabel);
        Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5, 5, 5, 5);
        Name = "BillingForm";
        Text = "BillingForm";
        ((System.ComponentModel.ISupportInitialize)ammountDueNumericUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CheckBox wasPaidCheckBox;
    private DateTimePicker payDayDateTimePicker;
    private Label payDayLabel;
    private NumericUpDown ammountDueNumericUpDown;
    private Label ammountDueLabel;
}