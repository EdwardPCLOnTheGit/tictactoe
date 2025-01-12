using System.Text.Json;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }
        Player player;
        Random random = new Random();
        int VittoriePlayer = 0;
        int VittorieCPU = 0;
        List<Button> buttons;
        int turni = 0;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }
        private void CPUmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                player = Player.O;
                buttons[index].Text = player.ToString();
                buttons[index].BackColor = Color.Chartreuse;
                buttons.RemoveAt(index);
                CheckGame();
                CPUtimer.Stop();
            }
        }

        private void PlayerClick(object sender, EventArgs e)
        {
            while (CPUtimer.Enabled != true)
            {
                var button = (Button)sender;
                player = Player.X;
                button.Text = player.ToString();
                button.Enabled = false;
                button.BackColor = Color.Aqua;
                buttons.Remove(button);
                CheckGame();
                Turno.Text = "Turno: " + turni;
                CPUtimer.Start();
            }
        }

        private void RestartGame(object sender, EventArgs e)
        {
      
            RestartGame();
        }
        private void CheckGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                PlayerWins();
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                PlayerWins();
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
                PlayerWins();
            if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
                PlayerWins();
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                PlayerWins();
            if (button3.Text == "X" && button4.Text == "X" && button7.Text == "X")
                PlayerWins();
            if (button1.Text == "X" && button6.Text == "X" && button9.Text == "X")
                PlayerWins();
            if (button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
                PlayerWins();
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                CPUWins();
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                CPUWins();
            else if (button7.Text == "O" && button9.Text == "O" && button8.Text == "O")
                CPUWins();
            else if (button1.Text == "O" && button5.Text == "O" && button7.Text == "O")
                CPUWins();
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                CPUWins();
            else if (button3.Text == "O" && button4.Text == "O" && button7.Text == "O")
                CPUWins();
            else if (button1.Text == "O" && button6.Text == "O" && button9.Text == "O")
                CPUWins();
            else if (button3.Text == "O" && button5.Text == "O" && button9.Text == "O")
                CPUWins();

        }
        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button button in buttons)
            {
                button.Enabled = true;
                button.Text = "?";
                button.BackColor = DefaultBackColor;
            }
            turni++;
        }
        private void PlayerWins()
        {
            CPUtimer.Stop();
            MessageBox.Show("Il giocatore ha vinto");
            VittoriePlayer++;
            label1.Text = "Vittorie Giocatore: " + VittoriePlayer;
            RestartGame();
        }
        private void CPUWins()
        {
            CPUtimer.Stop();
            MessageBox.Show("Il computer ha vinto");
            VittorieCPU++;
            label2.Text = "Vittorie CPU: " + VittorieCPU;
            RestartGame();
        }

        private void SalvaFile(object sender, EventArgs e)
        {
            string Json3 = JsonSerializer.Serialize(VittorieCPU);
            string Json2 = JsonSerializer.Serialize(VittoriePlayer);
            string Json1 = JsonSerializer.Serialize(turni);
            string pathfile = @"savedfile\file.json";
            File.WriteAllText(pathfile, "turni: " + Json1 + " vittorie giocatore: " + Json2 + " vittorie cpu: " + Json3);
        }
    }
}
