using System;
using System.Windows.Forms;

public partial class MainForm : Form
{
    public MainForm()
    {
       // InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // Create a label and textbox objects
        Label myLabel = new Label();
        myLabel.Text = "Enter your name:";
        myLabel.Location = new System.Drawing.Point(20, 20);
        TextBox myTextBox = new TextBox();
        myTextBox.Location = new System.Drawing.Point(20, 50);
        // Add label and textbox to the form
        Controls.Add(myLabel);
        Controls.Add(myTextBox);
        // Call a function that uses the label and textbox as parameters
        ProcessInput(myLabel, myTextBox);
    }

    private void ProcessInput(Label label, TextBox textBox)
    {
        // Access and manipulate the label and textbox objects
        string name = textBox.Text;
        label.Text = "Hello, " + name + "!";
    }
}