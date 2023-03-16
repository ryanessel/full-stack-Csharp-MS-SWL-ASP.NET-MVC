using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dragdrop_dragenter_test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBoxToReceiveDrop.AllowDrop= true;
            txtBoxToReceiveDrop.DragEnter += new DragEventHandler(txtBoxToReceiveDrop_DragEnter);
            //txtBoxToReceiveDrop.DragDrop += new DragEventHandler(txtBoxToReceiveDrop_DragDrop);
        }

        private void btnTextToDrag_MouseDown(object sender, MouseEventArgs e)
        {
            btnTextToDrag.DoDragDrop(btnTextToDrag.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void txtBoxToReceiveDrop_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtBoxToReceiveDrop_DragDrop(object sender, DragEventArgs e)
        {
            string droppedText = e.Data.GetData(DataFormats.Text).ToString();
            //MessageBox.Show(e.Data.GetData(DataFormats.Text).ToString(), "Dropped Text is ... ");
            txtBoxToReceiveDrop.Text += Environment.NewLine + droppedText;
        }
    }
}
