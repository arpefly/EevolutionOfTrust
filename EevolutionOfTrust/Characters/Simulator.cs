namespace EevolutionOfTrust.Characters
{
    /// <summary>
    /// ИМИТАТОР: Привет! На первом ходу я доверюсь, а потом просто буду копировать твой последний ход.
    /// </summary>
    public static class Simulator
    {
        /// <summary>
        /// Ход имитатора
        /// </summary>
        public static bool Action(bool playerChoise)
        {
            DataBank.GameTurn++;

            if (DataBank.GameTurn - 1 == 0)
            {
                return true;
            }
            else if (playerChoise)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}