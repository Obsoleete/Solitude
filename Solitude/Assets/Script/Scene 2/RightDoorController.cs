﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RightDoorController : MonoBehaviour, ISInteractable
{   
    public GameObject _interactable;
    public SceneFade _sceneFade;
    private Animator _animator;
    private AudioSource _doorSFX;
    private Scene2Controller _scene2Controller;

    // Start is called before the first frame update
    void Start()
    {
        _doorSFX = gameObject.GetComponent<AudioSource>();
        _animator = gameObject.GetComponent<Animator>();
        _scene2Controller = GameObject.FindObjectOfType<Scene2Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ISInteractable.interact()
    {   
        _doorSFX.Play();
        _animator.SetBool("CanOpen", true);
        _scene2Controller.GoNext();
    }

}
