

namespace Nightmare_Realm_Prototype
{
    public partial class Form1 : Form
    {
        int[] x1 = new int[] { 2, 4, 3, 4, 2 };
        int[] x2 = new int[] { 1, 0, 3, 0, 2 };
        int[] x3 = new int[] { 3, 4, 1, 4, 1 };
        int[] x4 = new int[] { 2, 0, 2, 0, 3 };
        int[] x5 = new int[] { 1, 4, 1, 4, 3 };
        public Form1()
        {
            InitializeComponent();
            typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty).SetValue(panel1, true, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
      

        private void pbx_Click(object sender, MouseEventArgs e)
        {
            
        }
        Point loc;
        int[] n = null;
        private void pbx_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pbx = ((PictureBox)sender);
            string state = "";
            if (loc.X < e.Location.X & (loc.Y >= e.Location.Y - 50 & loc.Y <= e.Location.Y + 50))
            {
                state = "right";
            }
            else if (loc.X > e.Location.X & (loc.Y >= e.Location.Y - 50 & loc.Y <= e.Location.Y + 50))
            {
                state = "left";
            }
            else if ((loc.X >= e.Location.X - 50 & loc.X <= e.Location.X + 50) & loc.Y > e.Location.Y)
            {
                state = "up";
            }
            else if ((loc.X >= e.Location.X - 50 & loc.X <= e.Location.X + 50) & loc.Y < e.Location.Y)
            {
                state = "down";
            }

            int a = 0;
            ref int[] pbxarr0 = ref n;
            ref int[] pbxarr1 = ref x1;
            ref int[] pbxarr2 = ref x2;
            if (pbx.Location.X == 120)
                a = 1;
            if (pbx.Location.X == 235)
                a = 2;
            if (pbx.Location.X == 350)
                a = 3;
            if (pbx.Location.X == 465)
                a = 4;
            if (pbx.Location.Y == 115)
            {
                pbxarr0 = ref x1;
                pbxarr1 = ref x2;
                pbxarr2 = ref x3;
            }
            if (pbx.Location.Y == 225)
            {
                pbxarr0 = ref x2;
                pbxarr1 = ref x3;
                pbxarr2 = ref x4;
            }
            if (pbx.Location.Y == 335)
            {
                pbxarr0 = ref x3;
                pbxarr1 = ref x4;
                pbxarr2 = ref x5;
            }
            if (pbx.Location.Y == 445)
            {
                pbxarr0 = ref x4;
                pbxarr1 = ref x5;
                pbxarr2 = ref n;
            }

            if (state == "left" && a != 0 && pbxarr1[a - 1] == 0)
            {
                pbx.Location = new Point(pbx.Location.X - 115, pbx.Location.Y);
                pbxarr1[a] = 0;
                pbxarr1[a - 1] = Convert.ToInt32(pbx.Tag);
            }
            else if (state == "right" && a != 4 && pbxarr1[a + 1] == 0)
            {
                pbx.Location = new Point(pbx.Location.X + 115, pbx.Location.Y);
                pbxarr1[a] = 0;
                pbxarr1[a + 1] = Convert.ToInt32(pbx.Tag);
            }
            else if (state == "up" && pbxarr0!=null && pbxarr0[a] == 0)
            {
                pbx.Location = new Point(pbx.Location.X, pbx.Location.Y - 110);
                pbxarr0[a] = Convert.ToInt32(pbx.Tag);
                pbxarr1[a] = 0;
            }
            else if (state == "down" && pbxarr2!=null && pbxarr2[a] == 0)
            {
                pbx.Location = new Point(pbx.Location.X, pbx.Location.Y + 110);
                pbxarr1[a] = 0;
                pbxarr2[a] = Convert.ToInt32(pbx.Tag);
            }
            if ((x1[0] == x2[0] & x2[0]==x3[0] & x3[0]==x4[0] & x4[0] == x5[0]) &
                (x1[2] == x2[2] & x2[2] == x3[2] & x3[2] == x4[2] & x4[2] == x5[2]) &
                (x1[4] == x2[4] & x2[4] == x3[4] & x3[4] == x4[4] & x4[4] == x5[4]))
                MessageBox.Show("win");
        }

        private void pbx_MouseDown(object sender, MouseEventArgs e)
        {
            loc = e.Location;
        }
    }
}