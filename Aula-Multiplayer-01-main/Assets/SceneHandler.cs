using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.SceneManagement;
using System;

public class SceneHandler : NetworkBehaviour
{
    [SerializeField] Transform playerPrefab;
    private bool initialSpawnDone = false;

    public void LoadGame()
    {
        if (!IsServer)
        {
            return;
        }

        //Carregar cena pelo NetworkManager;
        NetworkManager.Singleton.SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        NetworkManager.Singleton.SceneManager.OnLoadEventCompleted += SceneManager_OnLoadEventCompleted;
    }

    public void SceneManager_OnLoadEventCompleted(string sceneName, LoadSceneMode loadSceneMode, List<ulong> clientsCompleted, List<ulong> clientsTimedOut)
    {
        if (!initialSpawnDone && sceneName == "SampleScene")
        {
            initialSpawnDone = true;
            foreach (ulong id in NetworkManager.Singleton.ConnectedClientsIds)
            {
                //Instanciar o objeto player;
                Transform playerTransform = Instantiate(playerPrefab);

                //Usar a funcao de "SpawnAsPlayerObject" dentro do NetworkObject para conectar o player;
                NetworkObject networkObject = playerTransform.GetComponent<NetworkObject>();

                networkObject.SpawnAsPlayerObject(id, true);
            }
        }
    }
}
