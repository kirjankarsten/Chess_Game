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
        int _y = 0;
        int _x = 0;

        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                if (boardScript.GetBoard()[x, y].Equals(buttonName))
                {
                    _y = y;
                    _x = x;
                }
            }
        }

        Debug.Log("Pressed: " + GetPiece(buttonName));

        if (GetPiece(buttonName).Equals("Black_Bishop") || GetPiece(buttonName).Equals("White_Bishop"))
        {
            Bishop(_x, _y);
        } else if (GetPiece(buttonName).Equals("Black_King") || GetPiece(buttonName).Equals("White_King"))
        {
            King(_x, _y);
        }else if (GetPiece(buttonName).Equals("Black_Knight") || GetPiece(buttonName).Equals("White_Knight"))
        {
            Knight(_x, _y);
        }else if (GetPiece(buttonName).Equals("Black_Pawn") || GetPiece(buttonName).Equals("White_Pawn"))
        {
            Pawn(_x, _y);
        }else if (GetPiece(buttonName).Equals("Black_Queen") || GetPiece(buttonName).Equals("White_Queen"))
        {
            Queen(_x, _y);
        }else if (GetPiece(buttonName).Equals("Black_Rook") || GetPiece(buttonName).Equals("White_Rook"))
        {
            Rook(_x, _y);
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