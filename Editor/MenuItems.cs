﻿using UnityEditor;


namespace Assets.MyScripts
{
	public class MenuItems
	{
		[MenuItem("Geekbrains/Пункт меню №0 ")]
		private static void MenuOption()
		{
			EditorWindow.GetWindow(typeof(MyWindow), true, "Geekbrains");
		}

		[MenuItem("Geekbrains/PakAlekseyWindow %#a")]
		private static void NewMenuOption()
		{
			EditorWindow.GetWindow(typeof(MyWindowLesson7HW), true, "PakAlekseyWindow");
		}

		[MenuItem("Geekbrains/Пункт меню №2 %g")]
		private static void NewNestedOption()
		{
		}

		[MenuItem("Geekbrains/Пункт меню №3 _g")]
		private static void NewOptionWithHotkey()
		{
		}

		[MenuItem("Geekbrains/Пункт меню/Пункт меню №3 _g")]
		private static void NewOptionWithHot()
		{
		}
		[MenuItem("Assets/Geekbrains")]
		private static void LoadAdditiveScene()
		{
		}
		[MenuItem("Assets/Create/Geekbrains")]
		private static void AddConfig()
		{
		}
		[MenuItem("CONTEXT/Rigidbody/Geekbrains")]
		private static void NewOpenForRigidBody()
		{
		}
		[MenuItem("GameObject/Rigidbody/Geekbrains")]
		private static void NewOpenForRigidBody2()
		{
		}
	}
}
