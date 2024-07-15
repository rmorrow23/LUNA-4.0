using Moonbase.Properties; // Namespace for accessing project resources
using System;
using System.IO; // Namespace for file input/output operations
using System.Windows.Forms; // Namespace for Windows Forms components

namespace Moonbase
{
    public partial class FormMain : Form
    {
        // Global variables for room names, descriptions, background images, current position, and locations
        public string[] RmNm = new string[5];
        public string[] RmDsc = new string[5];
        public string[] RmBack = new string[5];
        public string currentPosition;
        public string[] location = new string[5];

        // Class to represent an Area in the moonbase
        class Area
        {
            private string[] roomName = new string[5]; // Array to hold room names
            private string[] roomDescription = new string[5]; // Array to hold room descriptions

            // Constructor to initialize the roomName and roomDescription arrays
            public Area(string[] RmNm, string[] RmDsc)
            {
                for (int i = 0; i < roomName.Length; i++)
                {
                    roomName[i] = RmNm[i];
                    roomDescription[i] = RmDsc[i];
                }
            }

            // Method to get the name of a room
            public string getRoom(int i)
            {
                return roomName[i];
            }

            // Method to get the description of a room
            public string getDesc(int i)
            {
                return roomDescription[i];
            }
        }

        // Constructor for the FormMain class
        public FormMain()
        {
            InitializeComponent(); // Initialize the form components
        }

        // Event handler for form load event
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize array with the different locations
            location[0] = "Command Center";
            location[1] = "Laboratory";
            location[2] = "Living Quarters";
            location[3] = "Medical Bay";
            location[4] = "Lobby";

            // Initialize array with Room Names
            RmNm[0] = "Lunar Operations Command Center";
            RmNm[1] = "Lunar Laboratory";
            RmNm[2] = "Lunar Living Quarters";
            RmNm[3] = "Lunar Medical Bay";
            RmNm[4] = "Lunar Lobby";

            // Initialize array with room descriptions
            RmDsc[0] = "The Lunar Operations Command Center is the heart of the moonbase, featuring walls of sleek metallic panels embedded with soft, ambient LED lights that create a futuristic glow. Large, reinforced windows offer a breathtaking view of the lunar landscape and Earth. High-tech consoles with holographic displays dominate the room, providing real-time data and interactive controls for managing base operations.";
            RmDsc[1] = "The Lunar Laboratory is a hub of scientific discovery, featuring sleek metallic walls illuminated by ambient LED lights. Large windows offer a view of the lunar surface, enhancing the high-tech atmosphere. Equipped with advanced scientific instruments and robotic assistants, the lab enables groundbreaking experiments and efficient research.";
            RmDsc[2] = "The Lunar Living Quarters offer a cozy refuge with sleek metallic walls and warm LED lighting. Large windows provide a stunning lunar landscape view. Modern furniture, including a comfortable bed, seating area, and holographic work desk, ensure comfort and functionality, while personal items add a homely touch.";
            RmDsc[3] = "The Lunar Medbay is a state-of-the-art medical facility with sleek metallic walls and soft LED lighting. Large windows provide a calming view of the lunar surface. Equipped with advanced medical technology and robotic assistants, the medbay ensures top-notch care and efficient patient management.";
            RmDsc[4] = "The Lunar Lobby is the central hub of the moonbase, featuring high ceilings, sleek metallic walls, and large panoramic windows offering stunning lunar views. Modern seating areas and a state-of-the-art reception desk with holographic displays provide comfort and efficient communication. Astronauts in advanced space suits and robotic assistants seamlessly move through the lobby, reflecting the integration of human and robotic efforts in moonbase operations.";

            // Simulate a click on the Lobby button to set the initial room
            LobbyBTN_Click(this, EventArgs.Empty);
        }

        // Method to update the user's current position
        private void UpdateUserPosition(string newPosition)
        {
            currentPosition = newPosition; // Update the current position
            LogUserPosition(); // Log the new position
            disableNav(currentPosition); // Disable navigation based on the new position
        }

        // Method to log the user's current position
        private void LogUserPosition()
        {
            string logFilePath = "user_location_log.txt"; // Log file path
            string logMessage = $"{DateTime.Now}: User moved to {currentPosition}"; // Log message

            try
            {
                // Save the new location to the specified log file
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // Show error message if logging fails
                MessageBox.Show($"Error logging user position: {ex.Message}");
            }
        }

        // Method to disable navigation buttons based on the current location
        public void disableNav(string currentlocation)
        {
            if (currentlocation == location[4])
            {
                // Re-enable all buttons except the main lobby
                commandCenterBTN.Enabled = true;
                labBTN.Enabled = true;
                livingQtBTN.Enabled = true;
                medBayBTN.Enabled = true;
                LobbyBTN.Enabled = false;
            }
            else
            {
                // Set all buttons to disabled except the main lobby
                commandCenterBTN.Enabled = false;
                labBTN.Enabled = false;
                livingQtBTN.Enabled = false;
                medBayBTN.Enabled = false;
                LobbyBTN.Enabled = true;
            }
        }

        // Event handler for room name textbox text changed
        private void TBRoomName_TextChanged(object sender, EventArgs e)
        {
            // Handle any changes to the room name textbox if necessary
        }

        // Event handler for label click
        private void label2_Click(object sender, EventArgs e)
        {
            // Handle any actions related to label2 if necessary
        }

        // Event handler for Command Center button click
        private void commandCenterBTN_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(0); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(0); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.command_center; // Set the background image
            UpdateUserPosition("Command Center"); // Update the user's position
        }

        // Event handler for Laboratory button click
        private void labBTN_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(1); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(1); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.lab; // Set the background image
            UpdateUserPosition("Laboratory"); // Update the user's position
        }

        // Event handler for Medical Bay button click
        private void medBayBTN_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(3); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(3); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.medbay; // Set the background image
            UpdateUserPosition("Medical Bay"); // Update the user's position
        }

        // Event handler for Living Quarters button click
        private void livingQtBTN_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(2); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(2); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.living; // Set the background image
            UpdateUserPosition("Living Quarters"); // Update the user's position
        }

        // Event handler for Lobby button click
        private void LobbyBTN_Click(object sender, EventArgs e)
        {
            Area Moonbase = new Area(RmNm, RmDsc); // Create an Area object
            string roomName = Moonbase.getRoom(4); // Get the room name
            TBRoomName.Text = roomName; // Set the room name textbox text
            string roomDesc = Moonbase.getDesc(4); // Get the room description
            TXBXRoomDesc.Text = roomDesc; // Set the room description textbox text
            this.BackgroundImage = Properties.Resources.lobby; // Set the background image
            UpdateUserPosition("Lobby"); // Update the user's position
        }
    }
}
