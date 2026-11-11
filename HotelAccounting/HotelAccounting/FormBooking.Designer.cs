namespace HotelAccounting
{
    partial class FormBooking
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
            comboBoxGuest = new ComboBox();
            labelGuest = new Label();
            labelRoom = new Label();
            comboBoxRoom = new ComboBox();
            dateTimePickerCheckIn = new DateTimePicker();
            labelCheckIn = new Label();
            labelCheckOut = new Label();
            dateTimePickerCheckOut = new DateTimePicker();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // comboBoxGuest
            // 
            comboBoxGuest.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGuest.FormattingEnabled = true;
            comboBoxGuest.Location = new Point(126, 27);
            comboBoxGuest.Name = "comboBoxGuest";
            comboBoxGuest.Size = new Size(121, 23);
            comboBoxGuest.TabIndex = 0;
            // 
            // labelGuest
            // 
            labelGuest.AutoSize = true;
            labelGuest.Location = new Point(51, 35);
            labelGuest.Name = "labelGuest";
            labelGuest.Size = new Size(37, 15);
            labelGuest.TabIndex = 1;
            labelGuest.Text = "Гость";
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Location = new Point(51, 72);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(45, 15);
            labelRoom.TabIndex = 3;
            labelRoom.Text = "Номер";
            // 
            // comboBoxRoom
            // 
            comboBoxRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoom.FormattingEnabled = true;
            comboBoxRoom.Location = new Point(129, 64);
            comboBoxRoom.Name = "comboBoxRoom";
            comboBoxRoom.Size = new Size(121, 23);
            comboBoxRoom.TabIndex = 2;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(51, 140);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(200, 23);
            dateTimePickerCheckIn.TabIndex = 4;
            // 
            // labelCheckIn
            // 
            labelCheckIn.AutoSize = true;
            labelCheckIn.Location = new Point(51, 112);
            labelCheckIn.Name = "labelCheckIn";
            labelCheckIn.Size = new Size(69, 15);
            labelCheckIn.TabIndex = 5;
            labelCheckIn.Text = "Дата заезда";
            // 
            // labelCheckOut
            // 
            labelCheckOut.AutoSize = true;
            labelCheckOut.Location = new Point(51, 183);
            labelCheckOut.Name = "labelCheckOut";
            labelCheckOut.Size = new Size(73, 15);
            labelCheckOut.TabIndex = 7;
            labelCheckOut.Text = "Дата выезда";
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(51, 211);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(200, 23);
            dateTimePickerCheckOut.TabIndex = 6;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(51, 264);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(178, 264);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 316);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(labelCheckOut);
            Controls.Add(dateTimePickerCheckOut);
            Controls.Add(labelCheckIn);
            Controls.Add(dateTimePickerCheckIn);
            Controls.Add(labelRoom);
            Controls.Add(comboBoxRoom);
            Controls.Add(labelGuest);
            Controls.Add(comboBoxGuest);
            Name = "FormBooking";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Новое бронирование";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGuest;
        private Label labelGuest;
        private Label labelRoom;
        private ComboBox comboBoxRoom;
        private DateTimePicker dateTimePickerCheckIn;
        private Label labelCheckIn;
        private Label labelCheckOut;
        private DateTimePicker dateTimePickerCheckOut;
        private Button buttonSave;
        private Button buttonCancel;
    }
}