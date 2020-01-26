namespace BattleShip
{
    public class BoardConfig
    {
        public int RowsNumber { get { return _rowsNumber; } set { _rowsNumber = value; } }
        public int ColumnsNumber { get { return _columnsNumber; } set { _columnsNumber = value; } }

        private int _rowsNumber;
        private int _columnsNumber;
    }
}
