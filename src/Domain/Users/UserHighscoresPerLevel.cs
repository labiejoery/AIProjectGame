using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class UserHighscoresPerLevel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LevelId { get; set; }
        public int HighScore { get; set; }
        public DateTime DatumBehaald { get; set; }
        public int HoogsteDecibels { get; set; }
        public int LaagsteDecibels { get; set; }
        public int HoogstFrequentie { get; set; }
        public int LaagsteFrequentie { get; set; }

        protected UserHighscoresPerLevel()
        {

        }

        public UserHighscoresPerLevel(int userId, int levelId, int highScore, DateTime datumBehaald, int hoogsteDecibels, int laagsteDecibels, int hoogstFrequentie, int laagsteFrequentie)
        {
            UserId = userId;
            LevelId = levelId;
            HighScore = highScore;
            DatumBehaald = datumBehaald;
            HoogsteDecibels = hoogsteDecibels;
            LaagsteDecibels = laagsteDecibels;
            HoogstFrequentie = hoogstFrequentie;
            LaagsteFrequentie = laagsteFrequentie;
        }
    }
}
