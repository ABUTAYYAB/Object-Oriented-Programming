using GameDLL.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
using System.Net.Configuration;

namespace GameDLL.Core
{
    public class GameBL
    {
        List<GameObject> gameObjects;
        Form container;
        List<CollisionDetection> collisionDetections;
        static GameBL Instance;

        public static GameBL GetInstance(Form container)
        {
            if(Instance == null)
            {
                Instance = new GameBL(container);
            }
            return Instance;
        }
        private GameBL(Form container)
        {
            this.container = container;
            gameObjects = new List<GameObject>();
            collisionDetections = new List<CollisionDetection>();
        }
        

        /*public GameBL(Form container)
        {
            gameObjects = new List<GameObject>();
            this.container = container;
            collisionDetections = new List<CollisionDetection>();
        }*/

        public void AddGameobject(Image img,int left,int top,IMovement controller, GameObjectType type)
        {
            GameObject obj = new GameObject(img,left,top,controller,type);
            gameObjects.Add(obj);
            container.Controls.Add(obj.GetPictureBox());            
        }        
        public void CreateBullet(Image image)
        {
            if (EZInput.Keyboard.IsKeyPressed(Key.Space))
            {
                int top = 0, left = 0;
                foreach (GameObject objj in gameObjects)
                {
                    if (objj.type1 == GameObjectType.Player)
                    {
                        top = objj.GetPictureBox().Top;
                        left = objj.GetPictureBox().Left;
                        break;
                    }                    
                }
                IbulletMovement bullet = new UpwardBullet(25);
                GameObject obj = new GameObject(image, left+50, top, bullet, GameObjectType.Bullet1);
                gameObjects.Add(obj);
                container.Controls.Add(obj.GetPictureBox());
            }
        }
        public void AddCollision(CollisionDetection collisionDetection)
        {
            collisionDetections.Add(collisionDetection);
        }        
        public string CheckCollisions()
        {
            string msg = "";

            for (int i = 0; i < gameObjects.Count; i++)
            {
                GameObject object1 = gameObjects[i];

                for (int j = i + 1; j < gameObjects.Count; j++)
                {
                    GameObject object2 = gameObjects[j];

                    foreach (CollisionDetection collision in collisionDetections)
                    {
                        if (object1.GetPictureBox().Bounds.IntersectsWith(object2.GetPictureBox().Bounds))
                        {
                            if (object1.type1 == GameObjectType.Enemy1 &&
                                object2.type1 == GameObjectType.Enemy2)
                            {
                                // Swap controllers between Enemy1 and Enemy2
                                IMovement tempController = object1.Controller;
                                object1.Controller = object2.Controller;                                
                                object2.Controller = tempController;
                                gameObjects[i].Controller = object1.Controller;
                                gameObjects[j].Controller = tempController;                                
                            }
                            else if (object1.type1 == GameObjectType.Enemy1 &&
                                object2.type1 == GameObjectType.Enemy3)
                            {
                                // Swap controllers between Enemy1 and Enemy2
                                IMovement tempController = object1.Controller;
                                object1.Controller = object2.Controller;
                                object2.Controller = tempController;
                                gameObjects[i].Controller = object1.Controller;
                                gameObjects[j].Controller = tempController;                                
                            }
                        }

                        msg = collision.CheckCollision(object1, object2);
                        if (!string.IsNullOrEmpty(msg))
                        {
                            if (msg == "Increase points logic")
                            {
                                object2.GetPictureBox().Visible = false;
                                object1.GetPictureBox().Visible = false;
                                gameObjects.Remove(object1);
                                gameObjects.Remove(object2);
                            }
                            return msg;
                        }
                    }
                }
            }

            return msg;
        }

        public void Update() 
        {
            foreach(GameObject obj in gameObjects)
            {
                if(obj.type1 == GameObjectType.Bullet1)
                {
                    obj.Updatee();
                    continue;
                }
                obj.Update();
            }
        }
    }
}
