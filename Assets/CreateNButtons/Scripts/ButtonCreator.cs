using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;



public class ButtonCreator : MonoBehaviour
{
	UIDocument uiButtonContainer;
	public VisualTreeAsset itemButtonTemplate;

	public List<string> buttonTexts;

	private void OnEnable()
	{
		uiButtonContainer = GetComponent<UIDocument>();

		foreach(string buttonText in buttonTexts)
		{
            //itemButtonTemplate.name = button.itsName;
            TemplateContainer itemButtonContainer = itemButtonTemplate.Instantiate();
            uiButtonContainer.rootVisualElement.Q("ButtonColumn").Q("ButtonContainer").Add(itemButtonContainer);
			Button el = uiButtonContainer.rootVisualElement.Q("ButtonColumn").Q("ButtonContainer").Q<Button>("It");
            //el.name = button.itsName;
            el.name = "InstButton";
			//el.text = button.displayText;
			el.text = buttonText;
            //el.AddToClassList(button.itsClass);
            el.AddToClassList("_button");
        }
	}
}
