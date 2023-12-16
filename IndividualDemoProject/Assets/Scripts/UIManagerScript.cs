using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    public GameObject startButton;
    public GameObject detailButton;
    public GameObject backButton;
    public GameObject gameTitle;
    public GameObject detailPage;
    public GameObject controlButton;
    public GameObject controlPage;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


    public void gameDetails()
    {
        gameTitle.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        detailButton.gameObject.SetActive(false);
        controlButton.gameObject.SetActive(false);
        detailPage.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
    }

    public void back()
    {
        detailPage.gameObject.SetActive(false);
        backButton.gameObject.SetActive(false);
        controlPage.gameObject.SetActive(false); ;
        gameTitle.gameObject.SetActive(true);
        startButton.gameObject.SetActive(true);
        detailButton.gameObject.SetActive(true);
        controlButton.gameObject.SetActive(true);
    }

    public void Controls()
    {
        gameTitle.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        detailButton.gameObject.SetActive(false);
        controlButton.gameObject.SetActive(false); 
        detailPage.gameObject.SetActive(false);
        controlPage.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
    }
}
