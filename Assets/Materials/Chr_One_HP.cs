using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public int StartingHP = 3;
	public Image demageImage; 
	public AudioClip DeathSound;
	public Slider healthSlider;

	AudioSource PlayerOneAudio;
	bool isDead;
	bool damage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void TakeDamage(int amount){
		damage = true;
		StartingHP -= amount;
		healthSlider.value = StartingHP;
		PlayerOneAudio.Play ();

		if (StartingHP <= 00 && !isDead) {
			Death ();
		}
	}
	void Death (){
		isDead = true;
		AnisotropicFiltering.SetTrigger ("Die");


	}
}
