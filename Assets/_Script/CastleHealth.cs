using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CastleHealth : MonoBehaviour
{

    [SerializeField] public bool castleIsLive;
    [SerializeField] private int _castleStartHealth,_castleHealth;
    [SerializeField] private GameObject _healthSprite;
    
    float damageScale;

    void Start()
    {
        castleIsLive = true;
        _castleHealth = _castleStartHealth;
        damageScale = _healthSprite.transform.localScale.x / _castleStartHealth;
    }
    
    public void TakeDamage(int damage)
    {
        
        if (castleIsLive)
        {
            _castleHealth -= damage;

            _healthSprite.transform.DOScaleX((_healthSprite.transform.localScale.x - (damageScale * damage)),0.1f) ;
            
            if (_castleHealth <= 0)
            {
                castleIsLive = false;
                //_healthSprite.transform.DOScaleX((0),0.1f) ;

            }
        }
    }
}
