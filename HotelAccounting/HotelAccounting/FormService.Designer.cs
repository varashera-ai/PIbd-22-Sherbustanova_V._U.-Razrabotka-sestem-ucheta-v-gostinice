namespace HotelAccounting
{
    partial class FormService
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
            textBoxName = new TextBox();
            labelName = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            labelPrice = new Label();
            labelService = new Label();
            numericUpDownPrice = new NumericUpDown();
            checkedListBoxServiceType = new CheckedListBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(166, 140);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(35, 148);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 15);
            labelName.TabIndex = 4;
            labelName.Text = "Название";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(35, 184);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(35, 15);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "Цена";
            // 
            // labelService
            // 
            labelService.AutoSize = true;
            labelService.Location = new Point(35, 26);
            labelService.Name = "labelService";
            labelService.Size = new Size(68, 15);
            labelService.TabIndex = 8;
            labelService.Text = "Тип услуги";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(166, 176);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 9;
            numericUpDownPrice.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // checkedListBoxServiceType
            // 
            checkedListBoxServiceType.CheckOnClick = true;
            checkedListBoxServiceType.FormattingEnabled = true;
            checkedListBoxServiceType.Location = new Point(166, 26);
            checkedListBoxServiceType.Name = "checkedListBoxServiceType";
            checkedListBoxServiceType.Size = new Size(120, 94);
            checkedListBoxServiceType.TabIndex = 10;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(35, 239);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(141, 239);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 291);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(checkedListBoxServiceType);
            Controls.Add(numericUpDownPrice);
            Controls.Add(labelService);
            Controls.Add(labelPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormService";
            Text = "Услуга";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label labelName;
        private ContextMenuStrip contextMenuStrip1;
        private Label labelPrice;
        private Label labelService;
        private NumericUpDown numericUpDownPrice;
        private CheckedListBox checkedListBoxServiceType;
        private Button buttonSave;
        private Button buttonCancel;
    }
}