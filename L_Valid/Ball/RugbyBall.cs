using System;

namespace L_Valid.Ball
{
    class RugbyBall : Ball
    {
        public int CircumferenceInLength { get; set; }
        public int CircumferenceInShortLength { get; set; }

        public override int Size
        {
            get
            {
                if (CircumferenceInShortLength > 58 && CircumferenceInShortLength < 62 && CircumferenceInLength > 74 && CircumferenceInLength < 77)
                {
                    return 7;
                }

                //...

                throw new ArgumentException("It's not a ball");
            }
        }

        public override bool IsNormalElasticity
        {
            get
            {
                if (BounceHeight > 5)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
