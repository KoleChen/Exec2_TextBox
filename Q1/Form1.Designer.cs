namespace Q1
{
	partial class Q1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.CheckButton = new System.Windows.Forms.Button();
			this.ResultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(80, 100);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(100, 22);
			this.InputTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(43, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "請輸入數字1~99";
			// 
			// CheckButton
			// 
			this.CheckButton.Location = new System.Drawing.Point(93, 143);
			this.CheckButton.Name = "CheckButton";
			this.CheckButton.Size = new System.Drawing.Size(75, 23);
			this.CheckButton.TabIndex = 2;
			this.CheckButton.Text = "檢查";
			this.CheckButton.UseVisualStyleBackColor = true;
			this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
			// 
			// ResultLabel
			// 
			this.ResultLabel.AutoSize = true;
			this.ResultLabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ResultLabel.Location = new System.Drawing.Point(62, 181);
			this.ResultLabel.Name = "ResultLabel";
			this.ResultLabel.Size = new System.Drawing.Size(85, 19);
			this.ResultLabel.TabIndex = 3;
			this.ResultLabel.Text = "顯示結果";
			// 
			// Q1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(258, 259);
			this.Controls.Add(this.ResultLabel);
			this.Controls.Add(this.CheckButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.InputTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Q1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Q1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox InputTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button CheckButton;
		private System.Windows.Forms.Label ResultLabel;
	}
}

