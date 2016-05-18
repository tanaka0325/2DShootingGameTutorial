using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject player;
    private GameObject title;

    void Start()
    {
        title = GameObject.Find("Title");
    }

    void Update()
    {
        if (IsPlaying() == false && Input.GetKeyDown(KeyCode.X))
        {
            GameStart();
        }
    }

    void GameStart()
    {
        title.SetActive(false);
        Instantiate(player, player.transform.position, player.transform.rotation);
    }

    public void GameOver()
    {
        FindObjectOfType<Score>().Save();
        title.SetActive(true);
    }

    public bool IsPlaying()
    {
        return title.activeSelf == false;
    }
}
