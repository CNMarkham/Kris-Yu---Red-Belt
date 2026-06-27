using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;
    public CodeyMove codeySpeed;

    public GameObject YouLost;

    private void Start()
    {
        YouLost.SetActive(false);
    }

    void Update()
    {
        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
        }
        else
        {
            startCountdown.gameObject.SetActive(false);
            codeySpeed.Speed = 25;
            totalLapTime -= Time.deltaTime;
        }
        if (totalLapTime <= 0)
        {
            YouLost.SetActive(true);
        }

        lapTime.text = Mathf.Round(totalLapTime).ToString();
        startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
    }
}
