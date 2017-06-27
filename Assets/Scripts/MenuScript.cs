using UnityEngine;

/// 

/// Скрипт главного меню
/// 

public class MenuScript : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 108;
		const int buttonHeight = 50;

		// Определяем место кнопки на экране:
		// по оси X - в центре, по оси Y - 2/3 от высоты
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(4 * Screen.height / 5 ) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
		);

		// Нарисуйте кнопку, чтобы начать игру
		if(GUI.Button(buttonRect,"Start!"))
		{
			// По щелчку по кнопке, загрузите первый уровень.
			// "Stage1" - название первой сцены, которую мы создали.
			// Ее то мы и загрузим.
			Application.LoadLevel("Stage1");
		}
	}
}