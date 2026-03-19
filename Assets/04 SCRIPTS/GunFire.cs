using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    [SerializeField] Bullet _bullet;
    [SerializeField] private float _countDownTimer, _lifeTime; 
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        _countDownTimer -= Time.deltaTime;
    }
    public void GunFireBullet()
    {
        //if (_countDownTimer > 0) return;
        Quaternion rotate = this.transform.rotation;
        rotate.eulerAngles = new Vector3(0, 0, this.transform.parent.localScale.x == 1 ? 0 : 180);
        this.transform.rotation = rotate;
        GameObject bullet = ObjectPooling.instance.GetPreFab(_bullet.gameObject);
        bullet.transform.position = this.transform.position;
        bullet.transform.rotation = this.transform.rotation;
        bullet.SetActive(true);
        //_countDownTimer = _lifeTime;

    }

}
