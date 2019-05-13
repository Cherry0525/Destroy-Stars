using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Destroy
{

    class Diamond
    {
        private int color;//颜色
        private int sx;//左上角起始x坐标
        private int sy;//左上角起始y坐标
        private int ex;//右下角结束x坐标
        private int ey;//右下角结束y坐标
        private int down;//下落
        private int left;//向左靠
        private Bitmap picture = new Bitmap(40,40);//图片

        public Bitmap Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        public Diamond(int C, int ssx, int ssy, int eex, int eey)
        {
            color = C;
            sx = ssx;
            sy = ssy;
            ex = eex;
            ey = eey;

            if (color == 0) picture = new Bitmap("Image\\0.jpg");
            if (color == 1) picture = new Bitmap("Image\\1.png");
            if (color == 2) picture = new Bitmap("Image\\2.png");
            if (color == 3) picture = new Bitmap("Image\\3.png");
            if (color == 4) picture = new Bitmap("Image\\4.png");
            if (color == 5) picture = new Bitmap("Image\\5.png");
            if (color == 6) picture = new Bitmap("Image\\St.jpg");
            if (color == 7) picture = new Bitmap("Image\\next.png");

        }

        public void Change()
        {
            if (color == 1) picture = new Bitmap("Image\\1_1.png");
            if (color == 2) picture = new Bitmap("Image\\2_2.png");
            if (color == 3) picture = new Bitmap("Image\\3_3.png");
            if (color == 4) picture = new Bitmap("Image\\4_4.png");
            if (color == 5) picture = new Bitmap("Image\\5_5.png");
        }

        public int Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Sx
        {
            get { return sx; }
            set { sx = value; }
        }

        public int Sy
        {
            get { return sy; }
            set { sy = value; }
        }

        public int Ex
        {
            get { return ex; }
            set { ex = value; }
        }

        public int Ey
        {
            get { return ey; }
            set { ey = value; }
        }

        public int move()
        {
            //向下落
            if (sx == ex)
            {
                if (sy < ey)
                {
                    sy = sy + 8;
                    return 0;
                }
            }

            //向左靠
            if (sy == ey)
            {
                if (sx > ex)
                {
                    sx = sx - 8;
                    return 0;
                }
            }
            return 1;
        }

        public void Draw(Graphics g)
        {
            if (Color != 0)
                g.DrawImage(picture, new Point(sx, sy));
        }

    }
}
