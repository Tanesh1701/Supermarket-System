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

namespace Assignment
{
    public partial class Notepad : Form
    {
        string path;
        public Notepad()
        {
            InitializeComponent();
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            path = string.Empty;
            textPlaceHolder.Clear(); //Clicking on new clears everything on the notepad
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true, Multiselect = false})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName)) //streamreader allows us to read files stored on the computer programatically
                        {
                            path = ofd.FileName;
                            Task<string> text = sr.ReadToEndAsync(); //here we are reading the text file completely
                            textPlaceHolder.Text = text.Result;
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void saveMenuItem_Click(object sender, EventArgs e) //an async function means that it will execute every statement until it reaches its first await statement
        {
            if (string.IsNullOrEmpty(path))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            path = sfd.FileName;
                            using (StreamWriter sw = new StreamWriter(sfd.FileName))
                            {
                                await sw.WriteLineAsync(textPlaceHolder.Text); //method is on hold until everyline on the notepad is saved onto a textfile
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            } else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        await sw.WriteLineAsync();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void saveasMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteLineAsync(textPlaceHolder.Text);
                        }
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
