using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student.UI
{
    public partial class AsyncForm : Form
    {
        public AsyncForm()
        {
            InitializeComponent();
        }

        private async Task<int> CountCharacters()
        {
            int count = 0;
            string content = await File.ReadAllTextAsync(@"../../../LoremText.txt");
            count += content.Length;

            return count;
        }

        private async void CountBtn_Click(object sender, EventArgs e)
        {
            int count = await CountCharacters();
            charactersQuantity.Text = count.ToString();
        }
    }
}
