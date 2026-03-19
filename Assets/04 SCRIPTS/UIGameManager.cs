using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameManager : Singleton<UIGameManager>
{
    // Start is called before the first frame update
    [Header("Score")]
    [SerializeField] private Text _textCoin;
    void Start()
    {
        Observer.instance.AddListener("UpdateCoin", setCoin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setCoin()
    {
        _textCoin.text = "Coin : " + GameManager.instance.coin.ToString();

    }
}
