namespace CopilotTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowMessage_Click(object sender, EventArgs e)
        {
            string test1 = "Hello, World!";
            // Try to parse the textbox input as an integer
            if (int.TryParse(textBoxMessage.Text, out int statusCode))
            {
                 string message = statusCode switch
                 {
                     200 => "OK",
                     400 => "Bad Request",
                     401 => "Unauthorized",
                     404 => "Not Found",
                     500 => "Internal Server Error",
                     _ => test1
                 };
                 textBoxMessage.Text = message;                           
            }
            else
            {
                textBoxMessage.Text = "Please enter a valid status code (e.g., 200, 400, 404, 500).";
            }
        }
    }
}
