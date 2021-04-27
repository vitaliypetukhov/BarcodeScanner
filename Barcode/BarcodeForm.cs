using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode
{
    public partial class Barcode : Form
    {
        public Barcode()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCapabilities videoCapabilities;

        private void Form1_Load(object sender, EventArgs e)
        {
            //инициализация списка доступных камер
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in filterInfoCollection)
            {
                cmbCamera.Items.Add(device.Name);
            }
            cmbCamera.SelectedIndex = 0;

        }
    }
}
 