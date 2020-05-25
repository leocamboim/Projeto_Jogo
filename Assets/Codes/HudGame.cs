using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudGame : MonoBehaviour
{
    public FpsWalk jogador;
    public Text timegame;
    public GameObject canvasDefeat;

    public float mytime;
    public float timeWin = 30f;
    // Start is called before the first frame update
    void Start()
    {
        canvasDefeat.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TimeSpan mytimespan = TimeSpan.FromSeconds(mytime);
        mytime += Time.deltaTime;
        timegame.text = mytimespan.ToString();

        if (mytime >= timeWin)
        {
            Cursor.lockState = CursorLockMode.None;
            canvasDefeat.SetActive(true);
        }
    }
}
