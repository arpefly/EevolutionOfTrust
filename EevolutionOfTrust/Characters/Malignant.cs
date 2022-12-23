namespace EevolutionOfTrust.Characters
{
    /// <summary>
    /// ЗЛОПАМЯТНЫЙ: Слушай сюда, дружище, я начну с доверия и буду продолжать доверять, 
    /// но если ты хоть раз меня обманешь, Я БУДУ ЖУЛЬНИЧАТЬ ДО ПОСЛЕДНЕГО.
    /// </summary>
    class Malignant
    {
        public static bool CheatedAtLeastOnce = false;  // Игрок хоть раз обманул

        public static bool Action()
        {
            DataBank.GameTurn++;

            if (!CheatedAtLeastOnce)
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