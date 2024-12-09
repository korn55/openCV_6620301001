using Emgu.CV;
using Emgu.CV.Structure;

namespace openCV_6620301001
{
    public partial class FormMain : Form
    {
        // Fields for video capture and frame processing
        private VideoCapture? _videoCapture = null;
        private Mat? _frame;
        private bool isCameraConnected = false;
        private bool isRecord = false;
        public FormMain()
        {
            InitializeComponent(); // Initializes the form components
        }

        // Processes a frame whenever an image is grabbed from the video stream
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_videoCapture != null && _videoCapture.Ptr != IntPtr.Zero)
            {
                bool canCapture = _videoCapture.Retrieve(_frame, 0); // Retrieves the current frame
                if (canCapture)
                {
                    imageBoxLive.Image = _frame; // Displays the frame in the image box
                }
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Placeholder for any initialization when the form loads
        }

        // Handles connect/disconnect button click
        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                camStatus.Text = "Waiting..."; // Updates status
                if (!isCameraConnected)
                {
                    // Connects to the camera
                    _videoCapture = new VideoCapture();
                    _videoCapture.ImageGrabbed += ProcessFrame; // Subscribes to the frame grab event
                    _frame = new Mat();

                    this.Connect.Text = "Disconnect";// Updates UI
                    camStatus.Text = "Connected";
                    camStatus.ForeColor = Color.Green;
                    this.Start.Enabled = true; // Enables the Start button
                    isCameraConnected = true; // Marks camera as connected

                }
                else
                {
                    // Disconnects the camera
                    if (_videoCapture != null)
                    {
                        _videoCapture.Pause();  // Pauses video capture
                        _videoCapture.Dispose(); // Releases resources

                        this.Connect.Text = "Connect"; // Updates UI
                        camStatus.Text = "Disconnect";
                        camStatus.ForeColor = Color.Red;
                        this.Start.Enabled = false; // Disables the Start button
                        isCameraConnected = false; // Marks camera as disconnected

                    }
                }
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message); // Handles potential exceptions
            }
        }
        // Handles start/stop recording button click
        private void Start_Click(object sender, EventArgs e)
        {
            if (_videoCapture != null)
            {
                recStatus.Text = "Waiting..."; // Updates status
                if (!isRecord)
                {
                    _videoCapture.Start();
                    recStatus.Text = "Recording"; // Updates UI
                    this.Connect.Enabled = false; // Disables Connect button
                    this.Start.Text = "Stop";
                    isRecord = true; // Marks recording as active
                }
                else
                {
                    // Stops recording
                    _videoCapture.Stop();
                    recStatus.Text = "Stop Record"; // Updates UI
                    this.Connect.Enabled = true; // Enables Connect button
                    this.Start.Text = "Start";
                    isRecord = false; // Marks recording as inactive
                }
            }
        }
        // Toggles horizontal flipping of the video stream
        private void FlipHor_Click(object sender, EventArgs e)
        {
            if (_videoCapture != null)
            {
                _videoCapture.FlipHorizontal = !_videoCapture.FlipHorizontal; // Toggles the flip state
            }
        }
        // Toggles vertical flipping of the video stream
        private void FlipVer_Click(object sender, EventArgs e)
        {
            if (_videoCapture != null)
            {
                _videoCapture.FlipVertical = !_videoCapture.FlipVertical; // Toggles the flip state
            }
        }
    }
}
