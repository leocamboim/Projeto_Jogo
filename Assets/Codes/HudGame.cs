using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudGame : MonoBehaviour
{
    public FpsWalk jogador;
    public Text timegame;

    public float mytime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan mytimespan = TimeSpan.FromSeconds(mytime);
        mytime += Time.deltaTime;
        timegame.text = mytimespan.ToString();
    }
}
