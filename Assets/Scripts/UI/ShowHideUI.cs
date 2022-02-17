using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideUI : MonoBehaviour
{
	[SerializeField] KeyCode toggleKey = KeyCode.Escape;
	[SerializeField] GameObject uiContainer = null;

	// Start is called before the first frame update
	void Start()
	{
		if (uiContainer != null)
			uiContainer.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(toggleKey))
		{
			if (uiContainer != null)
				uiContainer.SetActive(!uiContainer.activeSelf);

		}
	}
}
