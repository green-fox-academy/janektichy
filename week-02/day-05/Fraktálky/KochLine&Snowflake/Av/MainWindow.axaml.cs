using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System.Collections.Generic;
using GreenFox;

namespace Av
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);

            MakeKochSnowflake(foxDraw, 50, 600, 650, 600, 6);
        }
        public static void MakeKochLine(FoxDraw foxDraw, double x, double y, double x2, double y2, int depth)
        {
            if (depth == 0)
            {
                foxDraw.DrawLine(x, y, x2, y2);
                return;
            }
            else
            {

                double vektorX = (x2 - x) / 3;
                double vektorY = (y2 - y) / 3;

                double reversedVektorX = vektorY;
                double reversedVektorY = vektorX;

                double mainX = x + vektorX;
                double mainY = y + vektorY;
                double finalX = x + 2 * vektorX;
                double finalY = y + 2 * vektorY;
                double endX = x + 1.5 * vektorX + reversedVektorX;
                double endY = y + 1.5 * vektorY - reversedVektorY;

                MakeKochLine(foxDraw, x, y, mainX, mainY, depth - 1);
                MakeKochLine(foxDraw, mainX, mainY, endX, endY, depth - 1);
                MakeKochLine(foxDraw, endX, endY, finalX, finalY, depth - 1);
                MakeKochLine(foxDraw, finalX, finalY, x2, y2, depth - 1);

            }
        }
        public static void MakeKochSnowflake(FoxDraw foxDraw, double x, double y, double x2, double y2, int depth)
        {
            if (depth == 0)
            {
                foxDraw.DrawLine(x, y, x2, y2);
                return;
            }
            double vectorX = x2 - x;
            double vectorY = y2 - y;
            double length = System.Math.Sqrt(vectorX * vectorX + vectorY * vectorY);
            double height = System.Math.Sqrt(length * length - (length / 2) * (length / 2));
            MakeKochLine(foxDraw, x + length / 2, y - height, x2, y2, depth - 1);
            MakeKochLine(foxDraw, x, y, x + length / 2, y - height, depth - 1);
            MakeKochLine(foxDraw, x2, y2, x, y, depth - 1);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        
        }
    }


