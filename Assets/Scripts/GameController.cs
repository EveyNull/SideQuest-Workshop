using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public ParticleSystem winParticles;
    public Text timeUI;

    private List<GameObject> collectables;
    private int numCollectables;
    private int collectablesHit = 0;

    private float timePlayed = 0f;

    private bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        collectables = new List<GameObject>();
        foreach (Collectable collectable in FindObjectsOfType<Collectable>())
        {
            collectables.Add(collectable.gameObject);
        }
        numCollectables = collectables.Count;
    }

    private void Update()
    {
        if (!won)
        {
            timePlayed += Time.deltaTime;
        }
        timeUI.text = "Time: " + timePlayed;
    }

    public void CollectableHit(GameObject hitObject)
    {
        Destroy(hitObject);
        collectablesHit++;
        if(collectablesHit >= numCollectables)
        {
            won = true;
            winParticles.Play();
        }
    }
}
