using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class Sport
    {
        public int PlayersPerTeam { get; set; }
        public bool hasBall { get; set; }
        public string LocationOfPlay { get; set; }
        public virtual bool DeclaredWinner(int score1, int score2)//returns true if team1/person1 has a higher score, else returns false, tie is considered false since tying is not winning
        {
            if (score1 <= score2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public abstract int addPoints(int prevScore, string typeOfScore);
    }
    class FootBall: Sport
    {
        public override int addPoints(int score, string typeOfScore)
        {
            if (typeOfScore.ToLower() == "touchdown")
            {
                return score + 6;
            }else if (typeOfScore.ToLower()== "fieldgoal")
            {
                return score + 3;
            }
            else if (typeOfScore.ToLower() == "safety" || typeOfScore == "pat2")
            {
                return score + 2;
            }else if (typeOfScore.ToLower() == "pat1") 
            {
                return score + 1;
            }
            else
            {
                return score;
            }
        }
        public FootBall()
        {
            PlayersPerTeam = 11;
            hasBall = true;
            LocationOfPlay = "Indoor or outdoor stadium";
        }
    }
    class Basketball : Sport
    {
        public override int addPoints(int score, string typeOfScore)
        {
            if (typeOfScore.ToLower() == "freethrow")
            {
                return score + 1;
            }
            else if (typeOfScore.ToLower() == "basket")
            {
                return score + 2;
            }
            else if (typeOfScore.ToLower() == "threepointer")
            {
                return score + 3;
            }
            else
            {
                return score;
            }
        }
            public Basketball()
            {
                PlayersPerTeam = 5;
                hasBall = true;
                LocationOfPlay = "Indoor hardwood court";
            }
        }
    }

