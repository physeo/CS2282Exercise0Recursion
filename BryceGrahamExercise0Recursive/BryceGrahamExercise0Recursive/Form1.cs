/**********************************************
Bryce Graham
CS 2282
Dr. Beard
Exercise 0: An introductory program to learn how to use recursion.
**********************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BryceGrahamExercise0Recursive
{
    public partial class Exercise0Form : Form
    {
        public Exercise0Form()
        {
            InitializeComponent();
        }

        // Calls the interleave strings method after obtaining the strings 
        // from the textboxes on the form then displays the results.
        private void interleaveButton_Click(object sender, EventArgs e)
        {
            string s1 = stringBox1.Text.Trim();
            string s2 = stringBox2.Text.Trim();
            string newString = interleaveStrings(s1, s2, "", 0);
            displayBox.Text = newString;
        }

        // Calls the sumStringDif method after obtaining the strings
        // from the textboxes on the form then displays the results.
        private void sumStringDifferenceButton_Click(object sender, EventArgs e)
        {
            string s1 = stringBox1.Text.Trim();
            string s2 = stringBox2.Text.Trim();
            int asciiSum = sumStringDif(s1, s2, 0, 0);
            displayBox.Text = "The sum of the differences is: " + asciiSum;
        }

        // Calls the checkChars method after obtaining the strings
        // frmo the textboxes on the form then displays the results.
        private void checkCharsButton_Click(object sender, EventArgs e)
        {
            string s1 = stringBox1.Text.Trim();
            string s2 = stringBox2.Text.Trim();
            bool charInBoth = checkChars(s1, s2, 0, false);
            if(charInBoth)
            {
                displayBox.Text = "The strings both have the same characters.";
            }
            else
            {
                displayBox.Text = "The strings do not have the same characters.";
            }
        }

        // Combines two strings in an interleaving pattern so that the first
        // character of string one is followed by the first character of string
        // two and so on.
        public string interleaveStrings(string s1, string s2, string newString, int count)
        {
            if (count < s1.Length && count < s2.Length)
            {
                newString += s1[count].ToString() + s2[count].ToString();
                count++;
                newString = interleaveStrings(s1, s2, newString, count);
            }
            else if (count == s1.Length && count != s2.Length)
            {
                newString += s2.Substring(count);
            }
            if (count == s2.Length && count != s1.Length)
            {
                newString += s1.Substring(count);
            }

            return newString;
        }

        // Obtains the sum of the differences of corresponding ascii
        // characters in two equal length strings.
        public int sumStringDif(string s1, string s2, int count, int asciiSum)
        {
            if (s1.Length != s2.Length)
                return -1;
            else if (count < s1.Length)
            {
                asciiSum += (int)s1[count] - (int)s2[count];
                count++;
                asciiSum = sumStringDif(s1, s2, count, asciiSum);
            }
            return asciiSum;
        }

        // Checks to see if all of the characters in string one are in
        // string two and vice versa.
        public bool checkChars(string s1, string s2, int count, bool charInBoth)
        {
            if (s1.Length >= s2.Length && count < s1.Length)
            {
                charInBoth = s2.IndexOf(s1[count]) > -1;
                count++;
                charInBoth = checkChars(s1, s2, count, charInBoth);
            }
            else if (s2.Length >= s1.Length && count < s2.Length)
            {
                charInBoth = s1.IndexOf(s2[count]) > -1;
                count++;
                charInBoth = checkChars(s1, s2, count, charInBoth);
            }
            return charInBoth;
        }
    }
}
