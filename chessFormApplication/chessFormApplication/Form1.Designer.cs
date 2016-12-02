namespace chessFormApplication
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
            this.pnl_board = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectedXValue = new System.Windows.Forms.Label();
            this.lblSelectedYValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_board
            // 
            this.pnl_board.Location = new System.Drawing.Point(12, 12);
            this.pnl_board.Name = "pnl_board";
            this.pnl_board.Size = new System.Drawing.Size(400, 400);
            this.pnl_board.TabIndex = 0;
            this.pnl_board.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_board_Paint);
            this.pnl_board.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "selected X:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "selected Y:";
            // 
            // lblSelectedXValue
            // 
            this.lblSelectedXValue.AutoSize = true;
            this.lblSelectedXValue.Location = new System.Drawing.Point(515, 38);
            this.lblSelectedXValue.Name = "lblSelectedXValue";
            this.lblSelectedXValue.Size = new System.Drawing.Size(21, 17);
            this.lblSelectedXValue.TabIndex = 3;
            this.lblSelectedXValue.Text = "-1";
            // 
            // lblSelectedYValue
            // 
            this.lblSelectedYValue.AutoSize = true;
            this.lblSelectedYValue.Location = new System.Drawing.Point(515, 64);
            this.lblSelectedYValue.Name = "lblSelectedYValue";
            this.lblSelectedYValue.Size = new System.Drawing.Size(21, 17);
            this.lblSelectedYValue.TabIndex = 4;
            this.lblSelectedYValue.Text = "-1";
            this.lblSelectedYValue.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 432);
            this.Controls.Add(this.lblSelectedYValue);
            this.Controls.Add(this.lblSelectedXValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_board);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedXValue;
        private System.Windows.Forms.Label lblSelectedYValue;
    }
}

