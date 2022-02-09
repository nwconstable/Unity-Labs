using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button openCredits;
    [SerializeField] private Button closeCreditsButton;
    [SerializeField] private GameObject creditsPanel;
    [SerializeField] private Button platformerButton;
    [SerializeField] private Button threeDButton;

    // Start is called before the first frame update
    void Start() 
    {
        startButton.onClick.AddListener(() => { LoadingScreen.LoadScene("GameScene1"); } );
        openCredits.onClick.AddListener(() => { creditsPanel.SetActive(true); } );
        platformerButton.onClick.AddListener(() => { LoadingScreen.LoadScene("NotQuitePlatformer"); } );
        closeCreditsButton.onClick.AddListener(() => { creditsPanel.SetActive(false); } );
        threeDButton.onClick.AddListener(() => { LoadingScreen.LoadScene("GameScene3D"); } );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
