namespace RusRostPashAnt
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCanal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAnaliz = new System.Windows.Forms.Button();
            this.buttonOtcheet = new System.Windows.Forms.Button();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnView,
            this.ColumnTime,
            this.ColumnCanal,
            this.ColumnNumber,
            this.ColumnText});
            this.dataGridView1.Location = new System.Drawing.Point(700, 650);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(592, 104);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnView
            // 
            this.ColumnView.HeaderText = "Вид";
            this.ColumnView.MinimumWidth = 8;
            this.ColumnView.Name = "ColumnView";
            this.ColumnView.ReadOnly = true;
            this.ColumnView.Width = 75;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Время";
            this.ColumnTime.MinimumWidth = 8;
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.Width = 75;
            // 
            // ColumnCanal
            // 
            this.ColumnCanal.HeaderText = "Канал";
            this.ColumnCanal.MinimumWidth = 8;
            this.ColumnCanal.Name = "ColumnCanal";
            this.ColumnCanal.ReadOnly = true;
            this.ColumnCanal.Width = 75;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.HeaderText = "Номер";
            this.ColumnNumber.MinimumWidth = 8;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Width = 75;
            // 
            // ColumnText
            // 
            this.ColumnText.HeaderText = "Текст";
            this.ColumnText.MinimumWidth = 8;
            this.ColumnText.Name = "ColumnText";
            this.ColumnText.ReadOnly = true;
            this.ColumnText.Width = 150;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Станок 1",
            "Станок 2",
            "Станок 3"});
            this.comboBox1.Location = new System.Drawing.Point(51, 474);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 560);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 365);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAnaliz
            // 
            this.buttonAnaliz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnaliz.Image = global::RusRostPashAnt.Properties.Resources.graph_increase;
            this.buttonAnaliz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnaliz.Location = new System.Drawing.Point(51, 222);
            this.buttonAnaliz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAnaliz.Name = "buttonAnaliz";
            this.buttonAnaliz.Size = new System.Drawing.Size(182, 54);
            this.buttonAnaliz.TabIndex = 3;
            this.buttonAnaliz.Text = "Анализ";
            this.buttonAnaliz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnaliz.UseVisualStyleBackColor = true;
            // 
            // buttonOtcheet
            // 
            this.buttonOtcheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOtcheet.Image = global::RusRostPashAnt.Properties.Resources.bar_chart_01;
            this.buttonOtcheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOtcheet.Location = new System.Drawing.Point(51, 305);
            this.buttonOtcheet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOtcheet.Name = "buttonOtcheet";
            this.buttonOtcheet.Size = new System.Drawing.Size(182, 54);
            this.buttonOtcheet.TabIndex = 2;
            this.buttonOtcheet.Text = "Отчет";
            this.buttonOtcheet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOtcheet.UseVisualStyleBackColor = true;
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAlarm.Image = global::RusRostPashAnt.Properties.Resources.alarm;
            this.buttonAlarm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlarm.Location = new System.Drawing.Point(51, 134);
            this.buttonAlarm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(182, 55);
            this.buttonAlarm.TabIndex = 1;
            this.buttonAlarm.Text = "Мониторинг";
            this.buttonAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlarm.UseVisualStyleBackColor = true;
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Image = global::RusRostPashAnt.Properties.Resources.home_04;
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(51, 48);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(182, 62);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Главная";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1048);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAnaliz);
            this.Controls.Add(this.buttonOtcheet);
            this.Controls.Add(this.buttonAlarm);
            this.Controls.Add(this.buttonHome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "АКСИОМА";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonAlarm;
        private System.Windows.Forms.Button buttonOtcheet;
        private System.Windows.Forms.Button buttonAnaliz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCanal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnText;
    }
}

