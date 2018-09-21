using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DeckCard : MonoBehaviour, IPointerDownHandler
{
	public void OnPointerDown(PointerEventData pointerEventData)
	{
		Utilities.InstantiateCard(Utilities.PickFirstCard(), CardBorders.GetEmptyCardBorder(GlobalVariables.turn));

		RemainingCards.ChangeRemainingCardsText();
	}
}
