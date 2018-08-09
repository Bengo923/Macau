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

		RemainingCards.ChangeRemainingCardsText();
	}

	public static GameObject PickFirstCard(bool changeTurn = true)
	{
		GameObject firstCard = GlobalVariables.cards[0];

		GlobalVariables.cards.RemoveAt(0);

		if (changeTurn)
		{
			if (GlobalVariables.turn == 1)
			{
				GlobalVariables.turn = 2;
			}
			else if (GlobalVariables.turn == 2)
			{
				GlobalVariables.turn = 1;
			}
		}

		PlayerTurn.ChangePlayerTurnText();

		return firstCard;
	}

	public static GameObject InstantiateCard(GameObject cardPrefab, GameObject place)
	{
		GameObject card = Instantiate(cardPrefab);

		card.transform.SetParent(place.transform);
		card.transform.localPosition = Vector3.zero;
		card.transform.localScale = Vector3.one;

		if (card.GetComponent<Card>() != null)
		{
			card.GetComponent<Card>().player = GlobalVariables.turn;
		}

		if (place.GetComponent<CardBorder>() != null)
		{
			place.GetComponent<CardBorder>().isEmpty = false;
		}

		return card;
	}
}
