using EZInput;
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
        private IbulletMovement controllerr;
        private GameObjectType Type;
        public GameObjectType type1 { get => Type; set => Type = value; }

        public GameObject(Image img,int left,int top,IMovement controller, GameObjectType type)
        {
            this.Type = type;
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = img;
            pictureBox.Left = left;
            pictureBox.Top = top;
            pictureBox.Width = 120;
            pictureBox.Height = 112;
            pictureBox.BackColor = Color.Transparent;
            this.controller = controller;
        }
        public GameObject(Image img, int left, int top, IbulletMovement controller, GameObjectType type)
        {
            this.Type = type;
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = img;
            pictureBox.Left = left;
            pictureBox.Top = top;
            pictureBox.Width = 70;
            pictureBox.Height = 65;
            pictureBox.BackColor = Color.Transparent;
            this.controllerr = controller;
        }
        public void Update()
        {
            this.pictureBox.Location = controller.move(this.pictureBox.Location);
        }
        public void Updatee()
        {
            this.pictureBox.Location = controllerr.move(this.pictureBox.Location);
        }        
        public PictureBox GetPictureBox()
        {
            return pictureBox;
        }

        public IMovement Controller { get => controller; set => controller = value; }
    }
}
