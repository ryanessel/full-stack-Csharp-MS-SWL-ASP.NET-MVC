using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drag_drop_test
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;

        public Form1()
        {
            InitializeComponent();
            lblDragDrop.AllowDrop = true;
            lblDragDrop.DragEnter += new DragEventHandler(lblDragDrop_DragEnter);
//lblDragDrop.DragDrop += new DragEventHandler(lblDragDrop_DragDrop);
        }

        private void lblDragDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            isDragging = true;
        }

        private void lblDragDrop_DragDrop(object sender, DragEventArgs e)
        {
            if (!isDragging)
            {
                return;
            }

            isDragging = false;

            // Check if the dropped data is a file
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Get the file name and display it in a MessageBox
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string file in files)
                {
                 
                    
                        lbDroppedFiles.Items.Add(file);
                    
                }
            }
        }
    }
}
