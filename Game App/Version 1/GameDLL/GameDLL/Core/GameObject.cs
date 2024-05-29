using GameDLL.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameDLL.Core
{
    public class GameObject
    {
        private PictureBox pictureBox;
        private IMovement controller;

        public GameObject(Image img,int left,int top,IMovement controller)
        {
            pictureBox = new PictureBox();
            pictureBox.Image = img;
            pictureBox.Left = left;
            pictureBox.Top = top;
            pictureBox.Width = img.Width;
            pictureBox.Height = img.Height;
            this.controller = controller;
        }
        public void Update()
        {
            this.pictureBox.Location = controller.move(this.pictureBox.Location);
        }
        public PictureBox GetPictureBox()
        {
            return pictureBox;
        }

        public IMovement Controller { get => controller; set => controller = value; }
    }
}
