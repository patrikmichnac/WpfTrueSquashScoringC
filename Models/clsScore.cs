namespace WpfTrueSquashScoringC.models
{
    class clsScore
    {
        private int _LeftScore;
        private int _RightScore;
        private EnumServe _Serve;

        public enum EnumServe
        {
            Left,
            Right
        }

        public int LeftScore
        {
            get
            {
                return _LeftScore;
            }
            set
            {
                _LeftScore = value;
            }
        }

        public int RightScore
        {
            get
            {
                return _RightScore;
            }
            set
            {
                _RightScore = value;
            }
        }

        public EnumServe Serve
        {
            get
            {
                return _Serve;
            }
            set
            {
                _Serve = value;
            }
        }


    }
}

