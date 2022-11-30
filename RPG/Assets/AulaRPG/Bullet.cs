using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float duracao;
    public PlayerAttack ataque;
    public PlayerStats status;
    public GameObject particula;

    public void Start()
    {
        Destroy(gameObject, duracao);

        if (status.armaAtual == 2)
        {
            particula.SetActive(true);
        }

    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Inimigo") && status.armaAtual == 1)
        {
            ataque.AcertouPistola();
            Destroy(gameObject);
        }
        else
        {
            if (other.collider.CompareTag("Inimigo") && status.armaAtual == 2)
            {
                ataque.AcertouCajado();
                Destroy(gameObject);
            }
        }
    }
}
