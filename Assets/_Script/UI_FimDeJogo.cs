using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_FimDeJogo : MonoBehaviour
{
    public Text message;
    GameManager gm;
    // Start is called before the first frame update
    
    private void OnEnable(){

        gm = GameManager.GetInstance();

        if (gm.vidas > 0){
            message.text = "YOU WIN!";
        }else{
            message.text = "GAME OVER";
        }
    }

    public void Voltar(){
        gm.ChangeState(GameManager.GameState.GAME);
        gm.counter = true;
    }

    void Start(){}
    void Update(){}
}
