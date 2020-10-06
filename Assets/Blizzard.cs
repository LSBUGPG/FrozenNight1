﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class Blizzard : MonoBehaviour
{
    public AudioSource source;
    public AudioClip snow;
    public AudioClip blizzard;
    public float timeUntilblizzard = 20f;
    public float blizzardDuration = 30f;
    public Animator door;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Sequence());
    }

    // Update is called once per frame
    IEnumerator Sequence()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeUntilblizzard);
            source.clip = blizzard;
            source.Play();
            door.SetTrigger("Slam");
            yield return new WaitForSeconds(blizzardDuration);
            source.clip = snow;
            source.Play();
        }
    }
}
