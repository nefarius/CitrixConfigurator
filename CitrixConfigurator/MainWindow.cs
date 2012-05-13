using System;
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
using System.Diagnostics;

namespace CitrixConfigurator
{
    public partial class MainWindow : Form
    {
        RegistryKey key = null;
        private static readonly string value = "Configuration Model 000";

        public MainWindow()
        {
            InitializeComponent();

            key = Registry.CurrentUser.OpenSubKey(@"Software\Citrix\PNAgent", true);
        }

        private void bWrite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Write changes back to registry?", "U sure?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //byte[] bytes = Encoding.UTF8.GetBytes(RestoreCrippled(rtbRegValue.Text));
                //key.SetValue(value, bytes, RegistryValueKind.Binary);
            }
        }

        private void bGetString_Click(object sender, EventArgs e)
        {
            //tbBinValue.Text = StringToHex(RestoreCrippled(rtbRegValue.Text));
            tbBinValue.Focus();
            tbBinValue.SelectAll();
        }

        /// <summary>
        /// Converts a string to Group Policy compatible hex string.
        /// </summary>
        /// <param name="hexstring"></param>
        /// <returns></returns>
        private string StringToHex(string hexstring)
        {
            var sb = new StringBuilder();
            foreach (char t in hexstring)
                sb.Append(Convert.ToInt32(t).ToString("x"));
            return sb.ToString();
        }

        /// <summary>
        /// Auto-formats and indents an unformatted XML string.
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Converts the crippled citrix "xml" code to valide xml.
        /// </summary>
        /// <param name="crippled"></param>
        /// <returns></returns>
        private string FixCrippled(string crippled)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<root>");
            Match m = Regex.Match(crippled, @"<[\w\/]* \w* ?\w*>");
            do
            {
                crippled = Regex.Replace(crippled, m.Value, m.Value.Replace(' ', '_'));
            }
            while ((m = m.NextMatch()) != Match.Empty);
            sb.Append(crippled);
            sb.Append("</root>");

            return IndentXMLString(sb.ToString());
        }

        /// <summary>
        /// Converts valide xml data back to the crippled citrix format.
        /// </summary>
        /// <param name="valide"></param>
        /// <returns></returns>
        private string RestoreCrippled(string valide)
        {
            // replace all underscores in tags with spaces
            Match m = Regex.Match(valide, @"<[a-zA-Z\/]*_[a-zA-Z]*(_[a-zA-Z]*)?>");
            do
            {
                valide = Regex.Replace(valide, m.Value, m.Value.Replace('_', ' '));
            }
            while ((m = m.NextMatch()) != Match.Empty);

            // remove the <root> tags and line breaks
            string oneString = Regex.Replace(valide, @"(<(\/)?root>\n?)|\n|\r\n", string.Empty);
            // remove all spaces between tags
            string noSpaces = Regex.Replace(oneString, @"> *<", "><");
            // remove spaces at start and end of the string
            return noSpaces.Trim();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = (byte[])key.GetValue(value);

                string content = Encoding.UTF8.GetString(bytes);

                string valide = FixCrippled(content);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(valide);

                XmlElement root = doc.DocumentElement;
                XmlNode xmlNode = null;

                #region User Blob
                // DesktopDisplayEnabled
                xmlNode = root.SelectSingleNode("//User_Blob/Item[Key='DesktopDisplayEnabled']/Value");
                if (xmlNode != null)
                    DesktopDisplayEnabled.Checked = bool.Parse(xmlNode.InnerText);

                // DesktopName
                xmlNode = root.SelectSingleNode("//User_Blob/Item[Key='DesktopName']/Value");
                if (xmlNode != null)
                    DesktopName.Text = xmlNode.InnerText;

                // LogonMethod
                xmlNode = root.SelectSingleNode("//User_Blob/Item[Key='LogonMethod']/Value");
                if (xmlNode != null)
                    LogonMethod.SelectedItem = xmlNode.InnerText;

                // ReconnectFromButtonActive
                xmlNode = root.SelectSingleNode("//User_Blob/Item[Key='ReconnectFromButtonActive']/Value");
                if (xmlNode != null)
                    ReconnectFromButtonActive.Checked = bool.Parse(xmlNode.InnerText);

                // ReconnectFromButtonDisconnected
                xmlNode = root.SelectSingleNode("//User_Blob/Item[Key='ReconnectFromButtonDisconnected']/Value");
                if (xmlNode != null)
                    ReconnectFromButtonDisconnected.Checked = bool.Parse(xmlNode.InnerText);

                // ReconnectFromLogonActive
                xmlNode = root.SelectSingleNode("//User_Blob/Item[Key='ReconnectFromLogonActive']/Value");
                if (xmlNode != null)
                    ReconnectFromLogonActive.Checked = bool.Parse(xmlNode.InnerText);

                // ReconnectFromLogonDisconnected
                xmlNode = root.SelectSingleNode("//User_Blob/Item[Key='ReconnectFromLogonDisconnected']/Value");
                if (xmlNode != null)
                    ReconnectFromLogonDisconnected.Checked = bool.Parse(xmlNode.InnerText);

                // ServerURLEntered
                xmlNode = root.SelectSingleNode("//User_Blob/Item[Key='ServerURLEntered']/Value");
                if (xmlNode != null)
                    ServerURLEntered.Text = xmlNode.InnerText;

                // TODO: ServerURLListUsers

                // StartMenuDisplayEnabled
                xmlNode = root.SelectSingleNode("//User_Blob/Item[Key='StartMenuDisplayEnabled']/Value");
                if (xmlNode != null)
                    StartMenuDisplayEnabled.Checked = bool.Parse(xmlNode.InnerText);

                // StartMenuRoot
                xmlNode = root.SelectSingleNode("//User_Blob/Item[Key='StartMenuRoot']/Value");
                if (xmlNode != null)
                    StartMenuRoot.Text = xmlNode.InnerText;

                // StartMenuDisplayRootFolder
                xmlNode = root.SelectSingleNode("//User_Blob/Item[Key='StartMenuDisplayRootFolder']/Value");
                if (xmlNode != null)
                    StartMenuDisplayRootFolder.Text = xmlNode.InnerText;

                #endregion
                #region Primary Server Blob

                // DesktopName
                xmlNode = root.SelectSingleNode("//Primary_Server_Blob/Item[Key='DesktopName']/Value");
                if (xmlNode != null)
                    PS_DesktopName.Text = xmlNode.InnerText;

                // DesktopNameModifiable
                xmlNode = root.SelectSingleNode("//Primary_Server_Blob/Item[Key='DesktopNameModifiable']/Value");
                if (xmlNode != null)
                    PS_DesktopNameModifiable.Checked = bool.Parse(xmlNode.InnerText);

                // ServerURL
                xmlNode = root.SelectSingleNode("//Primary_Server_Blob/Item[Key='ServerURL']/Value");
                if (xmlNode != null)
                    PS_ServerURL.Text = xmlNode.InnerText;

                // ServerURLModifiable
                xmlNode = root.SelectSingleNode("//Primary_Server_Blob/Item[Key='ServerURLModifiable']/Value");
                if (xmlNode != null)
                    PS_ServerURLModifiable.Checked = bool.Parse(xmlNode.InnerText);

                // TODO: ServerURLListBackup

                // StartMenuDisplayRootFolder
                xmlNode = root.SelectSingleNode("//Primary_Server_Blob/Item[Key='StartMenuDisplayRootFolder']/Value");
                if (xmlNode != null)
                    PS_StartMenuDisplayRootFolder.Text = xmlNode.InnerText;

                // StartMenuRootFolderModifiable
                xmlNode = root.SelectSingleNode("//Primary_Server_Blob/Item[Key='StartMenuRootFolderModifiable']/Value");
                if (xmlNode != null)
                    PS_StartMenuRootFolderModifiable.Checked = bool.Parse(xmlNode.InnerText);

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://nefarius.at/");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
