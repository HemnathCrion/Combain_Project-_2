using TMPro;
using UnityEngine;

public class UI_Info_Text : MonoBehaviour
{
    public TextMeshProUGUI assetNameText;
    public TextMeshProUGUI descriptionNameText;

    public void ShowAssetPanel(string name, string description)
    {
        assetNameText.text = name;
        descriptionNameText.text = description;
    }
}
