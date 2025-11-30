namespace Lab10_TextEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жирныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подчёркнутыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SizeTSCBMM = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.цветШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветЗаливкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontTSMM = new System.Windows.Forms.ToolStripMenuItem();
            this.абзацToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выровнятьПоЦентруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выровнятьПоПравомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выровнятьПоЛевомуКраюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.создатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.копироватьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.вставкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BoldTSButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicTSButton = new System.Windows.Forms.ToolStripButton();
            this.UnderlineTSButton = new System.Windows.Forms.ToolStripButton();
            this.SizeTSComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.textColorTSButton = new System.Windows.Forms.ToolStripButton();
            this.fillingColorTSButton = new System.Windows.Forms.ToolStripButton();
            this.fontTSButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.centerTSButton = new System.Windows.Forms.ToolStripButton();
            this.rightTSButton = new System.Windows.Forms.ToolStripButton();
            this.leftTSButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TextEditor = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.форматToolStripMenuItem,
            this.текстToolStripMenuItem,
            this.абзацToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(784, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "txt";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.AutoToolTip = true;
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuFile.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.СоздатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.ВырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.КопироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.ВставитьToolStripMenuItem_Click);
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.жирныйToolStripMenuItem,
            this.курсивToolStripMenuItem,
            this.подчёркнутыйToolStripMenuItem,
            this.SizeTSCBMM,
            this.toolStripSeparator5,
            this.цветШрифтаToolStripMenuItem,
            this.цветЗаливкиToolStripMenuItem,
            this.fontTSMM});
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.текстToolStripMenuItem.Text = "Текст";
            this.текстToolStripMenuItem.DropDownClosed += new System.EventHandler(this.ТекстToolStripMenuItem_DropDownClosed);
            // 
            // жирныйToolStripMenuItem
            // 
            this.жирныйToolStripMenuItem.CheckOnClick = true;
            this.жирныйToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.жирныйToolStripMenuItem.Name = "жирныйToolStripMenuItem";
            this.жирныйToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.жирныйToolStripMenuItem.Text = "Жирный";
            this.жирныйToolStripMenuItem.Click += new System.EventHandler(this.ЖирныйToolStripMenuItem_Click);
            // 
            // курсивToolStripMenuItem
            // 
            this.курсивToolStripMenuItem.CheckOnClick = true;
            this.курсивToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.курсивToolStripMenuItem.Name = "курсивToolStripMenuItem";
            this.курсивToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.курсивToolStripMenuItem.Text = "Курсив";
            this.курсивToolStripMenuItem.Click += new System.EventHandler(this.КурсивToolStripMenuItem_Click);
            // 
            // подчёркнутыйToolStripMenuItem
            // 
            this.подчёркнутыйToolStripMenuItem.CheckOnClick = true;
            this.подчёркнутыйToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.подчёркнутыйToolStripMenuItem.Name = "подчёркнутыйToolStripMenuItem";
            this.подчёркнутыйToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.подчёркнутыйToolStripMenuItem.Text = "Подчёркнутый";
            this.подчёркнутыйToolStripMenuItem.Click += new System.EventHandler(this.ПодчёркнутыйToolStripMenuItem_Click);
            // 
            // SizeTSCBMM
            // 
            this.SizeTSCBMM.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.SizeTSCBMM.Name = "SizeTSCBMM";
            this.SizeTSCBMM.Size = new System.Drawing.Size(121, 23);
            this.SizeTSCBMM.Text = "12";
            this.SizeTSCBMM.DropDownClosed += new System.EventHandler(this.SizeTSCBMM_DropDownClosed);
            this.SizeTSCBMM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SizeTSCBMM_KeyDown);
            this.SizeTSCBMM.Validated += new System.EventHandler(this.SizeTSCBMM_Validated);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(178, 6);
            // 
            // цветШрифтаToolStripMenuItem
            // 
            this.цветШрифтаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.цветШрифтаToolStripMenuItem.Name = "цветШрифтаToolStripMenuItem";
            this.цветШрифтаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.цветШрифтаToolStripMenuItem.Text = "Цвет шрифта";
            this.цветШрифтаToolStripMenuItem.Click += new System.EventHandler(this.ЦветШрифтаToolStripMenuItem_Click);
            // 
            // цветЗаливкиToolStripMenuItem
            // 
            this.цветЗаливкиToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.цветЗаливкиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.цветЗаливкиToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.цветЗаливкиToolStripMenuItem.Name = "цветЗаливкиToolStripMenuItem";
            this.цветЗаливкиToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.цветЗаливкиToolStripMenuItem.Text = "Цвет заливки";
            this.цветЗаливкиToolStripMenuItem.Click += new System.EventHandler(this.ЦветЗаливкиToolStripMenuItem_Click);
            // 
            // fontTSMM
            // 
            this.fontTSMM.Name = "fontTSMM";
            this.fontTSMM.Size = new System.Drawing.Size(181, 22);
            this.fontTSMM.Text = "Microsoft Sans Serif";
            this.fontTSMM.Click += new System.EventHandler(this.FontTSMM_Click);
            // 
            // абзацToolStripMenuItem
            // 
            this.абзацToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выровнятьПоЦентруToolStripMenuItem,
            this.выровнятьПоПравомуКраюToolStripMenuItem,
            this.выровнятьПоЛевомуКраюToolStripMenuItem});
            this.абзацToolStripMenuItem.Name = "абзацToolStripMenuItem";
            this.абзацToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.абзацToolStripMenuItem.Text = "Абзац";
            // 
            // выровнятьПоЦентруToolStripMenuItem
            // 
            this.выровнятьПоЦентруToolStripMenuItem.CheckOnClick = true;
            this.выровнятьПоЦентруToolStripMenuItem.Name = "выровнятьПоЦентруToolStripMenuItem";
            this.выровнятьПоЦентруToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.выровнятьПоЦентруToolStripMenuItem.Text = "Выровнять по центру";
            this.выровнятьПоЦентруToolStripMenuItem.Click += new System.EventHandler(this.ВыровнятьПоЦентруToolStripMenuItem_Click);
            // 
            // выровнятьПоПравомуКраюToolStripMenuItem
            // 
            this.выровнятьПоПравомуКраюToolStripMenuItem.CheckOnClick = true;
            this.выровнятьПоПравомуКраюToolStripMenuItem.Name = "выровнятьПоПравомуКраюToolStripMenuItem";
            this.выровнятьПоПравомуКраюToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.выровнятьПоПравомуКраюToolStripMenuItem.Text = "Выровнять по правому краю";
            this.выровнятьПоПравомуКраюToolStripMenuItem.Click += new System.EventHandler(this.ВыровнятьПоПравомуКраюToolStripMenuItem_Click);
            // 
            // выровнятьПоЛевомуКраюToolStripMenuItem
            // 
            this.выровнятьПоЛевомуКраюToolStripMenuItem.Checked = true;
            this.выровнятьПоЛевомуКраюToolStripMenuItem.CheckOnClick = true;
            this.выровнятьПоЛевомуКраюToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.выровнятьПоЛевомуКраюToolStripMenuItem.Name = "выровнятьПоЛевомуКраюToolStripMenuItem";
            this.выровнятьПоЛевомуКраюToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.выровнятьПоЛевомуКраюToolStripMenuItem.Text = "Выровнять по левому краю";
            this.выровнятьПоЛевомуКраюToolStripMenuItem.Click += new System.EventHandler(this.ВыровнятьПоЛевомуКраюToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.СправкаToolStripMenuItem_Click);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripButton,
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.toolStripSeparator,
            this.вырезатьToolStripButton,
            this.копироватьToolStripButton,
            this.вставкаToolStripButton,
            this.toolStripSeparator1,
            this.BoldTSButton,
            this.ItalicTSButton,
            this.UnderlineTSButton,
            this.SizeTSComboBox,
            this.toolStripSeparator2,
            this.textColorTSButton,
            this.fillingColorTSButton,
            this.fontTSButton,
            this.toolStripSeparator3,
            this.centerTSButton,
            this.rightTSButton,
            this.leftTSButton,
            this.toolStripSeparator4,
            this.справкаToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip.Size = new System.Drawing.Size(784, 25);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "txt";
            // 
            // создатьToolStripButton
            // 
            this.создатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.создатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripButton.Image")));
            this.создатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripButton.Name = "создатьToolStripButton";
            this.создатьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.создатьToolStripButton.Text = "&Создать";
            this.создатьToolStripButton.Click += new System.EventHandler(this.СоздатьToolStripButton_Click);
            // 
            // открытьToolStripButton
            // 
            this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton.Image")));
            this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton.Name = "открытьToolStripButton";
            this.открытьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.открытьToolStripButton.Text = "&Открыть";
            this.открытьToolStripButton.Click += new System.EventHandler(this.ОткрытьToolStripButton_Click);
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.сохранитьToolStripButton.Text = "&Сохранить";
            this.сохранитьToolStripButton.Click += new System.EventHandler(this.СохранитьToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // вырезатьToolStripButton
            // 
            this.вырезатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вырезатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripButton.Image")));
            this.вырезатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripButton.Name = "вырезатьToolStripButton";
            this.вырезатьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.вырезатьToolStripButton.Text = "В&ырезать";
            this.вырезатьToolStripButton.Click += new System.EventHandler(this.ВырезатьToolStripButton_Click);
            // 
            // копироватьToolStripButton
            // 
            this.копироватьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.копироватьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripButton.Image")));
            this.копироватьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripButton.Name = "копироватьToolStripButton";
            this.копироватьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.копироватьToolStripButton.Text = "&Копировать";
            this.копироватьToolStripButton.Click += new System.EventHandler(this.КопироватьToolStripButton_Click);
            // 
            // вставкаToolStripButton
            // 
            this.вставкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вставкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripButton.Image")));
            this.вставкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripButton.Name = "вставкаToolStripButton";
            this.вставкаToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.вставкаToolStripButton.Text = "Вст&авка";
            this.вставкаToolStripButton.Click += new System.EventHandler(this.ВставкаToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BoldTSButton
            // 
            this.BoldTSButton.CheckOnClick = true;
            this.BoldTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BoldTSButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BoldTSButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldTSButton.Image")));
            this.BoldTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldTSButton.Name = "BoldTSButton";
            this.BoldTSButton.Size = new System.Drawing.Size(23, 22);
            this.BoldTSButton.Text = "Ж";
            this.BoldTSButton.ToolTipText = "Жирный";
            this.BoldTSButton.Click += new System.EventHandler(this.BoldTSButton_Click);
            // 
            // ItalicTSButton
            // 
            this.ItalicTSButton.CheckOnClick = true;
            this.ItalicTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ItalicTSButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.ItalicTSButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicTSButton.Image")));
            this.ItalicTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicTSButton.Name = "ItalicTSButton";
            this.ItalicTSButton.Size = new System.Drawing.Size(23, 22);
            this.ItalicTSButton.Text = "К";
            this.ItalicTSButton.ToolTipText = "Курсив";
            this.ItalicTSButton.Click += new System.EventHandler(this.ItalicTSButton_Click);
            // 
            // UnderlineTSButton
            // 
            this.UnderlineTSButton.CheckOnClick = true;
            this.UnderlineTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UnderlineTSButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.UnderlineTSButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineTSButton.Image")));
            this.UnderlineTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineTSButton.Name = "UnderlineTSButton";
            this.UnderlineTSButton.Size = new System.Drawing.Size(23, 22);
            this.UnderlineTSButton.Text = "Ч";
            this.UnderlineTSButton.ToolTipText = "Подчёркнутый";
            this.UnderlineTSButton.Click += new System.EventHandler(this.UnderlineTSButton_Click);
            // 
            // SizeTSComboBox
            // 
            this.SizeTSComboBox.AutoSize = false;
            this.SizeTSComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.SizeTSComboBox.Name = "SizeTSComboBox";
            this.SizeTSComboBox.Size = new System.Drawing.Size(50, 23);
            this.SizeTSComboBox.Text = "12";
            this.SizeTSComboBox.DropDownClosed += new System.EventHandler(this.SizeTSComboBox_DropDownClosed);
            this.SizeTSComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SizeTSComboBox_KeyDown);
            this.SizeTSComboBox.Validated += new System.EventHandler(this.SizeTSComboBox_Validated);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // textColorTSButton
            // 
            this.textColorTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textColorTSButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.textColorTSButton.ForeColor = System.Drawing.Color.Black;
            this.textColorTSButton.Image = ((System.Drawing.Image)(resources.GetObject("textColorTSButton.Image")));
            this.textColorTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textColorTSButton.Name = "textColorTSButton";
            this.textColorTSButton.Size = new System.Drawing.Size(23, 22);
            this.textColorTSButton.Text = "Ц";
            this.textColorTSButton.ToolTipText = "Цвет шрифта";
            this.textColorTSButton.Click += new System.EventHandler(this.TextColorTSButton_Click);
            // 
            // fillingColorTSButton
            // 
            this.fillingColorTSButton.BackColor = System.Drawing.SystemColors.Control;
            this.fillingColorTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillingColorTSButton.Image = ((System.Drawing.Image)(resources.GetObject("fillingColorTSButton.Image")));
            this.fillingColorTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillingColorTSButton.Name = "fillingColorTSButton";
            this.fillingColorTSButton.Size = new System.Drawing.Size(23, 22);
            this.fillingColorTSButton.Text = "З";
            this.fillingColorTSButton.ToolTipText = "Цвет заливки";
            this.fillingColorTSButton.Click += new System.EventHandler(this.FillingColorTSButton_Click);
            // 
            // fontTSButton
            // 
            this.fontTSButton.AutoSize = false;
            this.fontTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fontTSButton.Image = ((System.Drawing.Image)(resources.GetObject("fontTSButton.Image")));
            this.fontTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontTSButton.Name = "fontTSButton";
            this.fontTSButton.Size = new System.Drawing.Size(150, 22);
            this.fontTSButton.Text = "Microsoft Sans Serif";
            this.fontTSButton.ToolTipText = "Шрифт";
            this.fontTSButton.Click += new System.EventHandler(this.FontTSButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // centerTSButton
            // 
            this.centerTSButton.CheckOnClick = true;
            this.centerTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.centerTSButton.Image = ((System.Drawing.Image)(resources.GetObject("centerTSButton.Image")));
            this.centerTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centerTSButton.Name = "centerTSButton";
            this.centerTSButton.Size = new System.Drawing.Size(23, 22);
            this.centerTSButton.Text = "toolStripButton1";
            this.centerTSButton.ToolTipText = "Выровнять по центру";
            this.centerTSButton.Click += new System.EventHandler(this.CenterTSButton_Click);
            // 
            // rightTSButton
            // 
            this.rightTSButton.CheckOnClick = true;
            this.rightTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightTSButton.Image = ((System.Drawing.Image)(resources.GetObject("rightTSButton.Image")));
            this.rightTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightTSButton.Name = "rightTSButton";
            this.rightTSButton.Size = new System.Drawing.Size(23, 22);
            this.rightTSButton.Text = "toolStripButton2";
            this.rightTSButton.ToolTipText = "Выровнять по правому краю";
            this.rightTSButton.Click += new System.EventHandler(this.RightTSButton_Click);
            // 
            // leftTSButton
            // 
            this.leftTSButton.Checked = true;
            this.leftTSButton.CheckOnClick = true;
            this.leftTSButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftTSButton.Image = ((System.Drawing.Image)(resources.GetObject("leftTSButton.Image")));
            this.leftTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftTSButton.Name = "leftTSButton";
            this.leftTSButton.Size = new System.Drawing.Size(23, 22);
            this.leftTSButton.Text = "toolStripButton3";
            this.leftTSButton.ToolTipText = "Выровнять по левому краю";
            this.leftTSButton.Click += new System.EventHandler(this.LeftTSButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // справкаToolStripButton
            // 
            this.справкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.справкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripButton.Image")));
            this.справкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.справкаToolStripButton.Name = "справкаToolStripButton";
            this.справкаToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.справкаToolStripButton.Text = "Спр&авка";
            this.справкаToolStripButton.Click += new System.EventHandler(this.СправкаToolStripButton_Click);
            // 
            // TextEditor
            // 
            this.TextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextEditor.Location = new System.Drawing.Point(0, 49);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Size = new System.Drawing.Size(784, 412);
            this.TextEditor.TabIndex = 2;
            this.TextEditor.Text = "";
            this.TextEditor.SelectionChanged += new System.EventHandler(this.TextEditor_SelectionChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "center16.ico");
            this.imageList.Images.SetKeyName(1, "right16.ico");
            this.imageList.Images.SetKeyName(2, "left16.ico");
            this.imageList.Images.SetKeyName(3, "textcolor16.ico");
            this.imageList.Images.SetKeyName(4, "textfill16.ico");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TextEditor);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton создатьToolStripButton;
        private System.Windows.Forms.ToolStripButton открытьToolStripButton;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton вырезатьToolStripButton;
        private System.Windows.Forms.ToolStripButton копироватьToolStripButton;
        private System.Windows.Forms.ToolStripButton вставкаToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton справкаToolStripButton;
        private System.Windows.Forms.RichTextBox TextEditor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton BoldTSButton;
        private System.Windows.Forms.ToolStripButton ItalicTSButton;
        private System.Windows.Forms.ToolStripButton UnderlineTSButton;
        private System.Windows.Forms.ToolStripComboBox SizeTSComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton textColorTSButton;
        private System.Windows.Forms.ToolStripButton fillingColorTSButton;
        private System.Windows.Forms.ToolStripButton fontTSButton;
        private System.Windows.Forms.ToolStripButton centerTSButton;
        private System.Windows.Forms.ToolStripButton rightTSButton;
        private System.Windows.Forms.ToolStripButton leftTSButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жирныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подчёркнутыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripComboBox SizeTSCBMM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem цветШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветЗаливкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontTSMM;
        private System.Windows.Forms.ToolStripMenuItem абзацToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выровнятьПоЦентруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выровнятьПоПравомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выровнятьПоЛевомуКраюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

