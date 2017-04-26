using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Xml;

namespace graf
{
    public partial class Form1 : Form
    {
        public class MyPoint
        {
            public int PointId { get; set; }
            public int PointX { get; set; }
            public int PointY { get; set; }

            public MyPoint(int id, int x, int y)
            {
                PointId = id;
                PointX = x;
                PointY = y;
            }
        }

        Bitmap DrawArea;
        private List<MyPoint> points;
        private Dictionary<int, List<int>> EdgeToXml;
        private int?[,] Edge;
        private List<int> NodeToXml;
        public Form1() 
        {
            InitializeComponent();
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            points = RandomPoints(Int32.Parse(textBox_N.Text), Int32.Parse(textBox_R.Text));

            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.DarkRed);

            foreach (MyPoint point in points)
            {
                g.DrawEllipse(mypen, point.PointX + 250, point.PointY + 250, 1, 1);
            }

            pictureBox1.Image = DrawArea;

            g.Dispose();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            NodeToXml = new List<int>();
            EdgeToXml = new Dictionary<int, List<int>>();
            Edge = new int?[Int32.Parse(textBox_N.Text), Int32.Parse(textBox_N.Text)];

            Graphics g;
            g = Graphics.FromImage(DrawArea);
            Pen line = new Pen(Color.Black);
            Pen mypen = new Pen(Color.DarkRed);
            float r = float.Parse(textBox_rr.Text);
            foreach (MyPoint point in points)
            {
                NodeToXml.Add(point.PointId);
                foreach (MyPoint point2 in points)
                {
                    double distance = Distance(point, point2);
                    if (distance != 0 && distance < r)
                    {
                        if (!Edge[point.PointId, point2.PointId].HasValue && !Edge[point2.PointId, point.PointId].HasValue)
                        {
                            Edge[point.PointId, point2.PointId] = 1;
                            if (!EdgeToXml.ContainsKey(point.PointId))
                            {
                                EdgeToXml.Add(point.PointId, new List<int>());
                                EdgeToXml[point.PointId].Add(point2.PointId);
                            }
                            else
                            {
                                EdgeToXml[point.PointId].Add(point2.PointId);
                            }
                            g.DrawLine(line, point.PointX + 250, point.PointY + 250, point2.PointX + 250, point2.PointY + 250);
                        }
                    }
                }
            }
            foreach (MyPoint point in points)
            {
                g.DrawEllipse(mypen, point.PointX + 250 - r/2, point.PointY + 250 - r / 2, r, r);
            }
            pictureBox1.Image = DrawArea;
            g.Dispose();
        }

        private void SaveToGXL(string file)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter xmlWriter = XmlWriter.Create(file, settings);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("gxl");
            xmlWriter.WriteStartElement("graph");
            xmlWriter.WriteAttributeString("id", "graph");

            foreach (int i in NodeToXml)
            {
                xmlWriter.WriteStartElement("node");
                xmlWriter.WriteAttributeString("id", i.ToString());
                xmlWriter.WriteEndElement();
            }
            foreach (var edge in EdgeToXml.Keys)
            {
                Console.WriteLine("krawedz: " + edge);
                Console.WriteLine(EdgeToXml[edge].Count);
                foreach (int i in EdgeToXml[edge])
                {
                    xmlWriter.WriteStartElement("edge");
                    xmlWriter.WriteAttributeString("from", edge.ToString());
                    xmlWriter.WriteAttributeString("to", i.ToString());
                    xmlWriter.WriteEndElement();
                }
            }
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "GXL-File | *.gxl";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveToGXL(saveFileDialog.FileName);
                MessageBox.Show("Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static List<MyPoint> RandomPoints(int N, int R)
        {
            List<MyPoint> points = new List<MyPoint>();
            Random gen = new Random();
            while (points.Count < N)
            {
                int x = gen.Next(-R, R);
                int y = gen.Next(-R, R);

                if ((x * x + y * y) <= R * R)
                {
                    points.Add(new MyPoint(points.Count, x, y));
                }
            }

            return points;
        }

        public static double Distance(MyPoint pointA, MyPoint pointB)
        {
            double d1 = pointA.PointX - pointB.PointX;
            double d2 = pointA.PointY - pointB.PointY;

            return Math.Sqrt(d1 * d1 + d2 * d2);
        }
    }

}
