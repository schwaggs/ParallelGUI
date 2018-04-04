namespace AsyncGUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.singleThreadRB = new System.Windows.Forms.RadioButton();
            this.multiThreadRB = new System.Windows.Forms.RadioButton();
            this.parallelForRB = new System.Windows.Forms.RadioButton();
            this.waitAnyRB = new System.Windows.Forms.RadioButton();
            this.waitAllRB = new System.Windows.Forms.RadioButton();
            this.threadPoolRB = new System.Windows.Forms.RadioButton();
            this.awaitRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serialRB = new System.Windows.Forms.RadioButton();
            this.nonParallelRB = new System.Windows.Forms.RadioButton();
            this.parallelRB = new System.Windows.Forms.RadioButton();
            this.timeResultLB = new System.Windows.Forms.Label();
            this.noRecursionRB = new System.Windows.Forms.RadioButton();
            this.recursionRB = new System.Windows.Forms.RadioButton();
            this.stackRB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(160, 100);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(473, 326);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Non-Parallel Enumerable";
            this.columnHeader1.Width = 469;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(557, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(538, 20);
            this.textBox1.TabIndex = 3;
            // 
            // singleThreadRB
            // 
            this.singleThreadRB.AutoSize = true;
            this.singleThreadRB.Location = new System.Drawing.Point(6, 55);
            this.singleThreadRB.Name = "singleThreadRB";
            this.singleThreadRB.Size = new System.Drawing.Size(91, 17);
            this.singleThreadRB.TabIndex = 4;
            this.singleThreadRB.TabStop = true;
            this.singleThreadRB.Text = "Single Thread";
            this.singleThreadRB.UseVisualStyleBackColor = true;
            this.singleThreadRB.CheckedChanged += new System.EventHandler(this.singleThreadRB_CheckedChanged);
            // 
            // multiThreadRB
            // 
            this.multiThreadRB.AutoSize = true;
            this.multiThreadRB.Location = new System.Drawing.Point(6, 78);
            this.multiThreadRB.Name = "multiThreadRB";
            this.multiThreadRB.Size = new System.Drawing.Size(103, 17);
            this.multiThreadRB.TabIndex = 5;
            this.multiThreadRB.TabStop = true;
            this.multiThreadRB.Text = "Multiple Threads";
            this.multiThreadRB.UseVisualStyleBackColor = true;
            this.multiThreadRB.CheckedChanged += new System.EventHandler(this.multiThreadRB_CheckedChanged);
            // 
            // parallelForRB
            // 
            this.parallelForRB.AutoSize = true;
            this.parallelForRB.Location = new System.Drawing.Point(6, 124);
            this.parallelForRB.Name = "parallelForRB";
            this.parallelForRB.Size = new System.Drawing.Size(105, 17);
            this.parallelForRB.TabIndex = 6;
            this.parallelForRB.TabStop = true;
            this.parallelForRB.Text = "Parallel For Each";
            this.parallelForRB.UseVisualStyleBackColor = true;
            this.parallelForRB.CheckedChanged += new System.EventHandler(this.parallelForRB_CheckedChanged);
            // 
            // waitAnyRB
            // 
            this.waitAnyRB.AutoSize = true;
            this.waitAnyRB.Location = new System.Drawing.Point(6, 147);
            this.waitAnyRB.Name = "waitAnyRB";
            this.waitAnyRB.Size = new System.Drawing.Size(95, 17);
            this.waitAnyRB.TabIndex = 7;
            this.waitAnyRB.TabStop = true;
            this.waitAnyRB.Text = "Task Wait Any";
            this.waitAnyRB.UseVisualStyleBackColor = true;
            this.waitAnyRB.CheckedChanged += new System.EventHandler(this.waitAnyRB_CheckedChanged);
            // 
            // waitAllRB
            // 
            this.waitAllRB.AutoSize = true;
            this.waitAllRB.Location = new System.Drawing.Point(6, 170);
            this.waitAllRB.Name = "waitAllRB";
            this.waitAllRB.Size = new System.Drawing.Size(88, 17);
            this.waitAllRB.TabIndex = 8;
            this.waitAllRB.TabStop = true;
            this.waitAllRB.Text = "Task Wait All";
            this.waitAllRB.UseVisualStyleBackColor = true;
            this.waitAllRB.CheckedChanged += new System.EventHandler(this.waitAllRB_CheckedChanged);
            // 
            // threadPoolRB
            // 
            this.threadPoolRB.AutoSize = true;
            this.threadPoolRB.Location = new System.Drawing.Point(6, 101);
            this.threadPoolRB.Name = "threadPoolRB";
            this.threadPoolRB.Size = new System.Drawing.Size(83, 17);
            this.threadPoolRB.TabIndex = 9;
            this.threadPoolRB.TabStop = true;
            this.threadPoolRB.Text = "Thread Pool";
            this.threadPoolRB.UseVisualStyleBackColor = true;
            this.threadPoolRB.CheckedChanged += new System.EventHandler(this.threadPoolRB_CheckedChanged);
            // 
            // awaitRB
            // 
            this.awaitRB.AutoSize = true;
            this.awaitRB.Location = new System.Drawing.Point(6, 193);
            this.awaitRB.Name = "awaitRB";
            this.awaitRB.Size = new System.Drawing.Size(104, 17);
            this.awaitRB.TabIndex = 10;
            this.awaitRB.TabStop = true;
            this.awaitRB.Text = "Async and Await";
            this.awaitRB.UseVisualStyleBackColor = true;
            this.awaitRB.CheckedChanged += new System.EventHandler(this.awaitRB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Use Async Methods To Display All Top Directories Inside a Directory";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serialRB);
            this.groupBox1.Controls.Add(this.singleThreadRB);
            this.groupBox1.Controls.Add(this.multiThreadRB);
            this.groupBox1.Controls.Add(this.parallelForRB);
            this.groupBox1.Controls.Add(this.waitAnyRB);
            this.groupBox1.Controls.Add(this.waitAllRB);
            this.groupBox1.Controls.Add(this.threadPoolRB);
            this.groupBox1.Controls.Add(this.awaitRB);
            this.groupBox1.Location = new System.Drawing.Point(13, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 216);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standard Methods";
            // 
            // serialRB
            // 
            this.serialRB.AutoSize = true;
            this.serialRB.Location = new System.Drawing.Point(6, 32);
            this.serialRB.Name = "serialRB";
            this.serialRB.Size = new System.Drawing.Size(51, 17);
            this.serialRB.TabIndex = 11;
            this.serialRB.TabStop = true;
            this.serialRB.Text = "Serial";
            this.serialRB.UseVisualStyleBackColor = true;
            this.serialRB.CheckedChanged += new System.EventHandler(this.serialRB_CheckedChanged);
            // 
            // nonParallelRB
            // 
            this.nonParallelRB.AutoSize = true;
            this.nonParallelRB.Location = new System.Drawing.Point(4, 9);
            this.nonParallelRB.Name = "nonParallelRB";
            this.nonParallelRB.Size = new System.Drawing.Size(141, 17);
            this.nonParallelRB.TabIndex = 20;
            this.nonParallelRB.TabStop = true;
            this.nonParallelRB.Text = "Non-Parallel Enumerable";
            this.nonParallelRB.UseVisualStyleBackColor = true;
            this.nonParallelRB.CheckedChanged += new System.EventHandler(this.nonParallelRB_CheckedChanged);
            // 
            // parallelRB
            // 
            this.parallelRB.AutoSize = true;
            this.parallelRB.Location = new System.Drawing.Point(3, 32);
            this.parallelRB.Name = "parallelRB";
            this.parallelRB.Size = new System.Drawing.Size(118, 17);
            this.parallelRB.TabIndex = 21;
            this.parallelRB.TabStop = true;
            this.parallelRB.Text = "Parallel Enumerable";
            this.parallelRB.UseVisualStyleBackColor = true;
            this.parallelRB.CheckedChanged += new System.EventHandler(this.parallelRB_CheckedChanged);
            // 
            // timeResultLB
            // 
            this.timeResultLB.AutoSize = true;
            this.timeResultLB.Location = new System.Drawing.Point(160, 440);
            this.timeResultLB.Name = "timeResultLB";
            this.timeResultLB.Size = new System.Drawing.Size(0, 13);
            this.timeResultLB.TabIndex = 22;
            // 
            // noRecursionRB
            // 
            this.noRecursionRB.AutoSize = true;
            this.noRecursionRB.Location = new System.Drawing.Point(3, 4);
            this.noRecursionRB.Name = "noRecursionRB";
            this.noRecursionRB.Size = new System.Drawing.Size(96, 17);
            this.noRecursionRB.TabIndex = 23;
            this.noRecursionRB.TabStop = true;
            this.noRecursionRB.Text = "Non-Recursive";
            this.noRecursionRB.UseVisualStyleBackColor = true;
            this.noRecursionRB.CheckedChanged += new System.EventHandler(this.noRecursionRB_CheckedChanged);
            // 
            // recursionRB
            // 
            this.recursionRB.AutoSize = true;
            this.recursionRB.Location = new System.Drawing.Point(3, 27);
            this.recursionRB.Name = "recursionRB";
            this.recursionRB.Size = new System.Drawing.Size(73, 17);
            this.recursionRB.TabIndex = 24;
            this.recursionRB.TabStop = true;
            this.recursionRB.Text = "Recursive";
            this.recursionRB.UseVisualStyleBackColor = true;
            this.recursionRB.CheckedChanged += new System.EventHandler(this.recursionRB_CheckedChanged);
            // 
            // stackRB
            // 
            this.stackRB.AutoSize = true;
            this.stackRB.Location = new System.Drawing.Point(3, 50);
            this.stackRB.Name = "stackRB";
            this.stackRB.Size = new System.Drawing.Size(53, 17);
            this.stackRB.TabIndex = 25;
            this.stackRB.TabStop = true;
            this.stackRB.Text = "Stack";
            this.stackRB.UseVisualStyleBackColor = true;
            this.stackRB.CheckedChanged += new System.EventHandler(this.stackRB_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.parallelRB);
            this.panel1.Controls.Add(this.nonParallelRB);
            this.panel1.Location = new System.Drawing.Point(13, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 62);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.stackRB);
            this.panel2.Controls.Add(this.noRecursionRB);
            this.panel2.Controls.Add(this.recursionRB);
            this.panel2.Location = new System.Drawing.Point(13, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 72);
            this.panel2.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 507);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timeResultLB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton singleThreadRB;
        private System.Windows.Forms.RadioButton multiThreadRB;
        private System.Windows.Forms.RadioButton parallelForRB;
        private System.Windows.Forms.RadioButton waitAnyRB;
        private System.Windows.Forms.RadioButton waitAllRB;
        private System.Windows.Forms.RadioButton threadPoolRB;
        private System.Windows.Forms.RadioButton awaitRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton nonParallelRB;
        private System.Windows.Forms.RadioButton parallelRB;
        private System.Windows.Forms.RadioButton serialRB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label timeResultLB;
        private System.Windows.Forms.RadioButton noRecursionRB;
        private System.Windows.Forms.RadioButton recursionRB;
        private System.Windows.Forms.RadioButton stackRB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

