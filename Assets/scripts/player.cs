using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player : MonoBehaviour
{
    private int blocoAtual;
    private bool isPlaying;
    private bool PontoRecebido;
    public int score;
    public TMP_Text winnerText;
    public TMP_Text scoreText;
    public Image m_Image;
    public Sprite dice1;
    public Sprite dice2;
    public Sprite dice3;
    public Sprite dice4;
    public Sprite dice5;
    public Sprite dice6;

    void Awake() {
        isPlaying = true;
        PontoRecebido = false;
        blocoAtual = 0;
        m_Image.enabled = false;
        winnerText.enabled = false;
        Cursor.visible = false;
        score = 5;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if(isPlaying){
            if(Input.GetKeyDown(KeyCode.Space))
            {
                m_Image.enabled = true;
                JogarDado();
            }

            scoreText.text = $"score: {score}";

            if(blocoAtual >= 18){
                transform.position = new Vector3(16.17f,-1.5139f,-0.19f);
                winnerText.enabled = true;
                isPlaying = false;
            }

            switch (blocoAtual){
                case 0:
                    transform.position = new Vector3(10.96241f,-1.5139f,-9.550528f);
                    break;
                case 1:
                    transform.position = new Vector3(9.06f,-1.5139f,-8.45f);
                    break;
                case 2:
                    transform.position = new Vector3(7.15f,-1.5139f,-7.35f);
                    break;
                case 3:
                    transform.position = new Vector3(5.26f,-1.5139f,-6.26f);
                    if(!PontoRecebido){
                        score += 1;
                        PontoRecebido = true;
                    }
                    break;
                case 4:
                    transform.position = new Vector3(3.22f,-1.5139f,-5.08f);
                    break;
                case 5:
                    transform.position = new Vector3(1.49f,-1.5139f,-4.08f);
                    break;
                case 6:
                    transform.position = new Vector3(-0.42f,-1.5139f,-2.98f);
                    if(!PontoRecebido){
                        score += 1;
                        PontoRecebido = true;
                    }
                    break;
                case 7:
                    transform.position = new Vector3(0.61f,-1.5139f,-1.2f);
                    break;
                case 8:
                    transform.position = new Vector3(1.67f,-1.5139f,0.64f);
                    break;
                case 9:
                    transform.position = new Vector3(2.75f,-1.5139f,2.5f);
                    break;
                case 10:
                    transform.position = new Vector3(3.82f,-1.5139f,4.35f);
                    if(!PontoRecebido){
                        score += 1;
                        PontoRecebido = true;
                    }
                    break;
                case 11:
                    transform.position = new Vector3(4.95f,-1.5139f,6.3f);
                    break;
                case 12:
                    transform.position = new Vector3(6.78f,-1.5139f,5.24f);
                    if(!PontoRecebido){
                        score -= 1;
                        PontoRecebido = true;
                    }
                    break;
                case 13:
                    transform.position = new Vector3(8.52f,-1.5139f,4.24f);
                    break;
                case 14:
                    transform.position = new Vector3(10.56f,-1.5139f,3.06f);
                    break;
                case 15:
                    transform.position = new Vector3(12.48f,-1.5139f,1.95f);
                    break;
                case 16:
                    transform.position = new Vector3(14.36f,-1.5139f,0.86f);
                    if(!PontoRecebido){
                        score += 1;
                        PontoRecebido = true;
                    }
                    break;
                case 17:
                    transform.position = new Vector3(16.17f,-1.5139f,-0.19f);
                    break;
                default:
                    blocoAtual = 0;
                    break;
            }
        }
        
    }

    void JogarDado(){
        PontoRecebido = false;
        int numeroEscolhido = Random.Range(1,6);
        Debug.Log(numeroEscolhido);
        blocoAtual += numeroEscolhido;

        switch (numeroEscolhido){
            case 1:
                m_Image.sprite = dice1;
                break;
            case 2:
                m_Image.sprite = dice2;
                break;
            case 3:
                m_Image.sprite = dice3;
                break;
            case 4:
                m_Image.sprite = dice4;
                break;
            case 5:
                m_Image.sprite = dice5;
                break;
            case 6:
                m_Image.sprite = dice6;
                break;
        }
    }
}
