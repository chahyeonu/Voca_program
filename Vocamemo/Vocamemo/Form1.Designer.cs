namespace Vocamemo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Day = new System.Windows.Forms.ComboBox();
            this.Memorise = new System.Windows.Forms.RadioButton();
            this.Test_voca = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Day
            // 
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "Day1",
            "Day2",
            "Day3",
            "Day4",
            "Day5",
            "Day6",
            "Day7",
            "Day8",
            "Day9",
            "Day10",
            "Day11"});
            this.Day.Location = new System.Drawing.Point(12, 61);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(121, 23);
            this.Day.TabIndex = 0;
            // 
            // Memorise
            // 
            this.Memorise.AutoSize = true;
            this.Memorise.Location = new System.Drawing.Point(12, 12);
            this.Memorise.Name = "Memorise";
            this.Memorise.Size = new System.Drawing.Size(58, 19);
            this.Memorise.TabIndex = 1;
            this.Memorise.TabStop = true;
            this.Memorise.Text = "암기";
            this.Memorise.UseVisualStyleBackColor = true;
            this.Memorise.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Test_voca
            // 
            this.Test_voca.AutoSize = true;
            this.Test_voca.Location = new System.Drawing.Point(168, 12);
            this.Test_voca.Name = "Test_voca";
            this.Test_voca.Size = new System.Drawing.Size(56, 19);
            this.Test_voca.TabIndex = 2;
            this.Test_voca.TabStop = true;
            this.Test_voca.Text = "Test";
            this.Test_voca.UseVisualStyleBackColor = true;
            this.Test_voca.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 626);
            this.Controls.Add(this.Test_voca);
            this.Controls.Add(this.Memorise);
            this.Controls.Add(this.Day);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.RadioButton Memorise;
        private System.Windows.Forms.RadioButton Test_voca;
    }
}

