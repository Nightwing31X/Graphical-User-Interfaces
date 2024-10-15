using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InputFieldControl : MonoBehaviour
{
    EventSystem system;
    bool holdingKey;
    void Start()
    {
        system = EventSystem.current;

    }
    public void Update()
    {

        if (!holdingKey)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                Selectable next = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();

                if (next != null)
                {

                    InputField inputfield = next.GetComponent<InputField>();
                    if (inputfield != null) inputfield.OnPointerClick(new PointerEventData(system));

                    system.SetSelectedGameObject(next.gameObject, new BaseEventData(system));
                }
                //else
                //{
                //    Debug.Log("next nagivation element not found");
                //}
            }
        }
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            holdingKey = true;
            Debug.Log("Testing...");
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                Debug.Log("Testing...");
                Selectable back = system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();

                if (back != null)
                {

                    InputField inputfield = back.GetComponent<InputField>();
                    if (inputfield != null) inputfield.OnPointerClick(new PointerEventData(system));

                    system.SetSelectedGameObject(back.gameObject, new BaseEventData(system));
                }
                //else
                //{
                //    Debug.Log("back nagivation element not found");
                //}
            }
        }
        else
        {
            holdingKey = false;
        }
    }
}