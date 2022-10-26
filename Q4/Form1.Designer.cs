namespace Q4
{
	partial class Q4
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
			this.label1 = new System.Windows.Forms.Label();
			this.PeopleTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.CarTextBox = new System.Windows.Forms.TextBox();
			this.CalButton = new System.Windows.Forms.Button();
			this.PeopleLabel = new System.Windows.Forms.Label();
			this.CarLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(19, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "人數";
			// 
			// PeopleTextBox
			// 
			this.PeopleTextBox.Location = new System.Drawing.Point(83, 58);
			this.PeopleTextBox.Name = "PeopleTextBox";
			this.PeopleTextBox.Size = new System.Drawing.Size(100, 22);
			this.PeopleTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(196, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "車輛";
			// 
			// CarTextBox
			// 
			this.CarTextBox.Location = new System.Drawing.Point(260, 58);
			this.CarTextBox.Name = "CarTextBox";
			this.CarTextBox.Size = new System.Drawing.Size(100, 22);
			this.CarTextBox.TabIndex = 3;
			// 
			// CalButton
			// 
			this.CalButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.CalButton.Location = new System.Drawing.Point(150, 115);
			this.CalButton.Name = "CalButton";
			this.CalButton.Size = new System.Drawing.Size(92, 28);
			this.CalButton.TabIndex = 4;
			this.CalButton.Text = "計算費用";
			this.CalButton.UseVisualStyleBackColor = true;
			this.CalButton.Click += new System.EventHandler(this.CalButton_Click);
			// 
			// PeopleLabel
			// 
			this.PeopleLabel.AutoSize = true;
			this.PeopleLabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.PeopleLabel.Location = new System.Drawing.Point(12, 168);
			this.PeopleLabel.Name = "PeopleLabel";
			this.PeopleLabel.Size = new System.Drawing.Size(104, 19);
			this.PeopleLabel.TabIndex = 5;
			this.PeopleLabel.Text = "按人頭計算";
			// 
			// CarLabel
			// 
			this.CarLabel.AutoSize = true;
			this.CarLabel.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.CarLabel.Location = new System.Drawing.Point(207, 168);
			this.CarLabel.Name = "CarLabel";
			this.CarLabel.Size = new System.Drawing.Size(104, 19);
			this.CarLabel.TabIndex = 6;
			this.CarLabel.Text = "按車輛計算";
			// 
			// Q4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 303);
			this.Controls.Add(this.CarLabel);
			this.Controls.Add(this.PeopleLabel);
			this.Controls.Add(this.CalButton);
			this.Controls.Add(this.CarTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.PeopleTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Q4";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Q4";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox PeopleTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CarTextBox;
		private System.Windows.Forms.Button CalButton;
		private System.Windows.Forms.Label PeopleLabel;
		private System.Windows.Forms.Label CarLabel;
	}
}

