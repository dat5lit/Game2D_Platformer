using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D _rigi;

    [Header("Speed Bullet")]
    [SerializeField] private float _speed = 1f,_timeActive;

    Coroutine _coroutine;
    void Start()
    {
        _rigi = this.GetComponent<Rigidbody2D>();
        
    }
    private void OnEnable()
    {
        _coroutine = StartCoroutine(CountDownTimerBullet());   
    }
    private void OnDisable()
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _rigi.velocity = this.transform.right * _speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == null) return;
        if(collision.gameObject.CompareTag("enemy")) this.gameObject.SetActive(false);
    }
    IEnumerator CountDownTimerBullet()
    {
        yield return new WaitForSeconds(_timeActive);
        this.gameObject.SetActive(false);
    }
}
