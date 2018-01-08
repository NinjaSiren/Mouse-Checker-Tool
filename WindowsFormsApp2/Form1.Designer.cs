namespace WindowsFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tdelta = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lines = new System.Windows.Forms.TextBox();
            this.reset_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.about_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point(12, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(381, 13);
            this.label.TabIndex = 1;
            this.label.Text = "This program will test your mouse buttons and wheel. Click and scroll anywhere.";
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Crimson;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.display.FormattingEnabled = true;
            this.display.Location = new System.Drawing.Point(15, 41);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(469, 273);
            this.display.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(491, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mouse Wheel Checker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delta);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(494, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 51);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delta";
            // 
            // delta
            // 
            this.delta.BackColor = System.Drawing.Color.Crimson;
            this.delta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.delta.Location = new System.Drawing.Point(7, 19);
            this.delta.Name = "delta";
            this.delta.Size = new System.Drawing.Size(100, 13);
            this.delta.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tdelta);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(494, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 53);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Delta";
            // 
            // tdelta
            // 
            this.tdelta.BackColor = System.Drawing.Color.Crimson;
            this.tdelta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tdelta.Location = new System.Drawing.Point(6, 19);
            this.tdelta.Name = "tdelta";
            this.tdelta.Size = new System.Drawing.Size(100, 13);
            this.tdelta.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lines);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(494, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 51);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lines";
            // 
            // lines
            // 
            this.lines.BackColor = System.Drawing.Color.Crimson;
            this.lines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lines.Location = new System.Drawing.Point(6, 19);
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(100, 13);
            this.lines.TabIndex = 2;
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(494, 266);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(113, 23);
            this.reset_btn.TabIndex = 8;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(494, 295);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(113, 23);
            this.exit_btn.TabIndex = 9;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // about_btn
            // 
            this.about_btn.BackColor = System.Drawing.Color.Transparent;
            this.about_btn.Location = new System.Drawing.Point(494, 237);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(113, 23);
            this.about_btn.TabIndex = 10;
            this.about_btn.Text = "About";
            this.about_btn.UseVisualStyleBackColor = false;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(622, 336);
            this.Controls.Add(this.about_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mouse Checker Tool";
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Form_MouseWheel);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.TextBox delta;
        private System.Windows.Forms.TextBox tdelta;
        private System.Windows.Forms.TextBox lines;
        private System.Windows.Forms.Button about_btn;
    }
}

