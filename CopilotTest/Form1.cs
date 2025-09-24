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
            // Try to parse the textbox input as an integer
            if (int.TryParse(textBoxMessage.Text, out int statusCode))
            {
                int b = 3;
                string message;
                if (statusCode == 200)
                {
                    message = "OK";
                }
                else if (statusCode == 400)
                {
                    message = "Bad Request";
                }
                else if (statusCode == 404)
                {
                    message = "Not Found";
                }
                else if (statusCode == 500)
                {
                    message = "Internal Server Error";
                }
                else
                {
                    message = "Unknown Status";
                }
                textBoxMessage.Text = message;
            }
            else
            {
                textBoxMessage.Text = "Please enter a valid status code! (e.g., 200, 400, 404, 500).";
            }
        }
    }
}
