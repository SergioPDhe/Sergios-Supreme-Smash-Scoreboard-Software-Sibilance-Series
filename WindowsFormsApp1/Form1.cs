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

namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // All Stock Icon images are in an ImageList called 'StockIcons', and are named by a 3 letter character code and a 3 letter colour code
        // For example BOWBLK for black Bowser, MRTDEF for default Marth, YOSCYN for cyan Yoshi etc...
        string MainDirectory = null;
        string[] CharacterIDkey = { "000", "FOX", "FAL", "MRT", "SHK", "PUF", "PEA", "ICS", "CPT", "PIK", "SAM", "DOC", "YOS", // Character codes in tier list order
            "LUI", "GAN", "MAR", "YLK", "DKG", "LNK", "GNW", "ROY", "MEW", "ZLD", "NES", "PCH", "BOW", "KIR" }; // Also the order they appear on the dropdown
        string[] ColourIDkey = { "000", "DEF", "RED", "BLU", "GRN", "BLK", "WHT", "YLW", "PNK", "ORA", "PRP", "CYN" };// Colour codes
        string[] Colourkey = { "(none)", "Default", "Red", "Blue", "Green", "Black", "White", "Yellow", "Pink", "Orange", "Purple", "Cyan" };// Colour code names
        List<string> SavedTags = new List<string>(); // Used later for the player tag comboboxes to suggest previous tags



        private void Form1_Load(object sender, EventArgs e) // Form is loaded
        {
            P1Character.SelectedIndex = 0;
            P2Character.SelectedIndex = 0; // Index '0' corresponds to '(none)', resulting in a transparent image.

            if ((Properties.Settings.Default.SelectedDirectory == "") || (!Directory.Exists(Properties.Settings.Default.SelectedDirectory))) // Checks for (lack of) saved preferences
            {
                FolderBrowserDialog DirSelect = new FolderBrowserDialog();
                if (DirSelect.ShowDialog() == DialogResult.OK)
                {
                    MainDirectory = DirSelect.SelectedPath + "\\";
                    Properties.Settings.Default.SelectedDirectory = MainDirectory;
                    Properties.Settings.Default.Save();
                }
            }
            else // If a saved setting already exists
            {
                MainDirectory = Properties.Settings.Default.SelectedDirectory;
            }

            if (!File.Exists(MainDirectory + "Saved Tags.txt"))
            {
                StreamWriter sw = File.CreateText(MainDirectory + "Saved Tags.txt");
                sw.Close();
            }

            if (Directory.Exists(Properties.Settings.Default.SelectedDirectory))
            {
                SavedTags = File.ReadAllLines(MainDirectory + "Saved Tags.txt").ToList();
                SavedTags.Sort();

                P1Tag.DataSource = new List<string>(SavedTags);
                P2Tag.DataSource = new List<string>(SavedTags);
                Comm1.DataSource = new List<string>(SavedTags);
                Comm2.DataSource = new List<string>(SavedTags); // The code needs to use different entities of SavedTags so the ComboBoxes remain independendent
                P1Tag.SelectedIndex = -1;
                P2Tag.SelectedIndex = -1;
                Comm1.SelectedIndex = -1;
                Comm2.SelectedIndex = -1;
            }
        }

        private void SaveBoard(object sender, EventArgs e) // 'Save' Button is pressed
        {
            if ((Properties.Settings.Default.SelectedDirectory == "") || (!Directory.Exists(Properties.Settings.Default.SelectedDirectory))) // Checks for (lack of) saved preferences
            {
                FolderBrowserDialog DirSelect = new FolderBrowserDialog();
                if (DirSelect.ShowDialog() == DialogResult.OK)
                {
                    MainDirectory = DirSelect.SelectedPath + "\\";
                    Properties.Settings.Default.SelectedDirectory = MainDirectory;
                    Properties.Settings.Default.Save();
                }                
            }
            else // If a saved setting already exists
            {
                MainDirectory = Properties.Settings.Default.SelectedDirectory;
            }
            TextWriter P1Scoretxt = new StreamWriter(MainDirectory + "P1 Score.txt"); // Code below saves text into txt files for use in OBS or what have you
            P1Scoretxt.Write(P1Score.Text);
            P1Scoretxt.Close();

            TextWriter P2Scoretxt = new StreamWriter(MainDirectory + "P2 Score.txt");
            P2Scoretxt.Write(P2Score.Text);
            P2Scoretxt.Close();

            TextWriter P1Tagtxt = new StreamWriter(MainDirectory + "P1 Tag.txt");
            P1Tagtxt.Write(P1Tag.Text);
            P1Tagtxt.Close();
            if (!SavedTags.Contains(P1Tag.Text))
            {
                StreamWriter TagsTxt = File.AppendText(MainDirectory + "Saved Tags.txt"); // Also includes tags in a txt of saved tags, which is updated when the software loads
                TagsTxt.WriteLine(P1Tag.Text);
                TagsTxt.Close();
            }

            TextWriter P2Tagtxt = new StreamWriter(MainDirectory + "P2 Tag.txt");
            P2Tagtxt.Write(P2Tag.Text);
            P2Tagtxt.Close();
            if (!SavedTags.Contains(P2Tag.Text))
            {
                StreamWriter TagsTxt = File.AppendText(MainDirectory + "Saved Tags.txt");
                TagsTxt.WriteLine(P2Tag.Text);
                TagsTxt.Close();
            }

            TextWriter Comm1txt = new StreamWriter(MainDirectory + "Commentator 1.txt");
            Comm1txt.Write(Comm1.Text);
            Comm1txt.Close();
            if (!SavedTags.Contains(Comm1.Text))
            {
                StreamWriter TagsTxt = File.AppendText(MainDirectory + "Saved Tags.txt");
                TagsTxt.WriteLine(Comm1.Text);
                TagsTxt.Close();
            }

            TextWriter Comm2txt = new StreamWriter(MainDirectory + "Commentator 2.txt");
            Comm2txt.Write(Comm2.Text);
            Comm2txt.Close();
            if (!SavedTags.Contains(Comm2.Text))
            {
                StreamWriter TagsTxt = File.AppendText(MainDirectory + "Saved Tags.txt");
                TagsTxt.WriteLine(Comm2.Text);
                TagsTxt.Close();
            }

            TextWriter MatchNametxt = new StreamWriter(MainDirectory + "Match Round.txt");
            MatchNametxt.Write(MatchName.Text);
            MatchNametxt.Close();

            TextWriter EventNametxt = new StreamWriter(MainDirectory + "Event Name.txt");
            EventNametxt.Write(EventName.Text);
            EventNametxt.Close();

            P1Icon.Image.Save(MainDirectory + "P1 Character Icon.png");
            P2Icon.Image.Save(MainDirectory + "P2 Character Icon.png");
        }

        private void SelectDirectory_Click(object sender, EventArgs e) // Button to change save directory is pressed
        {
            FolderBrowserDialog DirSelect = new FolderBrowserDialog();
            if (DirSelect.ShowDialog() == DialogResult.OK)
            {
                MainDirectory = DirSelect.SelectedPath + "\\";
                Properties.Settings.Default.SelectedDirectory = MainDirectory;
                Properties.Settings.Default.Save();
            }
        }
        
        private void P1CharacterChange(object sender, EventArgs e) // Character select dropdown list is changed
        {
            string CharacterID = CharacterIDkey[P1Character.SelectedIndex]; // Converts Character name from dropdown to 3 letter code 'CharacterID' i.e.: Sheik -> SHK
            
            P1Colour.Items.Clear();
            foreach (string IconKey in StockIcons.Images.Keys) // Takes in every image file in StockIcons and stores it in 'IconKey' for each loop
            {                                                   //IconKey takes the form of a CharacterID, a 3 letter colour code and '.png'
                if (IconKey.Substring(0,3) == CharacterID) // Compares IconKey to CharacterID
                {
                    int ColourID = Array.IndexOf(ColourIDkey, IconKey.Substring(3, 3));
                    P1Colour.Items.Add(Colourkey[ColourID]);
                }
            }
            P1Colour.SelectedIndex = 0;
        }

        private void P2CharacterChange(object sender, EventArgs e)
        {
            string CharacterID = CharacterIDkey[P2Character.SelectedIndex]; // Converts Character name from dropdown to 3 letter code 'CharacterID' i.e.: Sheik -> SHK

            P2Colour.Items.Clear();
            foreach (string IconKey in StockIcons.Images.Keys) // Takes in every image file name in StockIcons and stores it in 'IconKey' for each loop
            {                                                   //IconKey takes the form of a CharacterID, a 3 letter colour code and '.png'
                if (IconKey.Substring(0, 3) == CharacterID) // Checks if CharacterID and the first 3 letters of IconKey match (eg: 'BOW' and 'BOWBLK.png' match)
                {
                    int ColourID = Array.IndexOf(ColourIDkey, IconKey.Substring(3, 3)); // Uses array 'ColourID' to find the index of the 3 letter colour code
                    P2Colour.Items.Add(Colourkey[ColourID]); // USes the index to find the full name of the colour and adds it to the drop down list
                }
            }
            P2Colour.SelectedIndex = 0; // Default selected colour is the default colour for each character (eg: green Luigi, red Mario. white Fox, etc...)

        }

        private void P1ColourChange(object sender, EventArgs e) // Colour select drop down list is changed
        {
            if (P1Colour.SelectedIndex >= 0) // Checks if a colour is selected
            {
                string Colour = ColourIDkey[Array.IndexOf(Colourkey, P1Colour.SelectedItem)]; // Finds 3-letter colour code for selected colour
                string IconImage = CharacterIDkey[P1Character.SelectedIndex] + Colour + ".png"; // Uses Selected character and colour to build the image file name
                P1Icon.Image = StockIcons.Images[StockIcons.Images.IndexOfKey(IconImage)]; // Selects image from StockIcons imagelist
            }
            
        }

        private void P2ColourChange(object sender, EventArgs e)
        {
            if (P2Colour.SelectedIndex >= 0)
            {
                string Colour = ColourIDkey[Array.IndexOf(Colourkey, P2Colour.SelectedItem)];
                string IconImage = CharacterIDkey[P2Character.SelectedIndex] + Colour + ".png";
                P2Icon.Image = StockIcons.Images[StockIcons.Images.IndexOfKey(IconImage)];
            }
        }

        private void SwapPlayers(object sender, EventArgs e) // 'Swap Players' Button is pressed
        {
            string SaveP1Tag = P1Tag.Text;
            decimal SaveP1Score = P1Score.Value;
            int SaveP1Character = P1Character.SelectedIndex;
            int SaveP1Colour = P1Colour.SelectedIndex;
            P1Tag.Text = P2Tag.Text;
            P1Score.Value = P2Score.Value;
            P1Character.SelectedIndex = P2Character.SelectedIndex;
            P1Colour.SelectedIndex = P2Colour.SelectedIndex;
            P2Tag.Text = SaveP1Tag;
            P2Score.Value = SaveP1Score;
            P2Character.SelectedIndex = SaveP1Character;
            P2Colour.SelectedIndex = SaveP1Colour;
        }

        private void MatchName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void P2Score_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
