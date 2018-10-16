using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hp : MonoBehaviour {

    //De_Fining the frames for health

    public Sprite A;
    public Sprite B;
    public Sprite C;
    public Sprite D;
    public Sprite E;
    public Sprite F;

    // Defining more varibles


    int Current = 6;
    public int Switch = 5;

    public GameObject HealthCircle;


    void Death()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Current != Switch)
        {
           
             if (Switch == 5)
            {
                HealthCircle.GetComponent<SpriteRenderer>().sprite = A;

            }
            else if (Switch == 4)
            {
                HealthCircle.GetComponent<SpriteRenderer>().sprite = B;

            }
            else if (Switch == 3)
            {
                HealthCircle.GetComponent<SpriteRenderer>().sprite = C;

            }
            else if (Switch == 2)
            {
                HealthCircle.GetComponent<SpriteRenderer>().sprite = D;

            }
            else if (Switch == 1)
            {
                HealthCircle.GetComponent<SpriteRenderer>().sprite = E;

            }
            else if (Switch == 0)
            {
                HealthCircle.GetComponent<SpriteRenderer>().sprite = F;
                Death();
            }

        }
	}
}
