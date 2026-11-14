namespace HotelAccounting
{
    partial class FormStay
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
            labelGuest = new Label();
            label2 = new Label();
            comboBoxGuest = new ComboBox();
            comboBoxRoom = new ComboBox();
            labelRoom = new Label();
            groupBoxServices = new GroupBox();
            dataGridViewServices = new DataGridView();
            ColumnService = new DataGridViewComboBoxColumn();
            ColumnQuantity = new DataGridViewTextBoxColumn();
            buttonSave = new Button();
            buttonCancel = new Button();
            groupBoxServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            SuspendLayout();
            // 
            // labelGuest
            // 
            labelGuest.AutoSize = true;
            labelGuest.Location = new Point(17, 15);
            labelGuest.Name = "labelGuest";
            labelGuest.Size = new Size(37, 15);
            labelGuest.TabIndex = 0;
            labelGuest.Text = "Гость";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 211);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // comboBoxGuest
            // 
            comboBoxGuest.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGuest.FormattingEnabled = true;
            comboBoxGuest.Location = new Point(141, 12);
            comboBoxGuest.Name = "comboBoxGuest";
            comboBoxGuest.Size = new Size(121, 23);
            comboBoxGuest.TabIndex = 2;
            // 
            // comboBoxRoom
            // 
            comboBoxRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoom.FormattingEnabled = true;
            comboBoxRoom.Location = new Point(141, 43);
            comboBoxRoom.Name = "comboBoxRoom";
            comboBoxRoom.Size = new Size(121, 23);
            comboBoxRoom.TabIndex = 4;
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Location = new Point(17, 43);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(45, 15);
            labelRoom.TabIndex = 3;
            labelRoom.Text = "Номер";
            // 
            // groupBoxServices
            // 
            groupBoxServices.Controls.Add(dataGridViewServices);
            groupBoxServices.Location = new Point(17, 72);
            groupBoxServices.Name = "groupBoxServices";
            groupBoxServices.Size = new Size(245, 186);
            groupBoxServices.TabIndex = 7;
            groupBoxServices.TabStop = false;
            groupBoxServices.Text = "Дополнительные услуги";
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Columns.AddRange(new DataGridViewColumn[] { ColumnService, ColumnQuantity });
            dataGridViewServices.Location = new Point(0, 22);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.Size = new Size(245, 164);
            dataGridViewServices.TabIndex = 0;
            // 
            // ColumnService
            // 
            ColumnService.HeaderText = "Услуга";
            ColumnService.Name = "ColumnService";
            // 
            // ColumnQuantity
            // 
            ColumnQuantity.HeaderText = "Количество";
            ColumnQuantity.Name = "ColumnQuantity";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(14, 275);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(141, 275);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormStay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 327);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(groupBoxServices);
            Controls.Add(comboBoxRoom);
            Controls.Add(labelRoom);
            Controls.Add(comboBoxGuest);
            Controls.Add(label2);
            Controls.Add(labelGuest);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormStay";
            Text = "Новое заселение";
            groupBoxServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGuest;
        private Label label2;
        private ComboBox comboBoxGuest;
        private ComboBox comboBoxRoom;
        private Label labelRoom;
        private GroupBox groupBoxServices;
        private DataGridView dataGridViewServices;
        private DataGridViewComboBoxColumn ColumnService;
        private DataGridViewTextBoxColumn ColumnQuantity;
        private Button buttonSave;
        private Button buttonCancel;
    }
}