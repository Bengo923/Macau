using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
	public static List<GameObject> cards = new List<GameObject>();

	public static List<GameObject> cardBordersPlayerOne = new List<GameObject>();
	public static List<GameObject> cardBordersPlayerTwo = new List<GameObject>();

	public static int turn = 1;

	public static Vector2 screenResolution;
}
