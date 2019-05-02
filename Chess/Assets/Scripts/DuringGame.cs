using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DuringGame : MonoBehaviour
{
    public Text turnText;
    private bool _turnBool;

    public void Start()
    {
        turnText.text = GetTurn();
    }

    private string GetTurn()
    {
        _turnBool = !_turnBool;
        if (_turnBool)
        {
            return "Turn = Black";
        }

        return "Turn = White";
    }

    private string GetPiece(GameObject button)
    {
        var sr = button.GetComponent<SpriteRenderer>();
        return sr.sprite.name;
    }

    public void ButtonPressed()
    {
        Debug.Log("Button Pressed");
        GetTurn();
        var buttonName = EventSystem.current.currentSelectedGameObject;
        var boardScript = gameObject.GetComponent<BoardScript>();
        var y = 0;
        var x = 0;

        for (int u = 0; u < 8; u++)
        {
            for (int t = 0; t < 8; t++)
            {
                if (boardScript.GetBoard()[u, t].name.Equals(GetPiece(buttonName)))
                {
                    y = t;
                    x = u;
                }
            }
        }

        Debug.Log("Pressed: " + GetPiece(buttonName));

        if (GetPiece(buttonName).Equals("Black_Bishop") || GetPiece(buttonName).Equals("White_Bishop"))
        {
            Bishop(x, y);
        } else if (GetPiece(buttonName).Equals("Black_King") || GetPiece(buttonName).Equals("White_King"))
        {
            King(x, y);
        }else if (GetPiece(buttonName).Equals("Black_Knight") || GetPiece(buttonName).Equals("White_Knight"))
        {
            Knight(x, y);
        }else if (GetPiece(buttonName).Equals("Black_Pawn") || GetPiece(buttonName).Equals("White_Pawn"))
        {
            Pawn(x, y);
        }else if (GetPiece(buttonName).Equals("Black_Queen") || GetPiece(buttonName).Equals("White_Queen"))
        {
            Queen(x, y);
        }else if (GetPiece(buttonName).Equals("Black_Rook") || GetPiece(buttonName).Equals("White_Rook"))
        {
            Rook(x, y);
        }
    }

    private void Bishop(int x, int y)
    {
        Debug.Log("Bishop");
    }

    private void King(int x, int y)
    {
        Debug.Log("King");
    }

    private void Knight(int x, int y)
    {
        Debug.Log("Knight");
    }

    private void Pawn(int x, int y)
    {
        Debug.Log("Pawn");
    }

    private void Queen(int x, int y)
    {
        Debug.Log("Queen");
    }

    private void Rook(int x, int y)
    {
        Debug.Log("Rook");
    }
}