using UnityEngine;

public class Asset_Data : MonoBehaviour
{
    public enum PanelType
    {
        InfoButtonPanel,
        InfoDuplicatePanel
    }

    public PanelType panelType;
    public Vector3 offest = new Vector3(0, 1.5f, 0);
    public Transform canvastransform;
    public UI_Info_Deteil Info_Deteil;

    private void OnMouseDown()
    {
        canvastransform.position = transform.position + offest;

        switch (panelType)
        {
            case PanelType.InfoButtonPanel:
                Info_Deteil.ShowInfoButtonPanel();
                break;
            case PanelType.InfoDuplicatePanel:
                Info_Deteil.ShowDuplicatePanel();
                break;
        }
    }
}
