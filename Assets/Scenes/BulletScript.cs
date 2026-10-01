using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float bulletSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += bulletSpeed * transform.up * Time.deltaTime;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Detect");
        print("Bam!");
        HealthScript victim = collision.transform.GetComponent<HealthScript>();
        if (victim)
        {
            victim.TakeDamage(50);
        }
    }
}
