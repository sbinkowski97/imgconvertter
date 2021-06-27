using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace ImgConverter
{

    //MyNamespace.MyClass myClass =new MyNamespace.MyClass();
    public partial class Form1 : Form
    {
       
        string[] images;
        Bitmap imageToProcess;
        string path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            images = (string[])e.Data.GetData(DataFormats.FileDrop);
            textBox1.Text = images[0];
            imageToProcess = new Bitmap(images[0]);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void console1_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void renderButton_Click(object sender, EventArgs e)
        {

            ImageManipulator im = new ImageManipulator(imageToProcess);
            im.Blur(Convert.ToInt32(blurValue.Value));
            Bitmap ret = im.ToBitmap();
            ret.Save($"{path}\\Output\\output.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImageManipulator im = new ImageManipulator(imageToProcess);
            im.Filter(rgbValue.Text);
            Bitmap ret = im.ToBitmap();
            ret.Save($"{path}\\Output\\output.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageManipulator im = new ImageManipulator(imageToProcess);
            im.Brightness(Convert.ToInt32(lightValue.Value));
            Bitmap ret = im.ToBitmap();
            ret.Save($"{path}\\Output\\output.jpg");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ImageManipulator im = new ImageManipulator(imageToProcess);
            im.Grayscale();
            Bitmap ret = im.ToBitmap();
            ret.Save($"{path}\\Output\\output.jpg");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ImageManipulator im = new ImageManipulator(imageToProcess);
            im.Negate();
            Bitmap ret = im.ToBitmap();
            ret.Save($"{path}\\Output\\output.jpg");
        }
    }
}
