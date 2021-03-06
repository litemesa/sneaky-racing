namespace sneakyRacing
{
	using UnityEngine;

	public class GameMenu : Menu
	{
		private PausePanel _pausePanel;

		public PausePanel pausePanel
		{
			get
			{
				return _pausePanel;
			}
		}

		private GameOverPanel _gameOverPanel;

		public GameOverPanel gameOverPanel
		{
			get
			{
				return _gameOverPanel;
			}
		}

		private InstrumentPanel _instrumentPanel;

		public InstrumentPanel instrumentPanel
		{
			get
			{
				return _instrumentPanel;
			}
		}

		private TouchControl _touchControl;

		public TouchControl touchControl
		{
			get
			{
				return _touchControl;
			}
		}

		private void Awake()
		{
			_pausePanel = transform.Find("PausePanel").GetComponent<PausePanel>();
			_gameOverPanel = transform.Find("GameOverPanel").GetComponent<GameOverPanel>();
			_instrumentPanel = transform.Find("InstrumentPanel").GetComponent<InstrumentPanel>();
			_touchControl = transform.Find("TouchControl").GetComponent<TouchControl>();

			_pausePanel.gameObject.SetActive(true);
			_gameOverPanel.gameObject.SetActive(false);
		}
	}
}