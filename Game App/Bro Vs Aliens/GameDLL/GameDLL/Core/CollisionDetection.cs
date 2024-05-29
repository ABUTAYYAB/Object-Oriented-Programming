using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDLL.Core
{
    public class CollisionDetection
    {                

        private GameObjectType objectType1;
        private GameObjectType objectType2;
        private GameAction action;

        public CollisionDetection(GameObjectType objectType1, GameObjectType objectType2, GameAction action)
        {
            this.objectType1 = objectType1;
            this.objectType2 = objectType2;
            this.action = action;
        }

        public string CheckCollision(GameObject object1, GameObject object2)
        {
            if (object1.type1 == objectType1 && object2.type1 == objectType2)
            {
                if (object1.GetPictureBox().Bounds.IntersectsWith(object2.GetPictureBox().Bounds))
                {                                        
                    switch (action)
                    {
                        case GameAction.IncreasePoints:                            
                            return "Increase points logic";
                        case GameAction.DecreasePoints:                            
                            return "Decrease points logic";
                        default:                            
                            return "Default action";
                    }
                }
            }
            return "";
        }
    }
}
