namespace BattleShip
{
    public class ShotConfig
    {
        public int RowNumber { get { return _rowNumber; } set { _rowNumber = value; } }
        public int ColumnNumber { get { return _columnNumber; } set { _columnNumber = value; } }

        private int _rowNumber;
        private int _columnNumber;
    }
}
