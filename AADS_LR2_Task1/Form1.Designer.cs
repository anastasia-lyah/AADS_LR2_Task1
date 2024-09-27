namespace AADS_LR2_Task1
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
            this.txtArray = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblBaseResult = new System.Windows.Forms.Label();
            this.lblOptimizedResult = new System.Windows.Forms.Label();
            this.lblBaseTime = new System.Windows.Forms.Label();
            this.lblOptimizedTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(272, 28);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(315, 29);
            this.txtArray.TabIndex = 0;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(322, 68);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(265, 29);
            this.txtTarget.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(211, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Знайти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblBaseResult
            // 
            this.lblBaseResult.AutoSize = true;
            this.lblBaseResult.Location = new System.Drawing.Point(24, 46);
            this.lblBaseResult.Name = "lblBaseResult";
            this.lblBaseResult.Size = new System.Drawing.Size(181, 27);
            this.lblBaseResult.TabIndex = 3;
            this.lblBaseResult.Text = "Знайдено на індексі:";
            // 
            // lblOptimizedResult
            // 
            this.lblOptimizedResult.AutoSize = true;
            this.lblOptimizedResult.Location = new System.Drawing.Point(29, 46);
            this.lblOptimizedResult.Name = "lblOptimizedResult";
            this.lblOptimizedResult.Size = new System.Drawing.Size(181, 27);
            this.lblOptimizedResult.TabIndex = 4;
            this.lblOptimizedResult.Text = "Знайдено на індексі:";
            this.lblOptimizedResult.Click += new System.EventHandler(this.lblOptimizedResult_Click);
            // 
            // lblBaseTime
            // 
            this.lblBaseTime.AutoSize = true;
            this.lblBaseTime.Location = new System.Drawing.Point(24, 86);
            this.lblBaseTime.Name = "lblBaseTime";
            this.lblBaseTime.Size = new System.Drawing.Size(125, 27);
            this.lblBaseTime.TabIndex = 5;
            this.lblBaseTime.Text = "Час базового:";
            // 
            // lblOptimizedTime
            // 
            this.lblOptimizedTime.AutoSize = true;
            this.lblOptimizedTime.Location = new System.Drawing.Point(29, 86);
            this.lblOptimizedTime.Name = "lblOptimizedTime";
            this.lblOptimizedTime.Size = new System.Drawing.Size(179, 27);
            this.lblOptimizedTime.TabIndex = 6;
            this.lblOptimizedTime.Text = "Час оптимізованого:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введіть відсортований масив:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введіть число, яке потрібно знайти:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.lblOptimizedResult);
            this.groupBox1.Controls.Add(this.lblOptimizedTime);
            this.groupBox1.Location = new System.Drawing.Point(317, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 131);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оптимізований пошук";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.lblBaseResult);
            this.groupBox2.Controls.Add(this.lblBaseTime);
            this.groupBox2.Location = new System.Drawing.Point(17, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 131);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Базовий пошук";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtArray);
            this.Font = new System.Drawing.Font("Onest", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бінарний пошук";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblBaseResult;
        private System.Windows.Forms.Label lblOptimizedResult;
        private System.Windows.Forms.Label lblBaseTime;
        private System.Windows.Forms.Label lblOptimizedTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

