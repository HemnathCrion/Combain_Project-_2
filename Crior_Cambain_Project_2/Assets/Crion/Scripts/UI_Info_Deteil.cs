using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class InfoButtonData
{
    public string assetName;
    public string description;
    public Button button;
}

public class UI_Info_Deteil : MonoBehaviour
{
    public GameObject infoButtonPanel;
    public GameObject infoDetailPanel;
    public GameObject infoDuplicatePanel;

    public UI_Info_Text uiInfoText;

    public List<InfoButtonData> infoButtons;

    void Start()
    {
        HideAllPanels();

        foreach (var infoData in infoButtons)
        {
            string name = infoData.assetName;
            string desc = infoData.description;

            infoData.button.onClick.AddListener(() => ShowInfoDetailPanel(name, desc));
        }
    }

    public void ShowInfoButtonPanel()
    {
        HideAllPanels();
        infoButtonPanel.SetActive(true);
    }

    public void ShowDuplicatePanel()
    {
        HideAllPanels();
        infoDuplicatePanel.SetActive(true);
    }

    public void ShowInfoDetailPanel(string name, string description)
    {
        HideAllPanels();
        infoDetailPanel.SetActive(true);
        uiInfoText.ShowAssetPanel(name, description);
    }

    public void HideAllPanels()
    {
        infoButtonPanel.SetActive(false);
        infoDetailPanel.SetActive(false);
        infoDuplicatePanel.SetActive(false);
    }
}
