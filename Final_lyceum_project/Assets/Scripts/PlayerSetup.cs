using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

[System.Obsolete]
public class PlayerSetup : NetworkBehaviour
{
    [SerializeField]
    public Behaviour[] componetsToDisable;

    private void Start()
    {
        if (!isLocalPlayer)
        {
            for (int i = 0; i < componetsToDisable.Length; i++)
            {
                componetsToDisable[i].enabled = false;
            }
        }
    }

}
