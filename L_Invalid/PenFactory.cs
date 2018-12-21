namespace L_Invalid
{
    class PenFactory
    {
        public bool IsReadyForPenCreating(BallpointPen pen)
        {
            if (pen.BodyModel != null && pen.CapModel != null && pen.RefillModel != null)
            {
                return true;
            }

            return false;
        }
    }
}
