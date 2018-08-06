using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemainingCards : MonoBehaviour
{
	public static void ChangeRemainingCardsText(Text textBox)
	{
		textBox.text = "Remaining Cards: " + GlobalVariables.cards.Count;
	}
}