using UnityEngine;
using UnityEngine.UI;

public class boardScript : MonoBehaviour
{
	Button b_1; Button b_2; Button b_3; Button b_4; Button b_5; Button b_6; Button b_7; Button b_8; Button b_9;
	Button b_10; Button b_11; Button b_12; Button b_13; Button b_14; Button b_15; Button b_16; Button b_17; Button b_18;
	Button b_19; Button b_20; Button b_21; Button b_22; Button b_23; Button b_24; Button b_25; Button b_26; Button b_27;
	Button b_28; Button b_29; Button b_30; Button b_31; Button b_32; Button b_33; Button b_34; Button b_35; Button b_36;
	Button b_37; Button b_38; Button b_39; Button b_40; Button b_41; Button b_42; Button b_43; Button b_44; Button b_45;
	Button b_46; Button b_47; Button b_48; Button b_49; Button b_50; Button b_51; Button b_52; Button b_53; Button b_54;
	Button b_55; Button b_56; Button b_57; Button b_58; Button b_59; Button b_60; Button b_61; Button b_62; Button b_63;
	Button b_64; Button b_65; Button b_66; Button b_67; Button b_68; Button b_69; Button b_70; Button b_71; Button b_72;
	Button b_73; Button b_74; Button b_75; Button b_76; Button b_77; Button b_78; Button b_79; Button b_80; Button b_81;

	public Button[,] board;

    void Start() {
	b_1 = new Button;
    board = new Button[,] {
		    {b_1, b_2, b_3, b_4, b_5, b_6, b_7, b_8, b_9},
		    {b_10, b_11, b_12, b_13, b_14, b_15, b_16, b_17, b_18},
		    {b_19, b_20, b_21, b_22, b_23, b_24, b_25, b_26, b_27},
		    {b_28, b_29, b_30, b_31, b_32, b_33, b_34, b_35, b_36},
		    {b_37, b_38, b_39, b_40, b_41, b_42, b_43, b_44, b_45},
		    {b_46, b_47, b_48, b_49, b_50, b_51, b_52, b_53, b_54},
		    {b_55, b_56, b_57, b_58, b_59, b_60, b_61, b_62, b_63},
		    {b_64, b_65, b_66, b_67, b_68, b_69, b_70, b_71, b_72},
		    {b_73, b_74, b_75, b_76, b_77, b_78, b_79, b_80, b_81}
	    };

		for(int i = 0; i < 9; i++){
			Debug.Log(board[i,i]);
		}
    }

	public Button[,] getBoard(){
		return board;
	}
}
