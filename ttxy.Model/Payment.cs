using System;

namespace ttxy.Model
{
    public class Payment
    {
        private uint _id;
        private uint _stnum;
        private double _fee;
        private ushort _payfor;
        private DateTime _paydt;

        private string _strStuName;
        private string _strPayFor;

        public uint Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public uint Stnum
        {
            get
            {
                return _stnum;
            }

            set
            {
                _stnum = value;
            }
        }

        public double Fee
        {
            get
            {
                return _fee;
            }

            set
            {
                _fee = value;
            }
        }

        public ushort Payfor
        {
            get
            {
                return _payfor;
            }

            set
            {
                _payfor = value;
            }
        }

        public DateTime Paydt
        {
            get
            {
                return _paydt;
            }

            set
            {
                _paydt = value;
            }
        }

        public string StrStuName
        {
            get
            {
                return _strStuName;
            }

            set
            {
                _strStuName = value;
            }
        }

        public string StrPayFor
        {
            get
            {
                return _strPayFor;
            }

            set
            {
                _strPayFor = value;
            }
        }
    }
}
