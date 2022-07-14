
namespace babuleh
{
    partial class Form3
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.Increment = new System.Windows.Forms.Button();
            this.Decrement = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(12, 49);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(80, 13);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "Первое число:";
            this.lblFirst.UseWaitCursor = true;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(14, 101);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(78, 13);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Второе число:";
            this.lblSecond.UseWaitCursor = true;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(133, 98);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 20);
            this.txtSecond.TabIndex = 2;
            this.txtSecond.UseWaitCursor = true;
            this.txtSecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(133, 46);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 3;
            this.txtFirst.UseWaitCursor = true;
            this.txtFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Increment
            // 
            this.Increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increment.Location = new System.Drawing.Point(12, 139);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(75, 23);
            this.Increment.TabIndex = 4;
            this.Increment.Text = "+";
            this.Increment.UseVisualStyleBackColor = true;
            this.Increment.UseWaitCursor = true;
            this.Increment.Click += new System.EventHandler(this.btn_click);
            // 
            // Decrement
            // 
            this.Decrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrement.Location = new System.Drawing.Point(144, 139);
            this.Decrement.Name = "Decrement";
            this.Decrement.Size = new System.Drawing.Size(75, 23);
            this.Decrement.TabIndex = 5;
            this.Decrement.Text = "-";
            this.Decrement.UseVisualStyleBackColor = true;
            this.Decrement.UseWaitCursor = true;
            this.Decrement.Click += new System.EventHandler(this.btn_click);
            // 
            // Increase
            // 
            this.Increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increase.Location = new System.Drawing.Point(12, 183);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(75, 23);
            this.Increase.TabIndex = 6;
            this.Increase.Text = "*";
            this.Increase.UseVisualStyleBackColor = true;
            this.Increase.UseWaitCursor = true;
            this.Increase.Click += new System.EventHandler(this.btn_click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(144, 183);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 23);
            this.Divide.TabIndex = 7;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.UseWaitCursor = true;
            this.Divide.Click += new System.EventHandler(this.btn_click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(46, 249);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Результат:";
            this.lblResult.UseWaitCursor = true;
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(141, 247);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(16, 17);
            this.txtResult.TabIndex = 9;
            this.txtResult.Text = "0";
            this.txtResult.UseWaitCursor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(258, 287);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form3";
            this.Text = "Form3";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Button Increment;
        private System.Windows.Forms.Button Decrement;
        private System.Windows.Forms.Button Increase;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label txtResult;
    }
}