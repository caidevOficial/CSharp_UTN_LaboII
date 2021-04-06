/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio_29
{
    public partial class ContadorDePalabras : Form
    {
        public ContadorDePalabras()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Counts the different words and shows in the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> amountWords = new Dictionary<string, int>();
            List<string> orderedTop = new List<string>();
            string finalMessage = "";
            string keyValue;
            bool first = true;
            int biggerNumber = int.MinValue;
            if (!String.IsNullOrWhiteSpace(richTextWords.Text))
            {
                string words = richTextWords.Text;
                string[] arrayWords;
                words.Trim(); // deletes the white spaces at the end & beginning
                words = words.ToLower(); // normalize the words.
                words = words.Replace(".", ""); // deletes the dots
                arrayWords = words.Split(' ');

                // Counts Words
                foreach (string word in arrayWords)
                {
                    if (!amountWords.ContainsKey(word))
                    {
                        amountWords.Add(word, 1);
                    }
                    else
                    {
                        amountWords[word] += 1;
                    }
                }

                // Obtains the k,v pair and shows into the text box.
                foreach (KeyValuePair<string, int> row in amountWords)
                {
                    keyValue = $"{row.Value} - {row.Key}. \n";
                    if (first || row.Value >= biggerNumber)
                    {
                        first = false;
                        biggerNumber = row.Value;
                        orderedTop.Insert(0, keyValue);
                    }
                    else
                    {
                        orderedTop.Add(keyValue);
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    finalMessage += orderedTop[i];
                }
                richTextShow.Text = "Top 3 palabras con mas apariciones:\n" + finalMessage;
            }
        }

        private void ContadorDePalabras_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this wonderful app?", "Choose wisely", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Dispose();
            }
        }
    }
}
