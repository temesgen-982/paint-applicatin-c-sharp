using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_application
{
    public partial class Form1 : Form
    {
        int x = -1;
        int y = -1;
        bool moving = false;

        Bitmap bitmapN, tempBitmap;
        Graphics graphics, tempGraphics;

        Pen pen = new Pen(Color.Black, 3);

        Color currentPenColor = Color.Black;
        int currentPenSize = 3;
        string currentShape = "none";

        private void colorBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                currentPenColor = clickedButton.BackColor;
                pen = new Pen(currentPenColor, currentPenSize);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White); // Reset to a blank white canvas

            tempGraphics.Clear(Color.Transparent);

            picture.Image = bitmapN;

            currentShape = "none";
        }

        private void penSizeBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                switch (clickedButton.Name)
                {
                    case "sizeOne":
                        currentPenSize = 3;
                        break;
                    case "sizeTwo":
                        currentPenSize = 6;
                        break;
                    case "sizeThree":
                        currentPenSize = 9;
                        break;
                    case "sizeFour":
                        currentPenSize = 12;
                        break;
                }
                pen = new Pen(currentPenColor, currentPenSize);
            }
        }

        private void shapeBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (clickedButton.Name == "rectangleButton")
                {
                    currentShape = "rectangle";
                }
                else if (clickedButton.Name == "circleButton")
                {
                    currentShape = "circle";
                }
                else if (clickedButton.Name == "triangleButton")
                {
                    currentShape = "triangle";
                }
                else if (clickedButton.Name == "lineButton")
                {
                    currentShape = "line";
                }
                else if (clickedButton.Name == "eraseButton")
                {
                    currentShape = "eraser";
                }
                else if (clickedButton.Name == "fillButton")
                {
                    currentShape = "fill";
                }
                else
                {
                    currentShape = "pen";
                }

            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp|All files|*.*";
            saveFileDialog.Title = "Save Drawing";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    bitmapN.Save(saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving the image: " + ex.Message);
                }
            }

        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            openFileDialog.Title = "Open Image";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(openFileDialog.FileName);
                    picture.Image = image;

                    bitmapN = new Bitmap(image);
                    graphics = Graphics.FromImage(bitmapN);
                    picture.Image = bitmapN;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening the image: " + ex.Message);
                }
            }

        }

        private void colorDialogBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorD = new ColorDialog();
            if (colorD.ShowDialog() == DialogResult.OK)
            {
                currentPenColor = colorD.Color;

                pen = new Pen(currentPenColor, currentPenSize);

                colorDialogButton.BackColor = currentPenColor;
            }
        }

        private void FloodFill(Bitmap bmp, int x, int y, Color targetColor, Color replacementColor)
        {
            if (targetColor == replacementColor) return;

            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point current = pixels.Dequeue();
                if (current.X < 0 || current.X >= bmp.Width || current.Y < 0 || current.Y >= bmp.Height)
                    continue;

                if (bmp.GetPixel(current.X, current.Y) != targetColor)
                    continue;

                bmp.SetPixel(current.X, current.Y, replacementColor);

                pixels.Enqueue(new Point(current.X + 1, current.Y));
                pixels.Enqueue(new Point(current.X - 1, current.Y));
                pixels.Enqueue(new Point(current.X, current.Y + 1));
                pixels.Enqueue(new Point(current.X, current.Y - 1));
            }
        }


        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            // Start drawing
            moving = true;
            x = e.X;
            y = e.Y;
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && e.Button == MouseButtons.Left)
            {
                tempGraphics.Clear(Color.Transparent);
                tempGraphics.DrawImage(bitmapN, 0, 0);

                int width = e.X - x;
                int height = e.Y - y;

                if (currentShape == "rectangle")
                {
                    tempGraphics.DrawRectangle(pen, x, y, width, height);
                }
                else if (currentShape == "circle")
                {
                    tempGraphics.DrawEllipse(pen, x, y, width, height);
                }
                else if (currentShape == "triangle")
                {
                    Point[] trianglePoints = {
                        new Point(x, y), // Top point
                        new Point(x + width, y + height), // Bottom-right point
                        new Point(x - width, y + height) // Bottom-left point
                    };

                    tempGraphics.DrawPolygon(pen, trianglePoints);
                }
                else if (currentShape == "line")
                {
                    tempGraphics.Clear(Color.Transparent);
                    tempGraphics.DrawImage(bitmapN, 0, 0);

                    tempGraphics.DrawLine(pen, new Point(x, y), new Point(e.X, e.Y));

                    picture.Image = tempBitmap;
                }
                else if (currentShape == "eraser")
                {
                    Pen eraserPen = new Pen(Color.White, currentPenSize);
                    graphics.DrawLine(eraserPen, new Point(x, y), new Point(e.X, e.Y));
                    x = e.X;
                    y = e.Y;

                    picture.Image = bitmapN;
                }
                else if (currentShape == "fill")
                {
                    
                }
                else
                {
                    graphics.DrawLine(pen, new Point(x, y), new Point(e.X, e.Y));
                    picture.Invalidate();
                    x = e.X;
                    y = e.Y;
                }

                picture.Image = tempBitmap;

                picture.Invalidate();

                }
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop drawing
            moving = false;

            int width = e.X - x;
            int height = e.Y - y;

            if (currentShape == "rectangle")
            {
                graphics.DrawRectangle(pen, x, y, width, height);
            }
            else if (currentShape == "circle")
            {
                graphics.DrawEllipse(pen, x, y, width, height);
            }
            else if (currentShape == "triangle")
            {
                Point[] trianglePoints = {
                    new Point(x, y),
                    new Point(x + width, y + height),
                    new Point(x - width, y + height)
                };

                graphics.DrawPolygon(pen, trianglePoints);
            }
            else if (currentShape == "line")
            {
                graphics.DrawLine(pen, new Point(x, y), new Point(e.X, e.Y));
            }
            else if (currentShape == "eraser")
            {
                Pen eraserPen = new Pen(Color.White, currentPenSize);
                graphics.DrawLine(eraserPen, new Point(x, y), new Point(e.X, e.Y));
            }else if( currentShape == "fill")
            {
                Point mousePoint = new Point(e.X, e.Y);
                Color targetColor = bitmapN.GetPixel(mousePoint.X, mousePoint.Y);

                if (targetColor != currentPenColor)
                {
                    FloodFill(bitmapN, mousePoint.X, mousePoint.Y, targetColor, currentPenColor);
                }

                picture.Image = bitmapN;
            }

            picture.Image = bitmapN;

            x = -1;
            y = -1;
        }

        public Form1()
        {
            InitializeComponent();

            bitmapN = new Bitmap(picture.Width, picture.Height);
            graphics = Graphics.FromImage(bitmapN);

            tempBitmap = new Bitmap(picture.Width, picture.Height);
            tempGraphics = Graphics.FromImage(tempBitmap);

            graphics.Clear(Color.White);
            picture.Image = bitmapN;
        }
    }
}
