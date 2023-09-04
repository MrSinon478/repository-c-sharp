using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_16
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text.File(*.txt)|*.txt|All File(*.*)|*.*";
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult save = MessageBox.Show("Вы хотите сохранить документ", "Сохранить", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (save == DialogResult.Yes)
            {
                Form activeChild = this;
                if (this.ActiveMdiChild != null)
                {
                    RichTextBox rtb = this.ActiveMdiChild.Controls[0] as RichTextBox;
                    var Form2 = (Form2)this.ActiveMdiChild;
                    saveFileDialog1.Filter = "Text.File(*.txt)|*.txt|All File(*.*)|*.*";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        rtb.SaveFile(saveFileDialog1.FileName);
                        Form2.Text = saveFileDialog1.FileName;
                        MessageBox.Show("Файл сохранен");
                    }
                }

            }
        
        }
    }
}
