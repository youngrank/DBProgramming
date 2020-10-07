namespace BasicFileIO
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
            this.buttonBinaryWrite = new System.Windows.Forms.Button();
            this.buttonBinaryRead = new System.Windows.Forms.Button();
            this.buttonStreamWriter = new System.Windows.Forms.Button();
            this.buttonStreamReader = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBinaryWrite
            // 
            this.buttonBinaryWrite.Location = new System.Drawing.Point(35, 29);
            this.buttonBinaryWrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBinaryWrite.Name = "buttonBinaryWrite";
            this.buttonBinaryWrite.Size = new System.Drawing.Size(143, 43);
            this.buttonBinaryWrite.TabIndex = 0;
            this.buttonBinaryWrite.Text = "Binary Writer";
            this.buttonBinaryWrite.UseVisualStyleBackColor = true;
            this.buttonBinaryWrite.Click += new System.EventHandler(this.buttonBinaryWriter_Click);
            // 
            // buttonBinaryRead
            // 
            this.buttonBinaryRead.Location = new System.Drawing.Point(184, 29);
            this.buttonBinaryRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBinaryRead.Name = "buttonBinaryRead";
            this.buttonBinaryRead.Size = new System.Drawing.Size(143, 43);
            this.buttonBinaryRead.TabIndex = 1;
            this.buttonBinaryRead.Text = "Binary Reader";
            this.buttonBinaryRead.UseVisualStyleBackColor = true;
            this.buttonBinaryRead.Click += new System.EventHandler(this.buttonBinaryReader_Click);
            // 
            // buttonStreamWriter
            // 
            this.buttonStreamWriter.Location = new System.Drawing.Point(350, 29);
            this.buttonStreamWriter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStreamWriter.Name = "buttonStreamWriter";
            this.buttonStreamWriter.Size = new System.Drawing.Size(143, 43);
            this.buttonStreamWriter.TabIndex = 2;
            this.buttonStreamWriter.Text = "Stream Writer";
            this.buttonStreamWriter.UseVisualStyleBackColor = true;
            this.buttonStreamWriter.Click += new System.EventHandler(this.buttonStreamWriter_Click);
            // 
            // buttonStreamReader
            // 
            this.buttonStreamReader.Location = new System.Drawing.Point(499, 29);
            this.buttonStreamReader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStreamReader.Name = "buttonStreamReader";
            this.buttonStreamReader.Size = new System.Drawing.Size(143, 43);
            this.buttonStreamReader.TabIndex = 3;
            this.buttonStreamReader.Text = "Stream Reader";
            this.buttonStreamReader.UseVisualStyleBackColor = true;
            this.buttonStreamReader.Click += new System.EventHandler(this.buttonStreamReader_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Location = new System.Drawing.Point(35, 95);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(607, 222);
            this.textBoxDisplay.TabIndex = 4;
            this.textBoxDisplay.Text = "Hello";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 356);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonStreamReader);
            this.Controls.Add(this.buttonStreamWriter);
            this.Controls.Add(this.buttonBinaryRead);
            this.Controls.Add(this.buttonBinaryWrite);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBinaryWrite;
        private System.Windows.Forms.Button buttonBinaryRead;
        private System.Windows.Forms.Button buttonStreamWriter;
        private System.Windows.Forms.Button buttonStreamReader;
        private System.Windows.Forms.TextBox textBoxDisplay;
    }
}

