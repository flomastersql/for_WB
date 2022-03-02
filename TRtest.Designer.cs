namespace TR
{
    partial class TRtest
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
            this.TC = new System.Windows.Forms.TabControl();
            this.TCTP1 = new System.Windows.Forms.TabPage();
            this.buildlists = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_city = new System.Windows.Forms.DataGridView();
            this.DGV_reg = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.b_store_count = new System.Windows.Forms.Button();
            this.TC.SuspendLayout();
            this.TCTP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_city)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_reg)).BeginInit();
            this.SuspendLayout();
            // 
            // TC
            // 
            this.TC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC.Controls.Add(this.TCTP1);
            this.TC.Controls.Add(this.tabPage2);
            this.TC.Location = new System.Drawing.Point(12, 12);
            this.TC.Name = "TC";
            this.TC.SelectedIndex = 0;
            this.TC.Size = new System.Drawing.Size(1359, 694);
            this.TC.TabIndex = 0;
            // 
            // TCTP1
            // 
            this.TCTP1.Controls.Add(this.b_store_count);
            this.TCTP1.Controls.Add(this.buildlists);
            this.TCTP1.Controls.Add(this.label2);
            this.TCTP1.Controls.Add(this.label1);
            this.TCTP1.Controls.Add(this.DGV_city);
            this.TCTP1.Controls.Add(this.DGV_reg);
            this.TCTP1.Location = new System.Drawing.Point(4, 25);
            this.TCTP1.Name = "TCTP1";
            this.TCTP1.Padding = new System.Windows.Forms.Padding(3);
            this.TCTP1.Size = new System.Drawing.Size(1351, 665);
            this.TCTP1.TabIndex = 0;
            this.TCTP1.Text = "Настройки";
            this.TCTP1.UseVisualStyleBackColor = true;
            // 
            // buildlists
            // 
            this.buildlists.Location = new System.Drawing.Point(759, 234);
            this.buildlists.Name = "buildlists";
            this.buildlists.Size = new System.Drawing.Size(140, 70);
            this.buildlists.TabIndex = 4;
            this.buildlists.Text = "Построить листы";
            this.buildlists.UseVisualStyleBackColor = true;
            this.buildlists.Click += new System.EventHandler(this.buildlists_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Город";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регион";
            // 
            // DGV_city
            // 
            this.DGV_city.AllowUserToAddRows = false;
            this.DGV_city.AllowUserToDeleteRows = false;
            this.DGV_city.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGV_city.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_city.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_city.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_city.ColumnHeadersVisible = false;
            this.DGV_city.Location = new System.Drawing.Point(388, 43);
            this.DGV_city.Name = "DGV_city";
            this.DGV_city.RowHeadersVisible = false;
            this.DGV_city.RowHeadersWidth = 51;
            this.DGV_city.RowTemplate.Height = 24;
            this.DGV_city.Size = new System.Drawing.Size(365, 600);
            this.DGV_city.TabIndex = 1;
            // 
            // DGV_reg
            // 
            this.DGV_reg.AllowUserToAddRows = false;
            this.DGV_reg.AllowUserToDeleteRows = false;
            this.DGV_reg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DGV_reg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_reg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_reg.ColumnHeadersVisible = false;
            this.DGV_reg.Location = new System.Drawing.Point(17, 43);
            this.DGV_reg.Name = "DGV_reg";
            this.DGV_reg.RowHeadersVisible = false;
            this.DGV_reg.RowHeadersWidth = 51;
            this.DGV_reg.RowTemplate.Height = 24;
            this.DGV_reg.Size = new System.Drawing.Size(365, 600);
            this.DGV_reg.TabIndex = 0;
            this.DGV_reg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_reg_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1351, 665);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // b_store_count
            // 
            this.b_store_count.Location = new System.Drawing.Point(759, 43);
            this.b_store_count.Name = "b_store_count";
            this.b_store_count.Size = new System.Drawing.Size(193, 36);
            this.b_store_count.TabIndex = 5;
            this.b_store_count.Text = "Узнать кол-во объектов";
            this.b_store_count.UseVisualStyleBackColor = true;
            this.b_store_count.Click += new System.EventHandler(this.b_store_count_Click);
            // 
            // TRtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 718);
            this.Controls.Add(this.TC);
            this.Name = "TRtest";
            this.Text = "Form1";
            this.TC.ResumeLayout(false);
            this.TCTP1.ResumeLayout(false);
            this.TCTP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_city)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_reg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TC;
        private System.Windows.Forms.TabPage TCTP1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGV_reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_city;
        private System.Windows.Forms.Button buildlists;
        private System.Windows.Forms.Button b_store_count;
    }
}

