using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitializePlayerCards : MonoBehaviour
{
	private void Start()
	{
		InitializeCards();
	}

	private void InitializeCards()
	{
		for (int i = 0; i < 10; i++)
		{
			DeckCard.InstantiateCard(DeckCard.PickFirstCard(), CardBorders.GetEmptyCardBorder(GlobalVariables.turn));
		}
	}
}

