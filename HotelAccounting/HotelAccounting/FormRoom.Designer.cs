namespace HotelAccounting
{
    partial class FormRoom
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
            labelRoomNumber = new Label();
            labelStatus = new Label();
            labelFloor = new Label();
            numericUpDownRoomNumber = new NumericUpDown();
            numericUpDownFloor = new NumericUpDown();
            comboBoxStatus = new ComboBox();
            labelCategory = new Label();
            comboBoxCategory = new ComboBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRoomNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloor).BeginInit();
            SuspendLayout();
            // 
            // labelRoomNumber
            // 
            labelRoomNumber.AutoSize = true;
            labelRoomNumber.Location = new Point(34, 27);
            labelRoomNumber.Name = "labelRoomNumber";
            labelRoomNumber.Size = new Size(97, 15);
            labelRoomNumber.TabIndex = 0;
            labelRoomNumber.Text = "Номер комнаты";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(34, 116);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(43, 15);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Статус";
            // 
            // labelFloor
            // 
            labelFloor.AutoSize = true;
            labelFloor.Location = new Point(34, 66);
            labelFloor.Name = "labelFloor";
            labelFloor.Size = new Size(34, 15);
            labelFloor.TabIndex = 3;
            labelFloor.Text = "Этаж";
            // 
            // numericUpDownRoomNumber
            // 
            numericUpDownRoomNumber.Location = new Point(161, 19);
            numericUpDownRoomNumber.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownRoomNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownRoomNumber.Name = "numericUpDownRoomNumber";
            numericUpDownRoomNumber.Size = new Size(120, 23);
            numericUpDownRoomNumber.TabIndex = 4;
            numericUpDownRoomNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownFloor
            // 
            numericUpDownFloor.Location = new Point(161, 58);
            numericUpDownFloor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownFloor.Name = "numericUpDownFloor";
            numericUpDownFloor.Size = new Size(120, 23);
            numericUpDownFloor.TabIndex = 5;
            numericUpDownFloor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(161, 113);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 6;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(34, 156);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(63, 15);
            labelCategory.TabIndex = 7;
            labelCategory.Text = "Категория";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(161, 148);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(121, 23);
            comboBoxCategory.TabIndex = 8;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(161, 202);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(34, 202);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // FormRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 258);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(comboBoxCategory);
            Controls.Add(labelCategory);
            Controls.Add(comboBoxStatus);
            Controls.Add(numericUpDownFloor);
            Controls.Add(numericUpDownRoomNumber);
            Controls.Add(labelFloor);
            Controls.Add(labelStatus);
            Controls.Add(labelRoomNumber);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormRoom";
            Text = "Номер";
            ((System.ComponentModel.ISupportInitialize)numericUpDownRoomNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFloor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRoomNumber;
        private Label labelStatus;
        private Label labelFloor;
        private NumericUpDown numericUpDownRoomNumber;
        private NumericUpDown numericUpDownFloor;
        private ComboBox comboBoxStatus;
        private Label labelCategory;
        private ComboBox comboBoxCategory;
        private Button buttonCancel;
        private Button buttonSave;
    }
}