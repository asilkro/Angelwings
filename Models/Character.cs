using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angelwings.Models
{
    public class Character
    {
        #region Properties
        // Metadata
        public Guid Id { get; set; } = Guid.NewGuid(); // Allows name changing later without breaking references
        private const int MaxHopeTokens = 6; // Maximum number of hope tokens a character can have
        private int _hopeTokens = 0; // Default starting hope tokens
        public int HopeTokens => _hopeTokens; // Public property to access hope tokens

        // Character Information
        public string CharacterName { get; set; }
        // Key Stats
        public int ArmorPoints { get; set; }
        public int HitPoints { get; set; }
        public int MinorInjuryThreshold { get; set; }
        public int MajorInjuryThreshold { get; set; }

        // Cosmetic
        public Color HopeColor { get; set; } = Colors.LightBlue;
        public Color FearColor { get; set; } = Colors.PaleVioletRed;

        #endregion

        #region Methods
        public Character(string characterName = "Stu Adventurer")
        {
            CharacterName = characterName;
            ArmorPoints = 0;
            HitPoints = 0;
            MinorInjuryThreshold = 0;
            MajorInjuryThreshold = 0;
        }

        public void AddHopeToken()
        {
            if (_hopeTokens < MaxHopeTokens)
                _hopeTokens++;
        }
        public void SpendHopeToken()
        {
            if (_hopeTokens > 0)
                _hopeTokens--;
        }

        public bool CanSpendHope => _hopeTokens > 0;
        public bool CappedHope => _hopeTokens >= MaxHopeTokens;
        #endregion
    }
}