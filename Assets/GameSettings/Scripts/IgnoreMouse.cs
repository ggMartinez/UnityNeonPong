using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IgnoreMouse : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject selectedObj;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        selectedObj = EventSystem.current.currentSelectedGameObject;
    }

    void Update()
	{
		if (EventSystem.current.currentSelectedGameObject == null)
			EventSystem.current.SetSelectedGameObject(selectedObj);
	
		selectedObj = EventSystem.current.currentSelectedGameObject;
	}
}
