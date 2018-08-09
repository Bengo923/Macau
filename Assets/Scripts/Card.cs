using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerDownHandler
{
	private GameObject downCard;

	private bool isSelected = false;
	private bool isCardSelectedOtherTurn = false;

	public bool isDown = false;

	public int player;

	private Color initialColor;

	public Color selectedColor;
	public Color cannotBeSelectedColor;
	public Color unavailableColor;

	public string value;
	public string type;

	private void Start()
	{
		downCard = GameObject.Find("Down Card");

		initialColor = gameObject.GetComponent<Image>().color;
		selectedColor = new Vector4(0.75f, 0.75f, 1f, 1f);
		cannotBeSelectedColor = new Vector4(1f, 0.75f, 0.75f, 1f);
		unavailableColor = new Vector4(0.75f, 0.75f, 0.75f, 1f);
	}

	private void Update()
	{
		CheckCardSelectedOtherTurn();
	}

	public void OnPointerDown(PointerEventData pointerEventData)
	{
		SelectCard();
		PutCardDown();

		ChangeCardColor();
	}

	private void SelectCard()
	{
		#region Swap isSelected Value
		if (isSelected || isCardSelectedOtherTurn)
		{
			isSelected = false;
		}
		else
		{
			isSelected = true;
		}
		#endregion

		if (!isDown)
		{
			if (GlobalVariables.turn == player)
			{
				if (isSelected)
				{
					CardSelected();
				}
				else if (!isSelected)
				{
					CardNotSelected();
				}
			}
		}
	}

	private void CardSelected()
	{
		if (player == 1)
		{
			gameObject.transform.position += Vector3.up * Screen.height / 30f;
		}
		else if (player == 2)
		{
			gameObject.transform.position += Vector3.down * Screen.height / 30f;
		}
		gameObject.GetComponent<Image>().color = selectedColor;
		GlobalVariables.cardsSelected.Add(gameObject);
	}

	private void CardNotSelected()
	{
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.GetComponent<Image>().color = initialColor;

		GlobalVariables.cardsSelected.Remove(gameObject);
	}

	public static string GetCardValue(GameObject card)
	{
		string name = card.name;

		if (card.GetComponent<Card>() != null)
		{
			#region Get Value If's
			if (name.Contains("Ace"))
			{
				card.GetComponent<Card>().value = "ACE";
			}
			else if (name.Contains("Two"))
			{
				card.GetComponent<Card>().value = "TWO";
			}
			else if (name.Contains("Three"))
			{
				card.GetComponent<Card>().value = "Three";
			}
			else if (name.Contains("For"))
			{
				card.GetComponent<Card>().value = "FOR";
			}
			else if (name.Contains("Five"))
			{
				card.GetComponent<Card>().value = "FIVE";
			}
			else if (name.Contains("Six"))
			{
				card.GetComponent<Card>().value = "SIX";
			}
			else if (name.Contains("Seven"))
			{
				card.GetComponent<Card>().value = "SEVEN";
			}
			else if (name.Contains("Eight"))
			{
				card.GetComponent<Card>().value = "EIGHT";
			}
			else if (name.Contains("Nine"))
			{
				card.GetComponent<Card>().value = "NINE";
			}
			else if (name.Contains("Ten"))
			{
				card.GetComponent<Card>().value = "TEN";
			}
			else if (name.Contains("Jack"))
			{
				card.GetComponent<Card>().value = "JACK";
			}
			else if (name.Contains("King"))
			{
				card.GetComponent<Card>().value = "KING";
			}
			else if (name.Contains("Queen"))
			{
				card.GetComponent<Card>().value = "QUEEN";
			}
			else if (name.Contains("Joker"))
			{
				card.GetComponent<Card>().value = "JOKER";
			}
			#endregion
		}

		return card.GetComponent<Card>().value;
	}

	public static string GetCardType(GameObject card)
	{
		string name = card.name;

		if (card.GetComponent<Card>() != null)
		{
			#region Get Type If's
			if (name.Contains("Spade"))
			{
				card.GetComponent<Card>().type = "SPADE";
			}
			else if (name.Contains("Club"))
			{
				card.GetComponent<Card>().type = "CLUB";
			}
			else if (name.Contains("Diamond"))
			{
				card.GetComponent<Card>().type = "DIAMOND";
			}
			else if (name.Contains("Heart"))
			{
				card.GetComponent<Card>().type = "HEART";
			}
			else if (name.Contains("Joker"))
			{
				card.GetComponent<Card>().type = "JOKER";
			}
			#endregion
		}

		return card.GetComponent<Card>().type;
	}

	private void PutCardDown()
	{
		if (gameObject.GetComponent<Card>().isDown && GlobalVariables.cardsDown[GlobalVariables.cardsDown.Count - 1] == gameObject)
		{
			for (int i = 0; i < GlobalVariables.cardsSelected.Count; i++)
			{
				if (gameObject.GetComponent<Card>().type == GlobalVariables.cardsSelected[i].GetComponent<Card>().type ||
					gameObject.GetComponent<Card>().value == GlobalVariables.cardsSelected[i].GetComponent<Card>().value)
				{
					GameObject cardSelected = GlobalVariables.cardsSelected[i];
					cardSelected.transform.SetParent(downCard.transform);
					cardSelected.GetComponent<Card>().isDown = true;
					cardSelected.transform.localPosition = Vector3.zero;
				}
			}
		}
	}

	private void CheckCardSelectedOtherTurn()
	{
		if (gameObject.GetComponent<Card>().player != GlobalVariables.turn || gameObject.GetComponent<Card>().isDown)
		{
			CardNotSelected();
		}
	}

	private bool AreCardsSelected()
	{
		if (GlobalVariables.cardsSelected.Count > 0)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	private void ChangeCardColor()
	{
		if (AreCardsSelected())
		{
			//for (int i = 0; i < playerOneCards.transform.childCount-1; i++)
			//{
			//	Transform playerOneChild = playerOneCards.transform.GetChild(i);
			//	GameObject card = playerOneChild.GetChild(0).gameObject;

			//	card.GetComponent<Image>().color = unavailableColor;
			//}
		}
	}
}
