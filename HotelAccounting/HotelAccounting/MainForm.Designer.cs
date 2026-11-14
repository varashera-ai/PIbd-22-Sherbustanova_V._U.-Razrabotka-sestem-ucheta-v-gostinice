namespace HotelAccounting
{
    partial class MainForm
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
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            категорииНомеровToolStripMenuItem = new ToolStripMenuItem();
            номераToolStripMenuItem = new ToolStripMenuItem();
            гостиToolStripMenuItem = new ToolStripMenuItem();
            услугиToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            бронированияToolStripMenuItem = new ToolStripMenuItem();
            заселенияToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            menuStripMain = new MenuStrip();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { категорииНомеровToolStripMenuItem, номераToolStripMenuItem, гостиToolStripMenuItem, услугиToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // категорииНомеровToolStripMenuItem
            // 
            категорииНомеровToolStripMenuItem.Name = "категорииНомеровToolStripMenuItem";
            категорииНомеровToolStripMenuItem.Size = new Size(183, 22);
            категорииНомеровToolStripMenuItem.Text = "Категории номеров";
            категорииНомеровToolStripMenuItem.Click += категорииНомеровToolStripMenuItem_Click;
            // 
            // номераToolStripMenuItem
            // 
            номераToolStripMenuItem.Name = "номераToolStripMenuItem";
            номераToolStripMenuItem.Size = new Size(183, 22);
            номераToolStripMenuItem.Text = "Номера";
            номераToolStripMenuItem.Click += номераToolStripMenuItem_Click;
            // 
            // гостиToolStripMenuItem
            // 
            гостиToolStripMenuItem.Name = "гостиToolStripMenuItem";
            гостиToolStripMenuItem.Size = new Size(183, 22);
            гостиToolStripMenuItem.Text = "Гости";
            гостиToolStripMenuItem.Click += гостиToolStripMenuItem_Click;
            // 
            // услугиToolStripMenuItem
            // 
            услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            услугиToolStripMenuItem.Size = new Size(183, 22);
            услугиToolStripMenuItem.Text = "Услуги";
            услугиToolStripMenuItem.Click += услугиToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { бронированияToolStripMenuItem, заселенияToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(75, 20);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // бронированияToolStripMenuItem
            // 
            бронированияToolStripMenuItem.Name = "бронированияToolStripMenuItem";
            бронированияToolStripMenuItem.Size = new Size(155, 22);
            бронированияToolStripMenuItem.Text = "Бронирования";
            бронированияToolStripMenuItem.Click += бронированияToolStripMenuItem_Click;
            // 
            // заселенияToolStripMenuItem
            // 
            заселенияToolStripMenuItem.Name = "заселенияToolStripMenuItem";
            заселенияToolStripMenuItem.Size = new Size(155, 22);
            заселенияToolStripMenuItem.Text = "Заселения";
            заселенияToolStripMenuItem.Click += заселенияToolStripMenuItem_Click;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(60, 20);
            отчетыToolStripMenuItem.Text = "Отчеты";
            отчетыToolStripMenuItem.Click += отчетыToolStripMenuItem_Click;
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem, операцииToolStripMenuItem, отчетыToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(800, 24);
            menuStripMain.TabIndex = 1;
            menuStripMain.Text = "Учёт в гостинице";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripMain);
            Name = "MainForm";
            Text = "Учёт в гостинице";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem категорииНомеровToolStripMenuItem;
        private ToolStripMenuItem номераToolStripMenuItem;
        private ToolStripMenuItem гостиToolStripMenuItem;
        private ToolStripMenuItem услугиToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem бронированияToolStripMenuItem;
        private ToolStripMenuItem заселенияToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private MenuStrip menuStripMain;
    }
}