﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class photoUsernameRegister : MonoBehaviour {
    

    private bool alreadyRegistered = false;

    public InputField usernameInput;

    public GameObject objectParent;

    public GameObject createButton;



    void Awake()
    {
        checkRegister();
    }


    void checkRegister () 
    {
        if (!alreadyRegistered)
        {
            objectParent.SetActive(true);
        }
	}

    public void usernameInputChange()
    {
        if (usernameInput.text.Length >= 2)
        {
            createButton.SetActive(true);
        }
        else
        {
            createButton.SetActive(false);
        }
    }

    public void createUsername()
    {
        PhotonNetwork.playerName = usernameInput.text;
        objectParent.SetActive(false);
        Debug.Log("This machine name is: " + PhotonNetwork.playerName);
    }
}
