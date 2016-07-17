using UnityEngine;
using System.Collections;

public class PlayAudioOnCollision : MonoBehaviour {

    private AudioClip[] bounce;
    private AudioSource source;
    private AudioSource ballsource;

    public GameObject CaptureSparklesPrefab;

    // Use this for initialization
    void Start () {
        ballsource = GetComponent<AudioSource>();
        bounce = new AudioClip[] {
        (AudioClip)Resources.Load("Sound/BounceA"),
        (AudioClip)Resources.Load("Sound/BounceB")};
    }
	
    //(AudioClip)Resources.Load("Sound/BounceC")
    //(AudioClip)Resources.Load("Sound/BounceD")
	
    // Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pokemon")
        {
            source = collision.gameObject.GetComponentInParent<AudioSource>();
            Debug.Log("collided with pokemon, playing sound");
            Debug.Log(source.clip);
            ballsource.PlayOneShot(source.clip);
            Instantiate(CaptureSparklesPrefab, transform.position, transform.rotation);
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
        else
        {
            if (GetComponent<AudioSource>().isPlaying) return;
            GetComponent<AudioSource>().clip = bounce[Random.Range(0, bounce.Length)];
            GetComponent<AudioSource>().Play();
        }
    }

}
