namespace HotelAccounting
{
    partial class FormRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRooms));
            dataGridViewData = new DataGridView();
            buttonDel = new Button();
            buttonUpd = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Location = new Point(1, -1);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.Size = new Size(240, 212);
            dataGridViewData.TabIndex = 0;
            // 
            // buttonDel
            // 
            buttonDel.BackgroundImage = (Image)resources.GetObject("buttonDel.BackgroundImage");
            buttonDel.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDel.Image = (Image)resources.GetObject("buttonDel.Image");
            buttonDel.Location = new Point(287, 135);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(50, 50);
            buttonDel.TabIndex = 6;
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonUpd
            // 
            buttonUpd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUpd.Image = (Image)resources.GetObject("buttonUpd.Image");
            buttonUpd.Location = new Point(287, 79);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(50, 50);
            buttonUpd.TabIndex = 5;
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += buttonUpd_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.Location = new Point(287, 23);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(50, 50);
            buttonAdd.TabIndex = 4;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewData);
            Name = "FormRooms";
            Text = "Номера";
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewData;
        private Button buttonDel;
        private Button buttonUpd;
        private Button buttonAdd;
    }
}