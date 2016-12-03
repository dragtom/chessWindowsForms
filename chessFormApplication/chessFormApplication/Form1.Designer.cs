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
            this.label3 = new System.Windows.Forms.Label();
            this.lblselectedPiece = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltoMove = new System.Windows.Forms.Label();
            this.btAImove = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(431, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "selected piece X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "selected piece Y:";
            // 
            // lblSelectedXValue
            // 
            this.lblSelectedXValue.AutoSize = true;
            this.lblSelectedXValue.Location = new System.Drawing.Point(566, 56);
            this.lblSelectedXValue.Name = "lblSelectedXValue";
            this.lblSelectedXValue.Size = new System.Drawing.Size(21, 17);
            this.lblSelectedXValue.TabIndex = 3;
            this.lblSelectedXValue.Text = "-1";
            // 
            // lblSelectedYValue
            // 
            this.lblSelectedYValue.AutoSize = true;
            this.lblSelectedYValue.Location = new System.Drawing.Point(566, 73);
            this.lblSelectedYValue.Name = "lblSelectedYValue";
            this.lblSelectedYValue.Size = new System.Drawing.Size(21, 17);
            this.lblSelectedYValue.TabIndex = 4;
            this.lblSelectedYValue.Text = "-1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "selected piece:";
            // 
            // lblselectedPiece
            // 
            this.lblselectedPiece.AutoSize = true;
            this.lblselectedPiece.Location = new System.Drawing.Point(540, 39);
            this.lblselectedPiece.Name = "lblselectedPiece";
            this.lblselectedPiece.Size = new System.Drawing.Size(21, 17);
            this.lblselectedPiece.TabIndex = 6;
            this.lblselectedPiece.Text = "-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Player to move:";
            // 
            // lbltoMove
            // 
            this.lbltoMove.AutoSize = true;
            this.lbltoMove.Location = new System.Drawing.Point(543, 22);
            this.lbltoMove.Name = "lbltoMove";
            this.lbltoMove.Size = new System.Drawing.Size(21, 17);
            this.lbltoMove.TabIndex = 8;
            this.lbltoMove.Text = "-1";
            // 
            // btAImove
            // 
            this.btAImove.Location = new System.Drawing.Point(434, 102);
            this.btAImove.Name = "btAImove";
            this.btAImove.Size = new System.Drawing.Size(169, 39);
            this.btAImove.TabIndex = 9;
            this.btAImove.Text = "Force AI to move";
            this.btAImove.UseVisualStyleBackColor = true;
            this.btAImove.Click += new System.EventHandler(this.btAImove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 432);
            this.Controls.Add(this.btAImove);
            this.Controls.Add(this.lbltoMove);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblselectedPiece);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblselectedPiece;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltoMove;
        private System.Windows.Forms.Button btAImove;
    }
}

