using UnityEngine;

public class PlayNewGame : MonoBehaviour
{
    public void StartNewGame()
    {
        Debug.Log("New Game Started");
        var boardScript = gameObject.GetComponent<BoardScript>();
        boardScript.ResetBoard();
    }

    public void ClickButtonTest()
    {
        Debug.Log("clicked");
        DuringGame duringGame = GetComponent<DuringGame>();
        duringGame.ButtonPressed();
    }
}
