namespace GrafikaLab1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DrawPolygonButton = new System.Windows.Forms.RadioButton();
            this.MovePolygonButton = new System.Windows.Forms.RadioButton();
            this.DeleteVertexButton = new System.Windows.Forms.RadioButton();
            this.AddVertexButton = new System.Windows.Forms.RadioButton();
            this.MoveVertexButton = new System.Windows.Forms.RadioButton();
            this.HorizontalButton = new System.Windows.Forms.RadioButton();
            this.VerticalButton = new System.Windows.Forms.RadioButton();
            this.FixedLenghtButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeletePolygonButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(664, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 408);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 408);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeletePolygonButton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.FixedLenghtButton);
            this.panel1.Controls.Add(this.VerticalButton);
            this.panel1.Controls.Add(this.HorizontalButton);
            this.panel1.Controls.Add(this.MoveVertexButton);
            this.panel1.Controls.Add(this.AddVertexButton);
            this.panel1.Controls.Add(this.DeleteVertexButton);
            this.panel1.Controls.Add(this.MovePolygonButton);
            this.panel1.Controls.Add(this.DrawPolygonButton);
            this.panel1.Location = new System.Drawing.Point(3, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 252);
            this.panel1.TabIndex = 0;
            // 
            // DrawPolygonButton
            // 
            this.DrawPolygonButton.AutoSize = true;
            this.DrawPolygonButton.Checked = true;
            this.DrawPolygonButton.Location = new System.Drawing.Point(3, 12);
            this.DrawPolygonButton.Name = "DrawPolygonButton";
            this.DrawPolygonButton.Size = new System.Drawing.Size(91, 17);
            this.DrawPolygonButton.TabIndex = 0;
            this.DrawPolygonButton.TabStop = true;
            this.DrawPolygonButton.Text = "Draw Polygon";
            this.DrawPolygonButton.UseVisualStyleBackColor = true;
            // 
            // MovePolygonButton
            // 
            this.MovePolygonButton.AutoSize = true;
            this.MovePolygonButton.Location = new System.Drawing.Point(3, 35);
            this.MovePolygonButton.Name = "MovePolygonButton";
            this.MovePolygonButton.Size = new System.Drawing.Size(93, 17);
            this.MovePolygonButton.TabIndex = 1;
            this.MovePolygonButton.Text = "Move Polygon";
            this.MovePolygonButton.UseVisualStyleBackColor = true;
            // 
            // DeleteVertexButton
            // 
            this.DeleteVertexButton.AutoSize = true;
            this.DeleteVertexButton.Location = new System.Drawing.Point(3, 58);
            this.DeleteVertexButton.Name = "DeleteVertexButton";
            this.DeleteVertexButton.Size = new System.Drawing.Size(89, 17);
            this.DeleteVertexButton.TabIndex = 2;
            this.DeleteVertexButton.TabStop = true;
            this.DeleteVertexButton.Text = "Delete Vertex";
            this.DeleteVertexButton.UseVisualStyleBackColor = true;
            // 
            // AddVertexButton
            // 
            this.AddVertexButton.AutoSize = true;
            this.AddVertexButton.Location = new System.Drawing.Point(3, 81);
            this.AddVertexButton.Name = "AddVertexButton";
            this.AddVertexButton.Size = new System.Drawing.Size(77, 17);
            this.AddVertexButton.TabIndex = 3;
            this.AddVertexButton.TabStop = true;
            this.AddVertexButton.Text = "Add Vertex";
            this.AddVertexButton.UseVisualStyleBackColor = true;
            // 
            // MoveVertexButton
            // 
            this.MoveVertexButton.AutoSize = true;
            this.MoveVertexButton.Location = new System.Drawing.Point(3, 104);
            this.MoveVertexButton.Name = "MoveVertexButton";
            this.MoveVertexButton.Size = new System.Drawing.Size(85, 17);
            this.MoveVertexButton.TabIndex = 4;
            this.MoveVertexButton.TabStop = true;
            this.MoveVertexButton.Text = "Move Vertex";
            this.MoveVertexButton.UseVisualStyleBackColor = true;
            // 
            // HorizontalButton
            // 
            this.HorizontalButton.AutoSize = true;
            this.HorizontalButton.Location = new System.Drawing.Point(3, 127);
            this.HorizontalButton.Name = "HorizontalButton";
            this.HorizontalButton.Size = new System.Drawing.Size(100, 17);
            this.HorizontalButton.TabIndex = 5;
            this.HorizontalButton.TabStop = true;
            this.HorizontalButton.Text = "Horizontal Edge";
            this.HorizontalButton.UseVisualStyleBackColor = true;
            // 
            // VerticalButton
            // 
            this.VerticalButton.AutoSize = true;
            this.VerticalButton.Location = new System.Drawing.Point(3, 150);
            this.VerticalButton.Name = "VerticalButton";
            this.VerticalButton.Size = new System.Drawing.Size(88, 17);
            this.VerticalButton.TabIndex = 6;
            this.VerticalButton.TabStop = true;
            this.VerticalButton.Text = "Vertical Edge";
            this.VerticalButton.UseVisualStyleBackColor = true;
            // 
            // FixedLenghtButton
            // 
            this.FixedLenghtButton.AutoSize = true;
            this.FixedLenghtButton.Location = new System.Drawing.Point(3, 173);
            this.FixedLenghtButton.Name = "FixedLenghtButton";
            this.FixedLenghtButton.Size = new System.Drawing.Size(86, 17);
            this.FixedLenghtButton.TabIndex = 7;
            this.FixedLenghtButton.TabStop = true;
            this.FixedLenghtButton.Text = "Fixed Lenght";
            this.FixedLenghtButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // DeletePolygonButton
            // 
            this.DeletePolygonButton.Location = new System.Drawing.Point(4, 223);
            this.DeletePolygonButton.Name = "DeletePolygonButton";
            this.DeletePolygonButton.Size = new System.Drawing.Size(93, 23);
            this.DeletePolygonButton.TabIndex = 9;
            this.DeletePolygonButton.Text = "Delete Polygon";
            this.DeletePolygonButton.UseVisualStyleBackColor = true;
            this.DeletePolygonButton.Click += new System.EventHandler(this.DeletePolygonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 427);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrafikaLab1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton MovePolygonButton;
        private System.Windows.Forms.RadioButton DrawPolygonButton;
        private System.Windows.Forms.Button DeletePolygonButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton FixedLenghtButton;
        private System.Windows.Forms.RadioButton VerticalButton;
        private System.Windows.Forms.RadioButton HorizontalButton;
        private System.Windows.Forms.RadioButton MoveVertexButton;
        private System.Windows.Forms.RadioButton AddVertexButton;
        private System.Windows.Forms.RadioButton DeleteVertexButton;
    }
}

