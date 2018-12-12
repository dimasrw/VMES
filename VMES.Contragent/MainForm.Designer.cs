namespace VMES.Contragent
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрагентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.судебкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.претензииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.делаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.связьДоговоровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 735);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1013, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.расчетыToolStripMenuItem,
            this.судебкаToolStripMenuItem,
            this.сервисныеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрагентыToolStripMenuItem,
            this.договорыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // контрагентыToolStripMenuItem
            // 
            this.контрагентыToolStripMenuItem.Name = "контрагентыToolStripMenuItem";
            this.контрагентыToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.контрагентыToolStripMenuItem.Text = "Контрагенты";
            this.контрагентыToolStripMenuItem.Click += new System.EventHandler(this.контрагентыToolStripMenuItem_Click);
            // 
            // договорыToolStripMenuItem
            // 
            this.договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            this.договорыToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.договорыToolStripMenuItem.Text = "Договоры";
            this.договорыToolStripMenuItem.Click += new System.EventHandler(this.договорыToolStripMenuItem_Click);
            // 
            // расчетыToolStripMenuItem
            // 
            this.расчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.актыToolStripMenuItem,
            this.платежкиToolStripMenuItem});
            this.расчетыToolStripMenuItem.Name = "расчетыToolStripMenuItem";
            this.расчетыToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.расчетыToolStripMenuItem.Text = "Расчеты";
            // 
            // актыToolStripMenuItem
            // 
            this.актыToolStripMenuItem.Name = "актыToolStripMenuItem";
            this.актыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.актыToolStripMenuItem.Text = "Акты";
            this.актыToolStripMenuItem.Click += new System.EventHandler(this.актыToolStripMenuItem_Click);
            // 
            // платежкиToolStripMenuItem
            // 
            this.платежкиToolStripMenuItem.Name = "платежкиToolStripMenuItem";
            this.платежкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.платежкиToolStripMenuItem.Text = "Платежки";
            this.платежкиToolStripMenuItem.Click += new System.EventHandler(this.платежкиToolStripMenuItem_Click);
            // 
            // судебкаToolStripMenuItem
            // 
            this.судебкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.претензииToolStripMenuItem,
            this.делаToolStripMenuItem});
            this.судебкаToolStripMenuItem.Name = "судебкаToolStripMenuItem";
            this.судебкаToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.судебкаToolStripMenuItem.Text = "ПИР";
            // 
            // претензииToolStripMenuItem
            // 
            this.претензииToolStripMenuItem.Name = "претензииToolStripMenuItem";
            this.претензииToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.претензииToolStripMenuItem.Text = "Претензии";
            // 
            // делаToolStripMenuItem
            // 
            this.делаToolStripMenuItem.Name = "делаToolStripMenuItem";
            this.делаToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.делаToolStripMenuItem.Text = "Дела";
            // 
            // сервисныеToolStripMenuItem
            // 
            this.сервисныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.связьДоговоровToolStripMenuItem});
            this.сервисныеToolStripMenuItem.Name = "сервисныеToolStripMenuItem";
            this.сервисныеToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.сервисныеToolStripMenuItem.Text = "Сервисные";
            // 
            // связьДоговоровToolStripMenuItem
            // 
            this.связьДоговоровToolStripMenuItem.Name = "связьДоговоровToolStripMenuItem";
            this.связьДоговоровToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.связьДоговоровToolStripMenuItem.Text = "Связь договоров";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 757);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Программа";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрагентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платежкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem судебкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem претензииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem делаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem связьДоговоровToolStripMenuItem;
    }
}

