namespace HotelAccounting
{
    partial class FormRoomCategory
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
            labelName = new Label();
            labelCapacity = new Label();
            labelPrice = new Label();
            textBoxName = new TextBox();
            numericUpDownCapacity = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            buttonCancel = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(49, 37);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Название";
            // 
            // labelCapacity
            // 
            labelCapacity.AutoSize = true;
            labelCapacity.Location = new Point(49, 80);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new Size(80, 15);
            labelCapacity.TabIndex = 1;
            labelCapacity.Text = "Вместимость";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(49, 126);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(79, 15);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Цена за ночь";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(166, 29);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 3;
            // 
            // numericUpDownCapacity
            // 
            numericUpDownCapacity.Location = new Point(166, 72);
            numericUpDownCapacity.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCapacity.Name = "numericUpDownCapacity";
            numericUpDownCapacity.Size = new Size(120, 23);
            numericUpDownCapacity.TabIndex = 4;
            numericUpDownCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(166, 124);
            numericUpDownPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(120, 23);
            numericUpDownPrice.TabIndex = 5;
            numericUpDownPrice.Value = new decimal(new int[] { 300, 0, 0, 0 });
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(176, 176);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(49, 176);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormRoomCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 241);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(numericUpDownPrice);
            Controls.Add(numericUpDownCapacity);
            Controls.Add(textBoxName);
            Controls.Add(labelPrice);
            Controls.Add(labelCapacity);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRoomCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Категории номеров ";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelCapacity;
        private Label labelPrice;
        private TextBox textBoxName;
        private NumericUpDown numericUpDownCapacity;
        private NumericUpDown numericUpDownPrice;
        private Button buttonCancel;
        private Button buttonSave;
    }
}