IPlayer[] players;
List<IPlayer> readyPlayers = new List<IPlayer>();
List<IPlayer> team1Players = new List<IPlayer>();
List<IPlayer> team2Players = new List<IPlayer>();
IObjectTimerTrigger timer;

public void onReady(TriggerArgs args) {
	players = Game.GetPlayers();
	IObject[] temp = Game.GetObjectsByName("TimerTrigger");
	timer = (IObjectTimerTrigger)temp[0];
	Random rand = new Random();
	int toBeChosen = rand.Next(players.Length);
	Vector2 pos = new Vector2(0, 200);
	players[toBeChosen].SetWorldPosition(pos);
}

public void onButtonL(TriggerArgs args) {
	IPlayer player = (IPlayer)args.Sender;
	for (int i = 0; i < readyPlayers.Count; i++) {
		if (readyPlayers[i] == player) {
			return;
		}
	}

	player.SetTeam(PlayerTeam.Team1);
	readyPlayers.Add(player);
	team1Players.Add(player);
	if (readyPlayers.Count == players.Length) {
		timer.Trigger();
	}

}

public void onButtonR(TriggerArgs args) {
	IPlayer player = (IPlayer)args.Sender;
	for (int i = 0; i < readyPlayers.Count; i++) {
		if (readyPlayers[i] == player) {
			return;
		}
	}

	player.SetTeam(PlayerTeam.Team2);
	readyPlayers.Add(player);
	team2Players.Add(player);
	if (readyPlayers.Count == players.Length) {
		timer.Trigger();
	}
}

public void onTimer(TriggerArgs args) {
	for (int i = 0; i < team1Players.Count; i++) {
		Vector2 pos = new Vector2(-312+i*8, -180);
		team1Players[i].SetWorldPosition(pos);
	}
	for (int i = 0; i < team2Players.Count; i++) {
		Vector2 pos = new Vector2(312-i*8, -180);
		team2Players[i].SetWorldPosition(pos);
	}
}
