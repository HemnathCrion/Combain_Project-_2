using UnityEngine;

public class Look_Panel : MonoBehaviour
{
    public GameObject targetTransform;
    void Update()
    {
        transform.LookAt(targetTransform.transform);
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + 180 , 0);
    }
}
