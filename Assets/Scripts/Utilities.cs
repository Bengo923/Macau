using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Utilities : MonoBehaviour
{
	public Text remainingCardsText;

	public static void ChangeTurn()
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

	public static void SetPositionZero(GameObject gameObject)
	{
		gameObject.transform.localPosition = Vector3.zero;
	}

	public static void SetScaleOne(GameObject gameObject)
	{
		gameObject.transform.localScale = Vector3.one;
	}

	public static void SetParent(GameObject gameObject, GameObject parent)
	{
		gameObject.transform.SetParent(parent.transform);
	}

	public static GameObject GetFirstCard()
	{
		return GlobalVariables.cards[0];
	}

	public static GameObject PickFirstCard(bool changeTurn = true)
	{
		GameObject firstCard = GetFirstCard();

		GlobalVariables.cards.RemoveAt(0);

		if (changeTurn)
		{
			ChangeTurn();
		}

		PlayerTurn.ChangePlayerTurnText();

		return firstCard;
	}

	public static GameObject InstantiateCard(GameObject cardPrefab, GameObject place)
	{
		GameObject card = Instantiate(cardPrefab);

		SetParent(card, place);
		SetPositionZero(card);
		SetScaleOne(card);

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

	public static void AreCardsSelected()
	{
		if (GlobalVariables.cardsSelected.Count > 0)
		{
			GlobalVariables.areCardsSelected = true;
		}
		else
		{
			GlobalVariables.areCardsSelected = false;
		}
	}

	//wip
	public static int SwapTurn()
	{
		if (GlobalVariables.turn == 1)
		{
			return 2;
		}
		else if (GlobalVariables.turn == 2)
		{
			return 1;
		}
		return 0;
	}
}
