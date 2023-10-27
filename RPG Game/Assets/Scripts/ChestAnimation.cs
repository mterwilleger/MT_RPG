using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ChestAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    
    void OnTriggerEnter2D (Collider2D collision)
    {
        if(!PhotonNetwork.IsMasterClient)
            return;

        if(collision.CompareTag("Player"))
        {
            //Debug.Log("Trigger");
            myAnimationController.SetBool("Open", true);
            PhotonNetwork.Destroy(gameObject);
        }
    }
}
