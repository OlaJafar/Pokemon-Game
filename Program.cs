using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collection.Generics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line{
    class line{
        public void draw(int x,int y,int xx,int yy){
            int x1=x,y1=y,x2=xx,y2=yy;
            int dx=x2-x1,dy=y2-y1;
            if(Math.abs(dx)>Math.abs(dy))
                steps=Math.abs(dx);
            else steps=Math.abs(dy);
            for(int i=1;i<=n;i++){
                
            }
        }
    
    
    }
}



/*namespace MyGraphicsApp
{
    public class MyForm : Form
    {
        public MyForm()
        {
            this.Text = "Hello Graphics!";
            this.BackColor = Color.White;
            this.ClientSize = new Size(400, 300);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            using (Pen pen = new Pen(Color.Blue, 3))
            {
                g.DrawLine(pen, 50, 50, 300, 200);
            }

            using (Font font = new Font("Arial", 16))
            {
                g.DrawString("Hello, Graphics!", font, Brushes.Black, 100, 100);
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm());
        }
    }
}*/
