using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Screamer1 : MonoBehaviour
{

    public bool isActive = true;
    public GameObject lamp;
    public AudioSource sound;


    private void OnTriggerEnter(Collider other)
    {
    	if(other.CompareTag("Player"))
    	{
    		if (isActive);
    		isActive = false;
    		lamp.SetActive(false);
    		sound.Play();
    	}
    }
}
