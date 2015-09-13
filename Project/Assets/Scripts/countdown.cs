﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class countdown : MonoBehaviour {

    [SerializeField]
    public float CountdownFrom;
    [SerializeField]
    public Text CountdownText;

    void Start() {
        GetComponent<AudioSource>().Play();
        if (CountdownText == null) {
            Debug.LogError("STATUS INDICATOR: No text object referenced!");
        }
    }
    void Update()
    {
        float time = CountdownFrom - Time.timeSinceLevelLoad;
        CountdownText.text = time.ToString("0");

        if (time < 1f) {
            CountdownText.text = "GO!";
        }
        if (time < 0)
        {
            TimeUp();
        }
    }

    void TimeUp()
    {
        Destroy(gameObject);
    }
}
