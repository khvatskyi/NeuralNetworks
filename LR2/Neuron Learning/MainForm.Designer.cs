
namespace Neuron_Learning
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cBoxChooseNumber = new System.Windows.Forms.ComboBox();
            this.lblChooseNumber = new System.Windows.Forms.Label();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnNewNeuron = new System.Windows.Forms.Button();
            this.pBarNeuronLearned = new System.Windows.Forms.ProgressBar();
            this.nUdNumberOfIterations = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfIterations = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCompletedIterations = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUdNumberOfIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxChooseNumber
            // 
            this.cBoxChooseNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBoxChooseNumber.FormattingEnabled = true;
            this.cBoxChooseNumber.Location = new System.Drawing.Point(342, 194);
            this.cBoxChooseNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cBoxChooseNumber.Name = "cBoxChooseNumber";
            this.cBoxChooseNumber.Size = new System.Drawing.Size(222, 39);
            this.cBoxChooseNumber.TabIndex = 0;
            // 
            // lblChooseNumber
            // 
            this.lblChooseNumber.AutoSize = true;
            this.lblChooseNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChooseNumber.Location = new System.Drawing.Point(135, 194);
            this.lblChooseNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChooseNumber.Name = "lblChooseNumber";
            this.lblChooseNumber.Size = new System.Drawing.Size(193, 32);
            this.lblChooseNumber.TabIndex = 1;
            this.lblChooseNumber.Text = "Виберіть цифру:";
            // 
            // btnLearn
            // 
            this.btnLearn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLearn.Location = new System.Drawing.Point(578, 248);
            this.btnLearn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(126, 40);
            this.btnLearn.TabIndex = 2;
            this.btnLearn.Text = "Вчити!";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnNewNeuron
            // 
            this.btnNewNeuron.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewNeuron.Location = new System.Drawing.Point(24, 22);
            this.btnNewNeuron.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewNeuron.Name = "btnNewNeuron";
            this.btnNewNeuron.Size = new System.Drawing.Size(249, 51);
            this.btnNewNeuron.TabIndex = 3;
            this.btnNewNeuron.Text = "Новий нейрон";
            this.btnNewNeuron.UseVisualStyleBackColor = true;
            this.btnNewNeuron.Click += new System.EventHandler(this.btnNewNeuron_Click);
            // 
            // pBarNeuronLearned
            // 
            this.pBarNeuronLearned.Location = new System.Drawing.Point(24, 492);
            this.pBarNeuronLearned.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pBarNeuronLearned.Name = "pBarNeuronLearned";
            this.pBarNeuronLearned.Size = new System.Drawing.Size(849, 21);
            this.pBarNeuronLearned.TabIndex = 4;
            this.pBarNeuronLearned.Tag = "Прогрес навчання";
            // 
            // nUdNumberOfIterations
            // 
            this.nUdNumberOfIterations.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nUdNumberOfIterations.Location = new System.Drawing.Point(342, 248);
            this.nUdNumberOfIterations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nUdNumberOfIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUdNumberOfIterations.Name = "nUdNumberOfIterations";
            this.nUdNumberOfIterations.Size = new System.Drawing.Size(221, 43);
            this.nUdNumberOfIterations.TabIndex = 5;
            this.nUdNumberOfIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumberOfIterations
            // 
            this.lblNumberOfIterations.AutoSize = true;
            this.lblNumberOfIterations.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumberOfIterations.Location = new System.Drawing.Point(129, 252);
            this.lblNumberOfIterations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfIterations.Name = "lblNumberOfIterations";
            this.lblNumberOfIterations.Size = new System.Drawing.Size(199, 32);
            this.lblNumberOfIterations.TabIndex = 6;
            this.lblNumberOfIterations.Text = "Ітерації начання:";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(578, 194);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(126, 37);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Перевірити";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCompletedIterations
            // 
            this.lblCompletedIterations.AutoSize = true;
            this.lblCompletedIterations.Location = new System.Drawing.Point(24, 454);
            this.lblCompletedIterations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompletedIterations.Name = "lblCompletedIterations";
            this.lblCompletedIterations.Size = new System.Drawing.Size(0, 20);
            this.lblCompletedIterations.TabIndex = 8;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(774, 22);
            this.lblLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(0, 20);
            this.lblLog.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 533);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblCompletedIterations);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblNumberOfIterations);
            this.Controls.Add(this.nUdNumberOfIterations);
            this.Controls.Add(this.pBarNeuronLearned);
            this.Controls.Add(this.btnNewNeuron);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.lblChooseNumber);
            this.Controls.Add(this.cBoxChooseNumber);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Навчання нейрона";
            ((System.ComponentModel.ISupportInitialize)(this.nUdNumberOfIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxChooseNumber;
        private System.Windows.Forms.Label lblChooseNumber;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnNewNeuron;
        private System.Windows.Forms.ProgressBar pBarNeuronLearned;
        private System.Windows.Forms.NumericUpDown nUdNumberOfIterations;
        private System.Windows.Forms.Label lblNumberOfIterations;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCompletedIterations;
        private System.Windows.Forms.Label lblLog;
    }
}

