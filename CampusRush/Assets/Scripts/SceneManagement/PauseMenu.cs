using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    GameObject menu;
    [SerializeField]
    GameObject settings;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            settings.GetComponent<SettingsMenu>().setRoot();
            settings.SetActive(false);
            menu.SetActive(!menu.activeSelf);
        }
    }
}