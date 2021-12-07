
namespace guiTask_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.labRes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(76, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 112);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ответ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labRes
            // 
            this.labRes.AutoSize = true;
            this.labRes.Location = new System.Drawing.Point(581, 43);
            this.labRes.Name = "labRes";
            this.labRes.Size = new System.Drawing.Size(46, 17);
            this.labRes.TabIndex = 1;
            this.labRes.Text = "label1";
            this.labRes.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(68, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "A";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbA.Location = new System.Drawing.Point(57, 102);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(56, 38);
            this.tbA.TabIndex = 3;
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbB.Location = new System.Drawing.Point(160, 102);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(55, 38);
            this.tbB.TabIndex = 4;
            // 
            // tbH
            // 
            this.tbH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbH.Location = new System.Drawing.Point(265, 102);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(55, 38);
            this.tbH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(170, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(273, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "H";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labRes);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

