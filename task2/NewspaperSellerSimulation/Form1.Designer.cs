namespace NewspaperSellerSimulation
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Day_type = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand_dist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numofpapers = new System.Windows.Forms.TextBox();
            this.Calc_button = new System.Windows.Forms.Button();
            this.Read_File_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Numofrecords = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scraps = new System.Windows.Forms.TextBox();
            this.sel_Price = new System.Windows.Forms.TextBox();
            this.Purchaseprice = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Day_type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_dist)).BeginInit();
            this.SuspendLayout();
            // 
            // Day_type
            // 
            this.Day_type.AllowUserToAddRows = false;
            this.Day_type.AllowUserToDeleteRows = false;
            this.Day_type.AllowUserToResizeColumns = false;
            this.Day_type.AllowUserToResizeRows = false;
            this.Day_type.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Day_type.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Day_type.BackgroundColor = System.Drawing.Color.LightGray;
            this.Day_type.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Day_type.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Day_type.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Day_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Day_type.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Day_type.DefaultCellStyle = dataGridViewCellStyle10;
            this.Day_type.EnableHeadersVisualStyles = false;
            this.Day_type.GridColor = System.Drawing.Color.Gray;
            this.Day_type.Location = new System.Drawing.Point(442, 137);
            this.Day_type.Margin = new System.Windows.Forms.Padding(2);
            this.Day_type.Name = "Day_type";
            this.Day_type.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Day_type.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Day_type.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.Day_type.RowTemplate.Height = 30;
            this.Day_type.Size = new System.Drawing.Size(374, 268);
            this.Day_type.TabIndex = 76;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Type Of Day";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Propability";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Demand_dist
            // 
            this.Demand_dist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Demand_dist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Demand_dist.BackgroundColor = System.Drawing.Color.LightGray;
            this.Demand_dist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Demand_dist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Demand_dist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Demand_dist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Demand_dist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column1,
            this.Column2});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Demand_dist.DefaultCellStyle = dataGridViewCellStyle14;
            this.Demand_dist.EnableHeadersVisualStyles = false;
            this.Demand_dist.GridColor = System.Drawing.Color.White;
            this.Demand_dist.Location = new System.Drawing.Point(52, 114);
            this.Demand_dist.Margin = new System.Windows.Forms.Padding(2);
            this.Demand_dist.Name = "Demand_dist";
            this.Demand_dist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Demand_dist.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Demand_dist.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.Demand_dist.RowTemplate.Height = 30;
            this.Demand_dist.Size = new System.Drawing.Size(371, 432);
            this.Demand_dist.TabIndex = 79;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Demand";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Good Probability";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fair Probability";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Poor Probability";
            this.Column2.Name = "Column2";
            // 
            // numofpapers
            // 
            this.numofpapers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.numofpapers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numofpapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numofpapers.ForeColor = System.Drawing.Color.Black;
            this.numofpapers.Location = new System.Drawing.Point(504, 54);
            this.numofpapers.Margin = new System.Windows.Forms.Padding(2);
            this.numofpapers.Name = "numofpapers";
            this.numofpapers.Size = new System.Drawing.Size(103, 23);
            this.numofpapers.TabIndex = 66;
            this.numofpapers.Text = "70";
            this.numofpapers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Calc_button
            // 
            this.Calc_button.BackColor = System.Drawing.Color.Green;
            this.Calc_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Calc_button.FlatAppearance.BorderSize = 2;
            this.Calc_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.Calc_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calc_button.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Calc_button.Location = new System.Drawing.Point(564, 483);
            this.Calc_button.Margin = new System.Windows.Forms.Padding(2);
            this.Calc_button.Name = "Calc_button";
            this.Calc_button.Size = new System.Drawing.Size(135, 38);
            this.Calc_button.TabIndex = 78;
            this.Calc_button.Text = "Calculate";
            this.Calc_button.UseVisualStyleBackColor = false;
            this.Calc_button.Click += new System.EventHandler(this.Calc_button_Click_1);
            // 
            // Read_File_Button
            // 
            this.Read_File_Button.BackColor = System.Drawing.Color.Firebrick;
            this.Read_File_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.Read_File_Button.FlatAppearance.BorderSize = 2;
            this.Read_File_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.Read_File_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Read_File_Button.Font = new System.Drawing.Font("Book Antiqua", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read_File_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Read_File_Button.Location = new System.Drawing.Point(583, 431);
            this.Read_File_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Read_File_Button.Name = "Read_File_Button";
            this.Read_File_Button.Size = new System.Drawing.Size(90, 38);
            this.Read_File_Button.TabIndex = 77;
            this.Read_File_Button.Text = "Read File";
            this.Read_File_Button.UseVisualStyleBackColor = false;
            this.Read_File_Button.Click += new System.EventHandler(this.Read_File_Button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 75;
            this.label5.Text = "Number Of Records";
            // 
            // Numofrecords
            // 
            this.Numofrecords.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Numofrecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Numofrecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numofrecords.ForeColor = System.Drawing.Color.Black;
            this.Numofrecords.Location = new System.Drawing.Point(25, 54);
            this.Numofrecords.Margin = new System.Windows.Forms.Padding(2);
            this.Numofrecords.Name = "Numofrecords";
            this.Numofrecords.Size = new System.Drawing.Size(103, 23);
            this.Numofrecords.TabIndex = 74;
            this.Numofrecords.Text = "20";
            this.Numofrecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(464, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "Num of paper\'s purshase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(333, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 72;
            this.label3.Text = "Scrap Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(180, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 71;
            this.label2.Text = "Selling Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(678, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Purchase Price";
            // 
            // scraps
            // 
            this.scraps.BackColor = System.Drawing.SystemColors.ControlLight;
            this.scraps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scraps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scraps.ForeColor = System.Drawing.Color.Black;
            this.scraps.Location = new System.Drawing.Point(328, 54);
            this.scraps.Margin = new System.Windows.Forms.Padding(2);
            this.scraps.Name = "scraps";
            this.scraps.Size = new System.Drawing.Size(103, 23);
            this.scraps.TabIndex = 69;
            this.scraps.Text = "0.05";
            this.scraps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sel_Price
            // 
            this.sel_Price.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sel_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sel_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_Price.ForeColor = System.Drawing.Color.Black;
            this.sel_Price.Location = new System.Drawing.Point(183, 54);
            this.sel_Price.Margin = new System.Windows.Forms.Padding(2);
            this.sel_Price.Name = "sel_Price";
            this.sel_Price.Size = new System.Drawing.Size(103, 23);
            this.sel_Price.TabIndex = 68;
            this.sel_Price.Text = "0.50";
            this.sel_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Purchaseprice
            // 
            this.Purchaseprice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Purchaseprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Purchaseprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchaseprice.ForeColor = System.Drawing.Color.Black;
            this.Purchaseprice.Location = new System.Drawing.Point(693, 54);
            this.Purchaseprice.Margin = new System.Windows.Forms.Padding(2);
            this.Purchaseprice.Name = "Purchaseprice";
            this.Purchaseprice.Size = new System.Drawing.Size(91, 23);
            this.Purchaseprice.TabIndex = 67;
            this.Purchaseprice.Text = "0.33";
            this.Purchaseprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.ReadOnlyChecked = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(827, 579);
            this.Controls.Add(this.Day_type);
            this.Controls.Add(this.Demand_dist);
            this.Controls.Add(this.numofpapers);
            this.Controls.Add(this.Calc_button);
            this.Controls.Add(this.Read_File_Button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Numofrecords);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scraps);
            this.Controls.Add(this.sel_Price);
            this.Controls.Add(this.Purchaseprice);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Day_type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_dist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Day_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView Demand_dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox numofpapers;
        private System.Windows.Forms.Button Calc_button;
        private System.Windows.Forms.Button Read_File_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Numofrecords;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scraps;
        private System.Windows.Forms.TextBox sel_Price;
        private System.Windows.Forms.TextBox Purchaseprice;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}