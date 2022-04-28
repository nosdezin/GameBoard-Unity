using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class jogo : MonoBehaviour
{
    private int randomQuestion;
    private int fase;
    private int contador;
    public TMP_Text faseText;
    public Text pergunta;
    public Text contadorText;
    public Button botaoCorreto;
    public Button botaoFalso1;
    public Button botaoFalso2;
    public Button botaoFalso3;
    public TMP_Text txtBtnCorreto;
    public TMP_Text txtBtnFalse1;
    public TMP_Text txtBtnFalse2;
    public TMP_Text txtBtnFalse3;

    void Awake() {
        randomQuestion = Random.Range(1,10);
        fase = 1;
        contador = 20;
    }

    void Start() {
        switch (randomQuestion){
            case 1:
                pergunta.text = "X + 7 = 14";
                txtBtnCorreto.text = "7";
                txtBtnFalse1.text = "30";
                txtBtnFalse2.text = "2";
                txtBtnFalse3.text = "28";
                break;
            case 2:
                pergunta.text = "9 x X = 27";
                txtBtnCorreto.text = "3";
                txtBtnFalse1.text = "4";
                txtBtnFalse2.text = "2";
                txtBtnFalse3.text = "5";
                break;
            case 3:
                pergunta.text = "10 / X = 5";
                txtBtnFalse1.text = "3";
                txtBtnFalse2.text = "1,5";
                txtBtnFalse3.text = "1";
                txtBtnCorreto.text = "2";
                break;
            case 4:
                pergunta.text = "(x + b) * (x - b) = ?";
                txtBtnFalse1.text = "x³ - b³";
                txtBtnFalse2.text = "x - b³";
                txtBtnFalse3.text = "x - b";
                txtBtnCorreto.text = "x² - b²";
                break;
            case 5:
                pergunta.text = "x³ * x = ?";
                txtBtnFalse1.text = "x²";
                txtBtnFalse2.text = "x";
                txtBtnFalse3.text = "x^5";
                txtBtnCorreto.text = "x^4";
                break;
            case 6:
                pergunta.text = "√49 = ?";
                txtBtnFalse1.text = "8";
                txtBtnFalse2.text = "9";
                txtBtnFalse3.text = "6";
                txtBtnCorreto.text = "7";
                break;
            case 7:
                pergunta.text = "2³ = ?";
                txtBtnFalse1.text = "7";
                txtBtnFalse2.text = "6";
                txtBtnFalse3.text = "9";
                txtBtnCorreto.text = "8";
                break;
            case 8:
                pergunta.text = "20 + 45 = ?";
                txtBtnFalse1.text = "50";
                txtBtnFalse2.text = "60";
                txtBtnFalse3.text = "75";
                txtBtnCorreto.text = "65";
                break;
            case 9:
                pergunta.text = "1 / 2 = ?";
                txtBtnFalse1.text = "1,2";
                txtBtnFalse2.text = "3";
                txtBtnFalse3.text = "25%";
                txtBtnCorreto.text = "0,5";
                break;
            case 10:
                pergunta.text = "(x + b) * (x + b) = ?";
                txtBtnFalse1.text = "x² + bx + b²";
                txtBtnFalse2.text = "x + b";
                txtBtnFalse3.text = "x + bx + b";
                txtBtnCorreto.text = "x² + 2bx + b²";
                break;
        }
    }

    void Update() {
        faseText.text = $"{fase}/3";   
        contadorText.text = $"{contador}"; 
        StartCoroutine(temporizador());

        if(contador == 0){
            Debug.Log("Terminou");
        }
    }

    IEnumerator temporizador(){
        yield return new WaitForSeconds(1f);
        contador -= 1;
    }
}
