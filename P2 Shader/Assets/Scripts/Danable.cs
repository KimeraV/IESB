using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danable : MonoBehaviour
{
    public int maxHP = 10;
    public int HPAtual;
    private void Start()
    {
        HPAtual = maxHP;
    }
    public void TomarDano(int quantoDeDano)
    {
        HPAtual -= quantoDeDano;
        if(HPAtual <= 0 )
        {
            Destroy(gameObject);
        }
    }
}
