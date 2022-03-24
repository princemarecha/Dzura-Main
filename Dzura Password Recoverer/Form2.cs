using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Dzura_Password_Recoverer
{
    public partial class welcome : Form
    {

        Dzura dzura = new Dzura();
   
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            try{

                Cursor.Current = Cursors.WaitCursor;
                dzura.networks();
                dzura.passwords();
                dzura.cancel();
                Cursor.Current = Cursors.Default;

                yut();
            }
            catch ( Exception ex){

                MessageBox.Show("Pane zvavhiringika, sendai meseji iri pazasi kwatiri kuti mubetserwe // Error, please send error information to us so that we can help. " + ex, "Mira / Stop" ,MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public async void yut()
        {
            Cursor.Current = Cursors.AppStarting;
            await Task.Delay(7000);
            this.Hide();
            Cursor.Current = Cursors.Default;
            dzura.Show();
        }

    }
}
