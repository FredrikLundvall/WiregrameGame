using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BlowtorchesAndGunpowder
{
    public partial class WireframeLobby : Form
    {
        private Settings _settings = new Settings("localhost", 4567);
        private LoginSession _currentLoginSession = null;
        private bool _refreshLobby = false;
        public WireframeLobby()
        {
            InitializeComponent();
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            //refreshTim.Enabled = false;
            _refreshLobby = false;

            WireframeGame theGame = new WireframeGame();
            this.ShowInTaskbar = false;
            theGame.ShowInTaskbar = true;
            theGame.ShowDialog();
            theGame.ShowInTaskbar = false;
            this.ShowInTaskbar = true;

            _refreshLobby = true;
            //refreshTim.Enabled = true;
        }
        private void quitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void WireframeLobby_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();                        
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            DialogResult loginResult = loginForm.ShowDialog(this);
            if (loginResult == DialogResult.OK)
            {
                LobbyClient client = new LobbyClient(_settings);
                LoginInfo loginInfo = loginForm.getLoginInfo();
                login(loginInfo.Username, loginInfo.Password);
            }
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(_settings);
            DialogResult settingsResult = settingsForm.ShowDialog(this);
            if (settingsResult == DialogResult.OK)
            {
                _settings = settingsForm.GetSettings();
            }
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (_currentLoginSession == null)
                return;
            LobbyClient client = new LobbyClient(_settings);
            client.RemoveSession(_currentLoginSession);
            _currentLoginSession = null;
            refreshLists();
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refreshLists();
        }
        private void login(string aUsername, string aPassword)
        {
            LobbyClient client = new LobbyClient(_settings);
            _currentLoginSession = client.CreateSession(aUsername, aPassword);
            if (_currentLoginSession == null)
                MessageBox.Show(this, "Inloggning misslyckades, användarnamnet eller lösenordet är felaktigt!");
            refreshLists();
        }
        private async void refreshLists()
        {
            LobbyClient client = new LobbyClient(_settings);
            var loggedInUserList = await client.GetListLoggedInUserAsync();
            LoggedInUser selLoggedInUser = loggedInPlayersLb.SelectedItem as LoggedInUser;
            loggedInPlayersLb.Items.Clear();
            foreach (LoggedInUser loggedInUser in loggedInUserList)
            {
                loggedInPlayersLb.Items.Add(loggedInUser);
            }
            if (selLoggedInUser != null)
            {
                int index = loggedInPlayersLb.FindString(selLoggedInUser.ToString());
                loggedInPlayersLb.SetSelected(index, true);
            }
            var availableGameList = await client.GetListAvailableGameAsync();
            AvailableGame selAvailableGame = currentGamesLb.SelectedItem as AvailableGame;
            currentGamesLb.Items.Clear();
            foreach (AvailableGame availableGame in availableGameList)
            {
                currentGamesLb.Items.Add(availableGame);
            }
            if (selAvailableGame != null)
            {
                int index = currentGamesLb.FindString(selAvailableGame.ToString());
                currentGamesLb.SetSelected(index, true);
            }
            connectionFailedLbl.Visible = client.ConnectionFailing;
        }

        private void createLoginBtn_Click(object sender, EventArgs e)
        {
            CreateLoginForm createLoginForm = new CreateLoginForm();
            LoginAccount loginAccount = null;
            while (true)
            {
                DialogResult loginResult = createLoginForm.ShowDialog(this);
                if (loginResult == DialogResult.OK)
                {
                    LobbyClient client = new LobbyClient(_settings);
                    loginAccount = createLoginForm.getLoginAccount();
                    if (!client.CreateLogin(loginAccount))
                        MessageBox.Show(this, "Skapande av inloggning misslyckades, användarnamnet finns redan!");
                    else
                    {
                        login(loginAccount.Username, loginAccount.Password);
                        break;
                    }
                }
                else
                    break;
            }
        }
        private void editLoginBtn_Click(object sender, EventArgs e)
        {
            if (_currentLoginSession == null)
            {
                MessageBox.Show(this, "Du måste först logga in!");
            }
            CreateLoginForm createLoginForm = new CreateLoginForm(_currentLoginSession);
            while (true)
            {
                DialogResult loginResult = createLoginForm.ShowDialog(this);
                if (loginResult == DialogResult.OK)
                {
                    LobbyClient client = new LobbyClient(_settings);
                    if (!client.UpdateLogin(createLoginForm.getLoginAccount(), _currentLoginSession.Password, _currentLoginSession.Playername))
                        MessageBox.Show(this, "Uppdatering av inloggning misslyckades, gamla värdet stämmer inte!");
                }
                else
                    break;
            }
        }
        private void createGameBtn_Click(object sender, EventArgs e)
        {
            if(_currentLoginSession == null)
            {
                MessageBox.Show(this, "Du måste först logga in!");
                return;
            }
            CreateGameForm createGameForm = new CreateGameForm(_currentLoginSession.Playername);
            DialogResult settingsResult = createGameForm.ShowDialog(this);
            if (settingsResult == DialogResult.OK)
            {
                LobbyClient client = new LobbyClient(_settings);
                var gameInfo = createGameForm.getGameInfo();
                if (!client.CreateGame(_currentLoginSession.SessionToken, gameInfo))
                    MessageBox.Show(this, "Skapande av spel misslyckades!");
                else
                    refreshLists();
            }
        }
        private void refreshTim_Tick(object sender, EventArgs e)
        {
            if(_refreshLobby)
                refreshLists();
        }

        private void joinGameBtn_Click(object sender, EventArgs e)
        {
            if (_currentLoginSession == null)
            {
                MessageBox.Show(this, "Du måste först logga in!");
                return;
            }
            AvailableGame selGame = currentGamesLb.SelectedItem as AvailableGame;
            if (selGame == null)
            {
                MessageBox.Show(this, "Du måste välja ett spel att gå med i!");
                return;
            }
            string pinCode = "";
            if ((selGame).UsePincode)
            {
                EnterPincodeForm enterPincode = new EnterPincodeForm();
                DialogResult settingsResult = enterPincode.ShowDialog(this);
                if (settingsResult != DialogResult.OK)
                    return;
                pinCode = enterPincode.getPincode();
            }
            LobbyClient client = new LobbyClient(_settings);
            if (!client.JoinGame(selGame.Gamename, pinCode, _currentLoginSession.SessionToken))
                MessageBox.Show(this, "Det gick inte att gå med i spelet!");
            else
                refreshLists();
        }
    }
}
