using UnityEngine;
using UnityEngine.UI;

public class BoardScript : MonoBehaviour
{
	public Button[,] board;
 	public Button b1; public Button b2; public Button b3; public Button b4; public Button b5; public Button b6; public Button b7; public Button b8; public Button b9;
    public Button b10; public Button b11; public Button b12; public Button b13; public Button b14; public Button b15; public Button b16; public Button b17; public Button b18;
    public Button b19; public Button b20; public Button b21; public Button b22; public Button b23; public Button b24; public Button b25; public Button b26; public Button b27;
    public Button b28; public Button b29; public Button b30; public Button b31; public Button b32; public Button b33; public Button b34; public Button b35; public Button b36;
    public Button b37; public Button b38; public Button b39; public Button b40; public Button b41; public Button b42; public Button b43; public Button b44; public Button b45;
    public Button b46; public Button b47; public Button b48; public Button b49; public Button b50; public Button b51; public Button b52; public Button b53; public Button b54;
    public Button b55; public Button b56; public Button b57; public Button b58; public Button b59; public Button b60; public Button b61; public Button b62; public Button b63;
    public Button b64; public Button b65; public Button b66; public Button b67; public Button b68; public Button b69; public Button b70; public Button b71; public Button b72;
    public Button b73; public Button b74; public Button b75; public Button b76; public Button b77; public Button b78; public Button b79; public Button b80; public Button b81;


    public void Start()
    {
	    b1 = GetComponent<Button>();


	    board = new [,] {
		    {b1, b2, b3, b4, b5, b6, b7, b8, b9},
		    {b10, b11, b12, b13, b14, b15, b16, b17, b18},
		    {b19, b20, b21, b22, b23, b24, b25, b26, b27},
		    {b28, b29, b30, b31, b32, b33, b34, b35, b36},
		    {b37, b38, b39, b40, b41, b42, b43, b44, b45},
		    {b46, b47, b48, b49, b50, b51, b52, b53, b54},
		    {b55, b56, b57, b58, b59, b60, b61, b62, b63},
		    {b64, b65, b66, b67, b68, b69, b70, b71, b72},
		    {b73, b74, b75, b76, b77, b78, b79, b80, b81}
	    };

	    for (var i = 0; i < 9; i++)
	    {
		    Debug.Log(board[i, i].tag);
	    }
    }

    public Button[,] GetBoard()
    {
	    return board;
    }
}
