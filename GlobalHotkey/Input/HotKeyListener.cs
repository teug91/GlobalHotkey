//using GlobalHotkey.Changers;
using GlobalHotkey.Core;
using GlobalHotkey.Properties;
using System.ComponentModel;

namespace GlobalHotkey.Input
{
    /// <summary>
    /// Doing stuff with hotkeys.
    /// </summary>
    internal class HotKeyListener
    {
        private KeyCombo[] keyCombos;


		/// <summary>
		///     Initializes a new instance of the <see cref="HotKeyListener" /> class.
		/// </summary>
		public HotKeyListener()
        {
			//KeyCombo pw = new KeyCombo(KeyModifier.Ctrl, System.Windows.Input.Key.F1);
			new HotKey(System.Windows.Input.Key.F1, KeyModifier.Ctrl, OnPassworkHotkeyHandler);

			if (Settings.Default.F2 != "")
				new HotKey(System.Windows.Input.Key.F2, KeyModifier.Ctrl, OnF2HotkeyHandler);

			if (Settings.Default.F3 != "")
				new HotKey(System.Windows.Input.Key.F3, KeyModifier.Ctrl, OnF3HotkeyHandler);

			if (Settings.Default.F4 != "")
				new HotKey(System.Windows.Input.Key.F4, KeyModifier.Ctrl, OnF4HotkeyHandler);

			if (Settings.Default.F5 != "")
				new HotKey(System.Windows.Input.Key.F5, KeyModifier.Ctrl, OnF5HotkeyHandler);

			if (Settings.Default.F6 != "")
				new HotKey(System.Windows.Input.Key.F6, KeyModifier.Ctrl, OnF6HotkeyHandler);

			if (Settings.Default.F7 != "")
				new HotKey(System.Windows.Input.Key.F7, KeyModifier.Ctrl, OnF7HotkeyHandler);

			if (Settings.Default.F8 != "")
				new HotKey(System.Windows.Input.Key.F8, KeyModifier.Ctrl, OnF8HotkeyHandler);

			if (Settings.Default.F9 != "")
				new HotKey(System.Windows.Input.Key.F9, KeyModifier.Ctrl, OnF9HotkeyHandler);

			if (Settings.Default.F10 != "")
				new HotKey(System.Windows.Input.Key.F10, KeyModifier.Ctrl, OnF10HotkeyHandler);

			if (Settings.Default.F11 != "")
				new HotKey(System.Windows.Input.Key.F11, KeyModifier.Ctrl, OnF11HotkeyHandler);

			if (Settings.Default.F12 != "")
				new HotKey(System.Windows.Input.Key.F11, KeyModifier.Ctrl, OnF12HotkeyHandler);



			/*keyCombos = SettingsManager.GetHotKeys();
            SettingsManager.GetAutoStart();

            displayHotKey = new HotKey(keyCombos[0].key, keyCombos[0].mod, OnDisplayHotKeyHandler);
            soundHotKey = new HotKey(keyCombos[1].key, keyCombos[1].mod, OnSoundHotKeyHandler);

            Settings.Default.SettingsSaving += SettingSaving;*/
		}

		/// <summary>
		/// Register new hotkeys and removes old.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SettingSaving(object sender, CancelEventArgs e)
        {
            /*KeyCombo[] newHotKeys = SettingsManager.GetHotKeys();

            if (newHotKeys[0].mod != keyCombos[0].mod || newHotKeys[0].key != keyCombos[0].key)
            {
                displayHotKey.Unregister();
                displayHotKey = new HotKey(newHotKeys[0].key, newHotKeys[0].mod, OnDisplayHotKeyHandler);
            }

            if (newHotKeys[1].mod != keyCombos[1].mod || newHotKeys[1].key != keyCombos[1].key)
            {
                soundHotKey.Unregister();
                soundHotKey = new HotKey(newHotKeys[1].key, newHotKeys[1].mod, OnDisplayHotKeyHandler);
            }

            keyCombos = newHotKeys;*/
        }

        private static void OnPassworkHotkeyHandler(HotKey hotKey)
        {
			PasswordGenerator.GeneratePassword();
        }


		private static void OnF2HotkeyHandler(HotKey hotKey)
		{
			System.Windows.Clipboard.SetText(Settings.Default.F2);
		}

		private static void OnF3HotkeyHandler(HotKey hotKey)
		{
			System.Windows.Clipboard.SetText(Settings.Default.F3);
		}

		private static void OnF4HotkeyHandler(HotKey hotKey)
		{
			System.Windows.Clipboard.SetText(Settings.Default.F4);
		}

		private static void OnF5HotkeyHandler(HotKey hotKey)
		{
			System.Windows.Clipboard.SetText(Settings.Default.F5);
		}

		private static void OnF6HotkeyHandler(HotKey hotKey)
		{
			System.Windows.Clipboard.SetText(Settings.Default.F6);
		}

		private static void OnF7HotkeyHandler(HotKey hotKey)
		{
			System.Windows.Clipboard.SetText(Settings.Default.F7);
		}

		private static void OnF8HotkeyHandler(HotKey hotKey)
		{
			System.Windows.Clipboard.SetText(Settings.Default.F8);
		}

		private static void OnF9HotkeyHandler(HotKey hotKey)
		{
			System.Windows.Clipboard.SetText(Settings.Default.F9);
		}

		private static void OnF10HotkeyHandler(HotKey hotKey)
		{
			System.Windows.Clipboard.SetText(Settings.Default.F10);
		}

		private static void OnF11HotkeyHandler(HotKey hotKey)
		{
			System.Windows.Clipboard.SetText(Settings.Default.F11);
		}

		private static void OnF12HotkeyHandler(HotKey hotKey)
		{
			System.Windows.Clipboard.SetText(Settings.Default.F12);
		}


	}
}
