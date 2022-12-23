namespace EevolutionOfTrust.Characters
{
    /// <summary>
    /// ОБМАНЩИК: сильные должны есть слабых
    /// </summary>
    public static class Cheater
    {
        /// <summary>
        /// Ход обманщика
        /// </summary>
        public static bool Action()
        {
            DataBank.GameTurn++;

            return false;
        }
    }
}