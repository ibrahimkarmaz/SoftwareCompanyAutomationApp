namespace Software_Company_Automation
{
    partial class MusteriArama
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.arama_islemleri_gb = new System.Windows.Forms.GroupBox();
            this.konu_combo = new System.Windows.Forms.ComboBox();
            this.arama_tb = new System.Windows.Forms.TextBox();
            this.otomatik_arama_cb = new System.Windows.Forms.CheckBox();
            this.tablolari_listele_dgv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.arama_islemleri_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablolari_listele_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // arama_islemleri_gb
            // 
            this.arama_islemleri_gb.Controls.Add(this.button2);
            this.arama_islemleri_gb.Controls.Add(this.label2);
            this.arama_islemleri_gb.Controls.Add(this.label1);
            this.arama_islemleri_gb.Controls.Add(this.button1);
            this.arama_islemleri_gb.Controls.Add(this.konu_combo);
            this.arama_islemleri_gb.Controls.Add(this.arama_tb);
            this.arama_islemleri_gb.Controls.Add(this.otomatik_arama_cb);
            this.arama_islemleri_gb.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama_islemleri_gb.Location = new System.Drawing.Point(12, 12);
            this.arama_islemleri_gb.Name = "arama_islemleri_gb";
            this.arama_islemleri_gb.Size = new System.Drawing.Size(916, 84);
            this.arama_islemleri_gb.TabIndex = 34;
            this.arama_islemleri_gb.TabStop = false;
            this.arama_islemleri_gb.Text = "Arama ve Listeleme İşlemleri";
            // 
            // konu_combo
            // 
            this.konu_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.konu_combo.FormattingEnabled = true;
            this.konu_combo.Location = new System.Drawing.Point(97, 24);
            this.konu_combo.Name = "konu_combo";
            this.konu_combo.Size = new System.Drawing.Size(167, 26);
            this.konu_combo.TabIndex = 63;
            // 
            // arama_tb
            // 
            this.arama_tb.Location = new System.Drawing.Point(372, 25);
            this.arama_tb.Name = "arama_tb";
            this.arama_tb.Size = new System.Drawing.Size(141, 26);
            this.arama_tb.TabIndex = 61;
            this.arama_tb.TextChanged += new System.EventHandler(this.arama_tb_TextChanged);
            // 
            // otomatik_arama_cb
            // 
            this.otomatik_arama_cb.AutoSize = true;
            this.otomatik_arama_cb.Location = new System.Drawing.Point(372, 56);
            this.otomatik_arama_cb.Name = "otomatik_arama_cb";
            this.otomatik_arama_cb.Size = new System.Drawing.Size(123, 22);
            this.otomatik_arama_cb.TabIndex = 60;
            this.otomatik_arama_cb.Text = "Otomatik Arama";
            this.otomatik_arama_cb.UseVisualStyleBackColor = true;
            // 
            // tablolari_listele_dgv
            // 
            this.tablolari_listele_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablolari_listele_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.tablolari_listele_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablolari_listele_dgv.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablolari_listele_dgv.DefaultCellStyle = dataGridViewCellStyle11;
            this.tablolari_listele_dgv.Location = new System.Drawing.Point(12, 102);
            this.tablolari_listele_dgv.Name = "tablolari_listele_dgv";
            this.tablolari_listele_dgv.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablolari_listele_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.tablolari_listele_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablolari_listele_dgv.Size = new System.Drawing.Size(916, 323);
            this.tablolari_listele_dgv.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 27);
            this.button1.TabIndex = 64;
            this.button1.Text = "Arama Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 65;
            this.label1.Text = "Arama Alanı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Arama Konusu:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(769, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 59);
            this.button2.TabIndex = 67;
            this.button2.Text = "Tabloyu Getir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MusteriArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 442);
            this.Controls.Add(this.arama_islemleri_gb);
            this.Controls.Add(this.tablolari_listele_dgv);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MusteriArama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Arama Penceresi";
            this.Load += new System.EventHandler(this.MusteriArama_Load);
            this.arama_islemleri_gb.ResumeLayout(false);
            this.arama_islemleri_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablolari_listele_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox arama_islemleri_gb;
        private System.Windows.Forms.ComboBox konu_combo;
        private System.Windows.Forms.TextBox arama_tb;
        private System.Windows.Forms.CheckBox otomatik_arama_cb;
        private System.Windows.Forms.DataGridView tablolari_listele_dgv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}