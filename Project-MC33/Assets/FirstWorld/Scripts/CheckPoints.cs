using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoints : MonoBehaviour
{
    public Rigidbody2D chRb;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Vector2 posPlayer;
    public bool check;

    public static int allChecks = 8;
    public bool saved;
    public int currentCheck = 0;
    public bool contact;
    public bool firstSaveLvl2;
    public Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        check = false;
        contact = false;
        scene = SceneManager.GetActiveScene();
        saved = false;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        chRb = gameObject.GetComponent<Rigidbody2D>();
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            check = true;
            contact = true;
            saved = true;
            SaveMangerDone.instance.activeSave.firstCheckDone = true;
            GameObject pos01 = GameObject.Find("PlayerGeneral");
            FallRestart pos02 = pos01.GetComponent<FallRestart>();
            pos02.startPos = chRb.transform.position;

            posPlayer = new Vector2(chRb.transform.position.x, chRb.transform.position.y);
            
            SaveMangerDone.instance.activeSave.respawnPosition = posPlayer;
            SaveMangerDone.instance.Save();
            spriteRenderer.sprite = newSprite;
        }
    }
}
