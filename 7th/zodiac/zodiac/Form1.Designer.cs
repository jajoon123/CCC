namespace zodiac
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(112, 47);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(157, 12);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "태어난 연도를 입력하세요 : ";
            this.lblPrompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(114, 72);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(155, 21);
            this.tb_year.TabIndex = 1;
            // 
            // btn_run
            // 
            this.btn_run.Font = new System.Drawing.Font("굴림체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_run.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_run.Location = new System.Drawing.Point(321, 38);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(140, 55);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "띠 알아보기";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(114, 120);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(347, 296);
            this.pbox.TabIndex = 3;
            this.pbox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.lblPrompt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.PictureBox pbox;
    }
}

