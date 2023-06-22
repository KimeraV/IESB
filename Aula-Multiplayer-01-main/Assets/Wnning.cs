using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.Netcode;
using UnityEngine.SceneManagement;

public class Wnning : NetworkBehaviour
{
    int contador;
    public int bolinhas;
    [SerializeField] TextMeshProUGUI bolinhaTXT;
    [SerializeField] CanvasRenderer vitoria;
    [SerializeField] CanvasRenderer derrota;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("contadores"))
        {
            contador++;
        }
    }
    void Update()
    {
        if (contador == 1)
        {
            bolinhas = 1;
            bolinhaTXT.text = "Bolinhas: 1/6";
        }
        else if (contador == 2)
        {
            bolinhas = 2;
            bolinhaTXT.text = "Bolinhas: 2/6";
        }
        else if (contador == 3)
        {
            bolinhas = 3;
            bolinhaTXT.text = "Bolinhas: 3/6";
        }
        else if (contador == 4)
        {
            bolinhas = 4;
            bolinhaTXT.text = "Bolinhas: 4/6";
        }
        else if (contador == 5)
        {
            bolinhas = 5;
            bolinhaTXT.text = "Bolinhas: 5/6";
        }
        else if (contador == 6)
        {
            bolinhas = 6;
            bolinhaTXT.text = "Bolinhas: 6/6";
        }
        else if (contador == 6)
        {
            
        }
    }
    [ServerRpc]
    void EndGameServerRpc()
    {
        EndGameClientRpc();
    }

    [ClientRpc]
    void EndGameClientRpc()
    {
        if (IsOwner)
        {
            vitoria.gameObject.SetActive(true);
        }
        else
        {
            derrota.gameObject.SetActive(true);
        }
    }
}
