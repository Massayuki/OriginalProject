using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleGenerator : MonoBehaviour
{
    public float Size;
    public ParticleSystem particle;
    public int count = 0;
    GameObject obj;
    public float speedy;
    public float scaley;

    // Use this for initialization
    void Start()
    {
        Size = Mathf.Sqrt
               (gameObject.transform.localScale.x * gameObject.transform.localScale.x +
                gameObject.transform.localScale.y * gameObject.transform.localScale.y +
                gameObject.transform.localScale.z * gameObject.transform.localScale.z);
        //Debug.Log(Size);
        // particle = particle.GetComponent<ParticleSystem>();
        obj = Resources.Load("Prefabs/flame") as GameObject;
       
        if (Size < 30.0f)
        {
            speedy = 3.5f;
            scaley = 3.0f;
        }else if(Size > 30.0f){
            if(Size < 50.0f){
                speedy = 7.0f;
                scaley = 5.0f;
            if (Size > 50.0f)
            {
                speedy = 10.0f;
                scaley = 7.0f;
            }
            }
        }
    }

    // Update is called once per frame


    void Update()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (count == 0)
        {

            if (collision.gameObject.tag == "DevilBullet")
            {
                count += 1;
                Instantiate(particle, this.transform.position, Quaternion.identity);
                particle = obj.GetComponent<ParticleSystem>();
                particle.startSpeed = speedy;
                particle.startLifetime = scaley;

            }
        }
    }
}
        
	

