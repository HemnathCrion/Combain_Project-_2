using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Look_Panel : MonoBehaviour
{
    public GameObject targetTransform;
    public Button backButton;
    private void Start()
    {
        backButton.onClick.AddListener(ShowBackButton);
    }
    void Update()
    {
        transform.LookAt(targetTransform.transform);
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + 180 , 0);
    }

    public void ShowBackButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
