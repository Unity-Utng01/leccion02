using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPerro : MonoBehaviour
{
    // Start is called before the first frame update
    public float limiteAnimals = 15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position.z < -limiteAnimals){
            Destroy(gameObject);

        }
        //para mover al perro
        transform.Translate(Vector3.forward*Time.deltaTime*15);
        
    }
}
