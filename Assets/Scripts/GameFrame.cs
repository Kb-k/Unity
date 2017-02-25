
public class GameFrame {

    public int ID { get; private set; }
    public float ShotClock { get; private set; }
    public float GameTime { get; private set; }
    public Player[] Players { get; private set; }

    public GameFrame(int id, float shotClock, float gameTime, Player[] players)
    {
        ID = id;
        ShotClock = shotClock;
        GameTime = gameTime;
        Players = players;
    }
}
