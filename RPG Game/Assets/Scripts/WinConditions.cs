using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class WinConditions : MonoBehaviourPun
{
    void OnTriggerEnter2D (Collider2D collision)
    {
        if(!PhotonNetwork.IsMasterClient)
            return;

        PhotonNetwork.Destroy(gameObject);
    }
}
