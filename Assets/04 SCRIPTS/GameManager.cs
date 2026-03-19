using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private PlayerController _player;
    [SerializeField] private CameraFllow _cameraFollow;
    public CameraFllow cam => _cameraFollow;
    public  PlayerController player => _player;
    [Header("Score")]
  
    [SerializeField] private float _coin = 0f;
    public float coin => _coin;
    
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateCoin(float coin)
    {
        _coin += coin;
        Observer.instance.Notify("UpdateCoin");
    }
}
