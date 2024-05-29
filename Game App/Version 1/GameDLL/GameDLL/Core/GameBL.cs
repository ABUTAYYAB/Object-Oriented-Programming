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
    public class GameBL
    {
        List<GameObject> gameObjects;
        Form container;

        public GameBL(Form container)
        {
            gameObjects = new List<GameObject>();
            this.container = container;
        }
        public void AddGameobject(Image img,int left,int top,IMovement controller)
        {
            GameObject obj = new GameObject(img,left,top,controller); 
            gameObjects.Add(obj);
            container.Controls.Add(obj.GetPictureBox());
        }

        public void Update() 
        {
            foreach(GameObject obj in gameObjects) 
            {
                obj.Update();
            }
        }




    }
}
