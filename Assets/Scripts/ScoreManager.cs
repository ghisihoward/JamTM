using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {


	//- Bagulinho aparece na tela de jogo :: Soma 1 nas coisas que apareceram 					> Apareceram = 1
	//	-  Jogador tem que reagir e reage    :: Soma 1 nas vezes que ele reagiu positivamente 	> Acertou 	 = 1
	//	- Bagulinho aparece na tela de jogo :: Soma 1 nas coisas que apareceram 					> Apareceram = 2
	//	- Jogador tem que reagir e não 	   :: Não soma 1 nas vezes que ele reagiu positivamente > Acertou    = 1
	//	- Acertou / Apareceram > 0~100% de 2 estrelas. 0 - 0 est, 25, 1/2 estrela... etc.

	int totalNotes = 0;
	int totalPlayerRights = 0;

	NoteManager noteManager;
	Log 

	void Start () {
		if (noteManager.NotesSpawn) {
			totalNotes += 1;
		}
		if (){
			
		}
	}
	
	void Update () {
		
	}
}
