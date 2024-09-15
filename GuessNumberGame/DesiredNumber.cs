using static GuessNumberGame.CompareTypes;

namespace GuessNumberGame
{
    internal class DesiredNumber : IDesiredNumber
    {
        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public DesiredNumber(int desiredNumber)
        {
            _number = desiredNumber;
        }

        public CompareTypes CompareNumber(int number)
        {
            if (number < _number)
                return CompareTypes.less;
            else if (number > _number)
                return CompareTypes.Bigger;
            else
                return CompareTypes.equal;
        }
    }
}
