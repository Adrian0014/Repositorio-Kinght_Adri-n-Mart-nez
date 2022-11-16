using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    // Start is called before the first frame update
    private int score;
    public Text scoreText;

    private SFXManager sfxManager;
    private BGMManager bgmManager;


    public int vidas = 3;
    public int puntos = 0;

    public GameObject win;
    void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();
        
        //Si ya hay una instancia y no soy yo me destruyo
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);

        
    }

    public void RestarVidas()
    {
        vidas--;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void TengoEstrella(GameObject star)
    {
        //sfxManager.CoinSound();
        Destroy(star);
        score++;
        scoreText.text = "X" + score;
        sfxManager.Estrella();
        
        if(score >= 8)
        {
            win.SetActive(true);
        }   
    }
    
    public void BombExplode(GameObject bomb)
    {
        Animator bombAnimator;
        bombAnimator = bomb.GetComponent<Animator>();
        bombAnimator.SetBool("BombExplosion", true);
        Destroy(bomb, 0.7f);
        sfxManager.BombExlpode();
    }
     
    
}
