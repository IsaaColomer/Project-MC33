using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    public FallRestart a;
    
    // Update is called once per frame
    void Update()
    {
        score.text =  a.GetComponent<FallRestart>().death.ToString();
    }
}
