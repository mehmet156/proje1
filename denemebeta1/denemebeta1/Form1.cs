#region(using)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging;
using System.IO.Ports;
using System.Drawing.Imaging;
#endregion
namespace denemebeta1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FilterInfoCollection VideoCapTureDevices;
        private VideoCaptureDevice Finalvideo;
        int i;
        int a;
        int b,R,G,B;

        private void Form1_Load(object sender, EventArgs e)
        {
        
            VideoCapTureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCapTureDevices)
            {

                comboBox1.Items.Add(VideoCaptureDevice.Name);

            }

            comboBox1.SelectedIndex = 0;

            comboBox2.DataSource = SerialPort.GetPortNames();


            button2.Enabled = true;


            int portSayisi = 0;
            portSayisi = comboBox2.Items.Count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Finalvideo = new VideoCaptureDevice(VideoCapTureDevices[comboBox1.SelectedIndex].MonikerString);
            Finalvideo.NewFrame += new NewFrameEventHandler(Finalvideo_NewFrame);
            
            Finalvideo.Start();
        }

        

        private void Finalvideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            Bitmap image1 = (Bitmap)eventArgs.Frame.Clone();


            Mirror filter2 = new Mirror(false, true);
            filter2.ApplyInPlace(image);
            
           


            pictureBox1.Image = image;




            
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
         
            filter.CenterColor = new RGB(Color.FromArgb(R, G, B));
            filter.Radius = 100;
            Mirror filter1 = new Mirror(false, true);
            filter1.ApplyInPlace(image1);


            filter.ApplyInPlace(image1);

            nesnebul(image1);
            dongu(image1);

           

           

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
          G = trackBar2.Value  ;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            B=trackBar3.Value  ;
        }
        #region(nesne bulma)
        public void nesnebul(Bitmap image)
        {
            
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 5;
            blobCounter.MinHeight = 5;
            blobCounter.FilterBlobs = true;
            blobCounter.ObjectsOrder = ObjectsOrder.Size;
            

           


            blobCounter.ProcessImage(image);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            Blob[] blobs = blobCounter.GetObjectsInformation();
            pictureBox2.Image = image;


           
            foreach (Rectangle rect in rects)
            {
                Rectangle objectRect = rects[i];


                int objectX = objectRect.X + (objectRect.Width / 2);
                int objectY = objectRect.Y + (objectRect.Height / 2);

                
                a = objectX;
                b = objectY;
                 

            }
           
            
        }

        #endregion

        #region(dongu)

        public void dongu(Bitmap image)
        {
            if (a <= 150)

            {

                if (b <= 150)
                {
                    serialPort1.Write("1");
                }


                else if (b <= 300 && b > 150)
                {
                    serialPort1.Write("4");
                }

                else if (b > 300)

                {
                    serialPort1.Write("7");
                }



            }
           

           else if (a > 150 && a <= 300)
            {

                if (b <= 150)
                {
                    serialPort1.Write("2");

                }

                else if (b > 150 && b <= 300)
                {
                    serialPort1.Write("5");
                }

                else if (b > 300 && b <= 450)

                {
                    serialPort1.Write("8");

                }


                else
                {
                    serialPort1.Write("0");
                }

            }
            

           else if (a > 300)
            {

                if (b > 150 && b <= 300)
                {
                    serialPort1.Write("6");
                }

                else if (b <= 150)
                {
                    serialPort1.Write("3");
                }

                else if (b > 300)
                {
                    serialPort1.Write("9");
                }




            }

            else
            { serialPort1.Write("0"); }

        }


        #endregion



        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = comboBox2.SelectedItem.ToString();
            serialPort1.Open();
            if (serialPort1.IsOpen == true)
            {
               button1.Enabled = true;
                
            }
            else
            {
                button1.Enabled = false;
            }
        }

        
    }
}
