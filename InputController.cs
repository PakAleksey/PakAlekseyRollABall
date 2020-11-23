using UnityEngine;


namespace Assets.MyScripts
{
    public sealed class InputController : IExecute
    {
        private readonly PlayerBase _playerBase;
        private readonly SaveDataRepository _saveDataRepository;
        private SaveController _saveController;
        private readonly KeyCode _savePlayer = KeyCode.C;
        private readonly KeyCode _loadPlayer = KeyCode.V;
        private readonly KeyCode _saveAll = KeyCode.O;
        private readonly KeyCode _loadAll = KeyCode.P;

        public InputController(PlayerBase player, SaveController saveController)
        {
            _playerBase = player;
            _saveDataRepository = new SaveDataRepository();
            _saveController = saveController;
        }

        public void Execute()
        {
            _playerBase.Move(Input.GetAxis(AxisManager.HORIZONTAL), 0.0f, Input.GetAxis(AxisManager.VERTICAL));
            if (Input.GetKeyDown(_savePlayer))
            {
                _saveDataRepository.Save(_playerBase);
            }
            if (Input.GetKeyDown(_loadPlayer))
            {
                _saveDataRepository.Load(_playerBase);
            }
            if (Input.GetKeyDown(_saveAll))
            {
                _saveDataRepository.SaveAll(_saveController._saveDataList);
            }
            if (Input.GetKeyDown(_loadAll))
            {
                _saveDataRepository.LoadAll(_saveController._saveDataList);
            }
        }
    }
}
