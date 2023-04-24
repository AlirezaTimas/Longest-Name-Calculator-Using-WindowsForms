using System.Data;

namespace Longest_Name_Calculator_Using_WindowsForm
{
    public partial class Form1 : Form
    {
        int maxlength;
        string longestname;
        int studentnumber;
        int c = 2;
        int a;
        int finalstudentnum;
        string name;
        int u = 1;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentLabel.Text = "Enter the name of: Student Number " + u;
            StudentNumberLabel.Text = "Enter the student code of: Student Number " + u;
            NameListBox.Items.Add("Student Names are sorted below ");
            LengthListBox.Items.Add("Student Names Lengths are sorted below");
            StudentNumberListBox.Items.Add("Student Codes are sorted below");
        }

        public void EnterButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                StudentLabel.Text = "Enter the name of student number " + c;
                name = StudentNameTextBox.Text;
                NameListBox.Items.Add("Student Number " + c + ": " + name);
                a = name.Length;
                LengthListBox.Items.Add("Name length: " + a);
                StudentNumberLabel.Text = "Enter the student code of: Student Number " + c;
                studentnumber = int.Parse(StudentNumberTextBox.Text);
                StudentNumberListBox.Items.Add(studentnumber);
                if (a > maxlength)
                {
                    maxlength = a;
                    finalstudentnum = studentnumber;
                    longestname = name;

                }
                if (StudentNameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter a name");
                    NameListBox.Items.Clear();
                    LengthListBox.Items.Clear();
                    StudentNumberListBox.Items.Clear();
                    NameListBox.Items.Add("Student Names are sorted below ");
                    LengthListBox.Items.Add("Student Names Lengths are sorted below");
                    StudentNumberListBox.Items.Add("Student Codes are sorted below");
                    c = 1;
                    return;
                }
                StudentNameTextBox.Clear();
                StudentNumberTextBox.Clear();
                c++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                NameListBox.Items.Clear();
                LengthListBox.Items.Clear();
                StudentNumberListBox.Items.Clear();
                NameListBox.Items.Add("Student Names are sorted below ");
                LengthListBox.Items.Add("Student Names Lengths are sorted below");
                StudentNumberListBox.Items.Add("Student Codes are sorted below");
            }

        }

        private void LengthListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (c == 1)
            {
                MessageBox.Show("You have to enter at least 1 name before checking largest one");
            }
            else
            {
                MessageBox.Show("Longest Name belongs to " + longestname + " with " + maxlength + " letters, StudentCode: " + finalstudentnum, "Result!");

            }
        }
        private void StudentNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}