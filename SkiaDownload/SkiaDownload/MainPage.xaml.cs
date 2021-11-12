using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace SkiaDownload
{
    public partial class MainPage : ContentPage
    {
        float x1, y1, r1, x2, y2, r2, x3, y3, r3;
        float vx, vy, vx2, vy2, vx3, vy3;


        public MainPage()
        {
            InitializeComponent();
            x1 = 700;
            y1 = 350;
            r1 = 50;
            vx = 10f;
            vy = 7f;
            x2 = 300;
            y2 = 200;
            r2 = 30;
            vx2 = 5f;
            vy2 = 25f;
            x3 = 50;
            y3 = 180;
            r3 = 36;
            vx3 = 3f;
            vy3 = 9f;

              
               
                 

            Device.StartTimer(TimeSpan.FromMilliseconds(50), () =>
            {
                canvasView.InvalidateSurface();

                return true;


            });
        }




        private void CanvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {

            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;
            canvas.Clear(SKColors.WhiteSmoke);
            SKSize size = canvasView.CanvasSize;

            SKPaint p = new SKPaint();
            p.Color = SKColors.MediumPurple;
            canvas.DrawCircle(x1, y1, r1, p);
            x1 += vx;
            y1 += vy;

            SKPaint p2 = new SKPaint();
            p2.Color = SKColors.Green;
            canvas.DrawCircle(x2, y2, r2, p2);
            x2 += vx2;
            y2 += vy2;

            SKPaint p3 = new SKPaint();
            p3.Color = SKColors.Orange;
            canvas.DrawCircle(x3, y3, r3, p3);
            x3 += vx3;
            y3 += vy3;

            if ((x1 > size.Width - r1) || (x1 < r1))
                vx = -vx;
            if ((y1 > size.Height - r1) || (y1 < r1))
                vy = -vy;
            if ((x2 > size.Width - r2) || (x2 < r2))
                vx2 = -vx2;
            if ((y2 > size.Height - r2) || (y2 < r2))
                vy2 = -vy2;
            if ((x3 > size.Width - r3) || (x3 < r3))
                vx3 = -vx3;
            if ((y3 > size.Height - r3) || (y3 < r3))
                vy3 = -vy3;


        }

             

    }
}