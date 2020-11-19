using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swim : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    public GameObject HUD_swim;
    float timer;
    bool wet;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        				// HUD_swim = GameObject.Find("HUD_water").GetComponent<TextMesh>();

        HUD_swim = GameObject.Find("HUD_water");
        HUD_swim.SetActive(false);
        timer = 0f;
        wet = false;
        // HUD_swim.text = "True FPS players do not swim!";



    }

    // Update is called once per frame
    void Update()
    {
        if (wet)
        {
            timer += Time.deltaTime;
            if (timer >= 5f){
                wet = false;
                HUD_swim.SetActive(false);
                timer = 0f;
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = new Vector3(507, 37, 862);
        HUD_swim.SetActive(true);
        wet = true;
        

    }


}
