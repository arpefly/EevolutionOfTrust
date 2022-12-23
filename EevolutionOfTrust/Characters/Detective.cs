namespace EevolutionOfTrust.Characters
{
    /// <summary>
    /// ДЕТЕКТИВ: Учти: я тебя анализирую. Мои первые ходы: доверие, обман, доверие, доверие.
    /// Если обманешь, я буду действовать как Имитатор. Если ни разу не обманешь, я буду всегда жульничать чтобы использовать тебя.
    /// Элементарно, мои дорогой Ватсон.
    /// </summary>
    class Detective
    {
        public static byte DetectiveStepCount = 0;   // Всего ходвов детектива
        public static bool CheatedAtLeastOnce = false;  // Игрок хоть раз обманул

        public static bool Action()
        {
            DataBank.GameTurn++;

            if (DetectiveStepCount == 0)
            {
                return true;
            }
            else if (DetectiveStepCount == 1)
            {
                return false;
            }
            else if (DetectiveStepCount == 2)
            {
                return true;
            }
            else if (DetectiveStepCount == 3)
            {
                return true;
            }
            else if (!CheatedAtLeastOnce)
            {
                return Simulator.Action(DataBank.PlayerChoise);
            }
            else
            {
                return Cheater.Action();
            }
        }
    }
}