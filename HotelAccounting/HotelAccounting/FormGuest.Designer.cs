namespace HotelAccounting
{
    partial class FormGuest
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
            textBoxFullName = new TextBox();
            labelName = new Label();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelPassport = new Label();
            textBoxPassport = new TextBox();
            labelRegular = new Label();
            checkBoxIsRegular = new CheckBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(138, 19);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(100, 23);
            textBoxFullName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(47, 27);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 1;
            labelName.Text = "ФИО";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(47, 101);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(56, 15);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Телефон";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(138, 93);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(100, 23);
            textBoxPhone.TabIndex = 2;
            // 
            // labelPassport
            // 
            labelPassport.AutoSize = true;
            labelPassport.Location = new Point(47, 63);
            labelPassport.Name = "labelPassport";
            labelPassport.Size = new Size(54, 15);
            labelPassport.TabIndex = 5;
            labelPassport.Text = "Паспорт";
            // 
            // textBoxPassport
            // 
            textBoxPassport.Location = new Point(138, 55);
            textBoxPassport.Name = "textBoxPassport";
            textBoxPassport.Size = new Size(100, 23);
            textBoxPassport.TabIndex = 4;
            // 
            // labelRegular
            // 
            labelRegular.AutoSize = true;
            labelRegular.Location = new Point(47, 140);
            labelRegular.Name = "labelRegular";
            labelRegular.Size = new Size(118, 15);
            labelRegular.TabIndex = 7;
            labelRegular.Text = "Постоянный клиент";
            // 
            // checkBoxIsRegular
            // 
            checkBoxIsRegular.AutoSize = true;
            checkBoxIsRegular.Location = new Point(181, 141);
            checkBoxIsRegular.Name = "checkBoxIsRegular";
            checkBoxIsRegular.Size = new Size(15, 14);
            checkBoxIsRegular.TabIndex = 8;
            checkBoxIsRegular.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(47, 174);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(174, 174);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 233);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(checkBoxIsRegular);
            Controls.Add(labelRegular);
            Controls.Add(labelPassport);
            Controls.Add(textBoxPassport);
            Controls.Add(labelPhone);
            Controls.Add(textBoxPhone);
            Controls.Add(labelName);
            Controls.Add(textBoxFullName);
            Name = "FormGuest";
            Text = "FormGuest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFullName;
        private Label labelName;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelPassport;
        private TextBox textBoxPassport;
        private Label labelRegular;
        private CheckBox checkBoxIsRegular;
        private Button buttonSave;
        private Button buttonCancel;
    }
}