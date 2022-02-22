using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocoSpawner : MonoBehaviour
{
    public GameObject Bloco;
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
        GameManager.changeStateDelegate += Construir;
        Construir();
    }

    void Construir(){
        if(gm.gameState == GameManager.GameState.GAME){
            foreach (Transform child in transform){
                GameObject.Destroy(child.gameObject);
            }
            for(int i=0; i<12; i++){
                for(int j=0; j<4; j++){
                    Vector3 posicao = new Vector3(-9 + 1.58f*i, 3.5f - 0.58f*j);
                    GameObject instance = Instantiate(Bloco, posicao, Quaternion.identity, transform);
                    instance.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f),1f);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount <= 0 && gm.gameState == GameManager.GameState.GAME){
            gm.ChangeState(GameManager.GameState.ENDGAME);
        }
    }
}
