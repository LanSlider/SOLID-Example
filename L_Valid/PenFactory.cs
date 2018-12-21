namespace L_Valid
{
    class PenFactory
    {
        public bool IsReadyForPenCreating(Pen pen)
        {
            var penCompositionModels = pen.GetAllPenCompositionModels();

            foreach (var penCompositionModel in penCompositionModels)
            {
                if (penCompositionModel.Value == null)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
