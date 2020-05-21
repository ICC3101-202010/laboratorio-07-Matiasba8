namespace Lab7_MatíasBustos
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Result = new System.Windows.Forms.TextBox();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.ResultButtonOperation = new System.Windows.Forms.Button();
            this.DeleteAllButtonFromView = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.AnsButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MultiplicationButton = new System.Windows.Forms.Button();
            this.DeleteOneButtonFromView = new System.Windows.Forms.Button();
            this.Num8Button = new System.Windows.Forms.Button();
            this.Num9Button = new System.Windows.Forms.Button();
            this.Num0Button = new System.Windows.Forms.Button();
            this.Num3Button = new System.Windows.Forms.Button();
            this.Num6Button = new System.Windows.Forms.Button();
            this.Num5Button = new System.Windows.Forms.Button();
            this.Num4Button = new System.Windows.Forms.Button();
            this.Num2Button = new System.Windows.Forms.Button();
            this.Num1Button = new System.Windows.Forms.Button();
            this.Num7Button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Result);
            this.panel1.Controls.Add(this.SubtractButton);
            this.panel1.Controls.Add(this.ResultButtonOperation);
            this.panel1.Controls.Add(this.DeleteAllButtonFromView);
            this.panel1.Controls.Add(this.DivisionButton);
            this.panel1.Controls.Add(this.PointButton);
            this.panel1.Controls.Add(this.AnsButton);
            this.panel1.Controls.Add(this.PlusButton);
            this.panel1.Controls.Add(this.MultiplicationButton);
            this.panel1.Controls.Add(this.DeleteOneButtonFromView);
            this.panel1.Controls.Add(this.Num8Button);
            this.panel1.Controls.Add(this.Num9Button);
            this.panel1.Controls.Add(this.Num0Button);
            this.panel1.Controls.Add(this.Num3Button);
            this.panel1.Controls.Add(this.Num6Button);
            this.panel1.Controls.Add(this.Num5Button);
            this.panel1.Controls.Add(this.Num4Button);
            this.panel1.Controls.Add(this.Num2Button);
            this.panel1.Controls.Add(this.Num1Button);
            this.panel1.Controls.Add(this.Num7Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 257);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(12, 12);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(252, 44);
            this.Result.TabIndex = 39;
            this.Result.Text = "0";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SubtractButton
            // 
            this.SubtractButton.AccessibleName = "";
            this.SubtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractButton.Location = new System.Drawing.Point(218, 162);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(46, 35);
            this.SubtractButton.TabIndex = 38;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // ResultButtonOperation
            // 
            this.ResultButtonOperation.AccessibleName = "";
            this.ResultButtonOperation.Location = new System.Drawing.Point(218, 203);
            this.ResultButtonOperation.Name = "ResultButtonOperation";
            this.ResultButtonOperation.Size = new System.Drawing.Size(46, 35);
            this.ResultButtonOperation.TabIndex = 37;
            this.ResultButtonOperation.Text = "=";
            this.ResultButtonOperation.UseVisualStyleBackColor = true;
            this.ResultButtonOperation.Click += new System.EventHandler(this.ResultButtonOperation_Click);
            // 
            // DeleteAllButtonFromView
            // 
            this.DeleteAllButtonFromView.AccessibleName = "";
            this.DeleteAllButtonFromView.Location = new System.Drawing.Point(218, 77);
            this.DeleteAllButtonFromView.Name = "DeleteAllButtonFromView";
            this.DeleteAllButtonFromView.Size = new System.Drawing.Size(46, 35);
            this.DeleteAllButtonFromView.TabIndex = 36;
            this.DeleteAllButtonFromView.Text = "AC";
            this.DeleteAllButtonFromView.UseVisualStyleBackColor = true;
            this.DeleteAllButtonFromView.Click += new System.EventHandler(this.DeleteAllButtonFromView_Click);
            // 
            // DivisionButton
            // 
            this.DivisionButton.AccessibleName = "";
            this.DivisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionButton.Location = new System.Drawing.Point(218, 118);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(46, 35);
            this.DivisionButton.TabIndex = 35;
            this.DivisionButton.Text = ":";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // PointButton
            // 
            this.PointButton.AccessibleName = "";
            this.PointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointButton.Location = new System.Drawing.Point(64, 200);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(46, 35);
            this.PointButton.TabIndex = 34;
            this.PointButton.Text = ",";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // AnsButton
            // 
            this.AnsButton.AccessibleName = "";
            this.AnsButton.Location = new System.Drawing.Point(166, 203);
            this.AnsButton.Name = "AnsButton";
            this.AnsButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AnsButton.Size = new System.Drawing.Size(46, 35);
            this.AnsButton.TabIndex = 33;
            this.AnsButton.Text = "Ans";
            this.AnsButton.UseVisualStyleBackColor = true;
            this.AnsButton.Click += new System.EventHandler(this.AnsButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.AccessibleName = "";
            this.PlusButton.Location = new System.Drawing.Point(166, 162);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(46, 35);
            this.PlusButton.TabIndex = 32;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.AccessibleName = "";
            this.MultiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicationButton.Location = new System.Drawing.Point(166, 121);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(46, 35);
            this.MultiplicationButton.TabIndex = 31;
            this.MultiplicationButton.Text = "*";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.Click += new System.EventHandler(this.Operator_Click);
            // 
            // DeleteOneButtonFromView
            // 
            this.DeleteOneButtonFromView.AccessibleName = "";
            this.DeleteOneButtonFromView.Location = new System.Drawing.Point(166, 77);
            this.DeleteOneButtonFromView.Name = "DeleteOneButtonFromView";
            this.DeleteOneButtonFromView.Size = new System.Drawing.Size(46, 35);
            this.DeleteOneButtonFromView.TabIndex = 30;
            this.DeleteOneButtonFromView.Text = "DEL";
            this.DeleteOneButtonFromView.UseVisualStyleBackColor = true;
            this.DeleteOneButtonFromView.Click += new System.EventHandler(this.DeleteOneButtonFromView_Click);
            // 
            // Num8Button
            // 
            this.Num8Button.AccessibleName = "";
            this.Num8Button.Location = new System.Drawing.Point(64, 77);
            this.Num8Button.Name = "Num8Button";
            this.Num8Button.Size = new System.Drawing.Size(46, 35);
            this.Num8Button.TabIndex = 29;
            this.Num8Button.Text = "8";
            this.Num8Button.UseVisualStyleBackColor = true;
            this.Num8Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num9Button
            // 
            this.Num9Button.AccessibleName = "";
            this.Num9Button.Location = new System.Drawing.Point(116, 77);
            this.Num9Button.Name = "Num9Button";
            this.Num9Button.Size = new System.Drawing.Size(46, 35);
            this.Num9Button.TabIndex = 28;
            this.Num9Button.Text = "9";
            this.Num9Button.UseVisualStyleBackColor = true;
            this.Num9Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num0Button
            // 
            this.Num0Button.AccessibleName = "";
            this.Num0Button.Location = new System.Drawing.Point(12, 200);
            this.Num0Button.Name = "Num0Button";
            this.Num0Button.Size = new System.Drawing.Size(46, 35);
            this.Num0Button.TabIndex = 27;
            this.Num0Button.Text = "0";
            this.Num0Button.UseVisualStyleBackColor = true;
            this.Num0Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num3Button
            // 
            this.Num3Button.AccessibleName = "";
            this.Num3Button.Location = new System.Drawing.Point(116, 159);
            this.Num3Button.Name = "Num3Button";
            this.Num3Button.Size = new System.Drawing.Size(46, 35);
            this.Num3Button.TabIndex = 26;
            this.Num3Button.Text = "3";
            this.Num3Button.UseVisualStyleBackColor = true;
            this.Num3Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num6Button
            // 
            this.Num6Button.AccessibleName = "";
            this.Num6Button.Location = new System.Drawing.Point(116, 118);
            this.Num6Button.Name = "Num6Button";
            this.Num6Button.Size = new System.Drawing.Size(46, 35);
            this.Num6Button.TabIndex = 25;
            this.Num6Button.Text = "6";
            this.Num6Button.UseVisualStyleBackColor = true;
            this.Num6Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num5Button
            // 
            this.Num5Button.AccessibleName = "";
            this.Num5Button.Location = new System.Drawing.Point(64, 118);
            this.Num5Button.Name = "Num5Button";
            this.Num5Button.Size = new System.Drawing.Size(46, 35);
            this.Num5Button.TabIndex = 24;
            this.Num5Button.Text = "5";
            this.Num5Button.UseVisualStyleBackColor = true;
            this.Num5Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num4Button
            // 
            this.Num4Button.AccessibleName = "";
            this.Num4Button.Location = new System.Drawing.Point(12, 118);
            this.Num4Button.Name = "Num4Button";
            this.Num4Button.Size = new System.Drawing.Size(46, 35);
            this.Num4Button.TabIndex = 23;
            this.Num4Button.Text = "4";
            this.Num4Button.UseVisualStyleBackColor = true;
            this.Num4Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num2Button
            // 
            this.Num2Button.AccessibleName = "";
            this.Num2Button.Location = new System.Drawing.Point(64, 159);
            this.Num2Button.Name = "Num2Button";
            this.Num2Button.Size = new System.Drawing.Size(46, 35);
            this.Num2Button.TabIndex = 22;
            this.Num2Button.Text = "2";
            this.Num2Button.UseVisualStyleBackColor = true;
            this.Num2Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num1Button
            // 
            this.Num1Button.AccessibleName = "";
            this.Num1Button.Location = new System.Drawing.Point(12, 159);
            this.Num1Button.Name = "Num1Button";
            this.Num1Button.Size = new System.Drawing.Size(46, 35);
            this.Num1Button.TabIndex = 21;
            this.Num1Button.Text = "1";
            this.Num1Button.UseVisualStyleBackColor = true;
            this.Num1Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num7Button
            // 
            this.Num7Button.AccessibleName = "";
            this.Num7Button.Location = new System.Drawing.Point(12, 77);
            this.Num7Button.Name = "Num7Button";
            this.Num7Button.Size = new System.Drawing.Size(46, 35);
            this.Num7Button.TabIndex = 20;
            this.Num7Button.Text = "7";
            this.Num7Button.UseVisualStyleBackColor = true;
            this.Num7Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 257);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button ResultButtonOperation;
        private System.Windows.Forms.Button DeleteAllButtonFromView;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Button AnsButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button MultiplicationButton;
        private System.Windows.Forms.Button DeleteOneButtonFromView;
        private System.Windows.Forms.Button Num8Button;
        private System.Windows.Forms.Button Num9Button;
        private System.Windows.Forms.Button Num0Button;
        private System.Windows.Forms.Button Num3Button;
        private System.Windows.Forms.Button Num6Button;
        private System.Windows.Forms.Button Num5Button;
        private System.Windows.Forms.Button Num4Button;
        private System.Windows.Forms.Button Num2Button;
        private System.Windows.Forms.Button Num1Button;
        private System.Windows.Forms.Button Num7Button;
    }
}