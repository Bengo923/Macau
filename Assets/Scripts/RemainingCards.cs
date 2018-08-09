using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainingCards : MonoBehaviour
{
	public static void ChangeRemainingCardsText()
	{
		GameObject.Find("Remaining Cards").GetComponent<Text>().text = "Remaining Cards: " + GlobalVariables.cards.Count;
	}
}
