using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAppear : MonoBehaviour
{
	public Book bookObj;
	public GameObject LeftButton;
	public GameObject RightButton;
	
	public bool hideRightButton;
	public bool hideLeftButton;
	
	void Awake()
	{
		hideRightButton = false;
		hideLeftButton = true;
	}
	
	void Update()
	{		
		if(bookObj.currentPage == 1)
			ClickToAppearLeftButton(true);
		else
			ClickToAppearLeftButton(false);
		
		if(bookObj.currentPage == bookObj.bookPages.Length)
			ClickToAppearRightButton(true);
		else
			ClickToAppearRightButton(false); 
	}

	public void ClickToAppearLeftButton(bool hideLeftButton)
	{
		if(hideLeftButton)
			LeftButton.gameObject.SetActive(false);
		else
			LeftButton.gameObject.SetActive(true);
	}

	public void ClickToAppearRightButton(bool hideRightButton)
	{
		if (hideRightButton)
			RightButton.gameObject.SetActive(false);
		else
			RightButton.gameObject.SetActive(true);
	}
}