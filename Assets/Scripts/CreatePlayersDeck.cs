using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePlayersDeck : MonoBehaviour
{
	public GameObject playerOne;
	public GameObject playerTwo;

	private void Start()
	{
		CreateDecks();
	}

	private void CreateDecks()
	{
		for (int i = 0; i < playerOne.transform.childCount; i++)
		{
			GameObject playerOneChild = playerOne.transform.GetChild(i).gameObject;

			if (playerOneChild.transform.childCount == 1)
			{
				GameObject card = playerOneChild.transform.GetChild(0).gameObject;

				GlobalVariables.cardsPlayerOne.Add(card);
			}
		}

		for (int i = 0; i < playerTwo.transform.childCount; i++)
		{
			GameObject playerTwoChild = playerTwo.transform.GetChild(i).gameObject;

			if (playerTwoChild.transform.childCount == 1)
			{
				GameObject card = playerTwoChild.transform.GetChild(0).gameObject;

				GlobalVariables.cardsPlayerTwo.Add(card);
			}
		}
	}
}
