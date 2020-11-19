

namespace Hangman
 {
public class Score
    {
    string playerNick;
    string dateOfGame;
    int timeOfGame;
    int lifes;
    public void setScore (string pn, string dog, int tog, int l) {
        playerNick = pn;
        dateOfGame = dog;
        timeOfGame = tog;
        lifes = l;
    }

    public string getName() {
        return playerNick;
    }
    public string getDate() {
        return dateOfGame;
    }
    public int getTime() {
        return timeOfGame;
    }
    public int getLife() {
        return lifes;
    }

    public override string ToString() {
        return playerNick + " " + dateOfGame + " " + timeOfGame + " " + lifes;
    }

    }
 }