namespace HotelAccounting
{
    partial class FormServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServices));
            dataGridViewData = new DataGridView();
            buttonUpd = new Button();
            buttonDel = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Location = new Point(1, 0);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.Size = new Size(258, 213);
            dataGridViewData.TabIndex = 0;
            // 
            // buttonUpd
            // 
            buttonUpd.Image = (Image)resources.GetObject("buttonUpd.Image");
            buttonUpd.Location = new Point(298, 77);
            buttonUpd.Name = "buttonUpd";
            buttonUpd.Size = new Size(50, 50);
            buttonUpd.TabIndex = 2;
            buttonUpd.UseVisualStyleBackColor = true;
            buttonUpd.Click += buttonUpd_Click;
            // 
            // buttonDel
            // 
            buttonDel.Image = (Image)resources.GetObject("buttonDel.Image");
            buttonDel.Location = new Point(298, 133);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(50, 50);
            buttonDel.TabIndex = 3;
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Image = (Image)resources.GetObject("buttonAdd.Image");
            buttonAdd.Location = new Point(298, 21);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(50, 50);
            buttonAdd.TabIndex = 4;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormServices
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDel);
            Controls.Add(buttonUpd);
            Controls.Add(dataGridViewData);
            Name = "FormServices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Услуги";
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewData;
        private Button buttonUpd;
        private Button buttonDel;
        private Button buttonAdd;
    }
}