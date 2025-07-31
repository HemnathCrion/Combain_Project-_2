using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triger_Dedection : MonoBehaviour
{
    public TextMeshProUGUI enterText;
    public TextMeshProUGUI dengorText;
    public GameObject enterPanel;
    public GameObject dangerPanel;
    public AudioSource audioSource;
    private void Start()
    {
       
        dangerPanel.SetActive(false);
        dengorText.enabled = false;
        enterPanel.SetActive(false);
        enterText.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Entered"))
        {
            enterPanel.SetActive(true);
            enterText.enabled = true;
            StartCoroutine(ShowText());
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Danger"))
        {
            
            dangerPanel.SetActive(true);
            dengorText.enabled = true;
            StartCoroutine(ShowText());
            Destroy(other.gameObject);
        }
        if (other.CompareTag("sceneChange"))
        {
            SceneChange();
            DontDestroyOnLoad(gameObject);
            Destroy(other.gameObject);


        }

    }
    public void AudioPlay()
    {
        audioSource.Play();
    }
    public void SceneChange()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );

    }
    public IEnumerator ShowText()
    {
        yield return new WaitForSeconds(1);
        enterPanel.SetActive(false);
        dangerPanel.SetActive(false );
    }
}
