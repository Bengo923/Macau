using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
	public static List<GameObject> cards = new List<GameObject>();

	public static List<GameObject> cardBordersPlayerOne = new List<GameObject>();
	public static List<GameObject> cardBordersPlayerTwo = new List<GameObject>();
	public static List<GameObject> cardsPlayerOne = new List<GameObject>();
	public static List<GameObject> cardsPlayerTwo = new List<GameObject>();
	public static List<GameObject> cardsDown = new List<GameObject>();
	public static List<GameObject> cardsSelected = new List<GameObject>();

	public static bool areCardsSelected = false;

	public static int turn = 1;
}
