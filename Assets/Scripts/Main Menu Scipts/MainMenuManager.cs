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
    [SerializeField] private Button pongButton;
    [SerializeField] private Button shooterButton;

    void Awake() {
        Cursor.lockState = CursorLockMode.None;
    }

    // Start is called before the first frame update
    void Start() 
    {
        startButton.onClick.AddListener(() => { LoadingScreen.LoadScene("GameScene1"); } );
        openCredits.onClick.AddListener(() => { creditsPanel.SetActive(true); } );
        platformerButton.onClick.AddListener(() => { LoadingScreen.LoadScene("NotQuitePlatformer"); } );
        closeCreditsButton.onClick.AddListener(() => { creditsPanel.SetActive(false); } );
        threeDButton.onClick.AddListener(() => { LoadingScreen.LoadScene("3DSpawn"); } );
        pongButton.onClick.AddListener(() => { LoadingScreen.LoadScene("Pong"); } );
        shooterButton.onClick.AddListener(() => { LoadingScreen.LoadScene("Shooter"); } );
    }
}
