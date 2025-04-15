using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventurProgramm
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {

            // load byte-array from data into byte-array object
            byte[] iconBytes = Properties.Resources.logo_background_biggercontrol;

            // MemoryStream converts byte array to icon object
            using (MemoryStream ms = new MemoryStream(iconBytes)) {
                this.Icon = new Icon(ms);
            }
        }
    }
}
