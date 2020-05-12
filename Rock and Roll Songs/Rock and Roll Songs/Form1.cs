using System;
using System.Windows.Forms;
using System.IO;

namespace Rock_and_Roll_Songs
{
    public partial class RockAndRollFrm : Form
    {
        int songID = 1; //value will incremented later for song table's primary key

        public RockAndRollFrm()
        {
            InitializeComponent();
        }

        private void songsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.songsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.songsDataSet);
        }

        private void RockAndRollFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'songsDataSet.Songs' table. You can move, or remove it, as needed.
            this.songsTableAdapter.Fill(this.songsDataSet.Songs);
        }

        //closes application
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //loads data into the 'songsDataSet.Songs' table
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            this.songsTableAdapter.Fill(this.songsDataSet.Songs);
        }

        //searches for artist and displays rows based on the data entered in the textbox
        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.songsTableAdapter.FillByArtist(this.songsDataSet.Songs, searchTxtBox.Text);
        }

        //imports data from text file into songs table
        private void importBtn_Click(object sender, EventArgs e)
        {
            string line = "";
            try
            {
                StreamReader inputFile = File.OpenText("songs.txt");    //opens text file

                int songRank = 0; //int which will store the song rank
                string artist = ""; //will store name of artist
                string title = ""; //will store the title of the song
                int length = 0; //used in calculating length of the substring that will be tokenized for artist

                //keeps looping until it reaches the end of the file
                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    //I used string.substring to tokenize my values in the text file, I did not use string.split because the space delimeters in the text file were not compatible with how i needed to tokenize the strings
                    songRank = int.Parse(line.Substring(0,line.IndexOf(' ')));  //tokenize the songRank from each line in the text file

                    //string.substring(startPosition,endPosition) is not a built in method, only string,substring(startPosition,length) is,
                    //so I used string.substring(startPosition,length) and figured out the length that i wanted. This way it works as if the method were string.substring(startPosition,endPos) 
                    length = (line.IndexOf(',')-1)-(line.IndexOf(' '));
                    artist = line.Substring(line.IndexOf(' ')+1,length); //tokenize the artist from each line in the text file

                    title = line.Substring(line.IndexOf(',')+2); //tokenize the song title from each line in the text file

                    this.songsTableAdapter.InsertQuery(songID, songRank, artist, title); //inserts a new row into the table using songId, songRank, artist, and title 

                    songID++; 
                }

                this.songsTableAdapter.FillByArtist(this.songsDataSet.Songs, searchTxtBox.Text); //loads data into the 'songsDataSet.Songs' table

                inputFile.Close();

                importBtn.Enabled = false; //disables import button, user can only import the data once so that the table will not have redundant data
            }
            catch
            {
                MessageBox.Show("File could not be found.");
            }
        }
    }
}
