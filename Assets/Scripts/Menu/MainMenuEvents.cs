using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu.UI
{
    public class MainMenuEvents : MonoBehaviour
    {
        public void ExitToDesktop()
        {
            #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
            #endif
            Application.Quit();
        }
    }
}