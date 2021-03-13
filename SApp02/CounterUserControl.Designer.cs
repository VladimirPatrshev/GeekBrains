namespace SApp02
{
    partial class CounterUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCounter = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.tbCounter = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCounter
            // 
            this.btnCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCounter.Location = new System.Drawing.Point(167, 75);
            this.btnCounter.Name = "btnCounter";
            this.btnCounter.Size = new System.Drawing.Size(125, 81);
            this.btnCounter.TabIndex = 0;
            this.btnCounter.Text = "Счетчик";
            this.btnCounter.UseVisualStyleBackColor = false;
            this.btnCounter.Click += new System.EventHandler(this.btnCounter_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter.Location = new System.Drawing.Point(189, 30);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(70, 20);
            this.lblCounter.TabIndex = 1;
            this.lblCounter.Text = "counter";
            // 
            // tbCounter
            // 
            this.tbCounter.Location = new System.Drawing.Point(15, 20);
            this.tbCounter.Name = "tbCounter";
            this.tbCounter.Size = new System.Drawing.Size(147, 20);
            this.tbCounter.TabIndex = 2;
            this.tbCounter.Text = "Счетчик";
            this.tbCounter.TextChanged += new System.EventHandler(this.tbCounter_TextChanged);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 55);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 13);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "label1";
            // 
            // CounterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.tbCounter);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnCounter);
            this.Name = "CounterUserControl";
            this.Size = new System.Drawing.Size(317, 198);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCounter;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.TextBox tbCounter;
        private System.Windows.Forms.Label lblText;
    }
}
