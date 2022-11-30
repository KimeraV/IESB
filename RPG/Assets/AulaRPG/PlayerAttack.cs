using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Animator anim;

    public Transform atacando;
    PlayerStats stats;

    public Transform spawn;
    public GameObject prefab, particulaPistola, particulaCajado;
    public float velocidadeBala;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        stats = GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stats.armaAtual == 0)
        {
            if (atacando != null)
            {
                if (Vector3.Distance(transform.position,
                    atacando.position) < 3)
                {
                    if (stats.barraDeEstamina.fillAmount == 1)
                    {
                        anim.SetTrigger("Ataque");
                    }
                }
            }
            else
            {
                anim.ResetTrigger("Ataque");
            }
        }

        if (stats.armaAtual == 1)
        {
            if (atacando != null)
            {
                if (Vector3.Distance(transform.position,
                    atacando.position) < 12)
                {
                    if (stats.barraDeEstamina.fillAmount == 1)
                    {
                        anim.SetTrigger("Ataque");
                        transform.LookAt(atacando);
                        var bullet = Instantiate(prefab, spawn.position, spawn.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = spawn.forward * velocidadeBala;
                        bullet.GetComponent<Bullet>().ataque = GetComponent<PlayerAttack>();
                        bullet.GetComponent<Bullet>().status = GetComponent<PlayerStats>();
                        particulaPistola.SetActive(false);
                        particulaPistola.SetActive(true);
                        stats.barraDeEstamina.fillAmount = 0;

                    }
                }
            }
            else
            {
                anim.ResetTrigger("Ataque");
            }
        }

        if (stats.armaAtual == 2)
        {
            if (atacando != null)
            {
                if (Vector3.Distance(transform.position,
                    atacando.position) < 6)
                {
                    if (stats.barraDeEstamina.fillAmount == 1)
                    {
                        anim.SetTrigger("Ataque");
                        transform.LookAt(atacando);
                        var bullet = Instantiate(prefab, spawn.position, spawn.rotation);
                        bullet.GetComponent<Rigidbody>().velocity = spawn.forward * velocidadeBala;
                        bullet.GetComponent<Bullet>().ataque = GetComponent<PlayerAttack>();
                        bullet.GetComponent<Bullet>().status = GetComponent<PlayerStats>();
                        particulaCajado.SetActive(false);
                        particulaCajado.SetActive(true);
                        stats.barraDeEstamina.fillAmount = 0;
                    }
                }
            }
            else
            {
                anim.ResetTrigger("Ataque");
            }
        }
    }

    public void Acertou()
    {
        stats.barraDeEstamina.fillAmount = 0;
        stats.GanharXP(
            atacando.GetComponent<InimigoRPG>().
                TomarDano(stats.forca)
            );
    }

    public void AcertouPistola()
    {
        stats.GanharXP(
            atacando.GetComponent<InimigoRPG>().
                TomarDano(stats.destreza)
            );
    }

    public void AcertouCajado()
    {
        stats.GanharXP(
            atacando.GetComponent<InimigoRPG>().
                TomarDano(stats.inteligencia)
            );
    }

}
