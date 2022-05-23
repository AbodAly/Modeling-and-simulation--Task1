using System;
using System.Windows.Forms;

namespace NewspaperSellerSimulation
{
    partial class Simulation_Table
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Demand_dist = new System.Windows.Forms.DataGridView();
            this.TotalLostProfit = new System.Windows.Forms.TextBox();
            this.TotalSalesProfit = new System.Windows.Forms.TextBox();
            this.TotalCost = new System.Windows.Forms.TextBox();
            this.DaysWithMoreDemand = new System.Windows.Forms.TextBox();
            this.TotalNetProfit = new System.Windows.Forms.TextBox();
            this.TotalScrapProfit = new System.Windows.Forms.TextBox();
            this.DaysWithUnsoldPapers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Demand_dist)).BeginInit();
            this.SuspendLayout();
            // 
            // Demand_dist
            // 
            this.Demand_dist.AllowUserToAddRows = false;
            this.Demand_dist.AllowUserToDeleteRows = false;
            this.Demand_dist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Demand_dist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Demand_dist.BackgroundColor = System.Drawing.Color.Silver;
            this.Demand_dist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Demand_dist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Demand_dist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Demand_dist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Demand_dist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Demand_dist.DefaultCellStyle = dataGridViewCellStyle3;
            this.Demand_dist.EnableHeadersVisualStyles = false;
            this.Demand_dist.GridColor = System.Drawing.Color.Black;
            this.Demand_dist.Location = new System.Drawing.Point(-5, 30);
            this.Demand_dist.Margin = new System.Windows.Forms.Padding(2);
            this.Demand_dist.Name = "Demand_dist";
            this.Demand_dist.ReadOnly = true;
            this.Demand_dist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Uighur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Demand_dist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Demand_dist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.Demand_dist.RowTemplate.Height = 30;
            this.Demand_dist.Size = new System.Drawing.Size(950, 510);
            this.Demand_dist.TabIndex = 20;
            this.Demand_dist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Demand_dist_CellContentClick);
            // 
            // TotalLostProfit
            // 
            this.TotalLostProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TotalLostProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TotalLostProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLostProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLostProfit.ForeColor = System.Drawing.Color.Black;
            this.TotalLostProfit.Location = new System.Drawing.Point(127, 641);
            this.TotalLostProfit.Margin = new System.Windows.Forms.Padding(2);
            this.TotalLostProfit.Name = "TotalLostProfit";
            this.TotalLostProfit.Size = new System.Drawing.Size(67, 23);
            this.TotalLostProfit.TabIndex = 59;
            // 
            // TotalSalesProfit
            // 
            this.TotalSalesProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TotalSalesProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TotalSalesProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalSalesProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesProfit.ForeColor = System.Drawing.Color.Black;
            this.TotalSalesProfit.Location = new System.Drawing.Point(252, 640);
            this.TotalSalesProfit.Margin = new System.Windows.Forms.Padding(2);
            this.TotalSalesProfit.Name = "TotalSalesProfit";
            this.TotalSalesProfit.Size = new System.Drawing.Size(67, 23);
            this.TotalSalesProfit.TabIndex = 58;
            // 
            // TotalCost
            // 
            this.TotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TotalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCost.ForeColor = System.Drawing.Color.Black;
            this.TotalCost.Location = new System.Drawing.Point(30, 643);
            this.TotalCost.Margin = new System.Windows.Forms.Padding(2);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(67, 23);
            this.TotalCost.TabIndex = 57;
            // 
            // DaysWithMoreDemand
            // 
            this.DaysWithMoreDemand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DaysWithMoreDemand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DaysWithMoreDemand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DaysWithMoreDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysWithMoreDemand.ForeColor = System.Drawing.Color.Black;
            this.DaysWithMoreDemand.Location = new System.Drawing.Point(383, 640);
            this.DaysWithMoreDemand.Margin = new System.Windows.Forms.Padding(2);
            this.DaysWithMoreDemand.Name = "DaysWithMoreDemand";
            this.DaysWithMoreDemand.Size = new System.Drawing.Size(67, 23);
            this.DaysWithMoreDemand.TabIndex = 56;
            // 
            // TotalNetProfit
            // 
            this.TotalNetProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TotalNetProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TotalNetProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalNetProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalNetProfit.ForeColor = System.Drawing.Color.Black;
            this.TotalNetProfit.Location = new System.Drawing.Point(524, 641);
            this.TotalNetProfit.Margin = new System.Windows.Forms.Padding(2);
            this.TotalNetProfit.Name = "TotalNetProfit";
            this.TotalNetProfit.Size = new System.Drawing.Size(67, 23);
            this.TotalNetProfit.TabIndex = 55;
            // 
            // TotalScrapProfit
            // 
            this.TotalScrapProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TotalScrapProfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TotalScrapProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalScrapProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalScrapProfit.ForeColor = System.Drawing.Color.Black;
            this.TotalScrapProfit.Location = new System.Drawing.Point(635, 641);
            this.TotalScrapProfit.Margin = new System.Windows.Forms.Padding(2);
            this.TotalScrapProfit.Name = "TotalScrapProfit";
            this.TotalScrapProfit.Size = new System.Drawing.Size(67, 23);
            this.TotalScrapProfit.TabIndex = 54;
            // 
            // DaysWithUnsoldPapers
            // 
            this.DaysWithUnsoldPapers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DaysWithUnsoldPapers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DaysWithUnsoldPapers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DaysWithUnsoldPapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysWithUnsoldPapers.ForeColor = System.Drawing.Color.Black;
            this.DaysWithUnsoldPapers.Location = new System.Drawing.Point(790, 641);
            this.DaysWithUnsoldPapers.Margin = new System.Windows.Forms.Padding(2);
            this.DaysWithUnsoldPapers.Name = "DaysWithUnsoldPapers";
            this.DaysWithUnsoldPapers.Size = new System.Drawing.Size(66, 23);
            this.DaysWithUnsoldPapers.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "Total Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Total Lost Profit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 621);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 62;
            this.label3.Text = "TotalSalesProfit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(614, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "TotalScarpProfit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 621);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 15);
            this.label5.TabIndex = 64;
            this.label5.Text = "DaysWithMoreDemand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 621);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 65;
            this.label6.Text = "TotalNetProfit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(722, 621);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 15);
            this.label7.TabIndex = 66;
            this.label7.Text = "DaysWithUnsoldPapers";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Day #";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "# Of Type NewsDay";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Type Of NewsDay";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "# Of Demand";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Demand";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Revenue";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Lost Profit";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Scrap Salvage";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Column12.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column12.HeaderText = "Daily Profit";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Simulation_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalLostProfit);
            this.Controls.Add(this.TotalSalesProfit);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.DaysWithMoreDemand);
            this.Controls.Add(this.TotalNetProfit);
            this.Controls.Add(this.TotalScrapProfit);
            this.Controls.Add(this.DaysWithUnsoldPapers);
            this.Controls.Add(this.Demand_dist);
            this.Name = "Simulation_Table";
            this.Load += new System.EventHandler(this.Simulation_Table_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Demand_dist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Demand_dist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        private DataGridView Demand_dist;
        private TextBox TotalLostProfit;
        private TextBox TotalSalesProfit;
        private TextBox TotalCost;
        private TextBox DaysWithMoreDemand;
        private TextBox TotalNetProfit;
        private TextBox TotalScrapProfit;
        private TextBox DaysWithUnsoldPapers;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
    }
}