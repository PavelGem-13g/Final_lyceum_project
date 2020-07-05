using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoomFuncrionsScr : MonoBehaviourPunCallbacks
{
    public GameObject text;
    void Start()
    {
        PhotonNetwork.NickName = "Player " + Random.Range(0, 100);
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
        Log("New player's nick: " + PhotonNetwork.NickName);

    }
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom("Server_name"+Random.Range(0,100),new Photon.Realtime.RoomOptions{MaxPlayers = 2});
        Log("Room was created");
    }
    public void JoinToRoom()
    {
        PhotonNetwork.JoinRandomRoom();
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(0);
        Log("You joined to room");
    }
    public override void OnConnectedToMaster()
    {
        Log("You connetcted to  Master server");
    }
    void Log(string message)
    {
        text.GetComponent<TextMeshProUGUI>().text += "\n" + message;
    }
}
