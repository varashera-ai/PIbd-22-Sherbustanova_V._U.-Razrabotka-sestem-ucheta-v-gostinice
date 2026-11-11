namespace HotelAccounting
{
    partial class FormRoomCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomCategories));
            dataGridViewData = new DataGridView();
            buttonAdd = new Button();
            buttonUpd = new Button();
            buttonDel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Dock = DockStyle.Left;
            dataGridViewData.Location = new Point(0, 0);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.Size = new Size(246, 211);
            dataGridViewData.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.Location = new Point(283, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(50, 50);
            buttonAdd.TabIndex = 1;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUpd.Image = (Image)resources.GetObject("buttonUpd.Image");
            buttonUpd.Location = new Point(283, 75);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(50, 50);
            buttonUpd.TabIndex = 2;
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += buttonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.BackgroundImage = (Image)resources.GetObject("buttonDel.BackgroundImage");
            buttonDel.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDel.Image = (Image)resources.GetObject("buttonDel.Image");
            buttonDel.Location = new Point(283, 139);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(50, 50);
            buttonDel.TabIndex = 3;
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // FormRoomCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewData);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            Name = "FormRoomCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Категории номеров";
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewData;
        private Button buttonAdd;
        private Button buttonUpd;
        private Button buttonDel;
    }
}