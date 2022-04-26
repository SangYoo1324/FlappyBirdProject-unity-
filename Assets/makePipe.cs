using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makePipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float timeDiff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >1*timeDiff){
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position =new Vector3(7,Random.Range(-3.5f,2.3f),0);
    timer = 0;
    Destroy(newPipe, 9.0f);
        }
        
    }
}
