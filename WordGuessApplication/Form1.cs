using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        private string word = "computer";
        private StringBuilder guess;
        public Form1()
        {
            InitializeComponent();
            guess = new StringBuilder(word.Length);
            guess.Append(word[0]); 
            for (int i = 1; i < word.Length - 1; i++) 
            {
                if (char.IsLetter(word[i]) && i > 1 && i < word.Length - 1)
                    guess.Append('?');
                else
                    guess.Append(word[i]);
            }
            guess.Append(word[word.Length - 1]); 
            label1.Text = guess.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string answer = textBox1.Text;

            if (answer == word)
            {
                label1.Text = word;
                MessageBox.Show("Correct Guess!");
            }
            else
            {
                listBox1.Items.Add(answer);
                MessageBox.Show("Wrong Guess!, Try Again");
              
            }

            textBox1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
     
        }
    }
}