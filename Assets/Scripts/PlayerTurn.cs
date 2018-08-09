using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : MonoBehaviour
{
	public static void ChangePlayerTurnText()
	{
		int turn = GlobalVariables.turn;

		#region Swap turn Value
		if (turn == 1)
		{
			turn = 2;
		}
		else if (turn == 2)
		{
			turn = 1;
		}
		#endregion

		GameObject.Find("Player Turn").GetComponent<Text>().text = "Player Turn: " + turn;
	}
}
