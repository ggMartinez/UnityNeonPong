using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreMouse : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject selectedObj;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    
}
