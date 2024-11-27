using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eilidh_assign3
{
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        public string NameText
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public string MainStyleText
        {
            get => lblMainStyle.Text;
            set => lblMainStyle.Text = value;
        }

        public string DOBText
        {
            get => lblDOB.Text;
            set => lblDOB.Text = value;
        }

        public string DODText
        {
            get => lblDOD.Text;
            set => lblDOD.Text = value;
        }

        public string YearsActiveText
        {
            get => lblYearsActive.Text;
            set => lblYearsActive.Text = value;
        }

        public Image ProfileImage
        {
            get => pictureBox.Image;
            set => pictureBox.Image = value;
        }

        public void UpdateBackground(string mainStyle)
        {
            switch (mainStyle)
            {
                case "Ballet":
                    this.BackColor = Color.MediumOrchid;
                    break;
                case "Jazz":
                    this.BackColor = Color.IndianRed;
                    break;
                case "Tap":
                    this.BackColor = Color.MediumTurquoise;
                    break;
                case "Hip-Hop":
                    this.BackColor = Color.MediumSeaGreen;
                    break;
                case "Modern":
                    this.BackColor = Color.MediumPurple;
                    break;
                case "Swing":
                case "Breakdancing":
                    this.BackColor = Color.MediumVioletRed;
                    break;
                default:
                    this.BackColor = Color.White;
                    break;
            }
        }
    }
}
