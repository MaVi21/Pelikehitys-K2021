using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameMenu : MonoBehaviour
{

    bool menuOpen = false;
    public GameObject mainMenuPanel;
    public GameObject objectivesMenuPanel;
    public GameObject settingsPanel;

    // Start is called before the first frame update
    void Start()
    {
        HideAllMenus();
    }

    // Update is called once per frame
    void Update()
    {
        //Listen for Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            ShowMainMenu();
        }
    }

    public void QuitGame()
    {

#if UNITY_EDITOR
        //emulate quit game in editor context
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void HideAllMenus()
    {
        mainMenuPanel.SetActive(false);
        objectivesMenuPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }

    public void ShowMainMenu()
    {
        HideAllMenus();
        mainMenuPanel.SetActive(true);
    }

    public void ShowObjectivesPanel()
    {
        HideAllMenus();
        objectivesMenuPanel.SetActive(true);
    }

    public void ShowSettingsPanel()
    {
        HideAllMenus();
        settingsPanel.SetActive(true);
    }
}
