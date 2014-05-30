using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HuntTheWumpus
{
    
    public partial class CaveGen : Form
    {
        Button[] buttons;
        Cave userCave = new Cave();
        CheckBox[] fillBoxes = new CheckBox[] { };
        int counter = 0;
        public CaveGen()
        {
            InitializeComponent();
            buttons = this.Controls.OfType<Button>().ToArray();
            fillBoxes = new CheckBox[] {
                fill1, fill1, fill2, fill3, fill4, fill5,
                fill6, fill7, fill8, fill9, fill10, 
                fill11, fill12, fill13, fill14, fill15, 
                fill16, fill17, fill18, fill19, fill20, 
                fill21, fill22, fill23, fill24, fill25, 
                fill26, fill27, fill28, fill29, fill30
                };
           
            
        }
        
        Button getCorrespondingButton(int caveOne, int caveTwo)
        {
            for (int index = 0; index < buttons.Count(); index++)
            {
                if (buttons[index].Name == "Gate_" + caveOne.ToString() + "_" + caveTwo.ToString())
                {
                    return buttons[index];
                }
            }
            //something went wrong!!
            return clearBox;
        }
        private void updateButtons()
        {
            for (int index = 1; index < 31; index++)
            {
                int[] connections = userCave.getNeighborCaves(index);
                for (int subindex = 0; subindex < 6; subindex++)
                {
                    if (index < connections[subindex])
                    {
                        getCorrespondingButton(index, connections[subindex]).BackColor = boolToColor(userCave.caveConnections[index, subindex]);
                    }
                    else
                    {
                        getCorrespondingButton(connections[subindex], index).BackColor = boolToColor(userCave.caveConnections[index, subindex]);
                    }
                }
            }
        }
        Color boolToColor(bool isOpen)
        {
            if (isOpen)
            {
                return Color.Lime;
            }
            else
            {
                return Color.Red;
            }
        }
        Color invert(Color redOrLime)
        {
            if (redOrLime == Color.Red)
            {
                return Color.Lime;
            }
            else
            {
                return Color.Red;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            
        }



        private void DoorClick(object sender, EventArgs e)
        {
            Button buttonClicked = sender as Button;
            string[] data = buttonClicked.Name.Split('_');
            buttonClicked.BackColor = invert(buttonClicked.BackColor);
            try
            {
                userCave.caveConnections[int.Parse(data[1]), userCave.getDirectionOfNeighbor(int.Parse(data[1]),int.Parse(data[2]))] 
                    = (buttonClicked.BackColor == Color.Lime);
                userCave.caveConnections[int.Parse(data[2]), userCave.getDirectionOfNeighbor(int.Parse(data[2]), int.Parse(data[1]))]
                    = (buttonClicked.BackColor == Color.Lime);
            }
            catch
            {
                MessageBox.Show("Internal error.");
            }            

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            bool writeError = userCave.writeCave();
            if (writeError)
            {
                MessageBox.Show("Error exporting");
            }
            else
            {
                MessageBox.Show("Export successful!");
            }
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            if (userCave.validateCave() == 0)
            {
                MessageBox.Show("Success! This is a valid configuration!");
            }
            else
            {
                MessageBox.Show(userCave.validateCave().ToString() + " is invalid (either not connected, or too many doors)");
            }
            for (int index = 0; index < 31; index++)
            {
                fillBoxes[index].Checked = userCave.getFilled[index];
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Hunt the Wumpus Cave (*.CAV)|*.CAV|All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            DialogResult userClickedOK = openFileDialog1.ShowDialog();
            List<string> caveInfo = new List<string>();
            try
            {
                if (userClickedOK == DialogResult.OK)
                {
                    System.IO.Stream fileStream = openFileDialog1.OpenFile();
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                    {
                        for (int index = 0; index < 31; index++)
                        {
                            caveInfo.Add(reader.ReadLine());
                        }
                    }
                    fileStream.Close();
                }
                if (userCave.loadCave(caveInfo))
                {
                    updateButtons();
                }
                else
                {
                    MessageBox.Show("Map data is corrupted or contradictory");
                }
                
            }
            catch
            {
                MessageBox.Show("Error reading file.");
            }
        }

        private void clearBox_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < 31; index++)
            {
                fillBoxes[index].Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (userCave.generateNewCave())
            {
                updateButtons();
            }
            else
            {
                MessageBox.Show("Cave failed to generate in this instance. Press the button to retry.");
            }*/
            timer1.Enabled = true;
            counter = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userCave.reset();
            updateButtons();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (userCave.generateNewCave())
            {
                updateButtons();
                counter++;
            }
            else
            {
                //MessageBox.Show("Cave failed to generate in this instance. Press the button to retry.");
            }
            if (counter == 20)
            {
                timer1.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*GameControl.NewGame();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*GameControl.HideForm("cavegen");
            GameControl.ShowForm("start");*/
        }

        private void CaveGen_FormClosing(object sender, FormClosingEventArgs e)
        {


            e.Cancel = true;
            /*GameControl.HideForm("cavegen");
            GameControl.reset();
            GameControl.ShowForm("start");*/


        }


    }
}
