using UnityEngine;
using UnityEngine.UI;

public class BoardScript : MonoBehaviour
{
	// Initialising of the board
	public Button[,] board;

	// All buttons
	public Button b1;  public Button b2;  public Button b3;  public Button b4;  public Button b5;  public Button b6;  public Button b7;  public Button b8;  public Button b9;
    public Button b10; public Button b11; public Button b12; public Button b13; public Button b14; public Button b15; public Button b16; public Button b17; public Button b18;
    public Button b19; public Button b20; public Button b21; public Button b22; public Button b23; public Button b24; public Button b25; public Button b26; public Button b27;
    public Button b28; public Button b29; public Button b30; public Button b31; public Button b32; public Button b33; public Button b34; public Button b35; public Button b36;
    public Button b37; public Button b38; public Button b39; public Button b40; public Button b41; public Button b42; public Button b43; public Button b44; public Button b45;
    public Button b46; public Button b47; public Button b48; public Button b49; public Button b50; public Button b51; public Button b52; public Button b53; public Button b54;
    public Button b55; public Button b56; public Button b57; public Button b58; public Button b59; public Button b60; public Button b61; public Button b62; public Button b63;
    public Button b64;

    // Sprite components for the buttons
    private SpriteRenderer _sr1;  private SpriteRenderer _sr2;  private SpriteRenderer _sr3;  private SpriteRenderer _sr4;  private SpriteRenderer _sr5;  private SpriteRenderer _sr6;  private SpriteRenderer _sr7;  private SpriteRenderer _sr8;  private SpriteRenderer _sr9;
    private SpriteRenderer _sr10; private SpriteRenderer _sr11; private SpriteRenderer _sr12; private SpriteRenderer _sr13; private SpriteRenderer _sr14; private SpriteRenderer _sr15; private SpriteRenderer _sr16; private SpriteRenderer _sr17; private SpriteRenderer _sr18;
    private SpriteRenderer _sr19; private SpriteRenderer _sr20; private SpriteRenderer _sr21; private SpriteRenderer _sr22; private SpriteRenderer _sr23; private SpriteRenderer _sr24; private SpriteRenderer _sr25; private SpriteRenderer _sr26; private SpriteRenderer _sr27;
    private SpriteRenderer _sr28; private SpriteRenderer _sr29; private SpriteRenderer _sr30; private SpriteRenderer _sr31; private SpriteRenderer _sr32; private SpriteRenderer _sr33; private SpriteRenderer _sr34; private SpriteRenderer _sr35; private SpriteRenderer _sr36;
    private SpriteRenderer _sr37; private SpriteRenderer _sr38; private SpriteRenderer _sr39; private SpriteRenderer _sr40; private SpriteRenderer _sr41; private SpriteRenderer _sr42; private SpriteRenderer _sr43; private SpriteRenderer _sr44; private SpriteRenderer _sr45;
    private SpriteRenderer _sr46; private SpriteRenderer _sr47; private SpriteRenderer _sr48; private SpriteRenderer _sr49; private SpriteRenderer _sr50; private SpriteRenderer _sr51; private SpriteRenderer _sr52; private SpriteRenderer _sr53; private SpriteRenderer _sr54;
    private SpriteRenderer _sr55; private SpriteRenderer _sr56; private SpriteRenderer _sr57; private SpriteRenderer _sr58; private SpriteRenderer _sr59; private SpriteRenderer _sr60; private SpriteRenderer _sr61; private SpriteRenderer _sr62; private SpriteRenderer _sr63;
    private SpriteRenderer _sr64;

    // This var is used to set rest of board to null when board gets resetted
    private SpriteRenderer _srLocal;


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


	// Start
    public void Start()
    {
	    _sr1 =  b1.GetComponent<SpriteRenderer>();  _sr2 =  b2.GetComponent<SpriteRenderer>();   _sr3 = b3.GetComponent<SpriteRenderer>();  _sr4 =  b4.GetComponent<SpriteRenderer>();  _sr5 =  b5.GetComponent<SpriteRenderer>();  _sr6 =  b6.GetComponent<SpriteRenderer>();  _sr7 =  b7.GetComponent<SpriteRenderer>();  _sr8 =  b8.GetComponent<SpriteRenderer>();  _sr9 =  b9.GetComponent<SpriteRenderer>();
	    _sr10 = b10.GetComponent<SpriteRenderer>(); _sr11 = b11.GetComponent<SpriteRenderer>(); _sr12 = b12.GetComponent<SpriteRenderer>(); _sr13 = b13.GetComponent<SpriteRenderer>(); _sr14 = b14.GetComponent<SpriteRenderer>(); _sr15 = b15.GetComponent<SpriteRenderer>(); _sr16 = b16.GetComponent<SpriteRenderer>(); _sr17 = b17.GetComponent<SpriteRenderer>(); _sr18 = b18.GetComponent<SpriteRenderer>();
	    _sr19 = b19.GetComponent<SpriteRenderer>(); _sr20 = b20.GetComponent<SpriteRenderer>(); _sr21 = b21.GetComponent<SpriteRenderer>(); _sr22 = b22.GetComponent<SpriteRenderer>(); _sr23 = b23.GetComponent<SpriteRenderer>(); _sr24 = b24.GetComponent<SpriteRenderer>(); _sr25 = b25.GetComponent<SpriteRenderer>(); _sr26 = b26.GetComponent<SpriteRenderer>(); _sr27 = b27.GetComponent<SpriteRenderer>();
	    _sr28 = b28.GetComponent<SpriteRenderer>(); _sr29 = b29.GetComponent<SpriteRenderer>(); _sr30 = b30.GetComponent<SpriteRenderer>(); _sr31 = b31.GetComponent<SpriteRenderer>(); _sr32 = b32.GetComponent<SpriteRenderer>(); _sr33 = b33.GetComponent<SpriteRenderer>(); _sr34 = b34.GetComponent<SpriteRenderer>(); _sr35 = b35.GetComponent<SpriteRenderer>(); _sr36 = b36.GetComponent<SpriteRenderer>();
	    _sr37 = b37.GetComponent<SpriteRenderer>(); _sr38 = b38.GetComponent<SpriteRenderer>(); _sr39 = b39.GetComponent<SpriteRenderer>(); _sr40 = b40.GetComponent<SpriteRenderer>(); _sr41 = b41.GetComponent<SpriteRenderer>(); _sr42 = b42.GetComponent<SpriteRenderer>(); _sr43 = b43.GetComponent<SpriteRenderer>(); _sr44 = b44.GetComponent<SpriteRenderer>(); _sr45 = b45.GetComponent<SpriteRenderer>();
	    _sr46 = b46.GetComponent<SpriteRenderer>(); _sr47 = b47.GetComponent<SpriteRenderer>(); _sr48 = b48.GetComponent<SpriteRenderer>(); _sr49 = b49.GetComponent<SpriteRenderer>(); _sr50 = b50.GetComponent<SpriteRenderer>(); _sr51 = b51.GetComponent<SpriteRenderer>(); _sr52 = b52.GetComponent<SpriteRenderer>(); _sr53 = b53.GetComponent<SpriteRenderer>(); _sr54 = b54.GetComponent<SpriteRenderer>();
	    _sr55 = b55.GetComponent<SpriteRenderer>(); _sr56 = b56.GetComponent<SpriteRenderer>(); _sr57 = b57.GetComponent<SpriteRenderer>(); _sr58 = b58.GetComponent<SpriteRenderer>(); _sr59 = b59.GetComponent<SpriteRenderer>(); _sr60 = b60.GetComponent<SpriteRenderer>(); _sr61 = b61.GetComponent<SpriteRenderer>(); _sr62 = b62.GetComponent<SpriteRenderer>(); _sr63 = b63.GetComponent<SpriteRenderer>();
	    _sr64 = b64.GetComponent<SpriteRenderer>();

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

	    ResetBoard();
    }

    // Returns the playing board
    public Button[,] GetBoard()
    {
	    return board;
    }

    // Returns fresh board
    public Button[,] GetNewBoard()
    {
	    ResetBoard();
	    return board;
    }

    // Resets the playing board
    public void ResetBoard()
    {
	    // Resets the black side
		_sr1.sprite = blackRook;
		_sr2.sprite = blackKnight;
		_sr3.sprite = blackBishop;
		_sr4.sprite = blackQueen;
		_sr5.sprite = blackKing;
		_sr6.sprite = blackBishop;
		_sr7.sprite = blackKnight;
		_sr8.sprite = blackRook;

		_sr9.sprite  = blackPawn;
		_sr10.sprite = blackPawn;
		_sr11.sprite = blackPawn;
		_sr12.sprite = blackPawn;
		_sr13.sprite = blackPawn;
		_sr14.sprite = blackPawn;
		_sr15.sprite = blackPawn;
		_sr16.sprite = blackPawn;

		// Resets the White side
		_sr49.sprite = whitePawn;
		_sr50.sprite = whitePawn;
		_sr51.sprite = whitePawn;
		_sr52.sprite = whitePawn;
		_sr53.sprite = whitePawn;
		_sr54.sprite = whitePawn;
		_sr55.sprite = whitePawn;
		_sr56.sprite = whitePawn;

		_sr57.sprite = whiteRook;
		_sr58.sprite = whiteKnight;
		_sr59.sprite = whiteBishop;
		_sr60.sprite = whiteQueen;
		_sr61.sprite = whiteKing;
		_sr62.sprite = whiteBishop;
		_sr63.sprite = whiteKnight;
		_sr64.sprite = whiteRook;

	    // Sets the rest of images to null
	    for (var i = 1; i < 7; i++) {
		    for (var j = 0; j < 8; j++) {
			    _srLocal = board[i, j].GetComponent<SpriteRenderer>();
			    _srLocal = null;
		    }
	    }
    }
}
