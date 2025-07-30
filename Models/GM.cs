using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angelwings.Models
{
    public class GM
    {
        private const int MaxFearTokens = 12;
        private int _fearTokens = 3; // Default starting fear tokens
        public int FearTokens => _fearTokens; // Public property to access fear tokens

        public void AddFearToken()
        {
            if (_fearTokens < MaxFearTokens)
                _fearTokens++;
        }
        public void SpendFearToken()
        {
            if (_fearTokens > 0)
                _fearTokens--;
        }

        public bool CanSpendFear => FearTokens > 0;
        public bool CappedFear => FearTokens >= MaxFearTokens;

    }
}
