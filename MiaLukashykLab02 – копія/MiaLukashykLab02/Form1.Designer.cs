namespace MiaLukashykLab02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            listBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            windowStateToolStripMenuItem = new ToolStripMenuItem();
            maximizedToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            button2TextПодіToolStripMenuItem = new ToolStripMenuItem();
            lable3FontSizeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            windowStateToolStripMenuItem1 = new ToolStripMenuItem();
            button2 = new Button();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            richTextBox1 = new RichTextBox();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            fontDialog2 = new FontDialog();
            button4 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            openFileDialog2 = new OpenFileDialog();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            radioButtonNone = new RadioButton();
            checkBoxStartStop = new CheckBox();
            radioButtonUp = new RadioButton();
            radioButtonDown = new RadioButton();
            radioButtonLeft = new RadioButton();
            radioButtonRight = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(69, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(69, 147);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Multiply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 113);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 4;
            label3.Text = "Result";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 5;
            label1.Text = "Selected";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            comboBox2.Location = new Point(328, 36);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            listBox1.Location = new Point(244, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, windowStateToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.F10;
            exitToolStripMenuItem.Size = new Size(182, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // windowStateToolStripMenuItem
            // 
            windowStateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { maximizedToolStripMenuItem });
            windowStateToolStripMenuItem.Name = "windowStateToolStripMenuItem";
            windowStateToolStripMenuItem.Size = new Size(133, 29);
            windowStateToolStripMenuItem.Text = "WindowState";
            windowStateToolStripMenuItem.Click += windowStateToolStripMenuItem_Click;
            // 
            // maximizedToolStripMenuItem
            // 
            maximizedToolStripMenuItem.CheckOnClick = true;
            maximizedToolStripMenuItem.Name = "maximizedToolStripMenuItem";
            maximizedToolStripMenuItem.Size = new Size(199, 34);
            maximizedToolStripMenuItem.Text = "Maximized";
            maximizedToolStripMenuItem.Click += maximizedToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { button2TextПодіToolStripMenuItem, lable3FontSizeToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // button2TextПодіToolStripMenuItem
            // 
            button2TextПодіToolStripMenuItem.Name = "button2TextПодіToolStripMenuItem";
            button2TextПодіToolStripMenuItem.Size = new Size(321, 34);
            button2TextПодіToolStripMenuItem.Text = "Button2.Text = \"Поділити\"";
            button2TextПодіToolStripMenuItem.Click += button2TextПодіToolStripMenuItem_Click;
            // 
            // lable3FontSizeToolStripMenuItem
            // 
            lable3FontSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            lable3FontSizeToolStripMenuItem.Name = "lable3FontSizeToolStripMenuItem";
            lable3FontSizeToolStripMenuItem.Size = new Size(321, 34);
            lable3FontSizeToolStripMenuItem.Text = "Lable3.Font.Size =";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(134, 34);
            toolStripMenuItem2.Text = "8";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(134, 34);
            toolStripMenuItem3.Text = "16";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(134, 34);
            toolStripMenuItem4.Text = "32";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { windowStateToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(190, 36);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // windowStateToolStripMenuItem1
            // 
            windowStateToolStripMenuItem1.Name = "windowStateToolStripMenuItem1";
            windowStateToolStripMenuItem1.Size = new Size(189, 32);
            windowStateToolStripMenuItem1.Text = "WindowState";
            // 
            // button2
            // 
            button2.Location = new Point(525, 67);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 39);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.RestoreDirectory = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 303);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "select file";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(244, 222);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(150, 144);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // button4
            // 
            button4.Location = new Point(247, 374);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 15;
            button4.Text = "upload";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(457, 207);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(178, 29);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "MaximizeWindow";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(457, 242);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(117, 29);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "IsAvailible";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(654, 179);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 18;
            label4.Text = "Font size";
            label4.Click += label4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(654, 207);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 29);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "8";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(654, 241);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(57, 29);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "16";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(654, 276);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(57, 29);
            radioButton3.TabIndex = 21;
            radioButton3.TabStop = true;
            radioButton3.Text = "32";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // button5
            // 
            button5.Location = new Point(365, 374);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 22;
            button5.Text = "save";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(247, 414);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 23;
            button6.Text = "color";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(365, 414);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 24;
            button7.Text = "font";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // radioButtonNone
            // 
            radioButtonNone.AutoSize = true;
            radioButtonNone.Location = new Point(493, 311);
            radioButtonNone.Name = "radioButtonNone";
            radioButtonNone.Size = new Size(80, 29);
            radioButtonNone.TabIndex = 25;
            radioButtonNone.TabStop = true;
            radioButtonNone.Text = "None";
            radioButtonNone.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartStop
            // 
            checkBoxStartStop.AutoSize = true;
            checkBoxStartStop.Location = new Point(579, 311);
            checkBoxStartStop.Name = "checkBoxStartStop";
            checkBoxStartStop.Size = new Size(184, 29);
            checkBoxStartStop.TabIndex = 26;
            checkBoxStartStop.Text = "checkBoxStartStop";
            checkBoxStartStop.UseVisualStyleBackColor = true;
            // 
            // radioButtonUp
            // 
            radioButtonUp.AutoSize = true;
            radioButtonUp.Location = new Point(493, 346);
            radioButtonUp.Name = "radioButtonUp";
            radioButtonUp.Size = new Size(154, 29);
            radioButtonUp.TabIndex = 27;
            radioButtonUp.TabStop = true;
            radioButtonUp.Text = "radioButtonUp";
            radioButtonUp.UseVisualStyleBackColor = true;
            // 
            // radioButtonDown
            // 
            radioButtonDown.AutoSize = true;
            radioButtonDown.Location = new Point(493, 381);
            radioButtonDown.Name = "radioButtonDown";
            radioButtonDown.Size = new Size(178, 29);
            radioButtonDown.TabIndex = 28;
            radioButtonDown.TabStop = true;
            radioButtonDown.Text = "radioButtonDown";
            radioButtonDown.UseVisualStyleBackColor = true;
            // 
            // radioButtonLeft
            // 
            radioButtonLeft.AutoSize = true;
            radioButtonLeft.Location = new Point(493, 416);
            radioButtonLeft.Name = "radioButtonLeft";
            radioButtonLeft.Size = new Size(160, 29);
            radioButtonLeft.TabIndex = 29;
            radioButtonLeft.TabStop = true;
            radioButtonLeft.Text = "radioButtonLeft";
            radioButtonLeft.UseVisualStyleBackColor = true;
            // 
            // radioButtonRight
            // 
            radioButtonRight.AutoSize = true;
            radioButtonRight.Location = new Point(493, 451);
            radioButtonRight.Name = "radioButtonRight";
            radioButtonRight.Size = new Size(173, 29);
            radioButtonRight.TabIndex = 30;
            radioButtonRight.TabStop = true;
            radioButtonRight.Text = "radioButtonRight";
            radioButtonRight.UseVisualStyleBackColor = true;

            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(radioButtonRight);
            Controls.Add(radioButtonLeft);
            Controls.Add(radioButtonDown);
            Controls.Add(radioButtonUp);
            Controls.Add(checkBoxStartStop);
            Controls.Add(radioButtonNone);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += formClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label3;
        private Label label1;
        private ComboBox comboBox2;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button2;
        private Label label2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem windowStateToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem maximizedToolStripMenuItem;
        private ToolStripMenuItem button2TextПодіToolStripMenuItem;
        private ToolStripMenuItem lable3FontSizeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem windowStateToolStripMenuItem1;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button button3;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox richTextBox1;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private FontDialog fontDialog2;
        private Button button4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private OpenFileDialog openFileDialog2;
        private Button button5;
        private Button button6;
        private Button button7;
        private RadioButton radioButtonNone;
        private CheckBox checkBoxStartStop;
        private RadioButton radioButtonUp;
        private RadioButton radioButtonDown;
        private RadioButton radioButtonLeft;
        private RadioButton radioButtonRight;
        private System.Windows.Forms.Timer timer1;
    }
}