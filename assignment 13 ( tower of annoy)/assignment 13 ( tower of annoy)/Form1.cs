using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace assignment_13___tower_of_annoy_
{
     public class actor
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public int type;
        public Color color;
    };

    public partial class Form1 : Form
    {
        List<actor> l = new List<actor>();
        List<actor> l1 = new List<actor>();
        List<actor> l2 = new List<actor>();
        List<actor> l3 = new List<actor>();
        bool isdrag;
        int xold;
        int yold;
        int xorg;
        int yorg;
        int ct1 = 1;
        int ct2 = 1;
        int ct3 = 1;
        int flag;
        int ival = -1;

        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += new EventHandler(Form1_Load);
            this.MouseDown +=new MouseEventHandler(Form1_MouseDown);
            this.MouseUp += new MouseEventHandler(Form1_MouseUp);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawscene();
        }

        void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isdrag == true)
            {
                if (flag == 1)
                {
                    int dx = e.X - xold;
                    int dy = e.Y - yold;
                    l1[ival].x += dx;
                    l1[ival].y += dy;
                    xold = e.X;
                    yold = e.Y;
                }
                if (flag == 2)
                {
                    int dx = e.X - xold;
                    int dy = e.Y - yold;
                    l2[ival].x += dx;
                    l2[ival].y += dy;
                    xold = e.X;
                    yold = e.Y;
                }
                if (flag == 3)
                {
                    int dx = e.X - xold;
                    int dy = e.Y - yold;
                    l3[ival].x += dx;
                    l3[ival].y += dy;
                    xold = e.X;
                    yold = e.Y;
                }
                drawscene();
            }
        }

        void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isdrag = false;
            if (xold >= 400 && xold <= 600)
            {
                if (flag == 2)
                {
                    if (ct1 == 1)
                    {
                        actor pnn = new actor();
                        pnn.x = l2[ival].x;
                        pnn.y = l2[ival].y;
                        pnn.h = l2[ival].h;
                        pnn.w = l2[ival].w;
                        pnn.type = l2[ival].type;
                        pnn.color = l2[ival].color;
                        l1.Add(pnn);
                        if (xorg >= 700 && xorg <= 900)
                        {
                            l2.RemoveAt(l2.Count - 1);
                            ct2--;
                        }
                        if (xorg >= 1000 && xorg <= 1200)
                        {
                            l3.RemoveAt(l3.Count - 1);
                            ct3--;
                        }
                        l1[l1.Count - 1].y = 500 - (ct1 * 32);
                        ct1++;
                        xorg = l1[l1.Count - 1].x;
                        yorg = l1[l1.Count - 1].y;
                    }
                    else
                    {
                        if (l1[l1.Count - 1].w > l2[ival].w)
                        {
                            actor pnn = new actor();
                            pnn.x = l2[ival].x;
                            pnn.y = l2[ival].y;
                            pnn.h = l2[ival].h;
                            pnn.w = l2[ival].w;
                            pnn.type = l2[ival].type;
                            pnn.color = l2[ival].color;
                            l1.Add(pnn);
                            if (xorg >= 700 && xorg <= 900)
                            {
                                l2.RemoveAt(l2.Count - 1);
                                ct2--;
                            }
                            if (xorg >= 1000 && xorg <= 1200)
                            {
                                l3.RemoveAt(l3.Count - 1);
                                ct3--;
                            }
                            l1[l1.Count - 1].y = 500 - (ct1 * 32);
                            ct1++;
                            xorg = l1[l1.Count - 1].x;
                            yorg = l1[l1.Count - 1].y;
                        }
                        else
                        {
                            if (flag == 1)
                            {
                                l1[ival].x = xorg;
                                l1[ival].y = yorg;
                            }
                            if (flag == 2)
                            {
                                l2[ival].x = xorg;
                                l2[ival].y = yorg;
                            }
                            if (flag == 3)
                            {
                                l3[ival].x = xorg;
                                l3[ival].y = yorg;
                            }
                            MessageBox.Show("Error");
                        }
                    }
                }
                if (flag == 3)
                {
                    if (ct1 == 1)
                    {
                        actor pnn = new actor();
                        pnn.x = l3[ival].x;
                        pnn.y = l3[ival].y;
                        pnn.h = l3[ival].h;
                        pnn.w = l3[ival].w;
                        pnn.type = l3[ival].type;
                        pnn.color = l3[ival].color;
                        l1.Add(pnn);
                        if (xorg >= 700 && xorg <= 900)
                        {
                            l2.RemoveAt(l2.Count - 1);
                            ct2--;
                        }
                        if (xorg >= 1000 && xorg <= 1200)
                        {
                            l3.RemoveAt(l3.Count - 1);
                            ct3--;
                        }
                        l1[l1.Count - 1].y = 500 - (ct1 * 32);
                        ct1++;
                        xorg = l1[l1.Count - 1].x;
                        yorg = l1[l1.Count - 1].y;
                    }
                    else
                    {
                        if (l1[l1.Count - 1].w > l3[ival].w)
                        {
                            actor pnn = new actor();
                            pnn.x = l3[ival].x;
                            pnn.y = l3[ival].y;
                            pnn.h = l3[ival].h;
                            pnn.w = l3[ival].w;
                            pnn.type = l3[ival].type;
                            pnn.color = l3[ival].color;
                            l1.Add(pnn);
                            if (xorg >= 700 && xorg <= 900)
                            {
                                l2.RemoveAt(l2.Count - 1);
                                ct2--;
                            }
                            if (xorg >= 1000 && xorg <= 1200)
                            {
                                l3.RemoveAt(l3.Count - 1);
                                ct3--;
                            }
                            l1[l1.Count - 1].y = 500 - (ct1 * 32);
                            ct1++;
                            xorg = l1[l1.Count - 1].x;
                            yorg = l1[l1.Count - 1].y;
                        }
                        else
                        {
                            if (flag == 1)
                            {
                                l1[ival].x = xorg;
                                l1[ival].y = yorg;
                            }
                            if (flag == 2)
                            {
                                l2[ival].x = xorg;
                                l2[ival].y = yorg;
                            }
                            if (flag == 3)
                            {
                                l3[ival].x = xorg;
                                l3[ival].y = yorg;
                            }
                            MessageBox.Show("Error");
                        }
                    }
                }
            }

            if (xold >= 700 && xold <= 900)
            {
                if (flag == 1)
                {
                    if (ct2 == 1)
                    {
                        actor pnn = new actor();
                        pnn.x = l1[ival].x;
                        pnn.y = l1[ival].y;
                        pnn.h = l1[ival].h;
                        pnn.w = l1[ival].w;
                        pnn.type = l1[ival].type;
                        pnn.color = l1[ival].color;
                        l2.Add(pnn);
                        if (xorg >= 400 && xorg <= 600)
                        {
                            l1.RemoveAt(l1.Count - 1);
                            ct1--;
                        }
                        if (xorg >= 1000 && xorg <= 1200)
                        {
                            l3.RemoveAt(l3.Count - 1);
                            ct3--;
                        }
                        l2[l2.Count - 1].y = 500 - (ct2 * 32);
                        ct2++;
                        xorg = l2[l2.Count - 1].x;
                        yorg = l2[l2.Count - 1].y;
                    }
                    else
                    {
                        if (l2[l2.Count - 1].w > l1[ival].w)
                        {
                            actor pnn = new actor();
                            pnn.x = l1[ival].x;
                            pnn.y = l1[ival].y;
                            pnn.h = l1[ival].h;
                            pnn.w = l1[ival].w;
                            pnn.type = l1[ival].type;
                            pnn.color = l1[ival].color;
                            l2.Add(pnn);
                            if (xorg >= 400 && xorg <= 600)
                            {
                                l1.RemoveAt(l1.Count - 1);
                                ct1--;
                            }
                            if (xorg >= 1000 && xorg <= 1200)
                            {
                                l3.RemoveAt(l3.Count - 1);
                                ct3--;
                            }
                            l2[l2.Count - 1].y = 500 - (ct2 * 32);
                            ct2++;
                            xorg = l2[l2.Count - 1].x;
                            yorg = l2[l2.Count - 1].y;
                        }
                        else
                        {
                            if (flag == 1)
                            {
                                l1[ival].x = xorg;
                                l1[ival].y = yorg;
                            }
                            if (flag == 2)
                            {
                                l2[ival].x = xorg;
                                l2[ival].y = yorg;
                            }
                            if (flag == 3)
                            {
                                l3[ival].x = xorg;
                                l3[ival].y = yorg;
                            }
                            MessageBox.Show("Error");
                        }
                    }
                }
                if (flag == 3)
                {
                    if (ct2 == 1)
                    {
                        actor pnn = new actor();
                        pnn.x = l3[ival].x;
                        pnn.y = l3[ival].y;
                        pnn.h = l3[ival].h;
                        pnn.w = l3[ival].w;
                        pnn.type = l3[ival].type;
                        pnn.color = l3[ival].color;
                        l2.Add(pnn);
                        if (xorg >= 400 && xorg <= 600)
                        {
                            l1.RemoveAt(l1.Count - 1);
                            ct1--;
                        }
                        if (xorg >= 1000 && xorg <= 1200)
                        {
                            l3.RemoveAt(l3.Count - 1);
                            ct3--;
                        }
                        l2[l2.Count - 1].y = 500 - (ct2 * 32);
                        ct2++;
                        xorg = l2[l2.Count - 1].x;
                        yorg = l2[l2.Count - 1].y;
                    }
                    else
                    {
                        if (l2[l2.Count - 1].w > l3[ival].w)
                        {
                            actor pnn = new actor();
                            pnn.x = l3[ival].x;
                            pnn.y = l3[ival].y;
                            pnn.h = l3[ival].h;
                            pnn.w = l3[ival].w;
                            pnn.type = l3[ival].type;
                            pnn.color = l3[ival].color;
                            l2.Add(pnn);
                            if (xorg >= 400 && xorg <= 600)
                            {
                                l1.RemoveAt(l1.Count - 1);
                                ct1--;
                            }
                            if (xorg >= 1000 && xorg <= 1200)
                            {
                                l3.RemoveAt(l3.Count - 1);
                                ct3--;
                            }
                            l2[l2.Count - 1].y = 500 - (ct2 * 32);
                            ct2++;
                            xorg = l2[l2.Count - 1].x;
                            yorg = l2[l2.Count - 1].y;
                        }
                        else
                        {
                            if (flag == 1)
                            {
                                l1[ival].x = xorg;
                                l1[ival].y = yorg;
                            }
                            if (flag == 2)
                            {
                                l2[ival].x = xorg;
                                l2[ival].y = yorg;
                            }
                            if (flag == 3)
                            {
                                l3[ival].x = xorg;
                                l3[ival].y = yorg;
                            }
                            MessageBox.Show("Error");
                        }
                    }
                }
            }
            if (xold >= 1000 && xold <= 1200)
            {
                if (flag == 1)
                {
                    if (ct3 == 1)
                    {
                        actor pnn = new actor();
                        pnn.x = l1[ival].x;
                        pnn.y = l1[ival].y;
                        pnn.h = l1[ival].h;
                        pnn.w = l1[ival].w;
                        pnn.type = l1[ival].type;
                        pnn.color = l1[ival].color;
                        l3.Add(pnn);
                        if (xorg >= 400 && xorg <= 600)
                        {
                            l1.RemoveAt(l1.Count - 1);
                            ct1--;
                        }
                        if (xorg >= 700 && xorg <= 900)
                        {
                            l2.RemoveAt(l2.Count - 1);
                            ct2--;
                        }
                        l3[l3.Count - 1].y = 500 - (ct3 * 32);
                        ct3++;
                        xorg = l3[l3.Count - 1].x;
                        yorg = l3[l3.Count - 1].y;
                    }
                    else
                    {
                        if (l3[l3.Count - 1].w > l1[ival].w)
                        {
                            actor pnn = new actor();
                            pnn.x = l1[ival].x;
                            pnn.y = l1[ival].y;
                            pnn.h = l1[ival].h;
                            pnn.w = l1[ival].w;
                            pnn.type = l1[ival].type;
                            pnn.color = l1[ival].color;
                            l3.Add(pnn);
                            if (xorg >= 400 && xorg <= 600)
                            {
                                l1.RemoveAt(l1.Count - 1);
                                ct1--;
                            }
                            if (xorg >= 700 && xorg <= 900)
                            {
                                l2.RemoveAt(l2.Count - 1);
                                ct2--;
                            }
                            l3[l3.Count - 1].y = 500 - (ct3 * 32);
                            ct3++;
                            xorg = l3[l3.Count - 1].x;
                            yorg = l3[l3.Count - 1].y;
                        }
                        else
                        {
                            if (flag == 1)
                            {
                                l1[ival].x = xorg;
                                l1[ival].y = yorg;
                            }
                            if (flag == 2)
                            {
                                l2[ival].x = xorg;
                                l2[ival].y = yorg;
                            }
                            if (flag == 3)
                            {
                                l3[ival].x = xorg;
                                l3[ival].y = yorg;
                            }
                            MessageBox.Show("Error");
                        }
                    }
                }
                if (flag == 2)
                {
                    if (ct3 == 1)
                    {
                        actor pnn = new actor();
                        pnn.x = l2[ival].x;
                        pnn.y = l2[ival].y;
                        pnn.h = l2[ival].h;
                        pnn.w = l2[ival].w;
                        pnn.type = l2[ival].type;
                        pnn.color = l2[ival].color;
                        l3.Add(pnn);
                        if (xorg >= 700 && xorg <= 900)
                        {
                            l2.RemoveAt(l2.Count - 1);
                            ct2--;
                        }
                        if (xorg >= 400 && xorg <= 600)
                        {
                            l1.RemoveAt(l1.Count - 1);
                            ct1--;
                        }
                        l3[l3.Count - 1].y = 500 - (ct3 * 32);
                        ct3++;
                        xorg = l3[l3.Count - 1].x;
                        yorg = l3[l3.Count - 1].y;
                    }
                    else
                    {
                        if (l3[l3.Count - 1].w > l2[ival].w)
                        {
                            actor pnn = new actor();
                            pnn.x = l2[ival].x;
                            pnn.y = l2[ival].y;
                            pnn.h = l2[ival].h;
                            pnn.w = l2[ival].w;
                            pnn.type = l2[ival].type;
                            pnn.color = l2[ival].color;
                            l3.Add(pnn);
                            if (xorg >= 700 && xorg <= 900)
                            {
                                l2.RemoveAt(l2.Count - 1);
                                ct2--;
                            }
                            if (xorg >= 400 && xorg <= 600)
                            {
                                l1.RemoveAt(l1.Count - 1);
                                ct1--;
                            }
                            l3[l3.Count - 1].y = 500 - (ct3 * 32);
                            ct3++;
                            xorg = l3[l3.Count - 1].x;
                            yorg = l3[l3.Count - 1].y;
                        }
                        else
                        {
                            if (flag == 1)
                            {
                                l1[ival].x = xorg;
                                l1[ival].y = yorg;
                            }
                            if (flag == 2)
                            {
                                l2[ival].x = xorg;
                                l2[ival].y = yorg;
                            }
                            if (flag == 3)
                            {
                                l3[ival].x = xorg;
                                l3[ival].y = yorg;
                            }
                            MessageBox.Show("Error");
                        }
                    }
                }
            }
             drawscene();
        }
            

        void  Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ival = isHit(e.X, e.Y);
            if (ival != -1)
            {
                if (flag == 1)
                {
                    xorg = l1[ival].x;
                    yorg = l1[ival].y;
                    isdrag = true;
                    xold = e.X;
                    yold = e.Y;
                }
                if (flag == 2)
                {
                    xorg = l2[ival].x;
                    yorg = l2[ival].y;
                    isdrag = true;
                    xold = e.X;
                    yold = e.Y;
                }
                if (flag == 3)
                {
                    xorg = l3[ival].x;
                    yorg = l3[ival].y;
                    isdrag = true;
                    xold = e.X;
                    yold = e.Y;
                }
            }
            else
            {
                MessageBox.Show("wait");
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                MessageBox.Show("x = " + e.X + " | " + "y = " + e.Y);
            }
        }

        int isHit(int Xm, int Ym)
        {
            for (int i = 0; i < l1.Count; i++)
            {
                if (Xm >= l1[i].x
                    && Xm <= l1[i].x + l1[i].w
                    && Ym >= l1[i].y
                    && Ym <= l1[i].y + l1[i].w)
                {
                    flag = 1;
                    return i;
                }
            }
            for (int i = 0; i < l2.Count; i++)
            {
                if (Xm >= l2[i].x
                    && Xm <= l2[i].x + l2[i].w
                    && Ym >= l2[i].y
                    && Ym <= l2[i].y + l2[i].w)
                {
                    flag = 2;
                    return i;
                }
            }
            for (int i = 0; i < l3.Count; i++)
            {
                if (Xm >= l3[i].x
                    && Xm <= l3[i].x + l3[i].w
                    && Ym >= l3[i].y
                    && Ym <= l3[i].y + l3[i].w)
                {
                    flag = 3;
                    return i;
                }
            }
            return -1;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            int x = 500;
            int y = 200;
            for (int i = 0; i < 3; i++)
            {
                actor pnn = new actor();
                pnn.x = x;
                pnn.y = y;
                pnn.h = 300;
                pnn.w = 15;
                pnn.type = 1;
                pnn.color = Color.Gray;
                l.Add(pnn);
                x += 300;
            }
            x = 400;
            y = 500;
            for (int i = 0; i < 3; i++)
            {
                actor pnn = new actor();
                pnn.x = x;
                pnn.y = y;
                pnn.h = 15;
                pnn.w = 200;
                pnn.type = 1;
                pnn.color = Color.Gray;
                l.Add(pnn);
                x += 300;
            }
            x = 410;
            y = 470;
           int h = 30;
           int w = 180;
            for (int i = 0; i < 8; i++)
            {
                actor pnn = new actor();
                pnn.x = x;
                pnn.y = y;
                pnn.h = h;
                pnn.w = w;
                pnn.type = 2;
                pnn.color = Color.Yellow;
                l1.Add(pnn);
                ct1++;
                x += 10;
                y -= 32;
                w -= 20;
            }

            drawscene();
        }

        void drawscene()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            for (int i = 0; i < l.Count; i++)
            {
                SolidBrush bb = new SolidBrush(l[i].color);
                Pen pp = new Pen(Color.Black);
                if (l[i].type == 1)
                {
                    g.FillRectangle(bb, l[i].x, l[i].y, l[i].w, l[i].h);
                }
            }
            for (int i = 0; i < l1.Count; i++)
            {
                SolidBrush bb = new SolidBrush(l1[i].color);
                Pen pp = new Pen(Color.Black);
                if (l1[i].type == 2)
                {
                    g.DrawRectangle(pp, l1[i].x - 1, l1[i].y - 1, l1[i].w + 1, l1[i].h + 1);
                    g.FillRectangle(bb, l1[i].x, l1[i].y, l1[i].w, l1[i].h);
                }
            }
            for ( int i=0; i < l2.Count; i++)
            {
                SolidBrush bb = new SolidBrush(l2[i].color);
                Pen pp = new Pen(Color.Black);
                if (l2[i].type == 2)
                {
                    g.DrawRectangle(pp, l2[i].x - 1, l2[i].y - 1, l2[i].w + 1, l2[i].h + 1);
                    g.FillRectangle(bb, l2[i].x, l2[i].y, l2[i].w, l2[i].h);
                }
            }
            for (int i = 0; i < l3.Count; i++)
            {
                SolidBrush bb = new SolidBrush(l3[i].color);
                Pen pp = new Pen(Color.Black);
                if (l3[i].type == 2)
                {
                    g.DrawRectangle(pp, l3[i].x - 1, l3[i].y - 1, l3[i].w + 1, l3[i].h + 1);
                    g.FillRectangle(bb, l3[i].x, l3[i].y, l3[i].w, l3[i].h);
                }
            }
        }

    }
}