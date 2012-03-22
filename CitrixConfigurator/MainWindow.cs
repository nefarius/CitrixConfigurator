﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace CitrixConfigurator
{
    public partial class MainWindow : Form
    {
        RegistryKey key = null;
        private static readonly string value = "Configuration Model 000";

        public MainWindow()
        {
            InitializeComponent();

            key = Registry.CurrentUser.OpenSubKey(@"Software\Citrix\PNAgent");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            byte[] bytes = (byte[])key.GetValue(value);

            string content = Encoding.UTF8.GetString(bytes);

            rtbRegValue.Text = FixCrippled(content);
        }

        private void bWrite_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(RestoreCrippled(rtbRegValue.Text));
            key.SetValue(value, bytes, RegistryValueKind.Binary);
        }

        private void bGetString_Click(object sender, EventArgs e)
        {
            rtbRegValue.Text = RestoreCrippled(rtbRegValue.Text);
            //tbBinValue.Text = StringToHex(RestoreCrippled(rtbRegValue.Text));
            //tbBinValue.SelectAll();
        }

        private string StringToHex(string hexstring)
        {
            var sb = new StringBuilder();
            foreach (char t in hexstring)
                sb.Append(Convert.ToInt32(t).ToString("x"));
            return sb.ToString();
        }

        private static string IndentXMLString(string xml)
        {
            string outXml = string.Empty;
            MemoryStream ms = new MemoryStream();
            // Create a XMLTextWriter that will send its output to a memory stream (file)
            XmlTextWriter xtw = new XmlTextWriter(ms, Encoding.Unicode);
            XmlDocument doc = new XmlDocument();

            // Load the unformatted XML text string into an instance
            // of the XML Document Object Model (DOM)
            doc.LoadXml(xml);

            // Set the formatting property of the XML Text Writer to indented
            // the text writer is where the indenting will be performed
            xtw.Formatting = Formatting.Indented;

            // write dom xml to the xmltextwriter
            doc.WriteContentTo(xtw);
            // Flush the contents of the text writer
            // to the memory stream, which is simply a memory file
            xtw.Flush();

            // set to start of the memory stream (file)
            ms.Seek(0, SeekOrigin.Begin);
            // create a reader to read the contents of
            // the memory stream (file)
            StreamReader sr = new StreamReader(ms);
            // return the formatted string to caller
            return sr.ReadToEnd();
        }

        private string FixCrippled(string crippled)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<root>");
            sb.Append(Regex.Replace(crippled, @"(<[\w\/]*) (\w*) ?(\w*>)", @"$1_$2_$3"));
            sb.Append("</root>");

            return IndentXMLString(sb.ToString());
        }

        private string RestoreCrippled(string valide)
        {
            string crippled = Regex.Replace(valide, @"(<[a-zA-Z\/]*)_([a-zA-Z]*)_([a-zA-Z]*)_?>", @"$1 $2 $3>");
            return Regex.Replace(crippled, @"<(\/)?root>\n?", "");
        }
    }
}
