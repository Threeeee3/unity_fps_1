using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


public class Throw : MonoBehaviour
{
    public GameObject rockPrefab;
    public GameObject Pencil;
    public GameObject Book;
    public GameObject Table;
    public AudioClip sound;
    private float reLowdTime;
    private float reLTime;
    public bool Trigger;
    private float time;
    public GameObject CoolImage;
    public GameObject PencilVideo;
    public GameObject BookVideo;
    public GameObject TableVideo;

    private void Start()
    {
        rockPrefab = Pencil;
        reLowdTime = 0.3f;
        PencilVideo.SetActive(false);
        TableVideo.SetActive(false);
        BookVideo.SetActive(false);
    }

    void Update()
    {
        time += Time.deltaTime;
        if (Trigger)
        {
            if (Input.GetMouseButtonDown(0))
            {
                reLTime = reLowdTime;
                GameObject rock = Instantiate(rockPrefab, transform.position, transform.rotation);
                Rigidbody rockRb = rock.GetComponent<Rigidbody>();
                rockRb.AddForce(transform.forward * 700);
                Destroy(rock, 3.5f);
                AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
                CoolImage.GetComponent<CoolTime>().reLowding(reLTime);
                Trigger = false;
                time = 0f;
            }
        }

        if(time >= reLTime)
        {
            Trigger = true;
        }

        if (Input.GetKeyDown("1"))
        {
            rockPrefab = Pencil;
            reLowdTime = 0.3f;
            PVideo();
        }

        if(Input.GetKeyDown("2"))
        {
            rockPrefab = Book;
            reLowdTime = 1f;
            BVideo();
        }

        if(Input.GetKeyDown("3"))
        {
            rockPrefab = Table;
            reLowdTime = 5f;
            TVideo();
        }
    }

    private async void PVideo()
    {
        TableVideo.SetActive(false);
        BookVideo.SetActive(false);
        PencilVideo.SetActive(true);
        await Task.Delay(3000);
        PencilVideo.SetActive(false);
    }

    private async void TVideo()
    {
        PencilVideo.SetActive(false);
        BookVideo.SetActive(false);
        TableVideo.SetActive(true);
        await Task.Delay(3000);
        TableVideo.SetActive(false);
    }

    private async void BVideo()
    {
        PencilVideo.SetActive(false);
        TableVideo.SetActive(false);
        BookVideo.SetActive(true);
        await Task.Delay(3000);
        BookVideo.SetActive(false);
    }
}