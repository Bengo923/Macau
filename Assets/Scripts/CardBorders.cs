using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBorders : MonoBehaviour
{
	public List<GameObject> cardBordersPlayerOne;
	public List<GameObject> cardBordersPlayerTwo;

	private void Start()
	{
		InitializeCardBorders();
	}

	private void InitializeCardBorders()
	{
		for (int i = 0; i < cardBordersPlayerOne.Count; i++)
		{
			GlobalVariables.cardBordersPlayerOne.Add(cardBordersPlayerOne[i]);
		}

		for (int i = 0; i < cardBordersPlayerTwo.Count; i++)
		{
			GlobalVariables.cardBordersPlayerTwo.Add(cardBordersPlayerTwo[i]);
		}
	}

	public static GameObject GetEmptyCardBorder(int player)
	{
		GameObject emptyCardBorder = null;

		if (player == 1)
		{
			for (int i = 0; i < GlobalVariables.cardBordersPlayerOne.Count; i++)
			{
				if (GlobalVariables.cardBordersPlayerOne[i].GetComponent<CardBorder>().isEmpty)
				{
					emptyCardBorder = GlobalVariables.cardBordersPlayerOne[i];
					break;
				}
			}
		}
		else
		{
			for (int i = 0; i < GlobalVariables.cardBordersPlayerTwo.Count; i++)
			{
				if (GlobalVariables.cardBordersPlayerTwo[i].GetComponent<CardBorder>().isEmpty)
				{
					emptyCardBorder = GlobalVariables.cardBordersPlayerTwo[i];
					break;
				}
			}
		}
		return emptyCardBorder;
	}
}
