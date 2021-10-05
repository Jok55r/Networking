using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : NetworkBehaviour
{
    public int HP = 100;
    public Text hpText;

    private void OnCollisionEnter(Collision collision)
    {
        if (isLocalPlayer && collision.gameObject.tag == "Player")
        {
            HP =- 1;
            hpText.text = HP.ToString();
        }
    }
}