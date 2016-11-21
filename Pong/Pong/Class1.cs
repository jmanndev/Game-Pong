using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace Pong
{
    class Paddle
    {
        Texture2D texture;
        int height;
        int width;
        float posX;
        float posY;

        public Paddle(int paddleHeight, int paddleWidth, float paddlePosX, float paddlePosY)
        {
            height = paddleHeight;
            width = paddleWidth;
            posX = paddlePosX;
            posY = paddlePosY;
        }

        public void action(String direction)
        {
            if (direction == "UP")
                posY -= 5;
            else if (direction == "DOWN")
                posY += 5;
            else if (direction == "LEFT")
                posX -= 5;
            else if (direction == "RIGHT")
                posX += 5;
        }

        public void edgeCheckY(float windowHeight)
        {
            if (posY < 0)
                posY = 0;
            if (posY > windowHeight - height)
                posY = windowHeight;
        }
    }
}
