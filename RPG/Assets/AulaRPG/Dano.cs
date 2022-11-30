using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public InimigoRPG inimigo;
    public GameObject dano;
    public TextMeshProUGUI danoTexto;
    Coroutine rotina;


    // Start is called before the first frame update
    void Start()
    {
        inimigo = GetComponent<InimigoRPG>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inimigo.danoTomado != 0)
        {
            if (rotina != null)
            {
                StopCoroutine(rotina);
                dano.SetActive(false);
            }
            rotina = StartCoroutine("AparecerDano");
        }
    }

    IEnumerator AparecerDano()
    {
        danoTexto.text = inimigo.danoTomado.ToString();
        inimigo.danoTomado = 0;
        dano.SetActive(true);
        yield return new WaitForSeconds(1);
        dano.SetActive(false);
        rotina = null;
    }
}

