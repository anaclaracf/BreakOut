using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Tempo : MonoBehaviour
{


    Text textComp;
    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        textComp = GetComponent<Text>();
        gm = GameManager.GetInstance();
        textComp.text = "02:00";
    }

    // Update is called once per frame
    void Update()
    {

        if (gm.counter){
            if (gm.tempo > 0 && gm.vidas > 0){
                if(gm.gameState == GameManager.GameState.PAUSE){
                    DisplayTime(gm.tempo);
                }else{
                    gm.tempo -= Time.deltaTime;
                    DisplayTime(gm.tempo);
                }
            }
            else{
                gm.tempo = 120;
                gm.counter = false;
                gm.ChangeState(GameManager.GameState.ENDGAME);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        textComp.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
