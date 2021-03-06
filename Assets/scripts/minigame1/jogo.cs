using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class jogo : MonoBehaviour
{
    private int randomQuestion;
    private int fase;
    private float contador;
    private bool timerIsRunning = false;
    public TMP_Text faseText;
    // public Text scoreText;
    // private int scoreMG1;
    public Text pergunta;
    public Text contadorText;
    public Button botaoCorreto;
    public Button botaoFalso1;
    public Button botaoFalso2;
    public Button botaoFalso3;
    private TMP_Text txtBtnCorreto;
    private TMP_Text txtBtnFalse1;
    private TMP_Text txtBtnFalse2;
    private TMP_Text txtBtnFalse3;

    void Awake() {
        randomQuestion = Random.Range(1,10);
        fase = 1;
        // scoreMG1 = player.score;
        contador = 5f;
        timerIsRunning = true;
        txtBtnCorreto = botaoCorreto.GetComponentInChildren<TMP_Text>();
        txtBtnFalse1 = botaoFalso1.GetComponentInChildren<TMP_Text>();
        txtBtnFalse2 = botaoFalso2.GetComponentInChildren<TMP_Text>();
        txtBtnFalse3 = botaoFalso3.GetComponentInChildren<TMP_Text>();
    }

    void Start() {
        RandomQuestionAndAnswer();

        botaoCorreto.onClick.AddListener(AcertouResposta);
        botaoFalso1.onClick.AddListener(ErrouResposta);
        botaoFalso2.onClick.AddListener(ErrouResposta);
        botaoFalso3.onClick.AddListener(ErrouResposta);
    }
    void Update() {
        // scoreText.text = $"score:{scoreMG1}";
        faseText.text = $"{fase}/3";   
        // temporizador();
        if(fase == 4){
            SceneManager.LoadScene("SampleScene");
        }
        
    }
    void AcertouResposta(){
        fase += 1;
        Reiniciar();
    }

    void ErrouResposta(){
        Reiniciar();
        RandomQuestionAndAnswer();
    }

    void RandomQuestionAndAnswer(){
        randomQuestion = Random.Range(1,10);

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
                txtBtnFalse1.text = "x?? - b??";
                txtBtnFalse2.text = "x - b??";
                txtBtnFalse3.text = "x - b";
                txtBtnCorreto.text = "x?? - b??";
                break;
            case 5:
                pergunta.text = "x?? * x = ?";
                txtBtnFalse1.text = "x??";
                txtBtnFalse2.text = "x";
                txtBtnFalse3.text = "x^5";
                txtBtnCorreto.text = "x^4";
                break;
            case 6:
                pergunta.text = "???49 = ?";
                txtBtnFalse1.text = "8";
                txtBtnFalse2.text = "9";
                txtBtnFalse3.text = "6";
                txtBtnCorreto.text = "7";
                break;
            case 7:
                pergunta.text = "2?? = ?";
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
                txtBtnFalse1.text = "x?? + bx + b??";
                txtBtnFalse2.text = "x + b";
                txtBtnFalse3.text = "x + bx + b";
                txtBtnCorreto.text = "x?? + 2bx + b??";
                break;
        }
    }

    void temporizador(){
        float minutes = Mathf.FloorToInt(contador / 60);  
        float seconds = Mathf.FloorToInt(contador % 60); 
        contadorText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (timerIsRunning)
        {
            if (contador > 0)
            {
                contador -= Time.deltaTime;
            }
            else
            {
                contador = 0;
                timerIsRunning = false;
                ErrouResposta();
            }
        }
    }

    void Reiniciar(){
        contador = 5f;
        timerIsRunning = true;
    }
}
