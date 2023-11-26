using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpFiller : MonoBehaviour
{
    public Image lifeBarFill;
    public float maxHP = 100f, currentHP, fillAmount, SkellyDamage;

    // Singleton instance
    private static HpFiller instance;

    public bool pauseCoroutine = false, GameStart = true;

    public GameObject LosingMessage, WinningMessage, TutorialMessage;

    public static HpFiller Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<HpFiller>();
                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("HpFillerSingleton");
                    instance = singletonObject.AddComponent<HpFiller>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        currentHP = maxHP;

        TutorialMessage.gameObject.SetActive(true);
        Time.timeScale = 0f;
        
    }

    void Update()
    {
        fillAmount = currentHP / maxHP;
        lifeBarFill.fillAmount = fillAmount;

        if(currentHP == 0)
        {
            StartCoroutine(TogglePauseLose());
        }
        
        if (Input.GetKeyDown(KeyCode.T))
        {
            TutorialMessage.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void TakeDamage()
    {
        currentHP = currentHP - SkellyDamage;
    }

    IEnumerator TogglePauseLose()
    {
        currentHP++;
        LosingMessage.gameObject.SetActive(true);
        pauseCoroutine = !pauseCoroutine;
        
        while (pauseCoroutine)
        {
            yield return null;
            Time.timeScale = 0f;

            if (Input.GetKeyDown(KeyCode.R))
            {
                pauseCoroutine = !pauseCoroutine;
            }
        }

        Time.timeScale = 1f;
        LosingMessage.gameObject.SetActive(false);
        ReloadScene();
        yield break;
    }

    public IEnumerator TogglePauseWin()
    {
        WinningMessage.gameObject.SetActive(true);
        pauseCoroutine = !pauseCoroutine;
        
        while (pauseCoroutine)
        {
            yield return null;
            Time.timeScale = 0f;

            if (Input.GetKeyDown(KeyCode.R))
            {
                pauseCoroutine = !pauseCoroutine;
            }
        }

        Time.timeScale = 1f;
        WinningMessage.gameObject.SetActive(false);
        ReloadScene();
        yield break;
    }


    void ReloadScene()
    {
        // Obtém o nome da cena atual
        string currentSceneName = SceneManager.GetActiveScene().name;

        // Recarrega a cena atual
        SceneManager.LoadScene(currentSceneName);
    }
}