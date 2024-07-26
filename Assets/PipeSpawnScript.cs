using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float hightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {

        float palingbawah = transform.position.y - hightOffset;
        float palingatas = transform.position.y + hightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(palingbawah, palingatas), 0), transform.rotation);
    }
}
