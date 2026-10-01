using UnityEngine;

public class HealthScript : MonoBehaviour
{
    float MaxHP = 100;
    float CurrentHP = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void TakeDamage(int DamageAmount)
    {
        CurrentHP -= DamageAmount;
        if(CurrentHP <= 0)
        {
            Destroy(gameObject);
        }
        print(CurrentHP);
    }
}
