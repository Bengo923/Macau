using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DeckCard : MonoBehaviour, IPointerDownHandler
{
	public Text remainingCardsText;

	public void OnPointerDown(PointerEventData pointerEventData)
	{
		InstantiateCard(PickFirstCard(), CardBorders.GetEmptyCardBorder(GlobalVariables.turn));

		RemainingCards.ChangeRemainingCardsText(remainingCardsText);
	}

	public static GameObject PickFirstCard()
	{
		GameObject firstCard = GlobalVariables.cards[0];

		GlobalVariables.cards.RemoveAt(0);

		if (GlobalVariables.turn == 1)
		{
			GlobalVariables.turn = 2;
		}
		else if (GlobalVariables.turn == 2)
		{
			GlobalVariables.turn = 1;
		}

		return firstCard;
	}

	public static void InstantiateCard(GameObject cardPrefab, GameObject place)
	{
		GameObject card = Instantiate(cardPrefab);

		card.transform.SetParent(place.transform);
		card.transform.localPosition = new Vector3(0, 0, 0);
		card.transform.localScale = new Vector3(1f, 1f, 1f);

		card.GetComponent<Card>().player = GlobalVariables.turn;

		place.GetComponent<CardBorder>().isEmpty = false;
	}
}
