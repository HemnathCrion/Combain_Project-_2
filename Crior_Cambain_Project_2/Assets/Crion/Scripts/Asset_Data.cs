using UnityEngine;

public class Asset_Data : MonoBehaviour
{
    public Vector3 offest = new Vector3(0, 1.5f, 0);
    public Transform canvastransform;
    public UI_Info_Deteil Info_Deteil;

    private void OnMouseDown()
    {
        canvastransform.position = transform.position + offest;
        Info_Deteil.infoButtonPanel.SetActive(true);
        Info_Deteil.infoDetailPanel.SetActive(false);
    }
}
