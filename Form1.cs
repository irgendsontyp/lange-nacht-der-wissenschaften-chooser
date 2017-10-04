using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace Lange_Nacht_der_Wissenschaften_Chooser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void downloadAppointmentDetails()
        {
            Directory.CreateDirectory("content/appointmentDetails");

            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;

            Directory.CreateDirectory("content");

            string appointmentsByPartnersPageContent = webClient.DownloadString("http://www.nacht-der-wissenschaften.de/2017/programm/nach-programmpartnern/buchstabe/%25/");

            Regex regexAppointmentPageLink = new Regex("<div style=\"margin-left:10px;\">\\s*<a href=\"(.*?)\">.*?</a>\\s*<div class=\"termindetails\">", RegexOptions.Singleline | RegexOptions.IgnoreCase);
            MatchCollection matchesAppointmentPageLink = regexAppointmentPageLink.Matches(appointmentsByPartnersPageContent);

            Regex regexFileNameCheck = new Regex("(\\d+)_content\\.html");
            Regex regexAppointmentPlace = new Regex("<div class=\"veranstaltungsort_ort_\\d+\">\\s*<a href=\".*?\">(.*?)</a>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Regex regexAppointmentBlock = new Regex("<h3 style=\"margin-bottom:-10px;\">.*?</h3>\\s*<div class=\"termindetails\">.*?<a.*?class=\"terminAdderWidget\".*?</a>\\s*</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);

            Match matchAppointmentPlace = regexAppointmentPlace.Match(appointmentsByPartnersPageContent);

            string appointmentPlace = matchAppointmentPlace.Groups[1].Value.Trim();

            Regex regexAppointmentTitle = new Regex("<h3 style=\"margin-bottom:-10px;\">(.*?)<", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Regex regexAppointmentImageUrl = new Regex("<img\\s*class=\"terminbild\"\\s*src=\"(.*?)\"", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Regex regexAppointmentDescription = new Regex("<p>(.*?)</p>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Regex regexAppointmentFooter = new Regex("<div class=\"terminfooter\">(.*?)</div>", RegexOptions.IgnoreCase | RegexOptions.Singleline);

            int appointmentCounter = 1;

            foreach (Match matchAppointmentPageLink in matchesAppointmentPageLink)
            {
                string contentUrl = "http://www.nacht-der-wissenschaften.de" + matchAppointmentPageLink.Groups[1].ToString();

                string appointmentsPageContent = webClient.DownloadString(contentUrl);

                MatchCollection matchesAppointmentBlocks = regexAppointmentBlock.Matches(appointmentsPageContent);
                
                foreach (Match matchSingleAppointmentBlock in matchesAppointmentBlocks)
                {
                    string appointmentDescriptionBlock = matchSingleAppointmentBlock.Value;

                    string appointmentTitle = regexAppointmentTitle.Match(appointmentDescriptionBlock).Groups[1].Value.Trim();
                    string appointmentImageUrl = regexAppointmentImageUrl.Match(appointmentDescriptionBlock).Groups[1].Value.Trim();

                    StringBuilder appointmentDescription = new StringBuilder();

                    MatchCollection matchesDescription = regexAppointmentDescription.Matches(appointmentDescriptionBlock);

                    foreach (Match matchDescriptionSingle in matchesDescription)
                    {
                        appointmentDescription.Append(matchDescriptionSingle.Groups[1].Value + Environment.NewLine);
                    }

                    string appointmentFooter = regexAppointmentFooter.Match(appointmentDescriptionBlock).Groups[1].Value.Trim();
                    appointmentFooter = new Regex("\\s+").Replace(appointmentFooter, " ");

                    StringBuilder str = new StringBuilder();

                    Directory.CreateDirectory("content/appointmentDetails/" + appointmentCounter.ToString());

                    File.WriteAllText("content/appointmentDetails/" + appointmentCounter.ToString() + "/description.txt", appointmentDescription.ToString());
                    File.WriteAllText("content/appointmentDetails/" + appointmentCounter.ToString() + "/footer.txt", appointmentFooter.ToString());
                    File.WriteAllText("content/appointmentDetails/" + appointmentCounter.ToString() + "/place.txt", appointmentPlace.ToString());
                    File.WriteAllText("content/appointmentDetails/" + appointmentCounter.ToString() + "/title.txt", appointmentTitle.ToString());
                    File.WriteAllText("content/appointmentDetails/" + appointmentCounter.ToString() + "/url.txt", contentUrl);

                    string imageExtension = Path.GetExtension(appointmentImageUrl);

                    if (appointmentImageUrl.Length != 0)
                    {
                        webClient.DownloadFile("http://www.nacht-der-wissenschaften.de" + appointmentImageUrl, "content/appointmentDetails/" + appointmentCounter.ToString() + "/image" + imageExtension);
                    }

                    ++appointmentCounter;
                }
            }
        }

        int currentAppointmentIndex = 0;

        private void loadSavedAppointmentIndex()
        {
            if (File.Exists("chooser/current-index.txt"))
            {
                string currentAppointmentIndexContent = File.ReadAllText("chooser/current-index.txt");

                currentAppointmentIndex = int.Parse(currentAppointmentIndexContent);
            }
        }

        string getCurrentAppointmentNumber()
        {
            return appointmentDirectories[currentAppointmentIndex];
        }

        class Appointment
        {
            public string Description
            {
                get;
                set;
            }

            public string Footer
            {
                get;
                set;
            }

            public Image Image
            {
                get;
                set;
            }

            public string Place
            {
                get;
                set;
            }

            public string Title
            {
                get;
                set;
            }

            public string Url
            {
                get;
                set;
            }
        }

        private Appointment loadAppointmentDetails()
        {
            Appointment appointment = new Appointment();

            appointment.Description = File.ReadAllText("content/appointmentDetails/" + getCurrentAppointmentNumber().ToString() + "/description.txt");
            appointment.Footer = File.ReadAllText("content/appointmentDetails/" + getCurrentAppointmentNumber().ToString() + "/footer.txt");

            IEnumerable<string> imageFiles = Directory.EnumerateFiles("content/appointmentDetails/" + getCurrentAppointmentNumber().ToString(), "image.*");

            if (imageFiles.Count() > 0)
            {
                appointment.Image = Image.FromFile("content/appointmentDetails/" + getCurrentAppointmentNumber().ToString() + "/" + Path.GetFileName(imageFiles.First()));
            }
            
            appointment.Place = File.ReadAllText("content/appointmentDetails/" + getCurrentAppointmentNumber().ToString() + "/place.txt");
            appointment.Title = File.ReadAllText("content/appointmentDetails/" + getCurrentAppointmentNumber().ToString() + "/title.txt");
            appointment.Url = File.ReadAllText("content/appointmentDetails/" + getCurrentAppointmentNumber().ToString() + "/url.txt");

            return appointment;
        }

        private void displayCurrentAppointment()
        {
            Appointment currentAppointment = loadAppointmentDetails();

            this.lblDescription.Text = currentAppointment.Description;
            this.lblTitle.Text = currentAppointment.Title;

            this.lnkLblUrl.Links.Clear();
            this.lnkLblUrl.Text = currentAppointment.Url;

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = currentAppointment.Url;

            this.lnkLblUrl.Links.Add(link);

            this.picImage.Image = currentAppointment.Image;
            this.lblPlace.Text = currentAppointment.Place;
            this.lblFooter.Text = currentAppointment.Footer;
            this.lblAppointmentCount.Text = "Termin " + (currentAppointmentIndex + 1).ToString() + " von " + appointmentDirectories.Count.ToString();
            this.lblRememberedCount.Text = "Gemerkt: " + Directory.EnumerateDirectories("chooser/interesting").Count().ToString();
        }

        List<string> appointmentDirectories = new List<string>();

        private void loadAvailableAppointmentNumbers()
        {
            IEnumerable<string> appointmentDirectoryPaths = Directory.EnumerateDirectories("content/appointmentDetails/");

            foreach (string appointmentDirectoryPath in appointmentDirectoryPaths)
            {
                appointmentDirectories.Add(Path.GetFileName(appointmentDirectoryPath));
            }

            appointmentDirectories.Sort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("chooser/interesting");

            if (!File.Exists("initialized"))
            {
                downloadAppointmentDetails();

                File.Create("initialized");
            }

            loadSavedAppointmentIndex();
            loadAvailableAppointmentNumbers();
            displayCurrentAppointment();
        }

        private void lnkLblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("chooser/current-index.txt", currentAppointmentIndex.ToString());
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            bool proceed = false;

            if (e.KeyCode == Keys.Space)
            {
                Directory.CreateDirectory("chooser/interesting/" + getCurrentAppointmentNumber().ToString());

                IEnumerable<string> appointmentFiles = Directory.EnumerateFiles("content/appointmentDetails/" + getCurrentAppointmentNumber().ToString());

                foreach (string appointmentFileName in appointmentFiles)
                {
                    File.Copy(appointmentFileName, "chooser/interesting/" + getCurrentAppointmentNumber().ToString() + "/" + Path.GetFileName(appointmentFileName), true);
                }

                proceed = true;
            }
            else if (e.KeyCode == Keys.ControlKey)
            {
                proceed = true;
            }

            if (proceed)
            {
                if (currentAppointmentIndex < appointmentDirectories.Count - 1)
                {
                    ++currentAppointmentIndex;
                    displayCurrentAppointment();
                }
                else
                {
                    MessageBox.Show(this, "Keine weiteren Termine!", "Fertig", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
