using UnityEngine;
using UnityEngine.UI;
public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponInformation weaponInformation;
    [SerializeField] private int _WeaponCurrentMagSize;
    [SerializeField] private Transform Camera;
    public GameObject GameMangerObj;
    GameManager gameManagerScript;
    [SerializeField] private Text ammotText;
    private void Start()
    {
        ammotText.text = _WeaponCurrentMagSize.ToString();
        _WeaponCurrentMagSize = weaponInformation.MagSize;
        GameMangerObj = GameObject.FindGameObjectWithTag("GameManager");
        gameManagerScript = GameMangerObj.GetComponent<GameManager>();
    }
    private void OnEnable()
    {
        ammotText.text = _WeaponCurrentMagSize.ToString();
        _WeaponCurrentMagSize = weaponInformation.MagSize;
        GameMangerObj = GameObject.FindGameObjectWithTag("GameManager");
        gameManagerScript = GameMangerObj.GetComponent<GameManager>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _WeaponCurrentMagSize -= weaponInformation.BulletReduced;
            ammotText.text = _WeaponCurrentMagSize.ToString();
            Raycast();
        }
       

    }
    void Raycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.position, Camera.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.Log(hit.transform.name);
            Debug.DrawRay(Camera.position, Camera.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            if (hit.transform.tag == "Enemy")
            {
                hit.transform.GetComponent<AIDeath>().EnemyDeath();

            }
            else
            {
                gameManagerScript.GameOverSequence();
            }
        }
    }
    public void Fire()
    {
        _WeaponCurrentMagSize -= weaponInformation.BulletReduced;
    }
}
