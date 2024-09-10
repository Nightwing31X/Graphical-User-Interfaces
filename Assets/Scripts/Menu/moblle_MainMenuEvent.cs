using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moblle_MainMenuEvent : MonoBehaviour
{
    public void ExitToDesktop()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
}
