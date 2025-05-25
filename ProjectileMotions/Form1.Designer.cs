namespace tests
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
            this.projectileBox = new System.Windows.Forms.PictureBox();
            this.gravityInput = new System.Windows.Forms.NumericUpDown();
            this.angleInput = new System.Windows.Forms.NumericUpDown();
            this.velocityInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.projectileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).BeginInit();
            this.SuspendLayout();
            // 
            // projectileBox
            // 
            this.projectileBox.BackColor = System.Drawing.Color.Red;
            this.projectileBox.Location = new System.Drawing.Point(13, 640);
            this.projectileBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectileBox.Name = "projectileBox";
            this.projectileBox.Size = new System.Drawing.Size(15, 15);
            this.projectileBox.TabIndex = 0;
            this.projectileBox.TabStop = false;
            // 
            // gravityInput
            // 
            this.gravityInput.DecimalPlaces = 1;
            this.gravityInput.Location = new System.Drawing.Point(228, 46);
            this.gravityInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gravityInput.Name = "gravityInput";
            this.gravityInput.Size = new System.Drawing.Size(180, 26);
            this.gravityInput.TabIndex = 1;
            this.gravityInput.Value = new decimal(new int[] {
            98,
            0,
            0,
            65536});
            // 
            // angleInput
            // 
            this.angleInput.Location = new System.Drawing.Point(443, 46);
            this.angleInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.angleInput.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleInput.Name = "angleInput";
            this.angleInput.Size = new System.Drawing.Size(180, 26);
            this.angleInput.TabIndex = 2;
            this.angleInput.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // velocityInput
            // 
            this.velocityInput.Location = new System.Drawing.Point(658, 47);
            this.velocityInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.velocityInput.Name = "velocityInput";
            this.velocityInput.Size = new System.Drawing.Size(180, 26);
            this.velocityInput.TabIndex = 3;
            this.velocityInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "gravity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "angle(θ)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(683, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "initial velocity";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(859, 46);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(104, 43);
            this.start.TabIndex = 7;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Height";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(13, 46);
            this.heightInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.heightInput.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(180, 26);
            this.heightInput.TabIndex = 8;
            this.heightInput.ValueChanged += new System.EventHandler(this.heightInput_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 660);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.velocityInput);
            this.Controls.Add(this.angleInput);
            this.Controls.Add(this.gravityInput);
            this.Controls.Add(this.projectileBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.projectileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velocityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox projectileBox;
        private System.Windows.Forms.NumericUpDown gravityInput;
        private System.Windows.Forms.NumericUpDown angleInput;
        private System.Windows.Forms.NumericUpDown velocityInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown heightInput;
    }
}

