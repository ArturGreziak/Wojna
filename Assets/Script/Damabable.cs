using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damabable : MonoBehaviour
{
    public DamagableType type;
    public DamageEffect damageEffect;
    public Color effectColor;
    public virtual void GetDamage(){

        var effect = Instantiate(damageEffect);
        effect.Setup(transform.position, effectColor);
        Destroy(gameObject);
    }
}

public enum DamagableType
{
    Invader,
    Player,
    Building
}