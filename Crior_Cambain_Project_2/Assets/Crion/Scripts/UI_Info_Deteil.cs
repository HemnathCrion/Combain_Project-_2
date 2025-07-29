using System.Collections;
using System.Collections.Generic;
using TMPro;
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
    public Button infoButton;
    public GameObject infoButtonPanel;
    public GameObject infoDetailPanel;
    public List<InfoButtonData> infoButtons;
    public UI_Info_Text uiInfoText;
    void Start()
    {
        infoButtonPanel.SetActive(false);
        infoDetailPanel.SetActive(false);
          foreach(var infodata in infoButtons)
        {
            infodata.button.onClick.AddListener(() => ShowCustomInfo(infodata.assetName, infodata.description));
        }
        
    }

    public void ShowCustomInfo(string name, string description)
    {
        infoButtonPanel.SetActive(false);
        infoDetailPanel.SetActive(true);
        uiInfoText.ShowAssetPanel(name, description);
    }
   
}
