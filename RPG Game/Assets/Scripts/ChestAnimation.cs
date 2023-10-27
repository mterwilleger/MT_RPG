using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ChestAnimation : MonoBehaviour
{

    void OnTriggerEnter2D (Collider2D collision)
    {
        if(!PhotonNetwork.IsMasterClient)
            return;

        if(collision.CompareTag("Player"))
        {
            PhotonNetwork.Destroy(gameObject);
        }
    }
}
