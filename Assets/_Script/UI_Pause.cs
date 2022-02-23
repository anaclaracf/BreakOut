using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Pause : MonoBehaviour
{

    GameManager gm;

    private void OnEnable(){
        gm = GameManager.GetInstance();
    }

    public void Retornar(){
        gm.ChangeState(GameManager.GameState.GAME);
        gm.counter = true;
    }

    public void Inicio(){
        gm.counter = false;
        gm.tempo = 120;
        gm.ChangeState(GameManager.GameState.MENU);
    }

    void Start(){}
    void Update(){}
}
