
namespace praktikum_w14
{
    partial class Team
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
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTeamName = new System.Windows.Forms.Label();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelStadium = new System.Windows.Forms.Label();
            this.labelTopScorer = new System.Windows.Forms.Label();
            this.labelWorstDisc = new System.Windows.Forms.Label();
            this.dataGridViewMatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(54, 34);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(71, 56);
            this.buttonFirst.TabIndex = 0;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(145, 34);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(71, 56);
            this.buttonPrev.TabIndex = 1;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(242, 34);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(71, 56);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(343, 34);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(71, 56);
            this.buttonLast.TabIndex = 3;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manager :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stadium :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Top Scorer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Worst Discipline :";
            // 
            // labelTeamName
            // 
            this.labelTeamName.AutoSize = true;
            this.labelTeamName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTeamName.Location = new System.Drawing.Point(210, 125);
            this.labelTeamName.Name = "labelTeamName";
            this.labelTeamName.Size = new System.Drawing.Size(0, 20);
            this.labelTeamName.TabIndex = 9;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(210, 164);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(0, 20);
            this.labelManager.TabIndex = 10;
            // 
            // labelStadium
            // 
            this.labelStadium.AutoSize = true;
            this.labelStadium.Location = new System.Drawing.Point(210, 205);
            this.labelStadium.Name = "labelStadium";
            this.labelStadium.Size = new System.Drawing.Size(0, 20);
            this.labelStadium.TabIndex = 11;
            // 
            // labelTopScorer
            // 
            this.labelTopScorer.AutoSize = true;
            this.labelTopScorer.Location = new System.Drawing.Point(210, 245);
            this.labelTopScorer.Name = "labelTopScorer";
            this.labelTopScorer.Size = new System.Drawing.Size(0, 20);
            this.labelTopScorer.TabIndex = 12;
            // 
            // labelWorstDisc
            // 
            this.labelWorstDisc.AutoSize = true;
            this.labelWorstDisc.Location = new System.Drawing.Point(210, 287);
            this.labelWorstDisc.Name = "labelWorstDisc";
            this.labelWorstDisc.Size = new System.Drawing.Size(0, 20);
            this.labelWorstDisc.TabIndex = 13;
            // 
            // dataGridViewMatch
            // 
            this.dataGridViewMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatch.Location = new System.Drawing.Point(54, 336);
            this.dataGridViewMatch.Name = "dataGridViewMatch";
            this.dataGridViewMatch.RowHeadersWidth = 62;
            this.dataGridViewMatch.RowTemplate.Height = 28;
            this.dataGridViewMatch.Size = new System.Drawing.Size(767, 328);
            this.dataGridViewMatch.TabIndex = 14;
            // 
            // Team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 688);
            this.Controls.Add(this.dataGridViewMatch);
            this.Controls.Add(this.labelWorstDisc);
            this.Controls.Add(this.labelTopScorer);
            this.Controls.Add(this.labelStadium);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelTeamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonFirst);
            this.Name = "Team";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Team_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTeamName;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label labelStadium;
        private System.Windows.Forms.Label labelTopScorer;
        private System.Windows.Forms.Label labelWorstDisc;
        private System.Windows.Forms.DataGridView dataGridViewMatch;
    }
}

