using TMPro;
using UnityEngine;

public class AmmoTxt : MonoBehaviour
{
    public Weapon weapon;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        UpdateAmmoText();
    }

    // Update is called once per frame
    private void Update()
    {
        UpdateAmmoText();
    }

    private void UpdateAmmoText()
    {
        text.text = $"{weapon.currentClip} / {weapon.maxClipSize} │ {weapon.currentAmmo} / {weapon.maxAmmoSize}";
    }
}
