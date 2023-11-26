using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindTarget : MonoBehaviour
{
    public static FindTarget instancia;

    public List<Transform> listaDeInimigos = new();
    public Transform inimigoLockado;
    public Transform hudDoTarget;
    public bool lockLigado;

    Image imagemComOHP;

    // Start is called before the first frame update
    void Awake()
    {
        instancia = this;

        //Sumir com o mouse!
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        imagemComOHP = hudDoTarget.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(inimigoLockado != null)
        {
            //CRIME! GetComponent é pesado
            Danable danoDoInimigo = 
                inimigoLockado.GetComponent<Danable>();
            float porcentagem = 
                (float)danoDoInimigo.HPAtual / 
                danoDoInimigo.maxHP;

            imagemComOHP.fillAmount = porcentagem;
        }


        if (Input.GetMouseButtonDown(2))
        {
            if (lockLigado)
            {
                lockLigado = false;
                hudDoTarget.GetComponent<Image>().color = Color.white;
            }
            else if (inimigoLockado != null)
            {
                lockLigado = true;
                hudDoTarget.GetComponent<Image>().color = Color.black;
            }
        }

        if (!lockLigado) { 
            inimigoLockado = null;
            float menorDistancia = 99999;
            foreach (Transform inimigo in listaDeInimigos)
            {
                Vector3 posicaoNaTela =
                    Camera.main.WorldToScreenPoint(inimigo.position);
                Vector3 meioDaTela =
                    Camera.main.ViewportToScreenPoint(
                        new Vector2(0.5f, 0.5f)
                        );

                float distanciaDoMeio =
                    Vector3.Distance(posicaoNaTela, meioDaTela);
                if (distanciaDoMeio < menorDistancia)
                {
                    inimigoLockado = inimigo;
                    menorDistancia = distanciaDoMeio;
                }
            }
        }

        if(inimigoLockado == null)
        {
            hudDoTarget.gameObject.SetActive(false);
        }
        else
        {
            hudDoTarget.gameObject.SetActive(true);
            hudDoTarget.position = Camera.main.WorldToScreenPoint(
                inimigoLockado.position
                );
        }
    }
}
