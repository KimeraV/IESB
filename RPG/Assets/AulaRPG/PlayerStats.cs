using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    [Header("Armas")]
    public GameObject[] armas;
    public Sprite[] sprites;
    public Image icon;
    public RuntimeAnimatorController[] animators;

    public int armaAtual = 0;


    [Header("Refer�ncia")]
    public Image barraDeEstamina;
    public Image barraDeXP;
    public TextMeshProUGUI textoDeNivel;
    public GameObject janelaLevelUp;

    [Header("Stats")]
    public int hp = 5;
    public int forca = 1; //Machado fica mais forte
    public int destreza = 1; //Revolver fica mais forte
    public int inteligencia = 1; //Cetro fica mais forte
    public float estamina = 1; //Tempo entre os ataques

    public int nivelAtual;
    public int XP = 0; //Para mudar de nivel
    public int XPParaOProximo = 100; //Quanto precisa para upar
    public int nivelMaximo = 50;
    //Ao dar level UP, aumenta HP e stamina e tem 1 ponto
    //para distribuir onde quiser

    // Start is called before the first frame update
    void Start()
    {
        icon.sprite = sprites[0];
        armaAtual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach(GameObject go in armas)
            {
                go.SetActive(false);
            }
            armas[0].SetActive(true);
            armaAtual = 0;
            GetComponentInChildren<Animator>().
                runtimeAnimatorController = animators[0];
                icon.sprite = sprites[0];
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (GameObject go in armas)
            {
                go.SetActive(false);
            }
            armas[1].SetActive(true);
            armaAtual = 1;
            GetComponentInChildren<Animator>().
                runtimeAnimatorController = animators[1];
                icon.sprite = sprites[1];
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            foreach (GameObject go in armas)
            {
                go.SetActive(false);
            }
            armas[2].SetActive(true);
            armaAtual = 2;
            GetComponentInChildren<Animator>().
                runtimeAnimatorController = animators[2];
                icon.sprite = sprites[2];
        }



        barraDeEstamina.fillAmount += 
            estamina * Time.deltaTime;
    }

    public void GanharXP(int quantidade)
    {
        XP += quantidade;

        if(XP >= XPParaOProximo)
        {
            //LEVEL UP!
            nivelAtual++; // nivelAtual = nivelAtual +1
            textoDeNivel.text = nivelAtual.ToString();
            XPParaOProximo *= 2;
            XP = 0;

            estamina++; // Soma 1;
            janelaLevelUp.SetActive(true);
        }

        barraDeXP.fillAmount = 
            (float)XP / (float)XPParaOProximo;
    }
    public void AumentarForca()
    {
        forca++;
        janelaLevelUp.SetActive(false);
    }
    public void AumentarInteligencia()
    {
        inteligencia++;
        janelaLevelUp.SetActive(false);
    }
    public void AumentarDestreza()
    {
        destreza++;
        janelaLevelUp.SetActive(false);
    }
}
