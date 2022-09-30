namespace Torolecarte.Patterns.Creational.Singleton
{
    public class ScrabbleSingleton
    {
        // Singleton.
        private static ScrabbleSingleton _instance;
        public static ScrabbleSingleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ScrabbleSingleton();

                return _instance;
            }
        }

        // Fields.
        private char[] _letters =
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p'
        };
        private List<char> _availableLetters;

        // Properties.
        public IReadOnlyCollection<char> AllLettersInBag
        {
            get
            {
                return _letters;
            }
        }
        public IReadOnlyCollection<char> AvailableLetters
        {
            get
            {
                return _availableLetters;
            }
        }

        // Constructors.
        private ScrabbleSingleton()
        {
            _availableLetters = new List<char>(_letters);
        }

        // Methods.
        public List<char> GetLetterTiles(int numberOfTiles)
        {
            var tilesToSend = new List<char>();

            while (tilesToSend.Count < numberOfTiles)
            {
                var indexToPick = Random.Shared.Next(_availableLetters.Count);
                tilesToSend.Add(_availableLetters[indexToPick]);
                _availableLetters.RemoveAt(indexToPick);
            }

            return tilesToSend;
        }
    }
}
