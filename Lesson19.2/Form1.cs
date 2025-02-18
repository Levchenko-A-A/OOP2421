using Lesson19._2.Properties;
using System.Windows.Forms;

namespace Lesson19._2
{
    public partial class Game : Form
    {
        private int count_eneys = 5;
        private Player player;
        private Random random;
        private List<Enemy> enemys;
        private List<PictureBox> pictureBoxs;
        public Game()
        {
            random = new Random();
            InitializeComponent();
            enemys = new List<Enemy>(count_eneys);
            pictureBoxs = new List<PictureBox>(count_eneys);
            player = new Player(Resources.Plain, 500, 700);
            UpdatePlayer();
            StartGame();
            timer1.Start();
        }
        private void StartGame()
        {
            for (int i = 0; i < enemys.Capacity; i++)
            {
                PictureBox pictureBox = new PictureBox();
                Enemy enemy = new Enemy(random.Next(0, this.Width-pictureBox.Width), -random.Next(600));
                pictureBox.Image = enemy.GetImage();
                pictureBox.Location = new Point(enemy.X, enemy.Y);
                pictureBox.Width = 39;
                pictureBox.Height = 55;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(pictureBox);
                enemys.Add(enemy);
                pictureBoxs.Add(pictureBox);
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        player.Up();
                        UpdatePlayer();
                    }
                    break;
                case Keys.Down:
                    {
                        player.Down();
                        UpdatePlayer();
                    }
                    break;
                case Keys.Left:
                    {
                        player.Left();
                        UpdatePlayer();
                    }
                    break;
                case Keys.Right:
                    {
                        player.Right();
                        UpdatePlayer();
                    }
                    break;
            }
        }
        private void UpdatePlayer()
        {
            pictureBoxPlayer.Location = new Point(player.X, player.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemys.Count; i++)
            {

                enemys[i].Down();
                pictureBoxs[i].Location = new Point(enemys[i].X, enemys[i].Y);
                if (enemys[i].Y > this.Height + pictureBoxs[i].Height)
                {
                    
                    enemys[i].X = random.Next(0, this.Width);
                    enemys[i].Y = -random.Next(600);
                    
                }
            }
        }
    }
}