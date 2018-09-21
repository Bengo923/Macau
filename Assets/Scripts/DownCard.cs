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
		GameObject firstCardPrefab = Utilities.PickFirstCard(false);

		GameObject firstCard = Utilities.InstantiateCard(firstCardPrefab, gameObject);

		firstCard.GetComponent<Card>().isDown = true;

		GlobalVariables.cardsDown.Add(firstCard);
	}
}
