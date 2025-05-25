using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics; // debuging cuz i am stupid

namespace tests
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        float time = 0; // Simulation time

        float velocity;
        float angle;
        float gravity;
        // Physics variables

        float vx, vy; // Velocity components
        Point startPosition; // Initial position (x, y)
        int floorY;    // Ground level

        int leftBorder;
        int rightBorder;

        public Form1()
        {
            InitializeComponent();

            velocity = 0f;
            angle = 45f;
            gravity = 9.8f; // Initial physics values

            InitProjectile();

            floorY = this.ClientSize.Height - projectileBox.Height;
            leftBorder = 0;
            rightBorder = this.ClientSize.Width - projectileBox.Width;

            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }

        void InitProjectile()
        {
            time = 0;
            startPosition = projectileBox.Location;

            float rad = angle * (float)Math.PI / 180f; // convert to radians cus cos and sin takes rads
            vx = velocity * (float)Math.Cos(rad);
            vy = velocity * (float)Math.Sin(rad);
            // Simple high school physics: separates the launch velocity into horizontal (vx) and vertical (vy) components based on the launch angle.
        }

        (float x, float y) GetProjectilePosition(float t)
        {
            float x = vx * t;
            float y = vy * t - 0.5f * gravity * t * t;
            return (x, y); // Calculate position based on physics
        }

        //private float energyLoss = 0.7f failed attempt at bouncing;

        private void Timer_Tick(object sender, EventArgs e)
        {
            time += 0.1f;

            var pos = GetProjectilePosition(time);
            int newX = (int)(startPosition.X + pos.x);
            int newY = (int)(startPosition.Y - pos.y);

            // Collision detection with the floor
            if (newY >= floorY)
            {
                newY = floorY; // Set the projectile's Y position to the floor
                vy = 0;       // Stop the vertical velocity
                timer.Stop(); // Optionally stop the entire simulation when it hits the floor
            }
            //Debug.WriteLine(floorY.ToString() + " floor Y");
            //Debug.WriteLine(newY);
            //Debug.WriteLine(vy);
            // aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa cant make bouncing 

            projectileBox.Location = new Point(newX, newY);
        } // Updates projectile position over time

        private void start_Click(object sender, EventArgs e)
        {
            RestartSimulation();
        }

        private void RestartSimulation()
        {
            velocity = (float)velocityInput.Value;
            angle = (float)angleInput.Value;
            gravity = (float)gravityInput.Value;
            float height = (float)heightInput.Value; // Get input values

            startPosition = new Point(startPosition.X, this.ClientSize.Height - (int)height - projectileBox.Height);

            InitProjectile();
            timer.Start();
        }

        private void heightInput_ValueChanged(object sender, EventArgs e)
        {
            int currentX = projectileBox.Location.X;
            int newY = this.ClientSize.Height - (int)heightInput.Value - projectileBox.Height;

            projectileBox.Location = new Point(currentX, newY);
        }
    }
}