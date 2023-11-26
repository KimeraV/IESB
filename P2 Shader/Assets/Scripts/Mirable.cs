using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirable : MonoBehaviour
{
    private void Start()
    {
        if (GetComponent<Renderer>().isVisible)
        {
            if (!FindTarget.instancia.listaDeInimigos.Contains(transform))
            {
                FindTarget.instancia.listaDeInimigos.Add(transform);
            }
        }
    }

    private void OnBecameVisible()
    {
        FindTarget.instancia.listaDeInimigos.Add(transform);
    }
    private void OnBecameInvisible()
    {
        FindTarget.instancia.listaDeInimigos.Remove(transform);
    }
}
