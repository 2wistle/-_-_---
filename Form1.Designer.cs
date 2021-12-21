namespace ppsat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.перевозкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b1DataSet = new ppsat.b1DataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.перевозкиTableAdapter = new ppsat.b1DataSetTableAdapters.ПеревозкиTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.перевозкиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевозкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бригадыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грузыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грузовикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наспунктыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b1DataSet1 = new ppsat.b1DataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.статусTableAdapter = new ppsat.b1DataSet1TableAdapters.СтатусTableAdapter();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевозкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевозкиBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // перевозкиBindingSource
            // 
            this.перевозкиBindingSource.DataMember = "Перевозки";
            this.перевозкиBindingSource.DataSource = this.b1DataSet;
            // 
            // b1DataSet
            // 
            this.b1DataSet.DataSetName = "b1DataSet";
            this.b1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 114);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(25, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(152, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(279, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(406, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 56);
            this.button4.TabIndex = 5;
            this.button4.Text = "Редактировать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(1055, 529);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 33);
            this.button5.TabIndex = 6;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(877, 442);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(874, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск записей по грузам и городам";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(874, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фильтрации по параметру срочности";
            // 
            // перевозкиTableAdapter
            // 
            this.перевозкиTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(533, 500);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 56);
            this.button6.TabIndex = 12;
            this.button6.Text = "Добавление видов груза";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // перевозкиBindingSource1
            // 
            this.перевозкиBindingSource1.DataMember = "Перевозки";
            this.перевозкиBindingSource1.DataSource = this.b1DataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1179, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перевозкиToolStripMenuItem,
            this.бригадыToolStripMenuItem,
            this.грузыToolStripMenuItem,
            this.грузовикиToolStripMenuItem,
            this.наспунктыToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // перевозкиToolStripMenuItem
            // 
            this.перевозкиToolStripMenuItem.Name = "перевозкиToolStripMenuItem";
            this.перевозкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.перевозкиToolStripMenuItem.Text = "Перевозки";
            this.перевозкиToolStripMenuItem.Click += new System.EventHandler(this.перевозкиToolStripMenuItem_Click);
            // 
            // бригадыToolStripMenuItem
            // 
            this.бригадыToolStripMenuItem.Name = "бригадыToolStripMenuItem";
            this.бригадыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.бригадыToolStripMenuItem.Text = "Бригады";
            this.бригадыToolStripMenuItem.Click += new System.EventHandler(this.бригадыToolStripMenuItem_Click);
            // 
            // грузыToolStripMenuItem
            // 
            this.грузыToolStripMenuItem.Name = "грузыToolStripMenuItem";
            this.грузыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.грузыToolStripMenuItem.Text = "Грузы";
            this.грузыToolStripMenuItem.Click += new System.EventHandler(this.грузыToolStripMenuItem_Click);
            // 
            // грузовикиToolStripMenuItem
            // 
            this.грузовикиToolStripMenuItem.Name = "грузовикиToolStripMenuItem";
            this.грузовикиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.грузовикиToolStripMenuItem.Text = "Грузовики";
            this.грузовикиToolStripMenuItem.Click += new System.EventHandler(this.грузовикиToolStripMenuItem_Click);
            // 
            // наспунктыToolStripMenuItem
            // 
            this.наспунктыToolStripMenuItem.Name = "наспунктыToolStripMenuItem";
            this.наспунктыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.наспунктыToolStripMenuItem.Text = "Наспункты";
            this.наспунктыToolStripMenuItem.Click += new System.EventHandler(this.наспунктыToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(877, 363);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Срочно",
            "Не срочно"});
            this.comboBox1.Location = new System.Drawing.Point(877, 325);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.статусBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(916, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(251, 185);
            this.dataGridView2.TabIndex = 15;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // статусBindingSource
            // 
            this.статусBindingSource.DataMember = "Статус";
            this.статусBindingSource.DataSource = this.b1DataSet1;
            // 
            // b1DataSet1
            // 
            this.b1DataSet1.DataSetName = "b1DataSet1";
            this.b1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(989, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Статус заявок";
            // 
            // статусTableAdapter
            // 
            this.статусTableAdapter.ClearBeforeFill = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(981, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 56);
            this.button7.TabIndex = 17;
            this.button7.Text = "Присвоение статуса";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(660, 500);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 56);
            this.button8.TabIndex = 18;
            this.button8.Text = "Добавление адреса";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1179, 568);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевозкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.перевозкиBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.статусBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private b1DataSet b1DataSet;
        private System.Windows.Forms.BindingSource перевозкиBindingSource;
        private b1DataSetTableAdapters.ПеревозкиTableAdapter перевозкиTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource перевозкиBindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перевозкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бригадыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem грузыToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem грузовикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наспунктыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private b1DataSet1 b1DataSet1;
        private System.Windows.Forms.BindingSource статусBindingSource;
        private b1DataSet1TableAdapters.СтатусTableAdapter статусTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

