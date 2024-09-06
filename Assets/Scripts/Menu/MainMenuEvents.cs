using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainMenu.UI
{
    public class MainMenuEvents : MonoBehaviour
    { 
        [SerializeField] GameObject backMobileBTNs;
        [SerializeField] GameObject backPCBTNs;
        bool mobile;
        bool PC;
        string m_DeviceType;

        public void ExitToDesktop()
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
            Application.Quit();
        }
        public void Openurl(string UrlName)
        {
            Application.OpenURL(UrlName);
        }

        void Awake()
        {
            backMobileBTNs.SetActive(false);
            backPCBTNs.SetActive(false);
        }

        void Start()
        {
            //Check if the device running this is a desktop
            if (SystemInfo.deviceType == DeviceType.Desktop)
            {
                m_DeviceType = "Desktop";
                PC = true;
                pcSettings();
            }

            //Check if the device running this is a handheld
            if (SystemInfo.deviceType == DeviceType.Handheld)
            {
                m_DeviceType = "Handheld";
                mobile = true;
                mobileSettings();
                //mobileBTNs.SetActive(true);
            }
            Debug.Log("Device type : " + m_DeviceType);
        }

        void mobileSettings()
        {
            if (mobile == true)
            {
                backPCBTNs.SetActive(!mobile);
                backMobileBTNs.SetActive(mobile);
            }
        }

        void pcSettings()
        {
            if (PC == true)
            {
                backPCBTNs.SetActive(PC);
                backMobileBTNs.SetActive(!PC);
            }
        }
    }
}