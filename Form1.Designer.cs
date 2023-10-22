
namespace PasswordGenerator {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.Label label1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.LowerCase = new System.Windows.Forms.CheckBox();
			this.UpperCase = new System.Windows.Forms.CheckBox();
			this.Numbers = new System.Windows.Forms.CheckBox();
			this.Symbols = new System.Windows.Forms.CheckBox();
			this.GeneratePassword = new System.Windows.Forms.Button();
			this.PasswordOut = new System.Windows.Forms.Label();
			this.PasswordLength = new System.Windows.Forms.NumericUpDown();
			this.CopyPassword = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PasswordLength)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(375, 70);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(111, 16);
			label1.TabIndex = 7;
			label1.Text = "Password Length";
			// 
			// LowerCase
			// 
			this.LowerCase.AutoSize = true;
			this.LowerCase.Checked = true;
			this.LowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
			this.LowerCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LowerCase.Location = new System.Drawing.Point(102, 65);
			this.LowerCase.Margin = new System.Windows.Forms.Padding(4);
			this.LowerCase.Name = "LowerCase";
			this.LowerCase.Size = new System.Drawing.Size(98, 20);
			this.LowerCase.TabIndex = 0;
			this.LowerCase.Text = "Lower Case";
			this.LowerCase.UseVisualStyleBackColor = true;
			// 
			// UpperCase
			// 
			this.UpperCase.AutoSize = true;
			this.UpperCase.Checked = true;
			this.UpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
			this.UpperCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpperCase.Location = new System.Drawing.Point(102, 93);
			this.UpperCase.Margin = new System.Windows.Forms.Padding(4);
			this.UpperCase.Name = "UpperCase";
			this.UpperCase.Size = new System.Drawing.Size(100, 20);
			this.UpperCase.TabIndex = 1;
			this.UpperCase.Text = "Upper Case";
			this.UpperCase.UseVisualStyleBackColor = true;
			// 
			// Numbers
			// 
			this.Numbers.AutoSize = true;
			this.Numbers.Checked = true;
			this.Numbers.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Numbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Numbers.Location = new System.Drawing.Point(102, 121);
			this.Numbers.Margin = new System.Windows.Forms.Padding(4);
			this.Numbers.Name = "Numbers";
			this.Numbers.Size = new System.Drawing.Size(82, 20);
			this.Numbers.TabIndex = 2;
			this.Numbers.Text = "Numbers";
			this.Numbers.UseVisualStyleBackColor = true;
			// 
			// Symbols
			// 
			this.Symbols.AutoSize = true;
			this.Symbols.Checked = true;
			this.Symbols.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Symbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Symbols.Location = new System.Drawing.Point(102, 149);
			this.Symbols.Margin = new System.Windows.Forms.Padding(4);
			this.Symbols.Name = "Symbols";
			this.Symbols.Size = new System.Drawing.Size(80, 20);
			this.Symbols.TabIndex = 3;
			this.Symbols.Text = "Symbols";
			this.Symbols.UseVisualStyleBackColor = true;
			// 
			// GeneratePassword
			// 
			this.GeneratePassword.Location = new System.Drawing.Point(280, 103);
			this.GeneratePassword.Name = "GeneratePassword";
			this.GeneratePassword.Size = new System.Drawing.Size(206, 38);
			this.GeneratePassword.TabIndex = 4;
			this.GeneratePassword.Text = "Generate Password";
			this.GeneratePassword.UseVisualStyleBackColor = true;
			this.GeneratePassword.Click += new System.EventHandler(this.GeneratePassword_Click);
			// 
			// PasswordOut
			// 
			this.PasswordOut.AutoSize = true;
			this.PasswordOut.Location = new System.Drawing.Point(41, 243);
			this.PasswordOut.MaximumSize = new System.Drawing.Size(500, 0);
			this.PasswordOut.MinimumSize = new System.Drawing.Size(500, 50);
			this.PasswordOut.Name = "PasswordOut";
			this.PasswordOut.Size = new System.Drawing.Size(500, 50);
			this.PasswordOut.TabIndex = 5;
			this.PasswordOut.Text = "Password Output";
			this.PasswordOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// PasswordLength
			// 
			this.PasswordLength.Location = new System.Drawing.Point(280, 68);
			this.PasswordLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.PasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.PasswordLength.Name = "PasswordLength";
			this.PasswordLength.Size = new System.Drawing.Size(89, 22);
			this.PasswordLength.TabIndex = 6;
			this.PasswordLength.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
			// 
			// CopyPassword
			// 
			this.CopyPassword.Location = new System.Drawing.Point(280, 147);
			this.CopyPassword.Name = "CopyPassword";
			this.CopyPassword.Size = new System.Drawing.Size(206, 38);
			this.CopyPassword.TabIndex = 8;
			this.CopyPassword.Text = "Copy Password";
			this.CopyPassword.UseVisualStyleBackColor = true;
			this.CopyPassword.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 377);
			this.Controls.Add(this.CopyPassword);
			this.Controls.Add(label1);
			this.Controls.Add(this.PasswordLength);
			this.Controls.Add(this.PasswordOut);
			this.Controls.Add(this.GeneratePassword);
			this.Controls.Add(this.Symbols);
			this.Controls.Add(this.Numbers);
			this.Controls.Add(this.UpperCase);
			this.Controls.Add(this.LowerCase);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Password Generator";
			((System.ComponentModel.ISupportInitialize)(this.PasswordLength)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox LowerCase;
		private System.Windows.Forms.CheckBox UpperCase;
		private System.Windows.Forms.CheckBox Numbers;
		private System.Windows.Forms.CheckBox Symbols;
		private System.Windows.Forms.Button GeneratePassword;
		private System.Windows.Forms.Label PasswordOut;
		private System.Windows.Forms.NumericUpDown PasswordLength;
		private System.Windows.Forms.Button CopyPassword;
	}
}

