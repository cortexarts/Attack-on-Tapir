using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenu : MonoBehaviour {

	[SerializeField]
	private Text healthText;

	[SerializeField]
	private Text speedText;

	[SerializeField]
	private float healthIncremention = 50.0f;

	[SerializeField]
	private float movementSpeedMultiplier = 1.2f;

	private PlayerStats stats;

	void OnEnable ()
	{
		stats = PlayerStats.instance;
		UpdateValues();
    }

	void UpdateValues ()
	{
		healthText.text = "HEALTH: " + stats.maxHealth.ToString();
		speedText.text = "SPEED: " + stats.movementSpeed.ToString();
    }

	public void UpgradeHealth ()
	{
		stats.maxHealth = (int)(stats.maxHealth + healthIncremention);
		UpdateValues();
	}

	public void UpgradeSpeed()
	{
		stats.movementSpeed = Mathf.Round (stats.movementSpeed * movementSpeedMultiplier);
		UpdateValues();
	}

}
