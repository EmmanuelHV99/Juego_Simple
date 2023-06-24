using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Personaje : MonoBehaviour {
	private int vel = 5, giro=150, fuerza=350, contador=0;
	private bool salto=false;
	private Rigidbody rb;
	public Text tVida, tContador;
	public Slider barraVida;
	public Button bAvanzar;
	private AudioSource[] sonidos;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		sonidos = GetComponents<AudioSource> ();
		bAvanzar.gameObject.SetActive (false);
	}//fin del Start
	
	// Update is called once per frame
	void Update () {
		//mover Adelante
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (new Vector3 (0, 0, vel) * Time.deltaTime);
		}
		//mover Atras
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (new Vector3 (0, 0, -vel) * Time.deltaTime);
		}
		//girar izquierda
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (new Vector3 (0, -giro, 0) * Time.deltaTime);
		}
		//girar derecha
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (new Vector3 (0, giro, 0) * Time.deltaTime);
		}
		//saltar
		if (Input.GetKeyDown (KeyCode.Space) & salto) {
			sonidos [1].Play ();
			rb.AddForce (0, fuerza, 0);
			salto = false;
		}//fin de saltar
	}//fin de update
	void OnCollisionEnter(Collision col){
		//acivacion de salto a verdadero
		salto = true;

		//colision con base falsa
		if(col.gameObject.tag=="falsa"){
			SceneManager.LoadScene (1);
		}

		//colision con barra mala
		if(col.gameObject.tag=="malo"){
			sonidos [0].Play();
			barraVida.value -= 30;
			tVida.text = "" + (int)(barraVida.value / 3) + "%";
			//inicia si vida llega a 0
			if (barraVida.value == 0) {
				SceneManager.LoadScene (1);
			}//fin de comparar vida con 0
		}
		//contar monedas
		if (col.gameObject.tag == "moneda") {
			sonidos [4].Play ();
			contador++;
			tContador.text = "" + contador;
			Destroy (col.gameObject);
			barraVida.value += 30;
			tVida.text = "" + (int)(barraVida.value / 3) + "%";
			if (contador == 5) {
				bAvanzar.gameObject.SetActive (true);
			}//mostrar boton Avanzar
		}//fin de contar monedas
	}//fin de OnCollisionEnter

	void OnTriggerStay(Collider trig){
		if (trig.tag == "buenas") {
			barraVida.value++;
			tVida.text = "" + (int)(barraVida.value / 3) + "%";
		}//fin de particulas buenas
		if (trig.tag == "malas") {
			barraVida.value --;
			tVida.text = "" + (int)(barraVida.value / 3) + "%";
			if (barraVida.value == 0) {
				SceneManager.LoadScene (1);
			}//fin de comparar vida con 0
		}//fin de particulas malas
	}//fin de OnTriggerStay

	void OnTriggerEnter(Collider otro){
		if (otro.tag == "buenas") {
			sonidos [2].Play ();
		}//sonido particulas buenas
		if (otro.tag == "malas") {
			sonidos [3].Play ();
		}//sonido particulas malas
	}
}//fin de codigo
