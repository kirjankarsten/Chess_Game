using UnityEngine;
using UnityEngine.UI;

public class BoardScript : MonoBehaviour
{
	// All buttons and initialising of the board
	public Button[,] board;
 	public Button b1; public Button b2; public Button b3; public Button b4; public Button b5; public Button b6; public Button b7; public Button b8; public Button b9;
    public Button b10; public Button b11; public Button b12; public Button b13; public Button b14; public Button b15; public Button b16; public Button b17; public Button b18;
    public Button b19; public Button b20; public Button b21; public Button b22; public Button b23; public Button b24; public Button b25; public Button b26; public Button b27;
    public Button b28; public Button b29; public Button b30; public Button b31; public Button b32; public Button b33; public Button b34; public Button b35; public Button b36;
    public Button b37; public Button b38; public Button b39; public Button b40; public Button b41; public Button b42; public Button b43; public Button b44; public Button b45;
    public Button b46; public Button b47; public Button b48; public Button b49; public Button b50; public Button b51; public Button b52; public Button b53; public Button b54;
    public Button b55; public Button b56; public Button b57; public Button b58; public Button b59; public Button b60; public Button b61; public Button b62; public Button b63;
    public Button b64;

    public GameObject s1;

    // All images for the chess pieces
    public Sprite blackBishop;
    public Sprite blackKing;
    public Sprite blackKnight;
    public Sprite blackPawn;
    public Sprite blackQueen;
    public Sprite blackRook;

    public Sprite whiteBishop;
    public Sprite whiteKing;
    public Sprite whiteKnight;
    public Sprite whitePawn;
    public Sprite whiteQueen;
    public Sprite whiteRook;

    public void Start()
    {


		// 2D array of the buttons
	    board = new [,] {
		    {b1,  b2,  b3,  b4,  b5,  b6,  b7,  b8},
		    {b9,  b10, b11, b12, b13, b14, b15, b16},
		    {b17, b18, b19, b20, b21, b22, b23, b24},
		    {b25, b26, b27, b28, b29, b30, b31, b32},
		    {b33, b34, b35, b36, b37, b38, b39, b40},
		    {b41, b42, b43, b44, b45, b46, b47, b48},
		    {b49, b50, b51, b52, b53, b54, b55, b56},
		    {b57, b58, b59, b60, b61, b62, b63, b64}
	    };
    }

    // Returns the playing board
    public Button[,] GetBoard()
    {
	    return board;
    }

    public Button[,] GetNewBoard()
    {
	    ResetBoard();
	    return board;
    }

    // Resets the playing board
    public void ResetBoard()
    {
	    // Resets the black side
	    s1.s = blackRook;
//	    b2.image = blackKnight;
//	    b3.image = blackBishop;
//	    b4.image = blackQueen;
//	    b5.image = blackKing;
//	    b6.image = blackBishop;
//	    b7.image = blackKnight;
//	    b8.image = blackRook;
//
//	    b9.image  = blackPawn;
//	    b10.image = blackPawn;
//	    b11.image = blackPawn;
//	    b12.image = blackPawn;
//	    b13.image = blackPawn;
//	    b14.image = blackPawn;
//	    b15.image = blackPawn;
//	    b16.image = blackPawn;
//
//		// Resets the White side
//	    b49.image = whitePawn;
//	    b50.image = whitePawn;
//	    b51.image = whitePawn;
//	    b52.image = whitePawn;
//	    b53.image = whitePawn;
//	    b54.image = whitePawn;
//	    b55.image = whitePawn;
//	    b56.image = whitePawn;
//
//	    b57.image = whiteRook;
//	    b58.image = whiteKnight;
//	    b59.image = whiteBishop;
//	    b60.image = whiteQueen;
//	    b61.image = whiteKing;
//	    b62.image = whiteBishop;
//	    b63.image = whiteKnight;
//	    b64.image = whiteRook;

	    // Sets the rest of images to null
	    for (var i = 1; i < 7; i++) {
		    for (var j = 0; j < 8; j++) {
			    board[i, j].image = null;
		    }
	    }
    }
}
