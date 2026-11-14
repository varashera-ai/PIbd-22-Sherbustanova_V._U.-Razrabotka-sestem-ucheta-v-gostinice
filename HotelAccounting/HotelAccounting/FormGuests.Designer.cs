namespace HotelAccounting
{
    partial class FormGuests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuests));
            buttonDel = new Button();
            buttonUpd = new Button();
            buttonAdd = new Button();
            dataGridViewData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // buttonDel
            // 
            buttonDel.Image = (Image)resources.GetObject("buttonDel.Image");
            buttonDel.Location = new Point(284, 136);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(50, 50);
            buttonDel.TabIndex = 7;
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.Image = (Image)resources.GetObject("buttonUpd.Image");
            buttonUpd.Location = new Point(284, 80);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(50, 50);
            buttonUpd.TabIndex = 6;
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += buttonUpd_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.Location = new Point(284, 24);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(50, 50);
            buttonAdd.TabIndex = 5;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewData
            // 
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Location = new Point(-2, -2);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.Size = new Size(232, 215);
            dataGridViewData.TabIndex = 4;
            // 
            // FormGuests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewData);
            Name = "FormGuests";
            Text = "Гости";
            Load += FormGuests_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDel;
        private Button buttonUpd;
        private Button buttonAdd;
        private DataGridView dataGridViewData;
    }
}