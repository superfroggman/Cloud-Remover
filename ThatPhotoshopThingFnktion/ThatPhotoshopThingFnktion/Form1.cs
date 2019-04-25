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

namespace ThatPhotoshopThingFnktion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool slowmode = false;
        string[] filePaths;
        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            //making sure there are images
            if (filePaths == null)
            {
                return;
            }

            changeStatus("Processing");

            Bitmap[] bmps = new Bitmap[filePaths.Length];
            
            for(int i = 0; i < filePaths.Length; i++)
            {
                bmps[i] = new Bitmap(Image.FromFile(filePaths[i]));
            }
            bmp = bmps[0];
            pictureBox1.Image = bmp;
            this.Update();

            //For each image(except the first)
            for (int i = 1; i < filePaths.Length; i++)
            {
                //For each height row
                for (int y = 0; y < bmp.Height; y++)
                {
                    //For each width row
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        //Get current and new pixel and change to the brightest one
                        Color currentPixel = bmp.GetPixel(x, y);
                        Color newPixel = bmps[i].GetPixel(x, y);
                        if ((newPixel.R+newPixel.B+newPixel.G) < (currentPixel.R + currentPixel.B + currentPixel.G))
                        {
                            bmp.SetPixel(x, y, newPixel);
                        }
                    }
                    //Update image every height row if slowmode is activated
                    if (slowmode)
                    {
                        pictureBox1.Image = bmp;
                        this.Refresh();
                    }
                }
                //Update image after each image processed
                pictureBox1.Image = bmp;
                
                this.Refresh();

            }
            changeStatus("DONE!");
            ButtonFilepath.Text = "Save";
            renderFinished = true;
            this.Refresh();
        }

        void changeStatus(string text)
        {
            LabelStatus.Text = text;
            this.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            slowmode = !slowmode;
        }

        bool renderFinished = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (renderFinished)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        //changeStatus("Image Saved");
                        changeStatus("Saved to: " + fbd.SelectedPath + "\\" + TextboxSavename.Text + ".png");
                        
                        bmp.Save(fbd.SelectedPath + "\\" + TextboxSavename.Text + ".png");
                    }
                    else
                    {
                        changeStatus("Save failed sucessfully");
                    }
                    ButtonFilepath.Text = "Choose Files";
                    renderFinished = false;
                    this.Refresh();
                }
            }
            else
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        filePaths = Directory.GetFiles(fbd.SelectedPath, "*.png");
                        changeStatus(filePaths.Length.ToString() + " files chosen");
                    }
                }
            }          
        }
    }
}
