using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FpsCounter : MonoBehaviour
{
    public float timer, refresh, avgFramerate;
    public string display = "0";
    public Text m_Text;
    public Text MaxFps_Text;
    public float MaxFps;
    public Text ZombieCount_Text;
    public float NrZombie;
    public float MinFps;
    public Text MinFps_Text;
    public Button Results;
    // Start is called before the first frame update
    void Start()
    {
        Results.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float timelapse = Time.smoothDeltaTime;
        timer = timer <= 0 ? refresh : timer -= timelapse;

        if (timer <= 0)
        {
            avgFramerate = (int)(1f / timelapse);
            if (avgFramerate > MaxFps) MaxFps = avgFramerate;
            if (avgFramerate < MinFps && avgFramerate > 15) MinFps = avgFramerate;
            

        }

        m_Text.text = string.Format(display, avgFramerate.ToString());
        MaxFps_Text.text = string.Format(display, MaxFps.ToString());
        MinFps_Text.text = string.Format(display, MinFps.ToString());

        NrZombie = GameObject.FindGameObjectsWithTag("Enemy").Length;

        ZombieCount_Text.text = string.Format(display, NrZombie.ToString());
        BazaDeDate.UsernameSave.MaxFrames = MaxFps;
        BazaDeDate.UsernameSave.MinFrames = MinFps;
        BazaDeDate.UsernameSave.NrZomb = NrZombie;


        if (NrZombie >= 1000)
        {
            Results.enabled = true;
        }
        
        
        
    }
}
