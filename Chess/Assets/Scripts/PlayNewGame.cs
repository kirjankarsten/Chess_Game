using UnityEngine;

public class PlayNewGame : MonoBehaviour
{
    public void StartNewGame()
    {
        var boardScript = gameObject.GetComponent<BoardScript>();
        boardScript.ResetBoard();
    }
}
