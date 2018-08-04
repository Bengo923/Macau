using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsDeck : MonoBehaviour
{
	public List<GameObject> cards;

	private void Start()
	{
		InitializeCardsDeck();
		RandomizeCardsDeck();
	}

	private void InitializeCardsDeck()
	{
		for (int i = 0; i < cards.Count; i++)
		{
			GlobalVariables.cards.Add(cards[i]);
		}
	}

	private void RandomizeCardsDeck()
	{
		for (int i = 0; i < GlobalVariables.cards.Count; i++)
		{
			GameObject temp = GlobalVariables.cards[i];
			int randomIndex = Random.Range(0, GlobalVariables.cards.Count);
			GlobalVariables.cards[i] = GlobalVariables.cards[randomIndex];
			GlobalVariables.cards[randomIndex] = temp;
		}
	}
}
