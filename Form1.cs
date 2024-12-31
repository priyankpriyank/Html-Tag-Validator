/*
Class: Form1
Author: Priyank Vora
Date: 22 November 2024
Purpose: This program is a Windows Forms that allows users to load an HTML file, check for its tags, and determine if the HTML tags are balanced or not.
         
I, Priyank Vora, 000922930, certify that this material is my original work. 
No other person's work has been used without due acknowledgment.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab4BForms
{
    /// <summary>
    /// Main form class for the HTML Tag Checker application.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Stores the content of the loaded HTML file.
        /// </summary>
        private string htmlContent;

        /// <summary>
        /// Stores the file path of the loaded HTML file.
        /// </summary>
        private string loadedFilePath = string.Empty;

        /// <summary>
        /// Initializes the form and its components.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the "Load File" menu option.
        /// Allows the user to select and load an HTML file.
        /// </summary>
        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkTagsToolStripMenuItem.Enabled = true;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "HTML Files|*.html",
                Title = "Open HTML File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadedFilePath = openFileDialog.FileName; // Store the path of the selected file
                string[] htmlContent = File.ReadAllLines(openFileDialog.FileName);

                // Clear the list box and display the file content
                listBox1.Items.Clear();
                foreach (string data in htmlContent)
                {
                    listBox1.Items.Add(data);
                }

                // Update the label to show the loaded file name
                string loadedFileName = Path.GetFileName(loadedFilePath);
                label1.Text = $"Loaded: {Path.GetFileName(loadedFilePath)}";
            }
        }

        /// <summary>
        /// Event handler for the "Check Tags" menu option.
        /// Checks if the tags in the loaded HTML file are balanced.
        /// </summary>
        private void checkTagsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loadedFilePath))
            {
                MessageBox.Show("No file loaded. Please load an HTML file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Parse the HTML file content and check the tags
                string htmlContent = File.ReadAllText(loadedFilePath);
                List<string> outcome = checkHtmlTags(htmlContent);

                // Update the list box with the result
                listBox1.Items.Clear();
                foreach (var data in outcome)
                {
                    listBox1.Items.Add(data);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Analyzes the HTML content for tags and checks if they are balanced.
        /// </summary>
        /// <param name="content">The HTML content as a string.</param>
        /// <returns>A list of strings representing the analysis of the tags.</returns>
        private List<string> checkHtmlTags(string content)
        {
            bool isBalanced = true; // Tracks if the tags are balanced
            int spaceTab = 0; // Tracks the indentation level for visual formatting
            Stack<string> tagStack = new Stack<string>(); // Stack for tracking open tags
            Regex tagRegex = new Regex(@"<(/?)(\w+).*?>"); // Regex for matching HTML tags
            List<string> allTags = new List<string>(); // Stores the analysis result

            allTags.Add($"{Path.GetFileName(loadedFilePath)} tags: ");

            foreach (Match match in tagRegex.Matches(content))
            {
                string tag = match.Groups[2].Value.ToLower(); // Extract the tag name
                bool isClosing = match.Groups[1].Value == "/"; // Check if it's a closing tag

                // Handle self-closing tags (do not affect balance)
                if (tag == "img" || tag == "hr" || tag == "br" || tag == "meta")
                {
                    allTags.Add($"{new string(' ', spaceTab * 4)}Found Non-Container Tag: <{tag}>");
                    continue;
                }

                if (!isClosing)
                {
                    // Opening tag: add to stack
                    allTags.Add($"{new string(' ', spaceTab * 4)}Found Opening Tag: <{tag}>");
                    tagStack.Push(tag);
                    spaceTab++;
                }
                else
                {
                    // Closing tag: check for a matching opening tag
                    spaceTab = Math.Max(0, spaceTab - 1);
                    allTags.Add($"{new string(' ', spaceTab * 4)}Found Closing Tag: </{tag}>");

                    if (tagStack.Count == 0 || tagStack.Peek() != tag)
                    {
                        isBalanced = false;
                        allTags.Add($"{new string(' ', spaceTab * 4)}Found Unmatched Closing Tag: </{tag}>");
                    }
                    else
                    {
                        tagStack.Pop();
                    }
                }
            }

            // Check for any unmatched opening tags left in the stack
            while (tagStack.Count > 0)
            {
                spaceTab = Math.Max(0, spaceTab - 1);
                isBalanced = false;
                
                allTags.Add($"{new string(' ', spaceTab * 4)}Found Unmatched Opening Tag: <{tagStack.Pop()}>");
            }

            // Update label with the balance status
            string fileName = Path.GetFileName(loadedFilePath);
            label1.Text = isBalanced
                ? $"{fileName} has Balanced Tags."
                : $"{fileName} doesn't have Balanced Tags.";

            return allTags;
        }

        /// <summary>
        /// Event handler for the "Exit" menu option.
        /// Closes the application.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
