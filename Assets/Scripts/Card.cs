using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IPointerDownHandler
{
	private bool isSelected = false;

	public int player;

	private Color initialColor;

	public Color selectedColor;

	public string type;

	private void Start()
	{
		initialColor = gameObject.GetComponent<Image>().color;
		selectedColor = new Vector4(0.75f,0.75f,1f,1f);
	}

	public void OnPointerDown(PointerEventData pointerEventData)
	{
		SelectCard();
	}

	private void SelectCard()
	{
		if (isSelected)
		{
			isSelected = false;
		}
		else
		{
			isSelected = true;
		}

		if (isSelected)
		{
			if (player == 1)
			{
				gameObject.transform.position += Vector3.up * Screen.height / 30f;
			}
			else
			{
				gameObject.transform.position += Vector3.down * Screen.height / 30f;
			}
			gameObject.GetComponent<Image>().color = selectedColor;
		}
		else
		{
			gameObject.transform.localPosition = Vector3.zero;
			gameObject.GetComponent<Image>().color = initialColor;
		}
	}

	private static string GetCardType()
	{
		string type = null;

		return type;
	}
}