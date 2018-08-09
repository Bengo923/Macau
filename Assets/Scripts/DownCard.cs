using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCard : MonoBehaviour
{
	private void Start()
	{
		PutFirstDownCard();
	}

	private void PutFirstDownCard()
	{
		GameObject firstCardPrefab = DeckCard.PickFirstCard(false);

		GameObject firstCard = DeckCard.InstantiateCard(firstCardPrefab, gameObject);

		firstCard.GetComponent<Card>().isDown = true;

		GlobalVariables.cardsDown.Add(firstCard);
	}
}
