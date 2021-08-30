using _4thTask2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4thTask2
{
    public partial class ExplainAll : Form
    {
        private Explain explain;
        int locationX = 12;
        int locationY = -150;
        int sizeX = 500;
        int sizeY = 200;

        public ExplainAll(Explain explain)
        {
            this.explain = explain;
            InitializeComponent();
            this.AutoScrollPosition = new Point(-50, 50);
        }

        private void ExplainAll_Load(object sender, EventArgs e)
        {
            lblExplainName.Text = Resource_JP.ResourceManager.GetString(this.explain.CurrentExplain.Name.ToString());
            var count = this.explain.GetCurrentExplainsCount();
            for (int i = 0; i < count; i++)
            {
                this.explain.SetExplain();
                this.CreatePicture();
                this.CreateLabel();
            }
        }

        private void CreateLabel()
        {
            var label = new Label();

            label.BackColor = SystemColors.Info;
            label.BorderStyle = BorderStyle.Fixed3D;
            label.Location = new Point(locationX, locationY += sizeY);
            label.Name = "lbl" + this.explain.MethodName;
            label.Size = new Size(sizeX, sizeY);
            label.TabIndex = 3;
            label.Text = this.explain.Message;
            label.TextAlign = ContentAlignment.TopLeft;

            this.Controls.Add(label);
        }

        private void CreatePicture()
        {
            var picture = new PictureBox();

            picture.BackColor = Color.White;
            picture.Location = new Point(locationX, locationY += sizeY);
            picture.Name = "picture" + this.explain.MethodName;
            picture.Size = new Size(sizeX, sizeY);
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            picture.TabIndex = 0;
            picture.TabStop = false;
            picture.ImageLocation = this.explain.GetImageLocation();

            this.Controls.Add(picture);
        }

        private int GetMessageLineCount => this.explain.Message.ToList().Where(c => c.Equals("\r\n")).Count() + 1;
    }
}