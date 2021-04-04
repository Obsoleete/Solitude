﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour, ISInteractable
{   
    private GameObject gameChar;
    public GameObject torch1;
    public GameObject torch2;
    public GameObject torch3;

    // Start is called before the first frame update
    void Start()
    {
        gameChar = GameObject.Find("GameChar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ISInteractable.interact()
    {   
        gameChar.GetComponent<Transform>().position = new Vector3(gameChar.GetComponent<Transform>().position.x, gameChar.GetComponent<Transform>().position.y, -33.12299f);
        gameChar.GetComponent<CharControl>()._withTorch = true;
        gameChar.GetComponent<Animator>().SetBool("WithTorch", true);
        gameObject.GetComponent<Renderer>().enabled = false;
        gameChar.GetComponent<CharControl>().startListening();
        StopAllCoroutines();
        StartCoroutine(TakeTorch());
        torch1.SetActive(false);
        torch2.SetActive(false);
        torch3.SetActive(false);
    }

    private IEnumerator TakeTorch()
    {   
        yield return new WaitForSeconds(1.6f);
        gameChar.GetComponent<CharControl>().endListening();
    }
}
