using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : MonoBehaviour
{
	public static void ChangePlayerTurnText()
	{
		int turn = Utilities.SwapTurn();

		GameObject.Find("Player Turn").GetComponent<Text>().text = "Player Turn: " + turn;
	}
}
