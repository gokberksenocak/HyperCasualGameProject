using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    private Vector3 FirstPos, LastPos;
    public float speed = 1.5f;
    [SerializeField] private GameObject hidden;
    [SerializeField] private GameObject hiddenCam;
    [SerializeField] private GameObject _panel;
    private Scene scene_;
    private Rigidbody rb;
    private Animator _anim;
    private bool free = true;
    void Start()
    {
        scene_ = SceneManager.GetActiveScene();
        rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        if (free)
        {
            transform.Translate(new Vector3(0, 0, 4.5f) * Time.deltaTime);
            _anim.SetBool("run", true);
            if (Input.GetMouseButtonDown(0))
            {
                FirstPos = Input.mousePosition;
            }
            else if (Input.GetMouseButton(0))
            {
                LastPos = Input.mousePosition;
                float difference = LastPos.x - FirstPos.x;
                transform.Translate(difference * Time.deltaTime * speed / 100, 0f, 0f);
            }
               if (Input.GetMouseButtonUp(0))
               {
                FirstPos = Vector3.zero;
                LastPos = Vector3.zero;
               }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("RotPla1"))
        {
            rb.velocity = new Vector3(-6f, 0, 0);
        }
        if (other.gameObject.CompareTag("RotPla2"))
        {
            rb.velocity = new Vector3(6f, 0, 0);
        }
        if (other.gameObject.CompareTag("Rotator"))
        {
            rb.velocity = new Vector3(0, 0, -10f);
            _anim.SetTrigger("hit");
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(scene_.buildIndex);
        }
        if (other.gameObject.CompareTag("HalfDonut"))
        {
            rb.velocity = new Vector3(0, 0, -10f);
            _anim.SetTrigger("hit");
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            free = false;
            rb.velocity = Vector3.zero;
            _anim.SetBool("run", false);
            _anim.SetBool("stop", true);
            hidden.SetActive(true);
            hiddenCam.SetActive(true);
            Invoke("Next", 2.75f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish2"))
        {
            _panel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Next()
    {
        SceneManager.LoadScene(1);
    }
}