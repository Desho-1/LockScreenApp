namespace LockScreen

{
    using System;
    
    public partial class screen1 : Form
    {
        
        int  Secondsleft = 7200000;
        public screen1()
        {
            InitializeComponent();
        }
        private void screen1_Load(object sender, EventArgs e)
        {
            time.ResetText();
            
            counter.Start();


        }

        private void counter_Tick(object sender, EventArgs e)
        {
            time.Text = Secondsleft--.ToString();
            if (Secondsleft == 0)
            {
                counter.Stop();
                this.Hide();
                screen2 s= new screen2();
                s.Show();
            }
        }


       
    }
}
   
