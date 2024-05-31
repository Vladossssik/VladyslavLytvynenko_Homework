using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace WinFormArenaGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void gameNotification(GameEngine.NotificationArgs args)
        {
            TextBox tbAttacker = args.Attacker switch
            {
                Knight => tbKnight,
                Assassin => tbAssassin,
                Tank => tbTank,
                Archer => tbArcher,
                _ => throw new ArgumentException("Unknown hero")
            };

            tbAttacker.AppendText(
                $"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.\r\n");

            DateTime dt = DateTime.Now;

            while (DateTime.Now - dt < TimeSpan.FromMilliseconds(300))
            {
                Application.DoEvents();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            lbWinner.Text = "";
            tbAssassin.Text = "";
            tbKnight.Text = "";
            lbWinner.Visible = false;

            GameEngine gameEngine = new GameEngine()
            {
                HeroA = new Knight("Knight", 10, 20, new Sword("Sword")),
                HeroB = new Assassin("Assassin", 10, 5, new Dagger("Dagger")),
                NotificationsCallBack = gameNotification
            };

            imgFight.Enabled = true;
            gameEngine.Fight();
            imgFight.Enabled = false;

            lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
            lbWinner.Visible = true;
        }

        private void lbWinner_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tbKnight_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAssassin_TextChanged(object sender, EventArgs e)
        {

        }

        private void imgFight_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbTank_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbArcher_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewGame2_Click(object sender, EventArgs e)
        {
            lbWinner.Text = "";
            tbAssassin.Text = "";
            tbKnight.Text = "";
            lbWinner.Visible = false;

            GameEngine gameEngine = new GameEngine()
            {
                HeroA = new Tank("Tank", 10, 20, new Morgenstern("Sword")),
                HeroB = new Archer("Archer", 10, 5, new Crossbow("Crossbow")),
                NotificationsCallBack = gameNotification
            };

            imgFight.Enabled = true;
            gameEngine.Fight();
            imgFight.Enabled = false;

            lbWinner.Text = $"And the winner is:\n{gameEngine.Winner}";
            lbWinner.Visible = true;
        }
    }
}