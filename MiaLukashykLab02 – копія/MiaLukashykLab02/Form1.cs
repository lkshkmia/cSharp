using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
// exercise 4 last part
namespace MiaLukashykLab02
{
    public partial class Form1 : Form
    {
        //Rectangle button
        private const int ObjectSize = 50; // ����� ��'����
        private const int MoveStep = 10; // ���� ����������
        private Rectangle objectRect;
        //Rectangle mouse
        private bool isDragging = false;
        private Point startPoint;
        private Rectangle rect = new Rectangle(50, 50, 100, 100);

        public Form1()
        {
            InitializeComponent();
            // ϳ������� ����� formClosing �� ���� FormClosing
            this.FormClosing += new FormClosingEventHandler(formClosing);

            // ���������� ������������ ��'���� � ����� �����
            int x = (ClientSize.Width - ObjectSize) / 2;
            int y = (ClientSize.Height - ObjectSize) / 2;
            objectRect = new Rectangle(x, y, ObjectSize, ObjectSize);
            // ������������ ���� Paint ��� ��������� ��'���� �� ����
            this.Paint += Form1_Paint;
            // ������������ ���� KeyDown ��� ������� ���������� �����
            this.KeyDown += Form1_KeyDown;
            this.KeyPreview = true;
            // ������������ ����� �����, ��� ����� ���� ���������� ��䳿 �����
            this.Focus();

            this.DoubleBuffered = true; // ��� �������� ���������� ��'����

            // ���������� ������
            timer1.Interval = 100; // �������� ������� � ����������

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // ������� ��'��� �� ����
            e.Graphics.FillRectangle(Brushes.Blue, rect); // ����������� rect

        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // ����������, �� ���� ��������� ��� ������ ����
            if (e.Button == MouseButtons.Left)
            {
                // ������������ ���� ������������� �� �������� ��������� �����
                isDragging = true;
                startPoint = e.Location;
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            // ����������, �� ����� ������������� �� �� ���� ��������� ��� ������ ����
            if (isDragging && e.Button == MouseButtons.Left)
            {
                // ���������� ������ �� �������� �������� ���� �� ���������� ������
                int dx = e.X - startPoint.X;
                int dy = e.Y - startPoint.Y;
                // ������� ��'��� �� �� ������
                rect.X += dx; // ������ Location �� X �� Y ���������� ������������
                rect.Y += dy;
                startPoint = e.Location; // �������� ��������� �����
                this.Invalidate(); // ������������� �����
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            // ����������, �� ���� �������� ��� ������ ����
            if (e.Button == MouseButtons.Left)
            {
                // ��������� �������������
                isDragging = false;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // ������� ��'��� �� ����
            e.Graphics.FillRectangle(Brushes.Blue, objectRect);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // ���������� ��'���� ������� �� ��������� ������
            switch (e.KeyCode)
            {
                case Keys.Left:
                    objectRect.X -= MoveStep;
                    break;
                case Keys.Right:
                    objectRect.X += MoveStep;
                    break;
                case Keys.Up:
                    objectRect.Y -= MoveStep;
                    break;
                case Keys.Down:
                    objectRect.Y += MoveStep;
                    break;
            }

            // ��������� ����� Invalidate(), ��� �������� ����� ������������ ��'���
            Invalidate();

            // ³�������� ��'���� �� ������� �����
            if (objectRect.Left < 0)
                objectRect.X = 0;
            if (objectRect.Top < 0)
                objectRect.Y = 0;
            if (objectRect.Right > ClientSize.Width)
                objectRect.X = ClientSize.Width - ObjectSize;
            if (objectRect.Bottom > ClientSize.Height)
                objectRect.Y = ClientSize.Height - ObjectSize;

            e.Handled = true;
        }
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to close this window?", "Close Window", buttons);
            if (result == DialogResult.No)
            {
                // ³���� �������� �����, ���� ���������� ������ "ͳ" ��� "���������"
                e.Cancel = true;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // �������� �������� � TextBox1 �� TextBox2, �� ���������� �� � �����
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                // ������ ��������
                double mult = num1 * num2;
                // ������������ ��������� � TextBox3
                textBox3.Text = mult.ToString();
            }
            else
            {
                // ���� ������ ��� �� � ���������
                MessageBox.Show("Please enter valid numbers in TextBox1 and TextBox2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = listBox1.SelectedIndex;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = comboBox2.SelectedIndex;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void windowStateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 8);
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 16);
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 32);
        }
        private void button2Text���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Text = "Divide";
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void maximizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (maximizedToolStripMenuItem.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files (*.*)|*.*";
            openFileDialog1.Title = "Select an Image File";
            openFileDialog1.ShowDialog();

            try
            {
                // Load the selected image into PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 8);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 16);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 32);
        }
        private void openFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            openFileDialog2 = new OpenFileDialog();
            openFileDialog2.Title = "Select File";
            openFileDialog2.ShowDialog();
            try
            {
                richTextBox1.LoadFile(openFileDialog2.FileName, RichTextBoxStreamType.PlainText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog2_FileOk(sender, null);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.Write(richTextBox1.Text);
                    }
                    MessageBox.Show("File saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not save file. " + ex.Message);
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                if (richTextBox1.SelectionLength > 0) // ����������, �� �������� �����
                {
                    richTextBox1.SelectionFont = fontDialog.Font;
                }
                else // ���� ����� �� ��������, ������� ����� ��� ������ ������
                {
                    richTextBox1.Font = fontDialog.Font;
                }
            }
        }
    }
}