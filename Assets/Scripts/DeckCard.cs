using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DeckCard : MonoBehaviour, IPointerDownHandler
{
	public void OnPointerDown(PointerEventData pointerEventData)
	{
		print(PickLastCard());
	}

	private GameObject PickLastCard()
	{
		return GlobalVariables.cards[0];
	}
}
