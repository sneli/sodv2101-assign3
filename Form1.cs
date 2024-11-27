using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace eilidh_assign3
{
    public partial class Form1 : Form
    {
        private BindingList<Dancers> dancers;
        private Image selectedImage; // store the selected image

        public Form1()
        {
            InitializeComponent();
            LoadData(listView1);
        }

        private void LoadData(ListView listView1)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Dancer", 290, HorizontalAlignment.Left);
            listView1.Columns.Add("Main Style", 150, HorizontalAlignment.Left);

            dancers = new BindingList<Dancers>(Data.GetDancers());

            RefreshListView();
        }

        private void RefreshListView()
        {
            listView1.Items.Clear();

            foreach (Dancers dancer in dancers)
            {
                var item = new ListViewItem(dancer.FullName);
                item.SubItems.Add(dancer.MainStyle);
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedName = listView1.SelectedItems[0].Text;

                var selectedDancer = dancers.FirstOrDefault(d => d.FullName == selectedName);

                if (selectedDancer != null)
                {
                    //updates the card to show the dancer data
                    card1.NameText = selectedDancer.FullName;
                    card1.MainStyleText = selectedDancer.MainStyle;
                    card1.DOBText = selectedDancer.DOB;
                    card1.DODText = selectedDancer.DOD;
                    card1.YearsActiveText = selectedDancer.YearsActive;
                    card1.ProfileImage = selectedDancer.PhotoPath;
                    card1.UpdateBackground(selectedDancer.MainStyle);

                    //updates the textboxes to show the dancer data
                    txtFullName.Text = selectedDancer.FullName;
                    txtMainStyle.Text = selectedDancer.MainStyle;
                    txtDOB.Text = selectedDancer.DOB;
                    txtDOD.Text = selectedDancer.DOD;
                    txtYearsActive.Text = selectedDancer.YearsActive;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                var newDancer = new Dancers
                {
                    FullName = txtFullName.Text,
                    MainStyle = txtMainStyle.Text,
                    DOB = txtDOB.Text,
                    DOD = txtDOD.Text,
                    YearsActive = txtYearsActive.Text,
                    PhotoPath = selectedImage
                };

                dancers.Add(newDancer);
                RefreshListView();
                ClearInputFields();
                card1.ProfileImage = null; // reset the image preview
                MessageBox.Show("Dancer added successfully!");
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e) //button to let users chose a new image
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                openFileDialog.Title = "Select a Profile Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImage = Image.FromFile(openFileDialog.FileName); // load the selected image
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedName = listView1.SelectedItems[0].Text;

                var selectedDancer = dancers.FirstOrDefault(d => d.FullName == selectedName);

                if (selectedDancer != null)
                {
                    // allows user to update only one item if they wish
                    if (!string.IsNullOrWhiteSpace(txtFullName.Text))
                    {
                        selectedDancer.FullName = txtFullName.Text;
                        card1.NameText = txtFullName.Text;
                    }
                    if (!string.IsNullOrWhiteSpace(txtMainStyle.Text))
                    {
                        selectedDancer.MainStyle = txtMainStyle.Text;
                        card1.MainStyleText = txtMainStyle.Text;
                        card1.UpdateBackground(txtMainStyle.Text);
                    }
                    if (!string.IsNullOrWhiteSpace(txtDOB.Text))
                    {
                        selectedDancer.DOB = txtDOB.Text;
                        card1.DOBText = txtDOB.Text;
                    }
                    if (!string.IsNullOrWhiteSpace(txtDOD.Text))
                    {
                        selectedDancer.DOD = txtDOD.Text;
                        card1.DODText = txtDOD.Text;
                    }
                    if (!string.IsNullOrWhiteSpace(txtYearsActive.Text))
                    {
                        selectedDancer.YearsActive = txtYearsActive.Text;
                        card1.YearsActiveText = txtYearsActive.Text;
                    }
                    //allows user to update a dancer without uploading a new image
                    if (selectedImage != null)
                    {
                        selectedDancer.PhotoPath = selectedImage;
                        card1.ProfileImage = selectedImage;
                    }
                    else
                    {
                        card1.ProfileImage = selectedDancer.PhotoPath;
                    }

                    RefreshListView();
                    ClearInputFields();
                    MessageBox.Show("Dancer updated successfully!");
                }
            }
            else
            {
                MessageBox.Show("Select a dancer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedName = listView1.SelectedItems[0].Text;

                var selectedDancer = dancers.FirstOrDefault(d => d.FullName == selectedName);

                if (selectedDancer != null)
                {
                    //clears all text boxes + images
                    dancers.Remove(selectedDancer);
                    RefreshListView();
                    ClearInputFields();
                    card1.ProfileImage = null;

                    //clears the card
                    card1.NameText = string.Empty;
                    card1.MainStyleText = string.Empty;
                    card1.DOBText = string.Empty;
                    card1.DODText = string.Empty;
                    card1.YearsActiveText = string.Empty;
                    card1.ProfileImage = null;
                    card1.BackColor = Color.White;
                    MessageBox.Show("Dancer deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Select a dancer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtMainStyle.Text) ||
                string.IsNullOrWhiteSpace(txtDOB.Text) ||
                string.IsNullOrWhiteSpace(txtDOD.Text) ||
                string.IsNullOrWhiteSpace(txtYearsActive.Text))
            {
                MessageBox.Show("All fields must be filled in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ClearInputFields()
        {
            txtFullName.Clear();
            txtMainStyle.Clear();
            txtDOB.Clear();
            txtDOD.Clear();
            txtYearsActive.Clear();
            selectedImage = null;
        }

        private void btnClearCard_Click(object sender, EventArgs e)
        {
            card1.NameText = string.Empty;
            card1.MainStyleText = string.Empty;
            card1.DOBText = string.Empty;
            card1.DODText = string.Empty;
            card1.YearsActiveText = string.Empty;
            card1.ProfileImage = null;
            card1.BackColor = Color.White;
        }
    }
}
